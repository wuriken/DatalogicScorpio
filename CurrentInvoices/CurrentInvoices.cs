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
    public partial class CurrentInvoices : Form
    {
        private Invoice invoiceShow;

        public CurrentInvoices()
        {
            InitializeComponent();

        }

        private void CurrentIncoicesLoad()
        {
            DirectoryInfo[] dirs = Helper.GetWorkDirectories();
            for (int i = 0; i < dirs.Length; i++)
			{
                TrVwCurrentInvoices.Nodes.Add(dirs[i].Name);
                FileInfo[] fileInf = dirs[i].GetFiles();
                foreach (FileInfo item in fileInf)
                {
                    TrVwCurrentInvoices.Nodes[i].Nodes.Add(item.Name);
                }
            }  
        }

        private void BtnInvoiceOpen_Click(object sender, EventArgs e)
        {
            if (TrVwCurrentInvoices.SelectedNode != null)
            {
                if (TrVwCurrentInvoices.SelectedNode.Parent != null)
                {
                    invoiceShow = new DatalogicScorpio.CurrentInvoices.Invoice(Helper.PathToRootDirectory + TrVwCurrentInvoices.SelectedNode.Parent.Text + @"\"
                        + TrVwCurrentInvoices.SelectedNode.Text);
                    invoiceShow.ShowDialog();
                }
            }
        }

        private void CurrentInvoices_Load(object sender, EventArgs e)
        {
            TrVwCurrentInvoices.Nodes.Clear();
            CurrentIncoicesLoad();
        }

        private void TrVwCurrentInvoices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && TrVwCurrentInvoices.SelectedNode != null)
            {
                if (TrVwCurrentInvoices.SelectedNode.Parent == null)
                {
                    TrVwCurrentInvoices.SelectedNode.Expand();
                }
                else
                {
                    BtnInvoiceOpen_Click(this, new EventArgs());
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}