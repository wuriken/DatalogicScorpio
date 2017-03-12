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
        private string PathFile;
        public Invoice(string path)
        {
            InitializeComponent();
            TrVwInvoice.Nodes.Clear();
            TreeViewLoad(path);
            PathFile = path;
        }

        private void TreeViewLoad(string path)
        {
            string result = string.Empty;
            StreamReader stream = new StreamReader(path, Encoding.UTF8);
            while ((result = stream.ReadLine()) != null)
            {
                TrVwInvoice.Nodes.Add(result);
            }
            stream.Close();
            stream.Dispose();
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
            TxtBxBarCode.Text = string.Empty;
            TxtBxBarCode.Text = Form1.Scanner.BarcodeDataAsText;
            if (Form1.Scanner.BarcodeDataAsText.Length > 6)
            {
                QuntityForm addForm = new QuntityForm(Form1.Scanner.BarcodeDataAsText, TxtBxGoodName.Text);
                addForm.ShowDialog();
                TreeViewAdd(Form1.Scanner.BarcodeDataAsText, TxtBxGoodName.Text, addForm.Quantity);
                TxtBxQuant.Text = addForm.Quantity;
                TxtBxGoodName.Text = addForm.Name;
            }
        }

        private void TreeViewAdd(string barCode, string name, string quantity)
        {
            TrVwInvoice.Nodes.Add(barCode + " - " + name + " - " + quantity);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FileInfo inf = new FileInfo(PathFile);
            File.Delete(PathFile);
            foreach (TreeNode item in TrVwInvoice.Nodes)
            {
                Helper.WriteLineToFile(item.Text, inf.Name);
            }
            Form1.Scanner.GoodReadEvent -= Scanner_GoodReadEvent;
            this.Close();
        }

        private void TrVwInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && TrVwInvoice.SelectedNode != null)
            {
                QuntityForm addForm = new QuntityForm(TxtBxBarCode.Text, TxtBxGoodName.Text);
                addForm.ShowDialog();
                TrVwInvoice.SelectedNode.Text = TxtBxBarCode.Text + " - " + addForm.GoodName + " - " + addForm.Quantity; 
                TxtBxQuant.Text = addForm.Quantity;
                TxtBxGoodName.Text = addForm.GoodName;
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
    }
}