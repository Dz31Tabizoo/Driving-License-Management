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


        public clsApplicationTypes (int appID,string appTitle, decimal appFee)
        {
            this.ApplicationTypeID = appID;
            this.ApplicationTypeTitle = appTitle;
            this.ApplicationFee = appFee;
        }

        public static bool UpdateAppFee(int appId, decimal appFee)
        {
            return (clsApplicationTypesDAL.UpdateAppType(appId, appFee));
        }


        public static async Task <DataTable> GetAllAppTypes()
        { 
            return await clsApplicationTypesDAL.GetApplicationTypes();
        }
            


    }
}
