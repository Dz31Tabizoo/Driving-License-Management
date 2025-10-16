using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicenseClasses
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode { get; set; } = enMode.AddNew;
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string ClassDescription { get; set; } = string.Empty;
        public byte MinimumAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get ; set; }

        
        public clsLicenseClasses()
        {

            LicenseClassID = 0;
            ClassName = string.Empty;
            ClassDescription = string.Empty;
            ClassFees = 0;
            MinimumAge = 0;
            DefaultValidityLength = 0;
        }

        public clsLicenseClasses(int id,string name,string discrp,byte minAge,byte validityLength,decimal fees )
        {
            LicenseClassID = id;
            ClassName = name;
            ClassDescription = discrp;
            MinimumAge = minAge;
            DefaultValidityLength = validityLength;
            ClassFees = fees;
            Mode = enMode.Update;
        }



        public static async Task<List<clsLicenseClasses>> GetAllLicensesClasses()
        {
            var dtos = await clsLicenseClassesDAL.GetAllLicenseClassesList();

            List<clsLicenseClasses> Classes = new List<clsLicenseClasses>();


            foreach (var dto in dtos)
            {
                Classes.Add( new clsLicenseClasses
                {
                    LicenseClassID = dto.LicenseClassID,
                    ClassName = dto.ClassName,
                    ClassDescription = dto.ClassDescription,
                    MinimumAge = dto.MinimumAge,
                    DefaultValidityLength = dto.DefaultValidityLength,
                    ClassFees = dto.ClassFees
                });
            }
            return Classes;
        }


        public static async Task<clsLicenseClasses> GetLicenseClassObjByIDAsync(int licenseClassID)
        {
            var dtos = await clsLicenseClassesDAL.GetLicenseClassObjectByID(licenseClassID);

            var licenseClass = new clsLicenseClasses
            {

                LicenseClassID = licenseClassID,
                DefaultValidityLength = dtos.DefaultValidityLength,
                ClassFees = dtos.ClassFees,
                ClassDescription = dtos.ClassDescription,
                ClassName = dtos.ClassName,
                MinimumAge = dtos.MinimumAge,
                Mode = enMode.Update,

            };
            return licenseClass;

        }







    }
}
