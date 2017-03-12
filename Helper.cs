using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DatalogicScorpio
{
    public static class Helper
    {
        public static void WriteLineToFile(string text, string fileName)
        {
            StreamWriter SW;
            FileStream FS;
            FS = new FileStream(@"\Program Files\DatalogicScorpio\Invoices\" + CurrentDirectoryCheck() + @"\" + fileName, System.IO.FileMode.Append);
            SW = new StreamWriter(FS, Encoding.GetEncoding("utf-8"));
            //SW.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " === " + text);
            SW.WriteLine(text);
            SW.Flush();
            SW.Close();
            FS.Close();
        }

        public static string CurrentDirectoryCheck()
        {
            List<string> listDir = new List<string>(Directory.GetDirectories(@"\Program Files\DatalogicScorpio\Invoices"));
            if (listDir[listDir.Count - 1].Split('\\')[4] == DateTime.Now.ToString("dd-MM-yyyy"))
            {
                return listDir[listDir.Count - 1].Split('\\')[4];
            }
            Directory.CreateDirectory(@"\Program Files\DatalogicScorpio\Invoices\" + DateTime.Now.ToString("dd-MM-yyyy"));
            return DateTime.Now.Year.ToString("dd-MM-yyyy");
        }

        public static bool DirectoriesCopy()
        {
            if (Directory.Exists(@"\My Documents\Invoices"))
            {
                try
                {
                    //Directory.Move(@"\My Documents\Invoices", @"\My Documents\Invoices" + DateTime.Now.ToString("dd_MM_HH_mm"));
                    Directory.Delete(@"\My Documents\Invoices\", true);
                }
                catch (Exception ex)
                {
                    return false;
                }
                
            }
            else
            {
                Directory.CreateDirectory(@"\My Documents\Invoices");
            }
            DirectoryInfo dirInfo = new DirectoryInfo(@"\Program Files\DatalogicScorpio\Invoices");
            DirectoryInfo[] dirs = dirInfo.GetDirectories();
            foreach (DirectoryInfo item in dirs)
            {
                Directory.CreateDirectory(@"\My Documents\Invoices\" + item.Name);
                FileInfo[] fileInf = item.GetFiles();
                foreach (FileInfo file in fileInf)
                {
                    File.Copy(dirInfo.FullName + "\\" + item.Name + "\\" + file.Name, @"\My Documents\Invoices\" + item.Name + "\\" + file.Name, true);
                }
            }
            return true;
            
        }


    }
}
