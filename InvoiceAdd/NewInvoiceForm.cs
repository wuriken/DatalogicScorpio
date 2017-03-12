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
        private datalogic.datacapture.Laser Scanner;
        public NewInvoiceForm(datalogic.datacapture.Laser scanner)
        {
            Scanner = scanner;
            InitializeComponent();
        }

        private void NewInvoiceForm_Load(object sender, EventArgs e)
        {
            TrwViewInvoice.Nodes.Clear();
            TxtBxDocName.Text = DateTime.Now.ToString("HH_mm");
            Scanner.GoodReadEvent += new datalogic.datacapture.ScannerEngine.LaserEventHandler(Scanner_GoodReadEvent);
        }

        private void Scanner_GoodReadEvent(datalogic.datacapture.ScannerEngine sender)
        {
            TxtBxBarCode.Text = string.Empty;
            TxtBxBarCode.Text = Scanner.BarcodeDataAsText;
            if (Scanner.BarcodeDataAsText.Length > 6)
            {
                QuntityForm addForm = new QuntityForm(Scanner.BarcodeDataAsText, TxtBxGoodName.Text);
                addForm.ShowDialog();
                TreeViewAdd(Scanner.BarcodeDataAsText, addForm.GoodName, addForm.Quantity);
                TxtBxQuant.Text = addForm.Quantity;
                TxtBxGoodName.Text = addForm.GoodName;

            }
        }

        private void TreeViewAdd(string barCode, string name, string quantity)
        {
            TrwViewInvoice.Nodes.Add(barCode + " - " +  name +  " - " + quantity);
        }

        private void NewInvoiceForm_Closed(object sender, EventArgs e)
        {

        }

        private void TrwViewInvoice_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TrwViewInvoice.SelectedNode != null)
            {
                string[] result = TrwViewInvoice.SelectedNode.Text.Split('-');
                TxtBxBarCode.Text = result[0].Trim();
                TxtBxGoodName.Text = result[1].Trim();
                TxtBxQuant.Text = result[2].Trim();
            }
        }

        private void BtnInvoiceSave_Click(object sender, EventArgs e)
        {
            foreach (TreeNode item in TrwViewInvoice.Nodes)
            {
                Helper.WriteLineToFile(item.Text, TxtBxDocName.Text + ".txt");
            }
            Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
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
    }
}