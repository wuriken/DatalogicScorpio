using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DatalogicScorpio
{
    public partial class NewInvoiceForm : Form
    {
        private List<Product> ProdList { get; set; }
        private InvoiceType invType;

        public NewInvoiceForm(InvoiceType type)
        {
            InitializeComponent();
            invType = type;
            Form1.Scanner.GoodReadEvent += new datalogic.datacapture.ScannerEngine.LaserEventHandler(Scanner_GoodReadEvent);
        }

        private void NewInvoiceForm_Load(object sender, EventArgs e)
        {
            TrwViewInvoice.Nodes.Clear();
            ProdList = new List<Product>();
            TxtBxDocName.Text = DateTime.Now.ToString("dd_MM_HH_mm");

            ControlsFilling();
            switch (invType)
            {
                case InvoiceType.Arrival:
                    LblWindowName.Text = "Приходная накладная";
                    break;
                case InvoiceType.Inventory:
                    LblWindowName.Text = "Инвентаризация";
                    CmbBxContractors.Enabled = false;
                    break;
                case InvoiceType.Production:
                    LblWindowName.Text = "Производство";
                    CmbBxContractors.Enabled = false;
                    break;
            }
        }

        private void ControlsFilling()
        {
            foreach (string item in Form1.ContractorsList)
            {
                CmbBxContractors.Items.Add(item);
            }
            foreach (string item in Form1.StorageList)
            {
                CmbBxStorage.Items.Add(item);
            }
        }

        private void Scanner_GoodReadEvent(datalogic.datacapture.ScannerEngine sender)
        {
            TxtBxBarCode.Text = string.Empty;
            string barCode = Form1.Scanner.BarcodeDataAsText;
            TxtBxBarCode.Text = string.Empty;
            TxtBxBarCode.Text = barCode;
            if (barCode.Length > 6)
            {
                FindAndAddProductToList(barCode);
            }
        }

        private void FindAndAddProductToList(string barcode)
        {
            Product curProd = new Product(Helper.GetProductByBarCode(Form1.ProductsList, barcode));
            bool isNewProd = curProd.Name == string.Empty ? true : false;
            QuntityForm addForm = new QuntityForm(curProd);
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
            {
                TreeViewAdd(addForm.CurrentProduct.Quantity, addForm.CurrentProduct.Price, addForm.CurrentProduct.Name);
                curProd.Name = addForm.CurrentProduct.Name;
                curProd.Quantity = addForm.CurrentProduct.Quantity;
                curProd.Price = addForm.CurrentProduct.Price;
                if (isNewProd)
                {
                    Form1.ProductsList.Add(curProd);
                }
                ProdList.Add(curProd);
                LblInvSumValue.Text = Helper.InvoiceSummCount(ProdList).ToString();
                TxtBxQuant.Text = addForm.CurrentProduct.Quantity;
                TxtBxGoodName.Text = addForm.CurrentProduct.Name;
                TxtBxPrice.Text = addForm.CurrentProduct.Price;
            }
        }

        private void TreeViewAdd(string quantity, string price, string name)
        {
            TrwViewInvoice.Nodes.Add(quantity + " - " + price + " - " + name);
        }

        private void NewInvoiceForm_Closed(object sender, EventArgs e)
        {
            Form1.Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
        }

        private void TrwViewInvoice_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TrwViewInvoice.SelectedNode != null)
            {
                int index = TrwViewInvoice.SelectedNode.Index;
                TxtBxBarCode.Text = ProdList[index].BarCode;
                TxtBxGoodName.Text = ProdList[index].Name;
                TxtBxPrice.Text = ProdList[index].Price;
                TxtBxQuant.Text = ProdList[index].Quantity;
            }
        }

        private void BtnInvoiceSave_Click(object sender, EventArgs e)
        {
            Helper.WriteLineToFile(Helper.HeaderInvoice,invType.ToString() + "_" + TxtBxDocName.Text + ".csv");
            foreach (Product item in ProdList)
            {
                item.Contractor = CmbBxContractors.Text;
                item.Storage = CmbBxStorage.Text;
                Helper.WriteLineToFile(item.ToString() + ";" + item.Contractor + ";" + item.Storage, invType.ToString() + "_" + TxtBxDocName.Text + ".csv");
            }
            
            this.Close();
        }

        private void NewInvoiceForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (int)Keys.Enter)
            //{
            //    BtnInvoiceSave_Click(this, new EventArgs());
            //}
        }

        private void TxtBxDocName_GotFocus(object sender, EventArgs e)
        {
            InpPnNewInvForm.Enabled = true;
            Helper.KeyboardChange(InpPnNewInvForm);
        }

        private void TxtBxDocName_LostFocus(object sender, EventArgs e)
        {
            InpPnNewInvForm.Enabled = false;
        }

        private void TxtBxGoodName_GotFocus(object sender, EventArgs e)
        {
            InpPnNewInvForm.Enabled = true;
        }

        private void TxtBxGoodName_LostFocus(object sender, EventArgs e)
        {
            InpPnNewInvForm.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewInvoiceForm_Closing(object sender, CancelEventArgs e)
        {
            Form1.Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
            TxtBxBarCode.Text = string.Empty;
            TxtBxDocName.Text = string.Empty;
            TxtBxGoodName.Text = string.Empty;
            TxtBxQuant.Text = string.Empty;
        }

        private void TxtBxBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && TxtBxBarCode.Text != string.Empty)
            {
                FindAndAddProductToList(TxtBxBarCode.Text);
            }
        }

        private void TxtBxBarCode_GotFocus(object sender, EventArgs e)
        {
            TxtBxBarCode.Text = string.Empty;
        }

        private void TxtBxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\u0008')
                e.Handled = false;
        }

        private void TxtBxQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\u0008')
                e.Handled = false;
        }
    }
}