using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using My_DVLD_DataAccessLayer;


namespace My_DVLD_BussinessLayer
{
    public class clsPeopleManagmentBusinuse
    {

        enum enMode {enUpdate = 0 , enAddnew = 1};
        enMode mode = enMode.enUpdate;


        public int PersonID { get; set; }
        public string NationalNo {  get; set; }
        public string FirstName {  get; set; }
        public string SecondName {  get; set; }
        public string ThirdName {  get; set; }
        public string LastName {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gendor {  get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath {  get; set; }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }

        public clsCountriesBusinuse CountryInfo;

        public clsPeopleManagmentBusinuse() 
        {
            PersonID = -1;
            this.NationalNo = string.Empty;
            this.FirstName = string.Empty; this.SecondName = string.Empty;
            this.ThirdName = string.Empty; this.LastName = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.Gendor = true; this.Address = string.Empty;
            this.Phone = Phone; this.Email = Email;
            this.NationalityCountryID = -1;
            this.ImagePath = string.Empty;

            mode = enMode.enAddnew;
        }

        public clsPeopleManagmentBusinuse(int PerID,string NationNo , string FName ,string SName , string ThName , string LName , DateTime DOB ,
        bool gendor , string Address , string Phone, string Email , int NCID , string Photo)
        {

            
            this.PersonID = PerID;
            this.NationalNo = NationNo;
            this.FirstName = FName; 
            this.SecondName = SName;
            this.ThirdName = ThName; 
            this.LastName = LName;
            this.DateOfBirth = DOB;
            this.Gendor = gendor; 
            this.Address = Address;
            this.Phone = Phone; 
            this.Email = Email;
            this.NationalityCountryID = NCID;
            this.ImagePath = Photo;
            this.CountryInfo = clsCountriesBusinuse.FindCountryByID(NCID);

            mode = enMode.enUpdate;
        }
        

        public static clsPeopleManagmentBusinuse Find(int PerID)
        {
            string NationNo = ""; string FName=""; string SName=""; string ThName = ""; string LName = ""; DateTime DOB = DateTime.Now;
            bool gendor = false; string Address = ""; string Phone = ""; string Email = ""; int NCID = -1; string Photo = "";
            
            if(clsPeopleManagmentData.FindPersonByID(PerID,ref NationNo, ref FName, ref SName, ref ThName, ref LName, ref DOB, ref gendor,
                                            ref Address, ref Phone, ref Email, ref NCID, ref Photo))
            {
                return new clsPeopleManagmentBusinuse(PerID, NationNo, FName, SName, ThName, LName, DOB, gendor, Address, Phone, Email, NCID, Photo);
            }
            else
            {
                return null;
            }
        }


        public static clsPeopleManagmentBusinuse Find(string NationalNo)
        {
            int PerID = -1; string FName = ""; string SName = ""; string ThName = ""; string LName = ""; DateTime DOB = DateTime.Now;
            bool gendor = false; string Address = ""; string Phone = ""; string Email = ""; int NCID = -1; string Photo = "";

            if (clsPeopleManagmentData.FindPersonByNationalNo(ref PerID, NationalNo, ref FName, ref SName, ref ThName, ref LName, ref DOB, ref gendor,
                                            ref Address, ref Phone, ref Email, ref NCID, ref Photo))
            {
                return new clsPeopleManagmentBusinuse(PerID, NationalNo, FName, SName, ThName, LName, DOB, gendor, Address, Phone, Email, NCID, Photo);
            }
            else
            {
                return null;
            }
        }



        bool _AddNewPerson()
        {
            this.PersonID = (clsPeopleManagmentData.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address,
                                                    Phone, Email, NationalityCountryID, ImagePath));
            if (PersonID != -1)
                return true;
            return false;
        }

        bool _UpdatePerson()
        {
            return (clsPeopleManagmentData.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor,
                                                    Address, Phone, Email, NationalityCountryID, ImagePath));
        }


        public static bool IsPersonExist(int PerID)
        {
            return clsPeopleManagmentData.IsPersonExistByID(PerID);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            return clsPeopleManagmentData.IsPersonExistByNationalNo(NationalNo);
        }


        public static bool DeletPerson(int PerID)
        {
            if (IsPersonExist(PerID))
            {
                return clsPeopleManagmentData.DeletePerson(PerID);
            }
            return false;
        }


        public static DataTable GetAllPeople()
        {
            return (clsPeopleManagmentData.GetAllPeople());
        }


        public bool Save()
        {


            switch (mode)
            {
                case enMode.enAddnew:
                    if (_AddNewPerson())
                    {
                        mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdatePerson();
                default:
                    return false;
            }
        }

        
    }
}
