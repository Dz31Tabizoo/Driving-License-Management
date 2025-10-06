using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplication
    {

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }


        public clsApplications Application {  get; set; }
        public clsLicenseClasses LicenseClass { get; set; }


        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            Application = new clsApplications();
            LicenseClass = new clsLicenseClasses();
        }

        public clsLocalDrivingLicenseApplication(int applicationId,int licenseClassId)
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = applicationId;
            LicenseClassID = licenseClassId;
            Application = new clsApplications();
            LicenseClass = new clsLicenseClasses();
        }
        public clsLocalDrivingLicenseApplication( clsApplications application, clsLicenseClasses licenseClass)
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = application?.AppID ?? -1;
            LicenseClassID = licenseClass?.LicenseClassID ?? -1;
            Application = application?? new clsApplications();
            LicenseClass = licenseClass ?? new clsLicenseClasses();
        }






    }
}
