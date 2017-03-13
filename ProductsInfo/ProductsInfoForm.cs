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
        private datalogic.datacapture.Laser Scanner { get; set; }

        public ProductsInfoForm()
        {
            Scanner = Form1.Scanner;
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
            Scanner.GoodReadEvent += new datalogic.datacapture.ScannerEngine.LaserEventHandler(Scanner_GoodReadEvent);
        }

        private void Scanner_GoodReadEvent(datalogic.datacapture.ScannerEngine sender)
        {
            if (Scanner.BarcodeDataAsText.Length > 6)
            {
                Product curProd = Helper.GetProductByBarCode(Form1.ProductsList, Scanner.BarcodeDataAsText);
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
        }

        private void ProductsInfo_Closing(object sender, CancelEventArgs e)
        {
            Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
            TxtBxBarCode.Text = string.Empty;
            TxtBxName.Text = string.Empty;
            TxtBxQuant.Text = string.Empty;
        }

    }
}