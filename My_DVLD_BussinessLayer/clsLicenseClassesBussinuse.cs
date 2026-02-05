using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsLicenseClassesBussinuse
    {

        enum enMode { enUpdate = 0, enAddNew = 1 }
        enMode mode = enMode.enUpdate;


        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public int ClassFees { get; set; }

        public clsLicenseClassesBussinuse()
        {
            this.LicenseClassID = -1;
            this.ClassName = string.Empty;
            this.ClassDescription = string.Empty;
            this.MinimumAllowedAge = -1;
            this.DefaultValidityLength = -1;
            this.ClassFees = -1;

            mode = enMode.enAddNew;
        }

        private clsLicenseClassesBussinuse(int LicenseClassID, string ClassName, string ClassDescription,
                                           int MinimumAllowedAge, int DefaultValidityLength, int ClassFees)
        {
            this.LicenseClassID  = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge=MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            mode = enMode.enUpdate;
        }


        public static clsLicenseClassesBussinuse Find(int LicenseClassID)
        {
            string ClassName = ""; string ClassDescription = "";
            int MinimumAllowedAge =18 ; int DefaultValidityLength = 10;
            int ClassFees = 0;

            if(clsLicenseClassesData.FindBy_LicenseClassID(LicenseClassID,ref ClassName, ref ClassDescription,
                                                        ref MinimumAllowedAge,ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClassesBussinuse(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }

        }

        public static clsLicenseClassesBussinuse Find(string ClassName)
        {
            int LicenseClassID = -1; string ClassDescription = "";
            int MinimumAllowedAge = 18; int DefaultValidityLength = 10;
            int ClassFees = 0;

            if (clsLicenseClassesData.FindBy_ClassName(ref LicenseClassID, ClassName, ref ClassDescription,
                                                        ref MinimumAllowedAge,ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClassesBussinuse(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewLicenseClass()
        {
            this.LicenseClassID = clsLicenseClassesData.AddNewLicenseClass(ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);

            return LicenseClassID != -1;
        }

        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassesData.UpdateLicenseClasses(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesData.GetAllLicenseClasses();
        }

        //public static bool DeleteLicenseClass(int LicenseClassID)
        //{
        //    return clsLicenseClassesData.DeleteLicenseClass(LicenseClassID);
        //}



    }
}
