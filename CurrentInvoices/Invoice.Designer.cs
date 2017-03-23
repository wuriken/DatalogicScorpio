namespace DatalogicScorpio.CurrentInvoices
{
    partial class Invoice
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс  следует удалить; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.TrVwInvoice = new System.Windows.Forms.TreeView();
            this.TxtBoxDate = new System.Windows.Forms.TextBox();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblInvName = new System.Windows.Forms.Label();
            this.TxtBxBarCode = new System.Windows.Forms.TextBox();
            this.TxtBxQuant = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtBxGoodName = new System.Windows.Forms.TextBox();
            this.InpPanelCurInv = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblWindowName = new System.Windows.Forms.Label();
            this.TxtBxPrice = new System.Windows.Forms.TextBox();
            this.LblQuant = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.CmbBxContractors = new System.Windows.Forms.ComboBox();
            this.CmbBxStorage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TrVwInvoice
            // 
            this.TrVwInvoice.Location = new System.Drawing.Point(4, 158);
            this.TrVwInvoice.Name = "TrVwInvoice";
            this.TrVwInvoice.ShowRootLines = false;
            this.TrVwInvoice.Size = new System.Drawing.Size(233, 107);
            this.TrVwInvoice.TabIndex = 0;
            this.TrVwInvoice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrVwInvoice_AfterSelect);
            this.TrVwInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrVwInvoice_KeyPress);
            // 
            // TxtBoxDate
            // 
            this.TxtBoxDate.Enabled = false;
            this.TxtBoxDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBoxDate.Location = new System.Drawing.Point(77, 47);
            this.TxtBoxDate.Name = "TxtBoxDate";
            this.TxtBoxDate.Size = new System.Drawing.Size(152, 19);
            this.TxtBoxDate.TabIndex = 9;
            // 
            // TxtBxName
            // 
            this.TxtBxName.Enabled = false;
            this.TxtBxName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxName.Location = new System.Drawing.Point(77, 23);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(152, 19);
            this.TxtBxName.TabIndex = 8;
            // 
            // LblDate
            // 
            this.LblDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblDate.Location = new System.Drawing.Point(4, 49);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(100, 20);
            this.LblDate.Text = "Дата:";
            // 
            // LblInvName
            // 
            this.LblInvName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblInvName.Location = new System.Drawing.Point(4, 25);
            this.LblInvName.Name = "LblInvName";
            this.LblInvName.Size = new System.Drawing.Size(100, 20);
            this.LblInvName.Text = "Имя:";
            // 
            // TxtBxBarCode
            // 
            this.TxtBxBarCode.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxBarCode.Location = new System.Drawing.Point(4, 71);
            this.TxtBxBarCode.Name = "TxtBxBarCode";
            this.TxtBxBarCode.Size = new System.Drawing.Size(147, 19);
            this.TxtBxBarCode.TabIndex = 12;
            this.TxtBxBarCode.GotFocus += new System.EventHandler(this.TxtBxBarCode_GotFocus);
            this.TxtBxBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxBarCode_KeyPress);
            // 
            // TxtBxQuant
            // 
            this.TxtBxQuant.Enabled = false;
            this.TxtBxQuant.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxQuant.Location = new System.Drawing.Point(59, 115);
            this.TxtBxQuant.Name = "TxtBxQuant";
            this.TxtBxQuant.Size = new System.Drawing.Size(51, 19);
            this.TxtBxQuant.TabIndex = 13;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(4, 271);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(110, 20);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtBxGoodName
            // 
            this.TxtBxGoodName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxGoodName.Location = new System.Drawing.Point(4, 93);
            this.TxtBxGoodName.Name = "TxtBxGoodName";
            this.TxtBxGoodName.Size = new System.Drawing.Size(232, 19);
            this.TxtBxGoodName.TabIndex = 15;
            this.TxtBxGoodName.GotFocus += new System.EventHandler(this.TxtBxGoodName_GotFocus);
            this.TxtBxGoodName.LostFocus += new System.EventHandler(this.TxtBxGoodName_LostFocus);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(126, 271);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(110, 20);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblWindowName
            // 
            this.LblWindowName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LblWindowName.Location = new System.Drawing.Point(51, 0);
            this.LblWindowName.Name = "LblWindowName";
            this.LblWindowName.Size = new System.Drawing.Size(178, 20);
            this.LblWindowName.Text = "Документ";
            // 
            // TxtBxPrice
            // 
            this.TxtBxPrice.Enabled = false;
            this.TxtBxPrice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.TxtBxPrice.Location = new System.Drawing.Point(164, 115);
            this.TxtBxPrice.Name = "TxtBxPrice";
            this.TxtBxPrice.Size = new System.Drawing.Size(48, 19);
            this.TxtBxPrice.TabIndex = 21;
            // 
            // LblQuant
            // 
            this.LblQuant.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblQuant.Location = new System.Drawing.Point(4, 117);
            this.LblQuant.Name = "LblQuant";
            this.LblQuant.Size = new System.Drawing.Size(49, 20);
            this.LblQuant.Text = "Кол-во:";
            // 
            // LblPrice
            // 
            this.LblPrice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LblPrice.Location = new System.Drawing.Point(116, 117);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(46, 20);
            this.LblPrice.Text = "Цена:";
            // 
            // CmbBxContractors
            // 
            this.CmbBxContractors.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.CmbBxContractors.Location = new System.Drawing.Point(4, 136);
            this.CmbBxContractors.Name = "CmbBxContractors";
            this.CmbBxContractors.Size = new System.Drawing.Size(127, 20);
            this.CmbBxContractors.TabIndex = 25;
            // 
            // CmbBxStorage
            // 
            this.CmbBxStorage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.CmbBxStorage.Location = new System.Drawing.Point(135, 136);
            this.CmbBxStorage.Name = "CmbBxStorage";
            this.CmbBxStorage.Size = new System.Drawing.Size(100, 20);
            this.CmbBxStorage.TabIndex = 26;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.CmbBxStorage);
            this.Controls.Add(this.CmbBxContractors);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblQuant);
            this.Controls.Add(this.TxtBxPrice);
            this.Controls.Add(this.LblWindowName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtBxGoodName);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtBxQuant);
            this.Controls.Add(this.TxtBxBarCode);
            this.Controls.Add(this.TxtBoxDate);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblInvName);
            this.Controls.Add(this.TrVwInvoice);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Invoice";
            this.Text = "Документ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TrVwInvoice;
        private System.Windows.Forms.TextBox TxtBoxDate;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblInvName;
        private System.Windows.Forms.TextBox TxtBxBarCode;
        private System.Windows.Forms.TextBox TxtBxQuant;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtBxGoodName;
        private Microsoft.WindowsCE.Forms.InputPanel InpPanelCurInv;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblWindowName;
        private System.Windows.Forms.TextBox TxtBxPrice;
        private System.Windows.Forms.Label LblQuant;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.ComboBox CmbBxContractors;
        private System.Windows.Forms.ComboBox CmbBxStorage;
    }
}