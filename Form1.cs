﻿using System;
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
        public static datalogic.device.BatteryMonitor Monitor;
        public static List<Product> ProductsList;


        private static NewInvoiceForm newInvForm;
        private static CurrentInvoices.CurrentInvoices curInvForm;

        public Form1()
        {
            InitializeComponent();
            Scanner = new Laser();
            Monitor = new datalogic.device.BatteryMonitor();
            //Scanner.ScannerEnabled = true;
            //BatteryMonitorCinfiguration();
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

        private void BatteryMonitorCinfiguration()
        {
            Monitor.Enabled = true;
            Monitor.Interval = 300000;
            Monitor.Threshold = 10;
            Monitor.OnLowBattery += monitor_OnLowBattery;
        }

        private void monitor_OnLowBattery(object sender, EventArgs e)
        {
            MessageBox.Show("Батарея разряжена. Зарядите устройство!");
        }

        
        private void BtnNewInvoice_Click(object sender, EventArgs e)
        {
            if (newInvForm == null)
            {
                newInvForm = new NewInvoiceForm();
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
            ProductsList = Helper.GetProductList();
            if (Helper.DirectoriesCopy() && ProductsList.Count != 0)
            {
                MessageBox.Show("Данные обновлены");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnResidues_Click(object sender, EventArgs e)
        {
            ProductsInfo.ProductsInfoForm form = new ProductsInfo.ProductsInfoForm();
            form.ShowDialog();
        }
    }
}