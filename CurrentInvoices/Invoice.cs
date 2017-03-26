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
            Form1.Scanner.GoodReadEvent += new datalogic.datacapture.ScannerEngine.LaserEventHandler(Scanner_GoodReadEvent);
        }

        private void TreeViewLoad(string path)
        {
            string result = string.Empty;
            ProductList = Helper.InvoiceLoad(path);
            foreach (Product item in ProductList)
            {
                TreeViewAdd(item.Quantity, item.Price, item.Name);
            }
            if(ProductList.Count > 0)
            {
                if (ProductList[0].Contractor != string.Empty)
                {
                    CmbBxContractors.Items.Add(ProductList[0].Contractor);
                    CmbBxContractors.SelectedIndex = 0;
                }
                else
                {
                    foreach (string item in Form1.ContractorsList)
                    {
                        CmbBxContractors.Items.Add(item);
                    }
                }
                if (ProductList[0].Storage != string.Empty)
                {
                    CmbBxStorage.Items.Add(ProductList[0].Storage);
                    CmbBxStorage.SelectedIndex = 0;
                }
                else
                {
                    foreach (string item in Form1.StorageList)
                    {
                        CmbBxStorage.Items.Add(item);
                    }
                }
            }
            FileInfo info = new FileInfo(path);
            TxtBxName.Text = info.Name;
            LblInvSumValue.Text = Helper.InvoiceSummCount(ProductList).ToString();
            TxtBoxDate.Text = info.CreationTime.ToString("dd-MM-yyyy HH:ss");
        }

        private void TrVwInvoice_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TrVwInvoice.SelectedNode != null)
            {
                int index = TrVwInvoice.SelectedNode.Index;
                TxtBxBarCode.Text = ProductList[index].BarCode;
                TxtBxGoodName.Text = ProductList[index].Name;
                TxtBxPrice.Text = ProductList[index].Price;
                TxtBxQuant.Text = ProductList[index].Quantity;
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
           
            if(PathToFile.Contains(InvoiceType.Arrival.ToString()))
            {
                    LblWindowName.Text = "Приходная накладная";
            }
            else if(PathToFile.Contains(InvoiceType.Inventory.ToString()))
            {
                    LblWindowName.Text = "Инвентаризация";
                    CmbBxContractors.Enabled = false;
            }
            else if(PathToFile.Contains(InvoiceType.Production.ToString()))
            {
                    LblWindowName.Text = "Производство";
                    CmbBxContractors.Enabled = false;
            }
        }

        private void Scanner_GoodReadEvent(datalogic.datacapture.ScannerEngine sender)
        {
            TxtBxBarCode.Text = string.Empty;
            string barCode = Form1.Scanner.BarcodeDataAsText;
            TxtBxBarCode.Text = string.Empty;
            TxtBxPrice.Text = string.Empty;
            TxtBxBarCode.Text = barCode;
            if (barCode.Length > 6)
            {
                GetProductByBarCode(barCode);
            }
        }

        private void GetProductByBarCode(string barCode)
        {
            Product curProd = new Product(Helper.GetProductByBarCode(Form1.ProductsList, barCode));
            bool isNewProduct = curProd.Name == string.Empty ? true : false;
            QuntityForm addForm = new QuntityForm(curProd);
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
            {
                TreeViewAdd(addForm.CurrentProduct.Quantity, addForm.CurrentProduct.Price, addForm.CurrentProduct.Name);
                curProd.Name = addForm.CurrentProduct.Name;
                curProd.Quantity = addForm.CurrentProduct.Quantity;
                curProd.Price = addForm.CurrentProduct.Price;
                if (isNewProduct)
                {
                    Form1.ProductsList.Add(curProd);
                }
                ProductList.Add(curProd);
                LblInvSumValue.Text = Helper.InvoiceSummCount(ProductList).ToString();
                TxtBxQuant.Text = addForm.CurrentProduct.Quantity;
                TxtBxGoodName.Text = addForm.CurrentProduct.Name;
                TxtBxPrice.Text = addForm.CurrentProduct.Price;
            }
        }

        private void TreeViewAdd(string quantity, string price, string name)
        {
            TrVwInvoice.Nodes.Add(quantity + " - " + price + " - " + name);
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
            Helper.WriteLineToFile(Helper.HeaderInvoice, infFile.Name);
            foreach (Product item in ProductList)
            {
                item.Contractor = CmbBxContractors.Text;
                item.Storage = CmbBxStorage.Text;
                Helper.WriteLineToFile(item.ToString() + ";" + item.Contractor + ";" + item.Storage, infFile.Name);
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
                    TrVwInvoice.SelectedNode.Text = addForm.CurrentProduct.Quantity + " - " + addForm.CurrentProduct.Price + " - " + addForm.CurrentProduct.Name;
                    ProductList[index].Name = addForm.CurrentProduct.Name;
                    ProductList[index].Quantity = addForm.CurrentProduct.Quantity;
                    ProductList[index].Price = addForm.CurrentProduct.Price;
                    TxtBxQuant.Text = addForm.CurrentProduct.Quantity;
                    TxtBxGoodName.Text = addForm.CurrentProduct.Name;
                    TxtBxPrice.Text = addForm.CurrentProduct.Price;
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

        private void Invoice_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void Invoice_Closed(object sender, EventArgs e)
        {
            Form1.Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
        }
    }
}