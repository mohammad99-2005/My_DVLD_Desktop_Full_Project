using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsTestTypeBussinuse
    {

        enum enMode { enUpdate = 0, enAddNew = 1 }
        enMode mode = enMode.enUpdate;

        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        

        public clsTestTypeBussinuse.enTestType ID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public int TestTypeFees {  get; set; }


        clsTestTypeBussinuse(clsTestTypeBussinuse.enTestType TestTypeID,string TestTypeTitle,string TestTypeDescription,int TestTypeFees) 
        {
            this.ID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
            mode = enMode.enUpdate;
        }

        public static clsTestTypeBussinuse Find(clsTestTypeBussinuse.enTestType TestTypeID)
        {
            string TestTypeTitle = ""; int TestTypeFees = -1; string TestTypeDescription = "";

            if (clsTestTypeData.FindByTestTypeID((int)TestTypeID, ref TestTypeTitle,ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestTypeBussinuse(TestTypeID, TestTypeTitle,TestTypeDescription, TestTypeFees);
            }
            return null;
        }

        public bool _UpdateTestTypes()
        {
            return clsTestTypeData.UpdateTestType((int)this.ID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.enAddNew:
                    return false;
                    break;
                case enMode.enUpdate:
                    return _UpdateTestTypes();
                default:
                    return false;
            }
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }


    }
}
