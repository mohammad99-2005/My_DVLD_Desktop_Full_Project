using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsApplicationTypesBusinuse
    {

        public int ApplicationTypeID {  get; set; }

        public string ApplicationTypeTitle {  get; set; }

        public int ApplicationTypeFees { get; set; }


        clsApplicationTypesBusinuse(int ApplicationTypeID,string ApplicationTypeTitle,int ApplicationTypeFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationTypeFees = ApplicationTypeFees;
        }


        public static clsApplicationTypesBusinuse Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";    int ApplicationFees =-1;

            if(clsApplicationTypesData.FindByApplicationID(ApplicationTypeID,ref ApplicationTypeTitle,ref ApplicationFees))
            {
                return new clsApplicationTypesBusinuse(ApplicationTypeID,ApplicationTypeTitle,ApplicationFees);
            }
            return null;
        }


        public static clsApplicationTypesBusinuse Find(string ApplicationTypeTitle)
        {
            int ApplicationTypeID = -1; int ApplicationFees = -1;

            if (clsApplicationTypesData.FindByApplicationTitle(ref ApplicationTypeID, ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationTypesBusinuse(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            return null;
        }

        public bool _UpdateApplications()
        {
            return clsApplicationTypesData.UpdateApplicationType(ApplicationTypeID,ApplicationTypeTitle, ApplicationTypeFees);
        }

        public bool Save()
        {
            return _UpdateApplications();
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesData.GetAllApplicationTypes();
        }



    }
}
