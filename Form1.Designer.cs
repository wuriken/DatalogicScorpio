namespace DatalogicScorpio
{
    partial class Form1
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.BtnNewInvoice = new System.Windows.Forms.Button();
            this.BtnOpenInvoice = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSinhrozization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNewInvoice
            // 
            this.BtnNewInvoice.Location = new System.Drawing.Point(4, 4);
            this.BtnNewInvoice.Name = "BtnNewInvoice";
            this.BtnNewInvoice.Size = new System.Drawing.Size(233, 20);
            this.BtnNewInvoice.TabIndex = 3;
            this.BtnNewInvoice.TabStop = false;
            this.BtnNewInvoice.Text = "1) Новый документ";
            this.BtnNewInvoice.Click += new System.EventHandler(this.BtnNewInvoice_Click);
            // 
            // BtnOpenInvoice
            // 
            this.BtnOpenInvoice.Location = new System.Drawing.Point(4, 31);
            this.BtnOpenInvoice.Name = "BtnOpenInvoice";
            this.BtnOpenInvoice.Size = new System.Drawing.Size(233, 20);
            this.BtnOpenInvoice.TabIndex = 4;
            this.BtnOpenInvoice.TabStop = false;
            this.BtnOpenInvoice.Text = "2) Просмотр документов";
            this.BtnOpenInvoice.Click += new System.EventHandler(this.BtnOpenInvoice_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(4, 245);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(233, 20);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "0) Закрыть";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSinhrozization
            // 
            this.BtnSinhrozization.Location = new System.Drawing.Point(4, 219);
            this.BtnSinhrozization.Name = "BtnSinhrozization";
            this.BtnSinhrozization.Size = new System.Drawing.Size(233, 20);
            this.BtnSinhrozization.TabIndex = 6;
            this.BtnSinhrozization.TabStop = false;
            this.BtnSinhrozization.Text = "9) Синхронизация";
            this.BtnSinhrozization.Click += new System.EventHandler(this.BtnSinhrozization_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.BtnSinhrozization);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOpenInvoice);
            this.Controls.Add(this.BtnNewInvoice);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Application";
            this.Closed += new System.EventHandler(this.Form1_Closed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewInvoice;
        private System.Windows.Forms.Button BtnOpenInvoice;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSinhrozization;

    }
}

