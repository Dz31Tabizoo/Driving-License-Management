using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLayer
{
    public class clsApplicationTypes
    {
        public int ApplicationTypeID { get; set; }

        public string ApplicationTypeTitle { get; set; }

        public decimal ApplicationFee { get; set; }


        public clsApplicationTypes() { }
        public clsApplicationTypes (int appID,string appTitle, decimal appFee)
        {
            this.ApplicationTypeID = appID;
            this.ApplicationTypeTitle = appTitle;
            this.ApplicationFee = appFee;
        }

        public bool UpdateAppFee()
        {
            return (clsApplicationTypesDAL.UpdateAppType(this.ApplicationTypeID,this.ApplicationTypeTitle,this.ApplicationFee));
        }


        public static async Task <DataTable> GetAllAppTypes()
        { 
            return await clsApplicationTypesDAL.GetApplicationTypes();
        }
            
        public static clsApplicationTypes FindAppTypeBtID(int applicationTypeId)
        {
            clsApplicationTypes Obj = new clsApplicationTypes();

            string appTypeTitle = string.Empty;
            decimal appFee = 0;

            if (clsApplicationTypesDAL.FindApplicationTypeByID(applicationTypeId,ref appTypeTitle,ref appFee))
            {
                Obj.ApplicationTypeID = applicationTypeId;
                Obj.ApplicationTypeTitle = appTypeTitle; Obj.ApplicationFee = appFee;
                return Obj;
            }
            else
            {
                return null;
            }




        }

    }
}
