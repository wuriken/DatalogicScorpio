﻿namespace DatalogicScorpio
{
    partial class NewInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.TxtBxBarCode = new System.Windows.Forms.TextBox();
            this.TrwViewInvoice = new System.Windows.Forms.TreeView();
            this.TxtBxQuant = new System.Windows.Forms.TextBox();
            this.BtnInvoiceSave = new System.Windows.Forms.Button();
            this.LblDocName = new System.Windows.Forms.Label();
            this.TxtBxDocName = new System.Windows.Forms.TextBox();
            this.InpPnNewInvForm = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.TxtBxGoodName = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblWindowName = new System.Windows.Forms.Label();
            this.LblQuant = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtBxPrice = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBxBarCode
            // 
            this.TxtBxBarCode.Location = new System.Drawing.Point(99, 50);
            this.TxtBxBarCode.Name = "TxtBxBarCode";
            this.TxtBxBarCode.Size = new System.Drawing.Size(134, 21);
            this.TxtBxBarCode.TabIndex = 0;
            this.TxtBxBarCode.GotFocus += new System.EventHandler(this.TxtBxBarCode_GotFocus);
            this.TxtBxBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxBarCode_KeyPress);
            // 
            // TrwViewInvoice
            // 
            this.TrwViewInvoice.Location = new System.Drawing.Point(6, 133);
            this.TrwViewInvoice.Name = "TrwViewInvoice";
            this.TrwViewInvoice.ShowRootLines = false;
            this.TrwViewInvoice.Size = new System.Drawing.Size(223, 125);
            this.TrwViewInvoice.TabIndex = 2;
            this.TrwViewInvoice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrwViewInvoice_AfterSelect);
            // 
            // TxtBxQuant
            // 
            this.TxtBxQuant.Enabled = false;
            this.TxtBxQuant.Location = new System.Drawing.Point(75, 77);
            this.TxtBxQuant.Name = "TxtBxQuant";
            this.TxtBxQuant.Size = new System.Drawing.Size(44, 21);
            this.TxtBxQuant.TabIndex = 3;
            this.TxtBxQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxQuant_KeyPress);
            // 
            // BtnInvoiceSave
            // 
            this.BtnInvoiceSave.Location = new System.Drawing.Point(4, 264);
            this.BtnInvoiceSave.Name = "BtnInvoiceSave";
            this.BtnInvoiceSave.Size = new System.Drawing.Size(91, 20);
            this.BtnInvoiceSave.TabIndex = 4;
            this.BtnInvoiceSave.Text = "Сохранить";
            this.BtnInvoiceSave.Click += new System.EventHandler(this.BtnInvoiceSave_Click);
            // 
            // LblDocName
            // 
            this.LblDocName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblDocName.Location = new System.Drawing.Point(4, 28);
            this.LblDocName.Name = "LblDocName";
            this.LblDocName.Size = new System.Drawing.Size(112, 20);
            this.LblDocName.Text = "Имя документа:";
            // 
            // TxtBxDocName
            // 
            this.TxtBxDocName.Location = new System.Drawing.Point(115, 26);
            this.TxtBxDocName.Name = "TxtBxDocName";
            this.TxtBxDocName.Size = new System.Drawing.Size(118, 21);
            this.TxtBxDocName.TabIndex = 6;
            this.TxtBxDocName.GotFocus += new System.EventHandler(this.TxtBxDocName_GotFocus);
            this.TxtBxDocName.LostFocus += new System.EventHandler(this.TxtBxDocName_LostFocus);
            // 
            // TxtBxGoodName
            // 
            this.TxtBxGoodName.Location = new System.Drawing.Point(7, 106);
            this.TxtBxGoodName.Name = "TxtBxGoodName";
            this.TxtBxGoodName.Size = new System.Drawing.Size(223, 21);
            this.TxtBxGoodName.TabIndex = 7;
            this.TxtBxGoodName.GotFocus += new System.EventHandler(this.TxtBxGoodName_GotFocus);
            this.TxtBxGoodName.LostFocus += new System.EventHandler(this.TxtBxGoodName_LostFocus);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(147, 264);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(80, 20);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblWindowName
            // 
            this.LblWindowName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LblWindowName.Location = new System.Drawing.Point(68, 3);
            this.LblWindowName.Name = "LblWindowName";
            this.LblWindowName.Size = new System.Drawing.Size(129, 20);
            this.LblWindowName.Text = "Новый документ";
            // 
            // LblQuant
            // 
            this.LblQuant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblQuant.Location = new System.Drawing.Point(7, 79);
            this.LblQuant.Name = "LblQuant";
            this.LblQuant.Size = new System.Drawing.Size(56, 20);
            this.LblQuant.Text = "Кол-во:";
            // 
            // LblPrice
            // 
            this.LblPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblPrice.Location = new System.Drawing.Point(130, 79);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(56, 20);
            this.LblPrice.Text = "Цена:";
            // 
            // TxtBxPrice
            // 
            this.TxtBxPrice.Enabled = false;
            this.TxtBxPrice.Location = new System.Drawing.Point(187, 77);
            this.TxtBxPrice.Name = "TxtBxPrice";
            this.TxtBxPrice.Size = new System.Drawing.Size(44, 21);
            this.TxtBxPrice.TabIndex = 13;
            this.TxtBxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxPrice_KeyPress);
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblName.Location = new System.Drawing.Point(4, 50);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(91, 20);
            this.LblName.Text = "Штрих-код:";
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TxtBxPrice);
            this.Controls.Add(this.LblQuant);
            this.Controls.Add(this.LblWindowName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtBxGoodName);
            this.Controls.Add(this.TxtBxDocName);
            this.Controls.Add(this.LblDocName);
            this.Controls.Add(this.BtnInvoiceSave);
            this.Controls.Add(this.TxtBxQuant);
            this.Controls.Add(this.TrwViewInvoice);
            this.Controls.Add(this.TxtBxBarCode);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "NewInvoiceForm";
            this.Text = "Новый документ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewInvoiceForm_Load);
            this.Closed += new System.EventHandler(this.NewInvoiceForm_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.NewInvoiceForm_Closing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewInvoiceForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxBarCode;
        private System.Windows.Forms.TreeView TrwViewInvoice;
        private System.Windows.Forms.TextBox TxtBxQuant;
        private System.Windows.Forms.Button BtnInvoiceSave;
        private System.Windows.Forms.Label LblDocName;
        private System.Windows.Forms.TextBox TxtBxDocName;
        private Microsoft.WindowsCE.Forms.InputPanel InpPnNewInvForm;
        private System.Windows.Forms.TextBox TxtBxGoodName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblWindowName;
        private System.Windows.Forms.Label LblQuant;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtBxPrice;
        private System.Windows.Forms.Label LblName;
    }
}