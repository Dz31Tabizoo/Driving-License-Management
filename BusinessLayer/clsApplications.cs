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

        public enum enAppStatus { New = 1, Cancelled = 2, Completed = 3 };
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _mode = enMode.AddNew;

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
            private set // Make setter private since it's auto-managed
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
            ApplicationStatus = enAppStatus.New; // this will set LastStatusDate = Now
            PaidFees = 0;
           
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













    }
}
