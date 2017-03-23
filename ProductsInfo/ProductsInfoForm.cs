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
            TxtBxName.Text = curProd.Name == string.Empty ? "Товар не найден" : curProd.Name;
            ChkBxWeight.Checked = curProd.IsWeight == "ИСТИНА" ? true : false;
            LblPriceValue.Text = curProd.Price;
            LblQuantValue.Text = curProd.Quantity;
            LblTypeValue.Text = curProd.Type;
            LblGroupValue.Text = curProd.Group;
            LblUnit.Text = curProd.Unit;
            LblWeightCode.Text = curProd.WeightCode;
            TxtBxBarCode.Text = curProd.BarCode;
            LblArtValue.Text = curProd.Article;
        }

        private void ProductsInfo_Closing(object sender, CancelEventArgs e)
        {
            Form1.Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
            TxtBxBarCode.Text = string.Empty;
            TxtBxName.Text = string.Empty;
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