using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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



        public static async Task<List<clsLocalDrivingLicenseApplication>> GetAllLocalDriveLicenseApps()
        {
            var dtos = await clsLocalDrivingLicenseApplicationDAL.GetAllLocalDrivingLicenseApps();
            var result = new List<clsLocalDrivingLicenseApplication>();

            foreach (var dto in dtos)
            {
                result.Add(new clsLocalDrivingLicenseApplication
                {
                    LocalDrivingLicenseApplicationID = dto.localDrivingLicenseApplicationID,
                    ApplicationID = dto.applicationID,
                    LicenseClassID = dto.licenseClassID,
                    Application = new clsApplications
                    {
                        AppID = dto.appId,
                        Applicant = new clsPeople
                        {
                            PersonID = dto.applicantId,
                            FirstName = dto.FirstName,
                            LastName = dto.LastName
                        },
                        AppDate = dto.appDate,
                        ApplicationStatus = (clsApplications.enAppStatus)dto.appStatus,
                        PaidFees = dto.paidFees
                    },
                    LicenseClass = new clsLicenseClasses
                    {
                        LicenseClassID = dto.licenseClassID,
                        ClassName = dto.className,
                        ClassDescription = dto.classDescription,
                        MinimumAge = dto.minimumAllowedAge,
                        DefaultValidityLength = dto.defaultValidityLength,
                        ClassFees = dto.classFees
                    }
                });
            }

            return result;
        }


        private static clsApplications MapToApplication( clsLocalDrivingLicenseApplicationDAL.LocalDrivingLicenseAppDTO dto)
        {

            return new clsApplications
            {
                AppID = dto.applicationID,
                Applicant = new clsPeople
                {
                    PersonID = dto.applicantId,
                    FirstName = dto.FirstName,
                    SecondName = dto.SecondName,
                    ThirdName = dto.ThirdName,
                    LastName = dto.LastName,
                    Email = dto.Email,
                    Phone = dto.Phone
                },
                AppDate = dto.appDate,
                ApplicationStatus = (clsApplications.enAppStatus)dto.appStatus,
                LastStatusDate = dto.lastStatusDate,
                PaidFees = dto.paidFees,
                CreatedByUser = new clsUser
                {
                    UserID = dto.userID,
                    UserName = dto.Username,
                    IsActive = dto.IsActive
                }
            };
        }

        private static clsLicenseClasses MapToLicenseClass(clsLocalDrivingLicenseApplicationDAL.LocalDrivingLicenseAppDTO dto)
        {
            return new clsLicenseClasses
            {
                LicenseClassID = dto.licenseClassID,
                ClassName = dto.className,
                ClassDescription = dto.classDescription,
                MinimumAge = dto.minimumAllowedAge,
                DefaultValidityLength = dto.defaultValidityLength,
                ClassFees = dto.classFees
            };
        }

    }
}
