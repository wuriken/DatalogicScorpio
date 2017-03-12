namespace DatalogicScorpio.CurrentInvoices
{
    partial class CurrentInvoices
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.TrVwCurrentInvoices = new System.Windows.Forms.TreeView();
            this.BtnInvoiceOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrVwCurrentInvoices
            // 
            this.TrVwCurrentInvoices.Location = new System.Drawing.Point(4, 3);
            this.TrVwCurrentInvoices.Name = "TrVwCurrentInvoices";
            this.TrVwCurrentInvoices.Size = new System.Drawing.Size(233, 231);
            this.TrVwCurrentInvoices.TabIndex = 0;
            this.TrVwCurrentInvoices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrVwCurrentInvoices_KeyPress);
            // 
            // BtnInvoiceOpen
            // 
            this.BtnInvoiceOpen.Location = new System.Drawing.Point(122, 240);
            this.BtnInvoiceOpen.Name = "BtnInvoiceOpen";
            this.BtnInvoiceOpen.Size = new System.Drawing.Size(115, 20);
            this.BtnInvoiceOpen.TabIndex = 1;
            this.BtnInvoiceOpen.Text = "Открыть";
            this.BtnInvoiceOpen.Click += new System.EventHandler(this.BtnInvoiceOpen_Click);
            // 
            // CurrentInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.BtnInvoiceOpen);
            this.Controls.Add(this.TrVwCurrentInvoices);
            this.Menu = this.mainMenu1;
            this.Name = "CurrentInvoices";
            this.Text = "Список документов";
            this.Load += new System.EventHandler(this.CurrentInvoices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TrVwCurrentInvoices;
        private System.Windows.Forms.Button BtnInvoiceOpen;
    }
}