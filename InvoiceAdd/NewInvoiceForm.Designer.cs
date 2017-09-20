namespace DatalogicScorpio
{
    partial class NewInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.LblStorage = new System.Windows.Forms.Label();
            this.LblCntractors = new System.Windows.Forms.Label();
            this.CmbBxStorage = new System.Windows.Forms.ComboBox();
            this.CmbBxContractors = new System.Windows.Forms.ComboBox();
            this.LblInvSumm = new System.Windows.Forms.Label();
            this.LblInvSumValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBxBarCode
            // 
            this.TxtBxBarCode.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxBarCode.Location = new System.Drawing.Point(101, 53);
            this.TxtBxBarCode.Name = "TxtBxBarCode";
            this.TxtBxBarCode.Size = new System.Drawing.Size(211, 19);
            this.TxtBxBarCode.TabIndex = 0;
            this.TxtBxBarCode.GotFocus += new System.EventHandler(this.TxtBxBarCode_GotFocus);
            this.TxtBxBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxBarCode_KeyPress);
            // 
            // TrwViewInvoice
            // 
            this.TrwViewInvoice.Location = new System.Drawing.Point(12, 161);
            this.TrwViewInvoice.Name = "TrwViewInvoice";
            this.TrwViewInvoice.ShowRootLines = false;
            this.TrwViewInvoice.Size = new System.Drawing.Size(300, 58);
            this.TrwViewInvoice.TabIndex = 2;
            this.TrwViewInvoice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrwViewInvoice_AfterSelect);
            // 
            // TxtBxQuant
            // 
            this.TxtBxQuant.Enabled = false;
            this.TxtBxQuant.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxQuant.Location = new System.Drawing.Point(81, 74);
            this.TxtBxQuant.Name = "TxtBxQuant";
            this.TxtBxQuant.Size = new System.Drawing.Size(70, 19);
            this.TxtBxQuant.TabIndex = 3;
            this.TxtBxQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxQuant_KeyPress);
            // 
            // BtnInvoiceSave
            // 
            this.BtnInvoiceSave.Location = new System.Drawing.Point(40, 248);
            this.BtnInvoiceSave.Name = "BtnInvoiceSave";
            this.BtnInvoiceSave.Size = new System.Drawing.Size(91, 20);
            this.BtnInvoiceSave.TabIndex = 4;
            this.BtnInvoiceSave.Text = "Сохранить";
            this.BtnInvoiceSave.Click += new System.EventHandler(this.BtnInvoiceSave_Click);
            // 
            // LblDocName
            // 
            this.LblDocName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblDocName.Location = new System.Drawing.Point(10, 31);
            this.LblDocName.Name = "LblDocName";
            this.LblDocName.Size = new System.Drawing.Size(112, 20);
            this.LblDocName.Text = "Имя документа:";
            // 
            // TxtBxDocName
            // 
            this.TxtBxDocName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxDocName.Location = new System.Drawing.Point(117, 28);
            this.TxtBxDocName.Name = "TxtBxDocName";
            this.TxtBxDocName.Size = new System.Drawing.Size(195, 19);
            this.TxtBxDocName.TabIndex = 6;
            this.TxtBxDocName.GotFocus += new System.EventHandler(this.TxtBxDocName_GotFocus);
            this.TxtBxDocName.LostFocus += new System.EventHandler(this.TxtBxDocName_LostFocus);
            // 
            // InpPnNewInvForm
            // 
            // 
            // TxtBxGoodName
            // 
            this.TxtBxGoodName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxGoodName.Location = new System.Drawing.Point(13, 95);
            this.TxtBxGoodName.Name = "TxtBxGoodName";
            this.TxtBxGoodName.Size = new System.Drawing.Size(299, 19);
            this.TxtBxGoodName.TabIndex = 7;
            this.TxtBxGoodName.GotFocus += new System.EventHandler(this.TxtBxGoodName_GotFocus);
            this.TxtBxGoodName.LostFocus += new System.EventHandler(this.TxtBxGoodName_LostFocus);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(183, 248);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(80, 20);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblWindowName
            // 
            this.LblWindowName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LblWindowName.Location = new System.Drawing.Point(23, 3);
            this.LblWindowName.Name = "LblWindowName";
            this.LblWindowName.Size = new System.Drawing.Size(210, 20);
            this.LblWindowName.Text = "Новый документ";
            // 
            // LblQuant
            // 
            this.LblQuant.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblQuant.Location = new System.Drawing.Point(13, 75);
            this.LblQuant.Name = "LblQuant";
            this.LblQuant.Size = new System.Drawing.Size(56, 20);
            this.LblQuant.Text = "Кол-во:";
            // 
            // LblPrice
            // 
            this.LblPrice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblPrice.Location = new System.Drawing.Point(162, 75);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(43, 20);
            this.LblPrice.Text = "Цена:";
            // 
            // TxtBxPrice
            // 
            this.TxtBxPrice.Enabled = false;
            this.TxtBxPrice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxPrice.Location = new System.Drawing.Point(211, 74);
            this.TxtBxPrice.Name = "TxtBxPrice";
            this.TxtBxPrice.Size = new System.Drawing.Size(65, 19);
            this.TxtBxPrice.TabIndex = 13;
            this.TxtBxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxPrice_KeyPress);
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblName.Location = new System.Drawing.Point(10, 53);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(91, 20);
            this.LblName.Text = "Штрих-код:";
            // 
            // LblStorage
            // 
            this.LblStorage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblStorage.Location = new System.Drawing.Point(13, 117);
            this.LblStorage.Name = "LblStorage";
            this.LblStorage.Size = new System.Drawing.Size(56, 20);
            this.LblStorage.Text = "Склад:";
            // 
            // LblCntractors
            // 
            this.LblCntractors.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblCntractors.Location = new System.Drawing.Point(13, 138);
            this.LblCntractors.Name = "LblCntractors";
            this.LblCntractors.Size = new System.Drawing.Size(74, 20);
            this.LblCntractors.Text = "Поставщик:";
            // 
            // CmbBxStorage
            // 
            this.CmbBxStorage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.CmbBxStorage.Location = new System.Drawing.Point(93, 116);
            this.CmbBxStorage.Name = "CmbBxStorage";
            this.CmbBxStorage.Size = new System.Drawing.Size(219, 20);
            this.CmbBxStorage.TabIndex = 23;
            // 
            // CmbBxContractors
            // 
            this.CmbBxContractors.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.CmbBxContractors.Location = new System.Drawing.Point(93, 138);
            this.CmbBxContractors.Name = "CmbBxContractors";
            this.CmbBxContractors.Size = new System.Drawing.Size(219, 20);
            this.CmbBxContractors.TabIndex = 24;
            // 
            // LblInvSumm
            // 
            this.LblInvSumm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblInvSumm.Location = new System.Drawing.Point(13, 228);
            this.LblInvSumm.Name = "LblInvSumm";
            this.LblInvSumm.Size = new System.Drawing.Size(100, 15);
            this.LblInvSumm.Text = "Сумма:";
            // 
            // LblInvSumValue
            // 
            this.LblInvSumValue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LblInvSumValue.Location = new System.Drawing.Point(65, 228);
            this.LblInvSumValue.Name = "LblInvSumValue";
            this.LblInvSumValue.Size = new System.Drawing.Size(100, 15);
            this.LblInvSumValue.Text = "0.00";
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(315, 280);
            this.Controls.Add(this.LblInvSumValue);
            this.Controls.Add(this.LblInvSumm);
            this.Controls.Add(this.CmbBxContractors);
            this.Controls.Add(this.CmbBxStorage);
            this.Controls.Add(this.LblCntractors);
            this.Controls.Add(this.LblStorage);
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
        private System.Windows.Forms.Label LblStorage;
        private System.Windows.Forms.Label LblCntractors;
        private System.Windows.Forms.ComboBox CmbBxStorage;
        private System.Windows.Forms.ComboBox CmbBxContractors;
        private System.Windows.Forms.Label LblInvSumm;
        private System.Windows.Forms.Label LblInvSumValue;
    }
}