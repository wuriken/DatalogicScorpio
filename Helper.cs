using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;

namespace DatalogicScorpio
{

    public enum InvoiceType
    {
        Arrival,
        Inventory,
        Production
    }

    public static class Helper
    {


        public static string PathToSyncDirectory = @"\My Documents\Invoices\";
        public static string PathToRootDirectory = @"\Program Files\DatalogicScorpio\Invoices\";
        public static string PathToProductList = @"\My Documents\Products.csv";
        public static string PathToGroupList = @"\My Documents\ProductsGroup.csv";
        public static string PathToContractorsList = @"\My Documents\Contractors.csv";
        public static string PathToStorageList = @"\My Documents\Storage.csv";
        public static string PathToTypeList = @"\My Documents\ProductsType.csv";
        public static string HeaderProductsList = @"Наименование:;Код товара:;Артикул:;Группа товаров:;Вид товаров:;Единица измерения:;Весовой товар:;
                        Код весового товара;Штрих-код:;Цена:;Количество:";
        public static string HeaderInvoice = @"Наименование:;Код товара:;Артикул:;Группа товаров:;Вид товаров:;Единица измерения:;Весовой товар:;Код весового товара;Штрих-код:;Цена:;Количество:;Контрагент:;Склад:";

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
                SW = new StreamWriter(FS, Encoding.GetEncoding(1251));
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

