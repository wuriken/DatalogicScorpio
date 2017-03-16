namespace DatalogicScorpio.ProductsInfo
{
    partial class ProductsInfoForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtBxBarCode = new System.Windows.Forms.TextBox();
            this.LblBarCode = new System.Windows.Forms.Label();
            this.LblProdName = new System.Windows.Forms.Label();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.LblProdQuant = new System.Windows.Forms.Label();
            this.TxtBxQuant = new System.Windows.Forms.TextBox();
            this.LblWindowName = new System.Windows.Forms.Label();
            this.TxtBxPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(163, 259);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(72, 20);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtBxBarCode
            // 
            this.TxtBxBarCode.Location = new System.Drawing.Point(34, 56);
            this.TxtBxBarCode.Name = "TxtBxBarCode";
            this.TxtBxBarCode.Size = new System.Drawing.Size(150, 21);
            this.TxtBxBarCode.TabIndex = 1;
            this.TxtBxBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxBarCode_KeyPress);
            // 
            // LblBarCode
            // 
            this.LblBarCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblBarCode.Location = new System.Drawing.Point(34, 33);
            this.LblBarCode.Name = "LblBarCode";
            this.LblBarCode.Size = new System.Drawing.Size(100, 20);
            this.LblBarCode.Text = "Штрих-код:";
            // 
            // LblProdName
            // 
            this.LblProdName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblProdName.Location = new System.Drawing.Point(13, 91);
            this.LblProdName.Name = "LblProdName";
            this.LblProdName.Size = new System.Drawing.Size(100, 20);
            this.LblProdName.Text = "Номенклатура:";
            // 
            // TxtBxName
            // 
            this.TxtBxName.Enabled = false;
            this.TxtBxName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.TxtBxName.Location = new System.Drawing.Point(3, 114);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(232, 26);
            this.TxtBxName.TabIndex = 4;
            // 
            // LblProdQuant
            // 
            this.LblProdQuant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblProdQuant.Location = new System.Drawing.Point(13, 158);
            this.LblProdQuant.Name = "LblProdQuant";
            this.LblProdQuant.Size = new System.Drawing.Size(100, 20);
            this.LblProdQuant.Text = "Количество:";
            // 
            // TxtBxQuant
            // 
            this.TxtBxQuant.Enabled = false;
            this.TxtBxQuant.Location = new System.Drawing.Point(102, 157);
            this.TxtBxQuant.Name = "TxtBxQuant";
            this.TxtBxQuant.Size = new System.Drawing.Size(72, 21);
            this.TxtBxQuant.TabIndex = 6;
            // 
            // LblWindowName
            // 
            this.LblWindowName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LblWindowName.Location = new System.Drawing.Point(82, 7);
            this.LblWindowName.Name = "LblWindowName";
            this.LblWindowName.Size = new System.Drawing.Size(100, 20);
            this.LblWindowName.Text = "Информация";
            // 
            // TxtBxPrice
            // 
            this.TxtBxPrice.Enabled = false;
            this.TxtBxPrice.Location = new System.Drawing.Point(102, 190);
            this.TxtBxPrice.Name = "TxtBxPrice";
            this.TxtBxPrice.Size = new System.Drawing.Size(72, 21);
            this.TxtBxPrice.TabIndex = 11;
            // 
            // LblPrice
            // 
            this.LblPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblPrice.Location = new System.Drawing.Point(13, 191);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(100, 20);
            this.LblPrice.Text = "Цена:";
            // 
            // ProductsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.TxtBxPrice);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblWindowName);
            this.Controls.Add(this.TxtBxQuant);
            this.Controls.Add(this.LblProdQuant);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.LblProdName);
            this.Controls.Add(this.LblBarCode);
            this.Controls.Add(this.TxtBxBarCode);
            this.Controls.Add(this.BtnClose);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ProductsInfoForm";
            this.Text = "Информация";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductsInfo_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ProductsInfo_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtBxBarCode;
        private System.Windows.Forms.Label LblBarCode;
        private System.Windows.Forms.Label LblProdName;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Label LblProdQuant;
        private System.Windows.Forms.TextBox TxtBxQuant;
        private System.Windows.Forms.Label LblWindowName;
        private System.Windows.Forms.TextBox TxtBxPrice;
        private System.Windows.Forms.Label LblPrice;
    }
}