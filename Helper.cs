using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;

namespace DatalogicScorpio
{
    public static class Helper
    {
        public static string PathToSyncDirectory = @"\My Documents\Invoices\";
        public static string PathToRootDirectory = @"\Program Files\DatalogicScorpio\Invoices\";
        public static string PathToProductList = @"\BACKUP\Products.csv";

        public static bool CheckRootDirectory()
        {
            try
            {
                if (Directory.Exists(PathToRootDirectory))
                    return true;
                Directory.CreateDirectory(PathToRootDirectory);
            }
            catch (Exception)
            {

                return false;
            }
            
            return true;    
        }

        public static void KeyboardChange(InputPanel panel)
        {
            foreach (InputMethod item in panel.InputMethods)
            {
                if (item.Name == "MSH Keyboard")
                    panel.CurrentInputMethod = item;
            }
        }

        public static void WriteLineToFile(string product, string fileName)
        {
            StreamWriter SW;
            FileStream FS;
            try
            {
                FS = new FileStream(PathToRootDirectory + CurrentDirectoryCheck() + @"\" + fileName, System.IO.FileMode.Append);
                SW = new StreamWriter(FS, Encoding.Default);
                SW.WriteLine(product);
                SW.Flush();
                SW.Close();
                FS.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string CurrentDirectoryCheck()
        {
            DirectoryInfo[] dirInfo = GetWorkDirectories();
            foreach (DirectoryInfo item in dirInfo)
            {
                if (item.Name == DateTime.Now.ToString("dd-MM-yyyy"))
                {
                    return item.Name;
                }
            }
            return Directory.CreateDirectory(PathToRootDirectory + 
                DateTime.Now.ToString("dd-MM-yyyy")).Name;
        }

        public static bool DirectoriesCopy()
        {
            if (Directory.Exists(PathToSyncDirectory))
            {
                try
                {
                    Directory.Delete(PathToSyncDirectory, true);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(PathToSyncDirectory);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            try
            {
                DirectoryInfo[] dirs = GetWorkDirectories();
                foreach (DirectoryInfo item in dirs)
                {
                    Directory.CreateDirectory(PathToSyncDirectory + item.Name);
                    FileInfo[] fileInf = item.GetFiles();
                    foreach (FileInfo file in fileInf)
                    {
                        File.Copy(PathToRootDirectory + item.Name + "\\" + file.Name, PathToSyncDirectory + item.Name + "\\" + file.Name, true);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
            
        }

        public static DirectoryInfo[] GetWorkDirectories()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(PathToRootDirectory);
            return dirInfo.GetDirectories();
        }

        public static DirectoryInfo RootDirectoryInfo()
        {
            return new DirectoryInfo(PathToRootDirectory);
        }

        public static List<Product> GetProductList()
        {
            string result = string.Empty;
            List<Product> resultList = new List<Product>();
            try
            {
                StreamReader stream = new StreamReader(PathToProductList, Encoding.Default);
                string[] tempArr = new string[0];
                while ((result = stream.ReadLine()) != null)
                {
                    tempArr = result.Split(';');
                    if (tempArr.Length == 3)
                    {
                        resultList.Add(new Product(tempArr[0], tempArr[1], tempArr[2], string.Empty));
                    }
                    
                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Список не загружен.");
                return new List<Product>();
            }
            return resultList;
        }

        public static Product GetProductByBarCode(List<Product> list, string barCode)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].BarCode == barCode)
                {
                    return list[i];
                }
            }
            return new Product(barCode, string.Empty, "0", "0.00");
        }
    }

    public class Product
    {
        public string BarCode { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }

        public Product(string barCode, string name, string quantity, string price)
        {
            BarCode = barCode;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return BarCode + ";" + Name + ";" + Quantity + ";" + Price;
        }
    }
}
