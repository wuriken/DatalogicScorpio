namespace DatalogicScorpio
{
    partial class QuntityForm
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
            this.TxtBxQuant = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblGoodName = new System.Windows.Forms.Label();
            this.LblBarCode = new System.Windows.Forms.Label();
            this.InptPanelQuantityForm = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.TxtBxGoodName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtBxQuant
            // 
            this.TxtBxQuant.Location = new System.Drawing.Point(167, 42);
            this.TxtBxQuant.Name = "TxtBxQuant";
            this.TxtBxQuant.Size = new System.Drawing.Size(66, 21);
            this.TxtBxQuant.TabIndex = 0;
            this.TxtBxQuant.TextChanged += new System.EventHandler(this.TxtBxQuant_TextChanged);
            this.TxtBxQuant.GotFocus += new System.EventHandler(this.TxtBxQuant_GotFocus);
            this.TxtBxQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxQuant_KeyPress);
            this.TxtBxQuant.LostFocus += new System.EventHandler(this.TxtBxQuant_LostFocus);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(83, 77);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(72, 20);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblGoodName
            // 
            this.LblGoodName.Location = new System.Drawing.Point(3, 10);
            this.LblGoodName.Name = "LblGoodName";
            this.LblGoodName.Size = new System.Drawing.Size(100, 20);
            this.LblGoodName.Text = "Товар:";
            // 
            // LblBarCode
            // 
            this.LblBarCode.Location = new System.Drawing.Point(110, 10);
            this.LblBarCode.Name = "LblBarCode";
            this.LblBarCode.Size = new System.Drawing.Size(100, 20);
            // 
            // TxtBxGoodName
            // 
            this.TxtBxGoodName.Location = new System.Drawing.Point(4, 41);
            this.TxtBxGoodName.Name = "TxtBxGoodName";
            this.TxtBxGoodName.Size = new System.Drawing.Size(151, 21);
            this.TxtBxGoodName.TabIndex = 2;
            this.TxtBxGoodName.GotFocus += new System.EventHandler(this.TxtBxGoodName_GotFocus);
            this.TxtBxGoodName.LostFocus += new System.EventHandler(this.TxtBxGoodName_LostFocus);
            // 
            // QuntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(236, 111);
            this.Controls.Add(this.TxtBxGoodName);
            this.Controls.Add(this.LblBarCode);
            this.Controls.Add(this.LblGoodName);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtBxQuant);
            this.Menu = this.mainMenu1;
            this.Name = "QuntityForm";
            this.Text = "Введите кол-во:";
            this.Load += new System.EventHandler(this.QuntityForm_Load);
            this.Closed += new System.EventHandler(this.QuntityForm_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxQuant;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblGoodName;
        private System.Windows.Forms.Label LblBarCode;
        private Microsoft.WindowsCE.Forms.InputPanel InptPanelQuantityForm;
        private System.Windows.Forms.TextBox TxtBxGoodName;
    }
}