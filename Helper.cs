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
        public static string PathToProductList = @"\Program Files\DatalogicScorpio\Invoices\Products.csv";
        public static string PathToGroupList = @"\Program Files\DatalogicScorpio\Invoices\ProductsGroup.csv";
        public static string PathToContractorsList = @"\Program Files\DatalogicScorpio\Invoices\Contractors.csv";
        public static string PathToStorageList = @"\Program Files\DatalogicScorpio\Invoices\Storage.csv";
        public static string PathToTypeList = @"\Program Files\DatalogicScorpio\Invoices\ProductsType.csv";
        public static string HeaderProductsList = @"Наименование:;Код товара:;Артикул:;Группа товаров:;Вид товаров:;Единица измерения:;Весовой товар:;
                        Код весового товара:;Штрих-код:;Цена:;Количество:";
        public static string HeaderInvoice = @"Наименование:;Код товара:;Артикул:;Группа товаров:;Вид товаров:;Единица измерения:;Весовой товар:;Код весового товара:;Штрих-код:;Цена:;Количество:;Контрагент:;Склад:";

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

        public static double InvoiceSummCount(List<Product> list)
        {
            double sum = 0.00;
            string price = string.Empty;
            string quant = string.Empty;
            for (int i = 0; i < list.Count; i++)
			{
                price = list[i].Price.Contains(",") ? list[i].Price.Replace(',', '.') : list[i].Price;
                quant = list[i].Quantity.Contains(",") ? list[i].Quantity.Replace(',', '.') : list[i].Quantity;
                sum += Double.Parse(price) * Double.Parse(quant);
            }
            return sum;
        }

        public static bool FileExistsCheck(string file)
        {
            return File.Exists(PathToRootDirectory + CurrentDirectoryCheck() + @"\" + file);
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

        public static int[] ArrivalInvoiceCount()
        {
            DirectoryInfo[] dirInfo = new DirectoryInfo(PathToRootDirectory).GetDirectories();
            int[] count = new int[] { 0, 0 };
            for (int i = 0; i < dirInfo.Length; i++)
			{
                FileInfo[] fileInf = dirInfo[i].GetFiles();
                for (int j = 0; j < fileInf.Length; j++)
                {
                    if (fileInf[j].Name.Contains(InvoiceType.Arrival.ToString()) && !fileInf[j].Name.EndsWith(".exc"))
                        count[0]++;
                    else if (fileInf[j].Name.Contains(InvoiceType.Arrival.ToString()) && fileInf[j].Name.EndsWith(".exc"))
                        count[1]++;
                }
			}
                
            return count;
        }

        public static int[] InventoryInvoiceCount()
        {
            DirectoryInfo[] dirInfo = new DirectoryInfo(PathToRootDirectory).GetDirectories();
            int[] count = new int[] { 0, 0 };
            for (int i = 0; i < dirInfo.Length; i++)
            {
                FileInfo[] fileInf = dirInfo[i].GetFiles();
                for (int j = 0; j < fileInf.Length; j++)
                {
                    if (fileInf[j].Name.Contains(InvoiceType.Inventory.ToString()) && !fileInf[j].Name.EndsWith(".exc"))
                        count[0]++;
                    else if (fileInf[j].Name.Contains(InvoiceType.Inventory.ToString()) && fileInf[j].Name.EndsWith(".exc"))
                        count[1]++; 
                }
            }
            return count;
        }

        public static int[] ProductionsInvoiceCount()
        {
            DirectoryInfo[] dirInfo = new DirectoryInfo(PathToRootDirectory).GetDirectories();
            int[] count = new int[] { 0, 0 };
                for (int i = 0; i < dirInfo.Length; i++)
                {
                    FileInfo[] fileInf = dirInfo[i].GetFiles();
                    for (int j = 0; j < fileInf.Length; j++)
                    {
                        if (fileInf[j].Name.Contains(InvoiceType.Production.ToString()) && !fileInf[j].Name.EndsWith(".exc"))
                            count[0]++;
                        else if (fileInf[j].Name.Contains(InvoiceType.Production.ToString()) && fileInf[j].Name.EndsWith(".exc"))
                            count[1]++;
                    }
                }

            return count;
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

        public static List<string> GetContractorsList()
        {
            string result = string.Empty;
            List<string> resultList = new List<string>();
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
                        if (!String.IsNullOrEmpty(tempArr[0])) resultList.Add(tempArr[0]);
                    }

                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Список не загружен.");
                return new List<string>();
            }
            return resultList;
        }

        public static List<string> GetTypeList()
        {
            string result = string.Empty;
            List<string> resultList = new List<string>();
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
                        if (!string.IsNullOrEmpty(tempArr[0])) resultList.Add(tempArr[0]);
                    }

                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Список не загружен.");
                return new List<string>();
            }
            return resultList;
        }

        public static List<string> GetGroupList()
        {
            string result = string.Empty;
            List<string> resultList = new List<string>();
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
                        if (!string.IsNullOrEmpty(tempArr[0])) resultList.Add(tempArr[0]);
                    }

                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Список не загружен.");
                return new List<string>();
            }
            return resultList;
        }

        public static bool DirectoriesCopy()
        {
            if (CheckRootDirectory())
            {
                string path = RootDirectoryInfo().Parent.FullName + @"\Archives";
                if (!Directory.Exists(path))
                {
                    try
                    {
                        Directory.CreateDirectory(path);
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                try
                {
                    DirectoryInfo[] dirs = RootDirectoryInfo().GetDirectories();
                    foreach (DirectoryInfo item in dirs)
                    {
                        Directory.CreateDirectory(RootDirectoryInfo().Parent.FullName + @"\Archives\" + item.Name);
                        FileInfo[] fileInf = item.GetFiles();
                        foreach (FileInfo file in fileInf)
                        {
                            if (file.Name.EndsWith(".exc"))
                            {
                                File.Move(PathToRootDirectory + item.Name + @"\" + file.Name,
                                    RootDirectoryInfo().Parent.FullName + @"\Archives\" + item.Name + @"\" + file.Name);
                            }
                        }
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }


        public static List<string> GetStorageList()
        {
            string result = string.Empty;
            List<string> resultList = new List<string>();
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
                        if (!string.IsNullOrEmpty(tempArr[0])) resultList.Add(tempArr[0]);
                    }
                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Список не загружен.");
                return new List<string>();
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
                if (value.Contains('.'))
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

        public Product(Product prod)
        {
            BarCode = prod.BarCode;
            Name = prod.Name;
            Quantity = prod.Quantity;
            Price = prod.Price;
            Code = prod.Code;
            Article = prod.Article;
            Group = prod.Group;
            Type = prod.Type;
            Unit = prod.Unit;
            IsWeight = prod.IsWeight;
            WeightCode = prod.WeightCode;
            Storage = string.Empty;
            Contractor = string.Empty;
        }


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


}
