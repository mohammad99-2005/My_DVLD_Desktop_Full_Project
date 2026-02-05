using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    internal class clsGetDataAccessFromDatabase
    {
        public static string DbConnectionStringBuilder = "Server=.; Database=DVLD; Integrated Security=True; TrustServerCertificate=True;";
        //public static string DbConnectionStringBuilder = "\"Server=.; Database=DVLD; User Id=yuyuy; Password=444; TrustServerCertificate=True;\"";
    }                                                   //Server=.;Database=ContactsDBP;User Id=sa;Password=123456;
}
