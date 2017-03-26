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
            this.LblWindowName = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblArt = new System.Windows.Forms.Label();
            this.LblArtValue = new System.Windows.Forms.Label();
            this.LblQuantValue = new System.Windows.Forms.Label();
            this.LblPriceValue = new System.Windows.Forms.Label();
            this.ChkBxWeight = new System.Windows.Forms.CheckBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblGroup = new System.Windows.Forms.Label();
            this.LblTypeValue = new System.Windows.Forms.Label();
            this.LblGroupValue = new System.Windows.Forms.Label();
            this.LblUnit = new System.Windows.Forms.Label();
            this.LblWeightCode = new System.Windows.Forms.Label();
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
            this.TxtBxBarCode.Location = new System.Drawing.Point(5, 47);
            this.TxtBxBarCode.Name = "TxtBxBarCode";
            this.TxtBxBarCode.Size = new System.Drawing.Size(150, 21);
            this.TxtBxBarCode.TabIndex = 0;
            this.TxtBxBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxBarCode_KeyPress);
            // 
            // LblBarCode
            // 
            this.LblBarCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblBarCode.Location = new System.Drawing.Point(13, 27);
            this.LblBarCode.Name = "LblBarCode";
            this.LblBarCode.Size = new System.Drawing.Size(100, 20);
            this.LblBarCode.Text = "Штрих-код:";
            // 
            // LblProdName
            // 
            this.LblProdName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblProdName.Location = new System.Drawing.Point(13, 74);
            this.LblProdName.Name = "LblProdName";
            this.LblProdName.Size = new System.Drawing.Size(107, 20);
            this.LblProdName.Text = "Наименование:";
            // 
            // TxtBxName
            // 
            this.TxtBxName.Enabled = false;
            this.TxtBxName.Location = new System.Drawing.Point(5, 92);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(232, 21);
            this.TxtBxName.TabIndex = 4;
            // 
            // LblProdQuant
            // 
            this.LblProdQuant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblProdQuant.Location = new System.Drawing.Point(5, 223);
            this.LblProdQuant.Name = "LblProdQuant";
            this.LblProdQuant.Size = new System.Drawing.Size(100, 20);
            this.LblProdQuant.Text = "Количество:";
            // 
            // LblWindowName
            // 
            this.LblWindowName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LblWindowName.Location = new System.Drawing.Point(72, 7);
            this.LblWindowName.Name = "LblWindowName";
            this.LblWindowName.Size = new System.Drawing.Size(134, 20);
            this.LblWindowName.Text = "Номенклатура";
            // 
            // LblPrice
            // 
            this.LblPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblPrice.Location = new System.Drawing.Point(5, 249);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(100, 20);
            this.LblPrice.Text = "Цена:";
            // 
            // LblArt
            // 
            this.LblArt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblArt.Location = new System.Drawing.Point(165, 27);
            this.LblArt.Name = "LblArt";
            this.LblArt.Size = new System.Drawing.Size(72, 20);
            this.LblArt.Text = "Артикул:";
            // 
            // LblArtValue
            // 
            this.LblArtValue.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.LblArtValue.Location = new System.Drawing.Point(168, 47);
            this.LblArtValue.Name = "LblArtValue";
            this.LblArtValue.Size = new System.Drawing.Size(72, 20);
            this.LblArtValue.Text = "_____";
            // 
            // LblQuantValue
            // 
            this.LblQuantValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblQuantValue.Location = new System.Drawing.Point(93, 223);
            this.LblQuantValue.Name = "LblQuantValue";
            this.LblQuantValue.Size = new System.Drawing.Size(44, 20);
            this.LblQuantValue.Text = "___";
            // 
            // LblPriceValue
            // 
            this.LblPriceValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblPriceValue.Location = new System.Drawing.Point(93, 249);
            this.LblPriceValue.Name = "LblPriceValue";
            this.LblPriceValue.Size = new System.Drawing.Size(53, 20);
            this.LblPriceValue.Text = "___";
            // 
            // ChkBxWeight
            // 
            this.ChkBxWeight.Enabled = false;
            this.ChkBxWeight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ChkBxWeight.Location = new System.Drawing.Point(5, 119);
            this.ChkBxWeight.Name = "ChkBxWeight";
            this.ChkBxWeight.Size = new System.Drawing.Size(100, 20);
            this.ChkBxWeight.TabIndex = 21;
            this.ChkBxWeight.Text = "Весовой";
            // 
            // LblType
            // 
            this.LblType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblType.Location = new System.Drawing.Point(5, 158);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(100, 20);
            this.LblType.Text = "Вид товара:";
            // 
            // LblGroup
            // 
            this.LblGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblGroup.Location = new System.Drawing.Point(5, 182);
            this.LblGroup.Name = "LblGroup";
            this.LblGroup.Size = new System.Drawing.Size(100, 20);
            this.LblGroup.Text = "Группа:";
            // 
            // LblTypeValue
            // 
            this.LblTypeValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblTypeValue.Location = new System.Drawing.Point(93, 157);
            this.LblTypeValue.Name = "LblTypeValue";
            this.LblTypeValue.Size = new System.Drawing.Size(100, 20);
            this.LblTypeValue.Text = "___";
            // 
            // LblGroupValue
            // 
            this.LblGroupValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LblGroupValue.Location = new System.Drawing.Point(93, 181);
            this.LblGroupValue.Name = "LblGroupValue";
            this.LblGroupValue.Size = new System.Drawing.Size(100, 20);
            this.LblGroupValue.Text = "___";
            // 
            // LblUnit
            // 
            this.LblUnit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.LblUnit.Location = new System.Drawing.Point(111, 119);
            this.LblUnit.Name = "LblUnit";
            this.LblUnit.Size = new System.Drawing.Size(43, 20);
            // 
            // LblWeightCode
            // 
            this.LblWeightCode.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.LblWeightCode.Location = new System.Drawing.Point(160, 119);
            this.LblWeightCode.Name = "LblWeightCode";
            this.LblWeightCode.Size = new System.Drawing.Size(74, 20);
            // 
            // ProductsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.LblWeightCode);
            this.Controls.Add(this.LblUnit);
            this.Controls.Add(this.LblGroupValue);
            this.Controls.Add(this.LblTypeValue);
            this.Controls.Add(this.LblGroup);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.ChkBxWeight);
            this.Controls.Add(this.LblPriceValue);
            this.Controls.Add(this.LblQuantValue);
            this.Controls.Add(this.LblArtValue);
            this.Controls.Add(this.LblArt);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblWindowName);
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
        private System.Windows.Forms.Label LblWindowName;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblArt;
        private System.Windows.Forms.Label LblArtValue;
        private System.Windows.Forms.Label LblQuantValue;
        private System.Windows.Forms.Label LblPriceValue;
        private System.Windows.Forms.CheckBox ChkBxWeight;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblGroup;
        private System.Windows.Forms.Label LblTypeValue;
        private System.Windows.Forms.Label LblGroupValue;
        private System.Windows.Forms.Label LblUnit;
        private System.Windows.Forms.Label LblWeightCode;
    }
}