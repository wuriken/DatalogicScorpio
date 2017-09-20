namespace DatalogicScorpio.CurrentInvoices
{
    partial class CurrentInvoices
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.TrVwCurrentInvoices = new System.Windows.Forms.TreeView();
            this.BtnInvoiceOpen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblWindowName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrVwCurrentInvoices
            // 
            this.TrVwCurrentInvoices.Location = new System.Drawing.Point(4, 27);
            this.TrVwCurrentInvoices.Name = "TrVwCurrentInvoices";
            this.TrVwCurrentInvoices.Size = new System.Drawing.Size(308, 204);
            this.TrVwCurrentInvoices.TabIndex = 0;
            this.TrVwCurrentInvoices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrVwCurrentInvoices_KeyPress);
            // 
            // BtnInvoiceOpen
            // 
            this.BtnInvoiceOpen.Location = new System.Drawing.Point(4, 237);
            this.BtnInvoiceOpen.Name = "BtnInvoiceOpen";
            this.BtnInvoiceOpen.Size = new System.Drawing.Size(115, 20);
            this.BtnInvoiceOpen.TabIndex = 1;
            this.BtnInvoiceOpen.Text = "Открыть";
            this.BtnInvoiceOpen.Click += new System.EventHandler(this.BtnInvoiceOpen_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(175, 237);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(111, 20);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Отмена";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblWindowName
            // 
            this.LblWindowName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LblWindowName.Location = new System.Drawing.Point(55, 4);
            this.LblWindowName.Name = "LblWindowName";
            this.LblWindowName.Size = new System.Drawing.Size(161, 20);
            this.LblWindowName.Text = "Список документов";
            // 
            // CurrentInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(315, 280);
            this.Controls.Add(this.LblWindowName);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnInvoiceOpen);
            this.Controls.Add(this.TrVwCurrentInvoices);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "CurrentInvoices";
            this.Text = "Список документов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CurrentInvoices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TrVwCurrentInvoices;
        private System.Windows.Forms.Button BtnInvoiceOpen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblWindowName;
    }
}