namespace DatalogicScorpio
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
            this.SuspendLayout();
            // 
            // TxtBxBarCode
            // 
            this.TxtBxBarCode.Enabled = false;
            this.TxtBxBarCode.Location = new System.Drawing.Point(4, 29);
            this.TxtBxBarCode.Name = "TxtBxBarCode";
            this.TxtBxBarCode.Size = new System.Drawing.Size(136, 21);
            this.TxtBxBarCode.TabIndex = 0;
            // 
            // TrwViewInvoice
            // 
            this.TrwViewInvoice.Location = new System.Drawing.Point(4, 84);
            this.TrwViewInvoice.Name = "TrwViewInvoice";
            this.TrwViewInvoice.Size = new System.Drawing.Size(223, 154);
            this.TrwViewInvoice.TabIndex = 2;
            this.TrwViewInvoice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrwViewInvoice_AfterSelect);
            // 
            // TxtBxQuant
            // 
            this.TxtBxQuant.Enabled = false;
            this.TxtBxQuant.Location = new System.Drawing.Point(146, 29);
            this.TxtBxQuant.Name = "TxtBxQuant";
            this.TxtBxQuant.Size = new System.Drawing.Size(80, 21);
            this.TxtBxQuant.TabIndex = 3;
            // 
            // BtnInvoiceSave
            // 
            this.BtnInvoiceSave.Location = new System.Drawing.Point(136, 244);
            this.BtnInvoiceSave.Name = "BtnInvoiceSave";
            this.BtnInvoiceSave.Size = new System.Drawing.Size(91, 20);
            this.BtnInvoiceSave.TabIndex = 4;
            this.BtnInvoiceSave.Text = "Сохранить";
            this.BtnInvoiceSave.Click += new System.EventHandler(this.BtnInvoiceSave_Click);
            // 
            // LblDocName
            // 
            this.LblDocName.Location = new System.Drawing.Point(4, 4);
            this.LblDocName.Name = "LblDocName";
            this.LblDocName.Size = new System.Drawing.Size(98, 20);
            this.LblDocName.Text = "Имя документа:";
            // 
            // TxtBxDocName
            // 
            this.TxtBxDocName.Location = new System.Drawing.Point(109, 4);
            this.TxtBxDocName.Name = "TxtBxDocName";
            this.TxtBxDocName.Size = new System.Drawing.Size(118, 21);
            this.TxtBxDocName.TabIndex = 6;
            this.TxtBxDocName.GotFocus += new System.EventHandler(this.TxtBxDocName_GotFocus);
            this.TxtBxDocName.LostFocus += new System.EventHandler(this.TxtBxDocName_LostFocus);
            // 
            // TxtBxGoodName
            // 
            this.TxtBxGoodName.Location = new System.Drawing.Point(4, 57);
            this.TxtBxGoodName.Name = "TxtBxGoodName";
            this.TxtBxGoodName.Size = new System.Drawing.Size(223, 21);
            this.TxtBxGoodName.TabIndex = 7;
            this.TxtBxGoodName.GotFocus += new System.EventHandler(this.TxtBxGoodName_GotFocus);
            this.TxtBxGoodName.LostFocus += new System.EventHandler(this.TxtBxGoodName_LostFocus);
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TxtBxGoodName);
            this.Controls.Add(this.TxtBxDocName);
            this.Controls.Add(this.LblDocName);
            this.Controls.Add(this.BtnInvoiceSave);
            this.Controls.Add(this.TxtBxQuant);
            this.Controls.Add(this.TrwViewInvoice);
            this.Controls.Add(this.TxtBxBarCode);
            this.Menu = this.mainMenu1;
            this.Name = "NewInvoiceForm";
            this.Text = "Новый документ";
            this.Load += new System.EventHandler(this.NewInvoiceForm_Load);
            this.Closed += new System.EventHandler(this.NewInvoiceForm_Closed);
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
    }
}