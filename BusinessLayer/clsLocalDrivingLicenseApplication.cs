using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplication
    {
        public enum enMode { Addnew = 1, Update = 2 }

        public enMode Mode { get; set; } = enMode.Addnew;
        public int LocalDrivingLicenseApplicationID {get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }


        public clsApplications Application { get; set; }
        public clsLicenseClasses LicenseClass { get; set; }


        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            Mode = enMode.Addnew;
            
        }

        public clsLocalDrivingLicenseApplication(int LDVLappID ,int applicationId, int licenseClassId)
        {
            LocalDrivingLicenseApplicationID = LDVLappID;
            ApplicationID = applicationId;
            LicenseClassID = licenseClassId;
            Mode = enMode.Update;
          
        }

        public clsLocalDrivingLicenseApplication(int LDVLID, clsApplications application, clsLicenseClasses licenseClass )
        {
            LocalDrivingLicenseApplicationID = LDVLID;
            ApplicationID = application?.AppID ?? -1;
            LicenseClassID = licenseClass?.LicenseClassID ?? -1;
            Application = application ?? new clsApplications();
            LicenseClass = licenseClass ?? new clsLicenseClasses();
        }



        public static async Task<DataTable> GetAllLocalDriveLicenseApps()
        {
            return await clsLocalDrivingLicenseApplicationDAL.GetAllLocalDrivingLicenseApps();
        }


        private async Task <bool> _AddNewLDVLApplication()
        {
            this.LocalDrivingLicenseApplicationID = await clsLocalDrivingLicenseApplicationDAL.AddNewLocalApplication(ApplicationID, LicenseClassID);
            return this.LocalDrivingLicenseApplicationID != -1;

        }


        public async Task<bool> Save()
        {
            switch (Mode)
            {
                case enMode.Update:

                    return true;


                case enMode.Addnew:
                    return await _AddNewLDVLApplication();



            }
            return false;
        }


        public static async Task<clsLocalDrivingLicenseApplication> FindLDVLapplicationById(int ID)
        {

            int appId = -1;
            int licenseClassID = -1;


            if (clsLocalDrivingLicenseApplicationDAL.FindLDVlApplicationByID(ID,ref appId,ref licenseClassID))
            {
                var ObjApplication = await clsApplications.FindApplicationByID(appId);
                var ObjLicenseClass = await clsLicenseClasses.GetLicenseClassObjByIDAsync(licenseClassID);
                return new clsLocalDrivingLicenseApplication(ID,ObjApplication,ObjLicenseClass);
            }
            else
            {
                return null;
            }




        }

    }


        
    
}
