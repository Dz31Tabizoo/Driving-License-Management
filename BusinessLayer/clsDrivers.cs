using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class clsDrivers
    {
        public enum enMode { AddNew = 1 , Update = 2 }


        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public enMode Mode { get ; set; } = enMode.AddNew;



        public clsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        public clsDrivers(int driverId,int personId,int userID,DateTime createdDate)
        {
            Mode = enMode.Update;
            DriverID = driverId;
            PersonID = personId;
            CreatedDate = createdDate;
            CreatedByUserID = userID;
        }

        public static async Task<DataTable> GetAllDriverAsync()
        {
            return await clsDriversDAL.GetAllDrivers();
        }

        public async Task<bool> AddNewDriver ()
        {
            this.DriverID = await clsDriversDAL.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return DriverID != -1;
        }


    }
}
