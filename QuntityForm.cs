using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;

namespace DatalogicScorpio
{
    public partial class QuntityForm : Form
    {
        public Product CurrentProduct { get; private set; }

        public QuntityForm(Product curProd)
        {
            InitializeComponent();
            CurrentProduct = curProd;
            LblBarCode.Text = curProd.ProductBarCode;
            TxtBxGoodName.Text = curProd.ProductName;
            InptPanelQuantityForm.Enabled = true;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtBxQuant.Text != string.Empty)
            {
                CurrentProduct.ProductName = TxtBxGoodName.Text;
                CurrentProduct.ProductQuantity = TxtBxQuant.Text;
                this.Close();
            }
        }

        private void TxtBxQuant_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBxQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\u0008')
                e.Handled = false;
            if (e.KeyChar == (int)Keys.Enter)
            {
                BtnOk_Click(this, new EventArgs());
            }
        }

        private void TxtBxGoodName_GotFocus(object sender, EventArgs e)
        {
            InptPanelQuantityForm.Enabled = true;
        }

        private void TxtBxGoodName_LostFocus(object sender, EventArgs e)
        {
            InptPanelQuantityForm.Enabled = false;
        }

        private void TxtBxQuant_GotFocus(object sender, EventArgs e)
        {
            InptPanelQuantityForm.Enabled = true;
        }

        private void TxtBxQuant_LostFocus(object sender, EventArgs e)
        {
            InptPanelQuantityForm.Enabled = false;
        }

        private void QuntityForm_Closed(object sender, EventArgs e)
        {
            TxtBxGoodName.Text = string.Empty;
            TxtBxQuant.Text = string.Empty;
        }

        private void QuntityForm_Load(object sender, EventArgs e)
        {

        }
    }
}