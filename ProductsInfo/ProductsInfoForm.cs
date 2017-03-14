using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DatalogicScorpio.ProductsInfo
{
    public partial class ProductsInfoForm : Form
    {

        public ProductsInfoForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsInfo_Load(object sender, EventArgs e)
        {
            TxtBxBarCode.Text = string.Empty;
            TxtBxName.Text = string.Empty;
            TxtBxQuant.Text = string.Empty;
            Form1.Scanner.GoodReadEvent += new datalogic.datacapture.ScannerEngine.LaserEventHandler(Scanner_GoodReadEvent);
        }

        private void Scanner_GoodReadEvent(datalogic.datacapture.ScannerEngine sender)
        {
            string barCode = Form1.Scanner.BarcodeDataAsText;
            if (barCode.Length > 6)
            {
                FindAndShowProduct(barCode);
            }
        }

        private void FindAndShowProduct(string barcode)
        {
            Product curProd = Helper.GetProductByBarCode(Form1.ProductsList, barcode);
            if (curProd.ProductName == string.Empty)
            {
                TxtBxName.Text = "Товар не найден";
            }
            else
            {
                TxtBxName.Text = curProd.ProductName;

            }
            TxtBxBarCode.Text = curProd.ProductBarCode;
            TxtBxQuant.Text = curProd.ProductQuantity;
        }

        private void ProductsInfo_Closing(object sender, CancelEventArgs e)
        {
            Form1.Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
            TxtBxBarCode.Text = string.Empty;
            TxtBxName.Text = string.Empty;
            TxtBxQuant.Text = string.Empty;
        }

        private void TxtBxBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && TxtBxBarCode.Text != string.Empty)
            {
                FindAndShowProduct(TxtBxBarCode.Text);
            }
        }

    }
}