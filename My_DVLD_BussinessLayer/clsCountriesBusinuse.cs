using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsCountriesBusinuse
    {

        public int CountryID { set; get; }
        public string CountryName {  get; set; }


        public clsCountriesBusinuse()
        {
            CountryID = -1;
            this.CountryName = "";
        }

        clsCountriesBusinuse(int CountryID,string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountriesBusinuse FindCountryByID(int CountryID)
        {
            string CountryName = "";
            
            if(clsCountriesData.FindCountryByID(CountryID,ref CountryName))
            {
                return new clsCountriesBusinuse(CountryID,CountryName);
            }
            else
            {
                return null;
            }

        }


        public static DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }

        public static clsCountriesBusinuse FindCountryByName(string CountryName)
        {
            int CountryID = -1;

            if (clsCountriesData.FindCountryByName(ref CountryID, CountryName))
            {
                return new clsCountriesBusinuse(CountryID, CountryName);
            }
            else
            {
                return null;
            }

        }


    }
}
