
namespace ElectricalShop.View
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.button_AddItemPicture = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.pictureBox_ItemPicture = new System.Windows.Forms.PictureBox();
            this.label_ItemDescription = new System.Windows.Forms.Label();
            this.label_ItemCharacteristic = new System.Windows.Forms.Label();
            this.label_CountAmount = new System.Windows.Forms.Label();
            this.label_ItemColor = new System.Windows.Forms.Label();
            this.label_ItemPrice = new System.Windows.Forms.Label();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.label_ItemCategory = new System.Windows.Forms.Label();
            this.label_ItemType = new System.Windows.Forms.Label();
            this.numericUpDown_CountAmount = new System.Windows.Forms.NumericUpDown();
            this.textBox_ItemColor = new System.Windows.Forms.TextBox();
            this.numericUpDown_ItemPrice = new System.Windows.Forms.NumericUpDown();
            this.textBox_ItemDescription = new System.Windows.Forms.TextBox();
            this.textBox_ItemCharacteristic = new System.Windows.Forms.TextBox();
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.comboBox_ProductCategory = new System.Windows.Forms.ComboBox();
            this.comboBox_ProductType = new System.Windows.Forms.ComboBox();
            this.openFileDialog_AddImage = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.button_ItemColor = new System.Windows.Forms.Button();
            this.button_AddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ItemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CountAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ItemPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddItemPicture
            // 
            this.button_AddItemPicture.Location = new System.Drawing.Point(258, 36);
            this.button_AddItemPicture.Name = "button_AddItemPicture";
            this.button_AddItemPicture.Size = new System.Drawing.Size(152, 57);
            this.button_AddItemPicture.TabIndex = 38;
            this.button_AddItemPicture.Text = "Добавить изображение";
            this.button_AddItemPicture.UseVisualStyleBackColor = true;
            this.button_AddItemPicture.Click += new System.EventHandler(this.button_AddItemPicture_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(257, 99);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(153, 57);
            this.button_Cancel.TabIndex = 37;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // pictureBox_ItemPicture
            // 
            this.pictureBox_ItemPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_ItemPicture.Location = new System.Drawing.Point(416, 36);
            this.pictureBox_ItemPicture.Name = "pictureBox_ItemPicture";
            this.pictureBox_ItemPicture.Size = new System.Drawing.Size(311, 267);
            this.pictureBox_ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ItemPicture.TabIndex = 36;
            this.pictureBox_ItemPicture.TabStop = false;
            // 
            // label_ItemDescription
            // 
            this.label_ItemDescription.AutoSize = true;
            this.label_ItemDescription.Location = new System.Drawing.Point(258, 406);
            this.label_ItemDescription.Name = "label_ItemDescription";
            this.label_ItemDescription.Size = new System.Drawing.Size(143, 17);
            this.label_ItemDescription.TabIndex = 35;
            this.label_ItemDescription.Text = "Описание продукта:";
            // 
            // label_ItemCharacteristic
            // 
            this.label_ItemCharacteristic.AutoSize = true;
            this.label_ItemCharacteristic.Location = new System.Drawing.Point(13, 406);
            this.label_ItemCharacteristic.Name = "label_ItemCharacteristic";
            this.label_ItemCharacteristic.Size = new System.Drawing.Size(185, 17);
            this.label_ItemCharacteristic.TabIndex = 34;
            this.label_ItemCharacteristic.Text = "Характеристики продукта:";
            // 
            // label_CountAmount
            // 
            this.label_CountAmount.AutoSize = true;
            this.label_CountAmount.Location = new System.Drawing.Point(13, 348);
            this.label_CountAmount.Name = "label_CountAmount";
            this.label_CountAmount.Size = new System.Drawing.Size(155, 17);
            this.label_CountAmount.TabIndex = 33;
            this.label_CountAmount.Text = "Количество продукта:";
            // 
            // label_ItemColor
            // 
            this.label_ItemColor.AutoSize = true;
            this.label_ItemColor.Location = new System.Drawing.Point(13, 289);
            this.label_ItemColor.Name = "label_ItemColor";
            this.label_ItemColor.Size = new System.Drawing.Size(110, 17);
            this.label_ItemColor.TabIndex = 32;
            this.label_ItemColor.Text = "Цвет продукта:";
            // 
            // label_ItemPrice
            // 
            this.label_ItemPrice.AutoSize = true;
            this.label_ItemPrice.Location = new System.Drawing.Point(13, 219);
            this.label_ItemPrice.Name = "label_ItemPrice";
            this.label_ItemPrice.Size = new System.Drawing.Size(161, 17);
            this.label_ItemPrice.TabIndex = 31;
            this.label_ItemPrice.Text = "Цена продукта(рубли):";
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Location = new System.Drawing.Point(13, 149);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(141, 17);
            this.label_ItemName.TabIndex = 30;
            this.label_ItemName.Text = "Название продукта:";
            // 
            // label_ItemCategory
            // 
            this.label_ItemCategory.AutoSize = true;
            this.label_ItemCategory.Location = new System.Drawing.Point(13, 78);
            this.label_ItemCategory.Name = "label_ItemCategory";
            this.label_ItemCategory.Size = new System.Drawing.Size(146, 17);
            this.label_ItemCategory.TabIndex = 29;
            this.label_ItemCategory.Text = "Категория продукта:";
            // 
            // label_ItemType
            // 
            this.label_ItemType.AutoSize = true;
            this.label_ItemType.Location = new System.Drawing.Point(13, 13);
            this.label_ItemType.Name = "label_ItemType";
            this.label_ItemType.Size = new System.Drawing.Size(102, 17);
            this.label_ItemType.TabIndex = 28;
            this.label_ItemType.Text = "Тип продукта:";
            // 
            // numericUpDown_CountAmount
            // 
            this.numericUpDown_CountAmount.Location = new System.Drawing.Point(12, 368);
            this.numericUpDown_CountAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_CountAmount.Name = "numericUpDown_CountAmount";
            this.numericUpDown_CountAmount.Size = new System.Drawing.Size(188, 22);
            this.numericUpDown_CountAmount.TabIndex = 27;
            // 
            // textBox_ItemColor
            // 
            this.textBox_ItemColor.Location = new System.Drawing.Point(12, 309);
            this.textBox_ItemColor.Name = "textBox_ItemColor";
            this.textBox_ItemColor.ReadOnly = true;
            this.textBox_ItemColor.Size = new System.Drawing.Size(127, 22);
            this.textBox_ItemColor.TabIndex = 26;
            // 
            // numericUpDown_ItemPrice
            // 
            this.numericUpDown_ItemPrice.DecimalPlaces = 2;
            this.numericUpDown_ItemPrice.Location = new System.Drawing.Point(13, 239);
            this.numericUpDown_ItemPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_ItemPrice.Name = "numericUpDown_ItemPrice";
            this.numericUpDown_ItemPrice.Size = new System.Drawing.Size(187, 22);
            this.numericUpDown_ItemPrice.TabIndex = 25;
            // 
            // textBox_ItemDescription
            // 
            this.textBox_ItemDescription.Location = new System.Drawing.Point(261, 426);
            this.textBox_ItemDescription.Multiline = true;
            this.textBox_ItemDescription.Name = "textBox_ItemDescription";
            this.textBox_ItemDescription.Size = new System.Drawing.Size(466, 210);
            this.textBox_ItemDescription.TabIndex = 24;
            // 
            // textBox_ItemCharacteristic
            // 
            this.textBox_ItemCharacteristic.Location = new System.Drawing.Point(12, 426);
            this.textBox_ItemCharacteristic.Multiline = true;
            this.textBox_ItemCharacteristic.Name = "textBox_ItemCharacteristic";
            this.textBox_ItemCharacteristic.Size = new System.Drawing.Size(223, 210);
            this.textBox_ItemCharacteristic.TabIndex = 23;
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Location = new System.Drawing.Point(12, 169);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(188, 22);
            this.textBox_ItemName.TabIndex = 22;
            // 
            // comboBox_ProductCategory
            // 
            this.comboBox_ProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductCategory.FormattingEnabled = true;
            this.comboBox_ProductCategory.Location = new System.Drawing.Point(12, 98);
            this.comboBox_ProductCategory.Name = "comboBox_ProductCategory";
            this.comboBox_ProductCategory.Size = new System.Drawing.Size(188, 24);
            this.comboBox_ProductCategory.TabIndex = 21;
            // 
            // comboBox_ProductType
            // 
            this.comboBox_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductType.FormattingEnabled = true;
            this.comboBox_ProductType.Location = new System.Drawing.Point(12, 36);
            this.comboBox_ProductType.Name = "comboBox_ProductType";
            this.comboBox_ProductType.Size = new System.Drawing.Size(188, 24);
            this.comboBox_ProductType.TabIndex = 20;
            this.comboBox_ProductType.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProductType_SelectedIndexChanged);
            // 
            // openFileDialog_AddImage
            // 
            this.openFileDialog_AddImage.FileName = "openFileDialog1";
            // 
            // button_ItemColor
            // 
            this.button_ItemColor.Location = new System.Drawing.Point(145, 309);
            this.button_ItemColor.Name = "button_ItemColor";
            this.button_ItemColor.Size = new System.Drawing.Size(55, 22);
            this.button_ItemColor.TabIndex = 39;
            this.button_ItemColor.Text = "...";
            this.button_ItemColor.UseVisualStyleBackColor = true;
            this.button_ItemColor.Click += new System.EventHandler(this.button_ItemColor_Click);
            // 
            // button_AddProduct
            // 
            this.button_AddProduct.Location = new System.Drawing.Point(531, 319);
            this.button_AddProduct.Name = "button_AddProduct";
            this.button_AddProduct.Size = new System.Drawing.Size(196, 75);
            this.button_AddProduct.TabIndex = 40;
            this.button_AddProduct.Text = "Добавить продукт";
            this.button_AddProduct.UseVisualStyleBackColor = true;
            this.button_AddProduct.Click += new System.EventHandler(this.button_AddProduct_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 648);
            this.Controls.Add(this.button_AddProduct);
            this.Controls.Add(this.button_ItemColor);
            this.Controls.Add(this.button_AddItemPicture);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.pictureBox_ItemPicture);
            this.Controls.Add(this.label_ItemDescription);
            this.Controls.Add(this.label_ItemCharacteristic);
            this.Controls.Add(this.label_CountAmount);
            this.Controls.Add(this.label_ItemColor);
            this.Controls.Add(this.label_ItemPrice);
            this.Controls.Add(this.label_ItemName);
            this.Controls.Add(this.label_ItemCategory);
            this.Controls.Add(this.label_ItemType);
            this.Controls.Add(this.numericUpDown_CountAmount);
            this.Controls.Add(this.textBox_ItemColor);
            this.Controls.Add(this.numericUpDown_ItemPrice);
            this.Controls.Add(this.textBox_ItemDescription);
            this.Controls.Add(this.textBox_ItemCharacteristic);
            this.Controls.Add(this.textBox_ItemName);
            this.Controls.Add(this.comboBox_ProductCategory);
            this.Controls.Add(this.comboBox_ProductType);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ItemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CountAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ItemPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddItemPicture;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.PictureBox pictureBox_ItemPicture;
        private System.Windows.Forms.Label label_ItemDescription;
        private System.Windows.Forms.Label label_ItemCharacteristic;
        private System.Windows.Forms.Label label_CountAmount;
        private System.Windows.Forms.Label label_ItemColor;
        private System.Windows.Forms.Label label_ItemPrice;
        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.Label label_ItemCategory;
        private System.Windows.Forms.Label label_ItemType;
        private System.Windows.Forms.NumericUpDown numericUpDown_CountAmount;
        private System.Windows.Forms.TextBox textBox_ItemColor;
        private System.Windows.Forms.NumericUpDown numericUpDown_ItemPrice;
        private System.Windows.Forms.TextBox textBox_ItemDescription;
        private System.Windows.Forms.TextBox textBox_ItemCharacteristic;
        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.ComboBox comboBox_ProductCategory;
        private System.Windows.Forms.ComboBox comboBox_ProductType;
        private System.Windows.Forms.OpenFileDialog openFileDialog_AddImage;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button button_ItemColor;
        private System.Windows.Forms.Button button_AddProduct;
    }
}