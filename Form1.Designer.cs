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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.BtnNewInvoice = new System.Windows.Forms.Button();
            this.BtnOpenInvoice = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSinhrozization = new System.Windows.Forms.Button();
            this.BtnResidues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNewInvoice
            // 
            resources.ApplyResources(this.BtnNewInvoice, "BtnNewInvoice");
            this.BtnNewInvoice.Name = "BtnNewInvoice";
            this.BtnNewInvoice.TabStop = false;
            this.BtnNewInvoice.Click += new System.EventHandler(this.BtnNewInvoice_Click);
            // 
            // BtnOpenInvoice
            // 
            resources.ApplyResources(this.BtnOpenInvoice, "BtnOpenInvoice");
            this.BtnOpenInvoice.Name = "BtnOpenInvoice";
            this.BtnOpenInvoice.TabStop = false;
            this.BtnOpenInvoice.Click += new System.EventHandler(this.BtnOpenInvoice_Click);
            // 
            // BtnClose
            // 
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSinhrozization
            // 
            resources.ApplyResources(this.BtnSinhrozization, "BtnSinhrozization");
            this.BtnSinhrozization.Name = "BtnSinhrozization";
            this.BtnSinhrozization.TabStop = false;
            this.BtnSinhrozization.Click += new System.EventHandler(this.BtnSinhrozization_Click);
            // 
            // BtnResidues
            // 
            resources.ApplyResources(this.BtnResidues, "BtnResidues");
            this.BtnResidues.Name = "BtnResidues";
            this.BtnResidues.TabStop = false;
            this.BtnResidues.Click += new System.EventHandler(this.BtnResidues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.BtnResidues);
            this.Controls.Add(this.BtnSinhrozization);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOpenInvoice);
            this.Controls.Add(this.BtnNewInvoice);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closed += new System.EventHandler(this.Form1_Closed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewInvoice;
        private System.Windows.Forms.Button BtnOpenInvoice;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSinhrozization;
        private System.Windows.Forms.Button BtnResidues;

    }
}

