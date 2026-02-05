using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_Desktop
{
    public class clsUtil
    {

        public static string GetGuid()
        {
            string strGuid = Guid.NewGuid().ToString();
            return strGuid;
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }

            }
            return true;
        }

        public static string ReplaceFileNameWithGuid(string OldImageLocation)
        {
            FileInfo fi = new FileInfo(OldImageLocation);
            string DestLocation = GetGuid() + fi.Extension.ToString();
            return DestLocation;
        }


        static public bool CopyImageToProjectImageFile(ref string ImageLocation)
        {
            string FolderPath = @"C:\DVLD-People-Images\";
            if (!CreateFolderIfDoesNotExist(FolderPath))
            {
                return false;
            }

            string DestLocation = FolderPath + ReplaceFileNameWithGuid(ImageLocation);
            try
            {
                File.Copy(ImageLocation, DestLocation, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            ImageLocation = DestLocation;
            return true;
        }



















    }
}
