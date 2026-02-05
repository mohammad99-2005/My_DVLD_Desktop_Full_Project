using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;

namespace My_DVLD_Desktop.Global
{
    public class clsGlobal
    {
        public static clsUsersManagemetsBussiness clsCurrUser;
        public static bool RememberUsernameAndPassword(string username, string password)
        {
            try
            {
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                string FilePath = CurrentDirectory + "\\data.txt";

                if (username == "" && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }

                string dataSaved = username + "#//#" + password;

                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    writer.Write(dataSaved);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential(ref string username, ref string password)
        {
            try
            {
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                string FilePath = CurrentDirectory + "\\data.txt";

                if (File.Exists(FilePath))
                {
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            username = result[0];
                            password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