        public static List<Product> InvoiceLoad(string path)
        {
            string result = string.Empty;
            List<Product> resultList = new List<Product>();
            try
            {
                StreamReader stream = new StreamReader(path, Encoding.GetEncoding(1251));
                Product tempProd;
                string[] tempArr = new string[0];
                while ((result = stream.ReadLine()) != null)
                {
                    tempArr = result.Split(';');
                    string temp = string.Empty;
                    if (tempArr.Length > 10 && !tempArr[0].Contains("Наименование"))
                    {
                        tempProd = new Product(tempArr[0], tempArr[1], tempArr[2], tempArr[3], tempArr[4], tempArr[5],
                            tempArr[6], tempArr[7], tempArr[8], tempArr[9], tempArr[10]);
                        tempProd.Contractor = tempArr[11];
                        tempProd.Storage = tempArr[12];
                        resultList.Add(tempProd);
                    }

                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Документ не загружен.");
                return new List<Product>();
            }
            return resultList;
        }


        public static List<Product> GetProductList()
        {
            string result = string.Empty;
            List<Product> resultList = new List<Product>();
            try
            {
                StreamReader stream = new StreamReader(PathToProductList, Encoding.GetEncoding(1251));
                string[] tempArr = new string[0];
                while ((result = stream.ReadLine()) != null)
                {
                    tempArr = result.Split(';');
                    string temp = string.Empty;
                    if (tempArr.Length == 11 && !tempArr[0].Contains("Наименование"))
                    {
                        resultList.Add(new Product
                            (tempArr[0], tempArr[1], tempArr[2], tempArr[3], tempArr[4], tempArr[5], 
                            tempArr[6], tempArr[7], tempArr[8], tempArr[9], tempArr[10]));
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

        public static List<Contractors> GetContractorsList()
        {
            string result = string.Empty;
            List<Contractors> resultList = new List<Contractors>();
            try
            {
                StreamReader stream = new StreamReader(PathToContractorsList, Encoding.GetEncoding(1251));
                string[] tempArr = new string[0];
                while ((result = stream.ReadLine()) != null)
                {
                    tempArr = result.Split(';');
                    string temp = string.Empty;
                    if (tempArr.Length == 1 && !tempArr[0].Contains("Контрагент"))
                    {
                        resultList.Add(new Contractors(tempArr[0]));
                    }

                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Список не загружен.");
                return new List<Contractors>();
            }
            return resultList;
        }

        public static List<ProductsType> GetTypeList()
        {
            string result = string.Empty;
            List<ProductsType> resultList = new List<ProductsType>();
            try
            {
                StreamReader stream = new StreamReader(PathToTypeList, Encoding.GetEncoding(1251));
                string[] tempArr = new string[0];
                while ((result = stream.ReadLine()) != null)
                {
                    tempArr = result.Split(';');
                    string temp = string.Empty;
                    if (tempArr.Length == 1 && !tempArr[0].Contains("Вид товара"))
                    {
                        resultList.Add(new ProductsType(tempArr[0]));
                    }

                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Список не загружен.");
                return new List<ProductsType>();
            }
            return resultList;
        }

        public static List<ProductsGroup> GetGroupList()
        {
            string result = string.Empty;
            List<ProductsGroup> resultList = new List<ProductsGroup>();
            try
            {
                StreamReader stream = new StreamReader(PathToGroupList, Encoding.GetEncoding(1251));
                string[] tempArr = new string[0];
                while ((result = stream.ReadLine()) != null)
                {
                    tempArr = result.Split(';');
                    string temp = string.Empty;
                    if (tempArr.Length == 1 && !tempArr[0].Contains("Группы товаров"))
                    {
                        resultList.Add(new ProductsGroup(tempArr[0]));
                    }

                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Список не загружен.");
                return new List<ProductsGroup>();
            }
            return resultList;
        }

        public static List<Storages> GetStorageList()
        {
            string result = string.Empty;
            List<Storages> resultList = new List<Storages>();
            try
            {
                StreamReader stream = new StreamReader(PathToStorageList, Encoding.GetEncoding(1251));
                string[] tempArr = new string[0];
                while ((result = stream.ReadLine()) != null)
                {
                    tempArr = result.Split(';');
                    string temp = string.Empty;
                    if (tempArr.Length == 1 && !tempArr[0].Contains("Склад:"))
                    {
                        resultList.Add(new Storages(tempArr[0]));
                    }

                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Список не загружен.");
                return new List<Storages>();
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
            return new Product(string.Empty, "", "", "", "", "", "", "", barCode, "", "");
        }
    }

    public class Product
    {
        private string _quantity;
        private string _price;
        private string _name;
        private string _barcode;
        private string _article;
        private string _code;
        private string _weightCode;

        public string BarCode 
        {
            get
            {
                return _barcode.Trim();
            }
            set
            {
                _barcode = value.Trim();
            }
        }
        public string Name
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }
        public string Quantity 
        {
            get 
            {
                if (_quantity.Contains('.'))
                    return _quantity.Replace('.', ',');
                else
                {
                    return _quantity;
                }
            }
            set
            {
                if(value.Contains('.'))
                {
                    _quantity = value.Replace('.', ',');
                }
                else
                {
                    _quantity = value;
                }
            } 
        }
        public string Price
        {
            get
            {
                if (_price.Contains('.'))
                    return _price.Replace('.', ',');
                else
                {
                    return _price;
                }
            }
            set
            {
                if (value.Contains('.'))
                {
                    _price = value.Replace('.', ',');
                }
                else
                {
                    _price = value;
                }
            }
        }
        public string Article
        {
            get
            {
                if (_article.Contains('.'))
                    return _article.Replace('.', ',');
                else
                {
                    return _article;
                }
            }
            set
            {
                if (value.Contains('.'))
                {
                    _article = value.Replace('.', ',');
                }
                else
                {
                    _article = value;
                }
            }
        }
        public string Code
        {
            get
            {
                if (_code.Contains('.'))
                    return _code.Replace('.', ',');
                else
                {
                    return _code;
                }
            }
            set
            {
                if (value.Contains('.'))
                {
                    _code = value.Replace('.', ',');
                }
                else
                {
                    _code = value;
                }
            }
        }
        public string WeightCode
        {
            get
            {
                if (_weightCode.Contains('.'))
                    return _weightCode.Replace('.', ',');
                else
                {
                    return _weightCode;
                }
            }
            set
            {
                if (value.Contains('.'))
                {
                    _weightCode = value.Replace('.', ',');
                }
                else
                {
                    _weightCode = value;
                }
            }
        }
        public string Group { get; set; }
        public string Type { get; set; }
        public string Unit { get; set; }
        public string IsWeight { get; set; }
        public string Storage { get; set; }
        public string Contractor { get; set; }



        public Product(string name, string code, string article, string group, string type,
            string unit, string iSweighted, string weightCode, string barCode, string price, string quantity)
        {
            BarCode = barCode;
            Name = name;
            Quantity = quantity;
            Price = price;
            Code = code;
            Article = article;
            Group = group;
            Type = type;
            Unit = unit;
            IsWeight = iSweighted;
            WeightCode = weightCode;
            Storage = string.Empty;
            Contractor = string.Empty;
        }

        public override string ToString()
        {
            return Name + ";" + Code + ";" + Article + ";" + Group + ";" + Type + ";" + 
                Unit + ";" + IsWeight + ";" + WeightCode + ";" + BarCode + ";" + Price + ";" + Quantity;
        }
    }

    public class Storages
    {
        public string Storage { get; set; }
        public Storages(string storage)
        {
            Storage = storage;
        }
    }

    public class ProductsType
    {
        public string Type { get; set; }
        public ProductsType(string type)
        {
            Type = type;
        }
    }

    public class Contractors
    {
        public string Contractor { get; set; }
        public Contractors(string contract)
        {
            Contractor = contract;
        }
    }

    public class ProductsGroup
    {
        public string Group { get; set; }
        public ProductsGroup(string group)
        {
            Group = group;
        }
    }
}
