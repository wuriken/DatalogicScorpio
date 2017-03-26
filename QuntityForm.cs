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
            QuanFormLoad(curProd);
        }

        private void QuanFormLoad(Product prod)
        {
            CurrentProduct = prod;
            LblBarCode.Text = prod.BarCode;
            if (prod.Name != string.Empty)
            {
                TxtBxGoodName.Text = prod.Name;
                TxtBxGoodName.Enabled = false;
                TxtBxPrice.Text = prod.Price;
                ChkBxIsWeight.Checked = prod.IsWeight == "ИСТИНА" ? true : false;
                ChkBxIsWeight.Enabled = false;
                CmbBxGroup.Items.Add(prod.Group);
                CmbBxGroup.SelectedIndex = 0;
                CmbBxGroup.Enabled = false;
                CmbBxType.Items.Add(prod.Type);
                CmbBxType.SelectedIndex = 0;
                CmbBxType.Enabled = false;
                CmbBxUnit.Items.Add(prod.Unit);
                CmbBxUnit.SelectedIndex = 0;
                CmbBxUnit.Enabled = false;
                TxtBxArticle.Text = prod.Article;
                TxtBxArticle.Enabled = false;
                InptPanelQuantityForm.Enabled = true;
            }
            else
            {
                foreach (string item in Form1.UnitList)
                {
                    CmbBxUnit.Items.Add(item);
                }
                foreach (string item in Form1.ProductsGroupList)
                {
                    CmbBxGroup.Items.Add(item);
                }
                foreach (string item in Form1.ProductsTypeList)
                {
                    CmbBxType.Items.Add(item);
                }
            }
            InptPanelQuantityForm.Enabled = false;
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtBxQuant.Text != string.Empty)
            {
                CurrentProduct.Name = TxtBxGoodName.Text;
                CurrentProduct.Quantity = TxtBxQuant.Text;
                CurrentProduct.Price = TxtBxPrice.Text;
                CurrentProduct.Group = CmbBxGroup.Text;
                CurrentProduct.Type = CmbBxType.Text;
                CurrentProduct.Unit = CmbBxUnit.Text;
                CurrentProduct.Article = TxtBxArticle.Text;
                CurrentProduct.IsWeight = ChkBxIsWeight.Checked ? "ИСТИНА" : "ЛОЖЬ";
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TxtBxQuant_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBxQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar))
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
            //InptPanelQuantityForm.Enabled = true;
            Helper.KeyboardChange(InptPanelQuantityForm);
        }

        private void TxtBxGoodName_LostFocus(object sender, EventArgs e)
        {
            InptPanelQuantityForm.Enabled = false;
        }

        private void TxtBxQuant_GotFocus(object sender, EventArgs e)
        {
            //InptPanelQuantityForm.Enabled = true;
        }

        private void TxtBxQuant_LostFocus(object sender, EventArgs e)
        {
            InptPanelQuantityForm.Enabled = false;
        }

        private void QuntityForm_Closed(object sender, EventArgs e)
        {
            TxtBxGoodName.Text = string.Empty;
            TxtBxQuant.Text = string.Empty;
            TxtBxPrice.Text = string.Empty;
        }

        private void QuntityForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TxtBxPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtBxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\u0008')
                e.Handled = false;
            if (e.KeyChar == (int)Keys.Enter)
            {
                BtnOk_Click(this, new EventArgs());
            }
        }

        private void TxtBxPrice_GotFocus(object sender, EventArgs e)
        {
            InptPanelQuantityForm.Enabled = true;
            if (TxtBxPrice.Text == "0.00" || TxtBxPrice.Text == "0")
                TxtBxPrice.Text = string.Empty;
        }

        private void TxtBxPrice_LostFocus(object sender, EventArgs e)
        {
            InptPanelQuantityForm.Enabled = false;
        }
    }
}