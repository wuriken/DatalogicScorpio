using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DatalogicScorpio.CurrentInvoices
{
    public partial class Invoice : Form
    {
        private string PathToFile;
        private List<Product> ProductList {get; set;}

        public Invoice(string path)
        {
            InitializeComponent();
            TrVwInvoice.Nodes.Clear();
            TreeViewLoad(path);
            PathToFile = path;
        }

        private void TreeViewLoad(string path)
        {
            string result = string.Empty;
            ProductList = new List<Product>();
            try
            {
                StreamReader stream = new StreamReader(path, Encoding.Default);
                string[] tempArr = new string[0];
                while ((result = stream.ReadLine()) != null)
                {
                    tempArr = result.Split(';');
                    ProductList.Add(new Product(tempArr[0], tempArr[1], tempArr[2]));
                    TreeViewAdd(tempArr[0], tempArr[1], tempArr[2]);
                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Документ не загружен.");
            }
            FileInfo info = new FileInfo(path);
            TxtBxName.Text = info.Name;
            TxtBoxDate.Text = info.CreationTime.ToString("dd-MM-yyyy HH:ss");
        }

        private void TrVwInvoice_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TrVwInvoice.SelectedNode != null)
            {
                string[] tmpArr = TrVwInvoice.SelectedNode.Text.Split('-');
                TxtBxBarCode.Text = tmpArr[0].Trim();
                TxtBxGoodName.Text = tmpArr[1].Trim();
                TxtBxQuant.Text = tmpArr[2].Trim();
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            Form1.Scanner.GoodReadEvent += new datalogic.datacapture.ScannerEngine.LaserEventHandler(Scanner_GoodReadEvent);
        }

        private void Scanner_GoodReadEvent(datalogic.datacapture.ScannerEngine sender)
        {
            string barCode = Form1.Scanner.BarcodeDataAsText;
            TxtBxBarCode.Text = string.Empty;
            TxtBxBarCode.Text = barCode;
            if (barCode.Length > 6)
            {
                GetProductByBarCode(barCode);
            }
        }

        private void GetProductByBarCode(string barCode)
        {
            Product curProd = Helper.GetProductByBarCode(Form1.ProductsList, barCode);
            bool isNewProduct = curProd.ProductName == string.Empty ? true : false;
            QuntityForm addForm = new QuntityForm(curProd);
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
            {
                TreeViewAdd(barCode, addForm.CurrentProduct.ProductName, addForm.CurrentProduct.ProductQuantity);
                curProd.ProductName = addForm.CurrentProduct.ProductName;
                curProd.ProductQuantity = addForm.CurrentProduct.ProductQuantity;
                if (isNewProduct)
                {
                    Form1.ProductsList.Add(curProd);
                }
                ProductList.Add(curProd);
                TxtBxQuant.Text = addForm.CurrentProduct.ProductQuantity;
                TxtBxGoodName.Text = addForm.CurrentProduct.ProductName;
            }
        }

        private void TreeViewAdd(string barCode, string name, string quantity)
        {
            TrVwInvoice.Nodes.Add(barCode + " - " + name + " - " + quantity);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FileInfo infFile = new FileInfo(PathToFile);
            try
            {
                if(File.Exists(PathToFile))
                {
                    File.Delete(PathToFile);
                }
            }
            catch (Exception)
            {
            }
            
            foreach (Product item in ProductList)
            {
                Helper.WriteLineToFile(item.ToString(), infFile.Name);
            }
            Form1.Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
            this.Close();
        }

        private void TrVwInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && TrVwInvoice.SelectedNode != null)
            {
                int index = TrVwInvoice.SelectedNode.Index;
                QuntityForm addForm = new QuntityForm(ProductList[index]);
                addForm.ShowDialog();
                if (addForm.DialogResult == DialogResult.OK)
                {
                    TrVwInvoice.SelectedNode.Text = TxtBxBarCode.Text + " - " + addForm.CurrentProduct.ProductName + " - " + addForm.CurrentProduct.ProductQuantity;
                    ProductList[index].ProductName = addForm.CurrentProduct.ProductName;
                    ProductList[index].ProductQuantity = addForm.CurrentProduct.ProductQuantity;
                    TxtBxQuant.Text = addForm.CurrentProduct.ProductQuantity;
                    TxtBxGoodName.Text = addForm.CurrentProduct.ProductName;
                }
            }
        }

        private void TxtBxGoodName_GotFocus(object sender, EventArgs e)
        {
            InpPanelCurInv.Enabled = true;
        }

        private void TxtBxGoodName_LostFocus(object sender, EventArgs e)
        {
            InpPanelCurInv.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Invoice_Closing(object sender, CancelEventArgs e)
        {
            Form1.Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
        }

        private void TxtBxBarCode_GotFocus(object sender, EventArgs e)
        {
            TxtBxBarCode.Text = string.Empty;
        }

        private void TxtBxBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter &&  TxtBxBarCode.Text != string.Empty)
            {
                GetProductByBarCode(TxtBxBarCode.Text);
            }
        }
    }
}