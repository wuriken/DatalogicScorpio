using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using datalogic.datacapture;
using System.IO;
using System.Reflection;

namespace DatalogicScorpio
{
    public partial class Form1 : Form
    {
        public static datalogic.datacapture.Laser Scanner;
        public datalogic.device.Cradle Cradle;
        public static List<Product> ProductsList;

        private static NewInvoiceForm newInvForm;
        private static CurrentInvoices.CurrentInvoices curInvForm;

        public Form1()
        {
            InitializeComponent();
            Scanner = new Laser();
            Cradle = new datalogic.device.Cradle();
            Scanner.ScannerEnabled = true;
            if (!Helper.CheckRootDirectory())
            {
                MessageBox.Show("Рабочая папка недоступна");
                this.Close();
            }
            try
            {
                ProductsList = Helper.GetProductList();
            }
            catch (Exception)
            {
                ProductsList = new List<Product>();
                MessageBox.Show("Ошибка. Список номенклатуры не загружен");
            }
        }

        
        private void BtnNewInvoice_Click(object sender, EventArgs e)
        {
            if (newInvForm == null)
            {
                newInvForm = new NewInvoiceForm(Scanner);
            }
            newInvForm.ShowDialog();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.D1)
            {
                BtnNewInvoice_Click(this, new EventArgs());
            }
            if (e.KeyChar == (int)Keys.D0)
            {
                BtnClose_Click(this, new EventArgs());
            }
            if (e.KeyChar == (int)Keys.D2)
            {
                BtnOpenInvoice_Click(this, new EventArgs());
            }
            if (e.KeyChar == (int)Keys.D9)
            {
                BtnSinhrozization_Click(this, new EventArgs());
            }
            if (e.KeyChar == (int)Keys.D3)
            {
                BtnResidues_Click(this, new EventArgs());
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOpenInvoice_Click(object sender, EventArgs e)
        {
            if (curInvForm == null)
            {
                curInvForm = new DatalogicScorpio.CurrentInvoices.CurrentInvoices();
            }
            curInvForm.ShowDialog();
        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            this.Dispose();  
        }

        private void BtnSinhrozization_Click(object sender, EventArgs e)
        {
            Cradle.Enabled = true;
            Cradle.OnCradleEnter += OnCradleEnterHandler;
            if (Helper.DirectoriesCopy())
            {
                MessageBox.Show("Папки скопированы");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private static void OnCradleEnterHandler(object sender, EventArgs e)
        {

        }

        private void BtnResidues_Click(object sender, EventArgs e)
        {
            ProductsInfo.ProductsInfoForm form = new ProductsInfo.ProductsInfoForm();
            form.ShowDialog();
        }
    }
}