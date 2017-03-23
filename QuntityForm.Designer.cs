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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuntityForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.TxtBxQuant = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblGoodName = new System.Windows.Forms.Label();
            this.LblBarCode = new System.Windows.Forms.Label();
            this.InptPanelQuantityForm = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.TxtBxGoodName = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblWindowName = new System.Windows.Forms.Label();
            this.TxtBxPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblQuant = new System.Windows.Forms.Label();
            this.CmbBxType = new System.Windows.Forms.ComboBox();
            this.CmbBxGroup = new System.Windows.Forms.ComboBox();
            this.ChkBxIsWeight = new System.Windows.Forms.CheckBox();
            this.CmbBxUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtBxQuant
            // 
            resources.ApplyResources(this.TxtBxQuant, "TxtBxQuant");
            this.TxtBxQuant.Name = "TxtBxQuant";
            this.TxtBxQuant.TextChanged += new System.EventHandler(this.TxtBxQuant_TextChanged);
            this.TxtBxQuant.GotFocus += new System.EventHandler(this.TxtBxQuant_GotFocus);
            this.TxtBxQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxQuant_KeyPress);
            this.TxtBxQuant.LostFocus += new System.EventHandler(this.TxtBxQuant_LostFocus);
            // 
            // BtnOk
            // 
            resources.ApplyResources(this.BtnOk, "BtnOk");
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblGoodName
            // 
            resources.ApplyResources(this.LblGoodName, "LblGoodName");
            this.LblGoodName.Name = "LblGoodName";
            // 
            // LblBarCode
            // 
            resources.ApplyResources(this.LblBarCode, "LblBarCode");
            this.LblBarCode.Name = "LblBarCode";
            // 
            // TxtBxGoodName
            // 
            resources.ApplyResources(this.TxtBxGoodName, "TxtBxGoodName");
            this.TxtBxGoodName.Name = "TxtBxGoodName";
            this.TxtBxGoodName.GotFocus += new System.EventHandler(this.TxtBxGoodName_GotFocus);
            this.TxtBxGoodName.LostFocus += new System.EventHandler(this.TxtBxGoodName_LostFocus);
            // 
            // BtnCancel
            // 
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblWindowName
            // 
            resources.ApplyResources(this.LblWindowName, "LblWindowName");
            this.LblWindowName.Name = "LblWindowName";
            // 
            // TxtBxPrice
            // 
            resources.ApplyResources(this.TxtBxPrice, "TxtBxPrice");
            this.TxtBxPrice.Name = "TxtBxPrice";
            this.TxtBxPrice.TextChanged += new System.EventHandler(this.TxtBxPrice_TextChanged);
            this.TxtBxPrice.GotFocus += new System.EventHandler(this.TxtBxPrice_GotFocus);
            this.TxtBxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxPrice_KeyPress);
            this.TxtBxPrice.LostFocus += new System.EventHandler(this.TxtBxPrice_LostFocus);
            // 
            // LblPrice
            // 
            resources.ApplyResources(this.LblPrice, "LblPrice");
            this.LblPrice.Name = "LblPrice";
            // 
            // LblQuant
            // 
            resources.ApplyResources(this.LblQuant, "LblQuant");
            this.LblQuant.Name = "LblQuant";
            // 
            // CmbBxType
            // 
            resources.ApplyResources(this.CmbBxType, "CmbBxType");
            this.CmbBxType.Name = "CmbBxType";
            // 
            // CmbBxGroup
            // 
            resources.ApplyResources(this.CmbBxGroup, "CmbBxGroup");
            this.CmbBxGroup.Name = "CmbBxGroup";
            // 
            // ChkBxIsWeight
            // 
            resources.ApplyResources(this.ChkBxIsWeight, "ChkBxIsWeight");
            this.ChkBxIsWeight.Name = "ChkBxIsWeight";
            // 
            // CmbBxUnit
            // 
            resources.ApplyResources(this.CmbBxUnit, "CmbBxUnit");
            this.CmbBxUnit.Name = "CmbBxUnit";
            // 
            // QuntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.CmbBxUnit);
            this.Controls.Add(this.ChkBxIsWeight);
            this.Controls.Add(this.CmbBxGroup);
            this.Controls.Add(this.CmbBxType);
            this.Controls.Add(this.LblQuant);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TxtBxPrice);
            this.Controls.Add(this.LblWindowName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtBxGoodName);
            this.Controls.Add(this.LblBarCode);
            this.Controls.Add(this.LblGoodName);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtBxQuant);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "QuntityForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblWindowName;
        private System.Windows.Forms.TextBox TxtBxPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblQuant;
        private System.Windows.Forms.ComboBox CmbBxType;
        private System.Windows.Forms.ComboBox CmbBxGroup;
        private System.Windows.Forms.CheckBox ChkBxIsWeight;
        private System.Windows.Forms.ComboBox CmbBxUnit;
    }
}