using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplications
    {
        private DateTime _appDate;
        private DateTime _lastStatusDate;
        private decimal _paidFees;
        private enAppStatus _AppStatus;
        private clsPeople _applicant;
        private clsApplicationTypes _appType;
        private clsUser _createdByUser;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _mode = enMode.AddNew;



        public enum enAppStatus { New = 1, Cancelled = 2, Completed = 3 };              
        public int AppID { get; set; }
        public clsPeople Applicant
        {
            get => _applicant;
            set => _applicant = value ?? throw new ArgumentNullException(nameof(Applicant));
        }

        public DateTime AppDate
        {
            get => _appDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Application date cannot be in the future");
                _appDate = value;
            }
        }

        public clsApplicationTypes AppType
        {
            get => _appType;
            set => _appType = value ?? throw new ArgumentNullException(nameof(AppType));
        }

        public enAppStatus ApplicationStatus
        {
            get => _AppStatus;
            set
            {
                if (_AppStatus != value)
                {
                    _AppStatus = value;
                    LastStatusDate = DateTime.Now; // Auto-update on status change
                }
            }
        }

        public DateTime LastStatusDate
        {
            get => _lastStatusDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Last status date cannot be in the future");
                _lastStatusDate = value;
            }
        }

        public decimal PaidFees
        {
            get => _paidFees;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Paid fees cannot be negative");
                _paidFees = value;
            }
        }

        public clsUser CreatedByUser
        {
            get => _createdByUser;
            set => _createdByUser = value ?? throw new ArgumentNullException(nameof(CreatedByUser));
        }

        public enMode Mode => _mode;





        public clsApplications()
        {
            AppID = -1;
            AppDate = DateTime.Now;
            AppType = new clsApplicationTypes();
            ApplicationStatus = enAppStatus.New; // this will set LastStatusDate = Now
            PaidFees = AppType.ApplicationFee;
            CreatedByUser = new clsUser();
            _mode = enMode.AddNew;
           
        }




        public clsApplications(int appID, clsPeople applicant, DateTime appDate,
                             clsApplicationTypes appType, enAppStatus applicationStatus,
                             decimal paidFees, clsUser createdByUser)
        {
            AppID = appID;
            Applicant = applicant;
            AppDate = appDate;
            AppType = appType;
            ApplicationStatus = applicationStatus; // set LastStatusDate to Now           
            PaidFees = paidFees;
            CreatedByUser = createdByUser;

            _mode = enMode.Update;
        }




        public async Task<bool> Save()
        {
            switch (Mode)
            {
                case enMode.Update:
                    
                    return true;
                   

                case enMode.AddNew:
                    return await _AddNewApp();
                    
                    

            }
            return false;
        }


        private async Task<bool> _AddNewApp()
        {
            this.AppID = await clsApplicationsDAL.AddNewApplication(this.Applicant.PersonID, this.AppDate, this.AppType.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUser.UserID);


            return AppID != -1;
        }


        public static async Task<clsApplications> FindApplicationByID(int appID)
        {
            var obj = await clsApplicationsDAL.FindApplicationByIDasync(appID);
            if (obj == null)
            {
                return null;
            }

            clsApplications newObj = new clsApplications();
            newObj.AppID = appID;
            newObj._mode = enMode.Update;
            newObj.Applicant = clsPeople.FindPersonByID(obj.applicantId);
            newObj.ApplicationStatus = (enAppStatus) obj.appStatus;
            newObj.AppDate = obj.appDate;
            newObj.AppType = clsApplicationTypes.FindAppTypeBtID(obj.appTypeId);
            newObj.PaidFees = obj.paidFees;
            newObj.LastStatusDate = obj.lastStatusDate;
            newObj.CreatedByUser = clsUser.FindUserByID(obj.userID);



            // it's a bad practice for me to call database every time + 3  we should call one time all tables using joins and filter to get data easly

            return newObj;
        }


        public static async Task<bool> UpdateApplicationStatus(int applicationID, byte status)
        {
            return await clsApplicationsDAL.UpdateApplicationStatusAsync(applicationID, status);
        }
    }
}
