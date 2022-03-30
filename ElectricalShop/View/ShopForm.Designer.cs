
namespace ElectricalShop.View
{
    partial class ShopForm
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
            this.comboBox_SortProduct = new System.Windows.Forms.ComboBox();
            this.comboBox_ProductCategory = new System.Windows.Forms.ComboBox();
            this.comboBox_ProductType = new System.Windows.Forms.ComboBox();
            this.button_AddProductInBasket = new System.Windows.Forms.Button();
            this.linkLabel_Basket = new System.Windows.Forms.LinkLabel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.textBox_Characteristic = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_SortProduct
            // 
            this.comboBox_SortProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SortProduct.FormattingEnabled = true;
            this.comboBox_SortProduct.Items.AddRange(new object[] {
            "Сортировать по цене(по возрастанию)",
            "Сортировать по цене(по убыванию)",
            "Top 10 дорогих товаров",
            "Нет на складе"});
            this.comboBox_SortProduct.Location = new System.Drawing.Point(380, 30);
            this.comboBox_SortProduct.Name = "comboBox_SortProduct";
            this.comboBox_SortProduct.Size = new System.Drawing.Size(387, 24);
            this.comboBox_SortProduct.TabIndex = 1;
            // 
            // comboBox_ProductCategory
            // 
            this.comboBox_ProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductCategory.FormattingEnabled = true;
            this.comboBox_ProductCategory.Items.AddRange(new object[] {
            "Выберите категорию"});
            this.comboBox_ProductCategory.Location = new System.Drawing.Point(199, 30);
            this.comboBox_ProductCategory.Name = "comboBox_ProductCategory";
            this.comboBox_ProductCategory.Size = new System.Drawing.Size(175, 24);
            this.comboBox_ProductCategory.TabIndex = 3;
            this.comboBox_ProductCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProductCategory_SelectedIndexChanged);
            // 
            // comboBox_ProductType
            // 
            this.comboBox_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductType.FormattingEnabled = true;
            this.comboBox_ProductType.Location = new System.Drawing.Point(18, 30);
            this.comboBox_ProductType.Name = "comboBox_ProductType";
            this.comboBox_ProductType.Size = new System.Drawing.Size(175, 24);
            this.comboBox_ProductType.TabIndex = 4;
            // 
            // button_AddProductInBasket
            // 
            this.button_AddProductInBasket.Location = new System.Drawing.Point(890, 30);
            this.button_AddProductInBasket.Name = "button_AddProductInBasket";
            this.button_AddProductInBasket.Size = new System.Drawing.Size(199, 24);
            this.button_AddProductInBasket.TabIndex = 5;
            this.button_AddProductInBasket.Text = "Добавить в корзину";
            this.button_AddProductInBasket.UseVisualStyleBackColor = true;
            this.button_AddProductInBasket.Click += new System.EventHandler(this.button_AddProductInBasket_Click);
            // 
            // linkLabel_Basket
            // 
            this.linkLabel_Basket.AutoSize = true;
            this.linkLabel_Basket.Location = new System.Drawing.Point(782, 34);
            this.linkLabel_Basket.Name = "linkLabel_Basket";
            this.linkLabel_Basket.Size = new System.Drawing.Size(102, 17);
            this.linkLabel_Basket.TabIndex = 6;
            this.linkLabel_Basket.TabStop = true;
            this.linkLabel_Basket.Text = "Ваша корзина";
            this.linkLabel_Basket.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Basket_LinkClicked);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(18, 61);
            this.treeView.Name = "treeView";
            this.treeView.ShowRootLines = false;
            this.treeView.Size = new System.Drawing.Size(591, 549);
            this.treeView.TabIndex = 7;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // textBox_Characteristic
            // 
            this.textBox_Characteristic.Location = new System.Drawing.Point(615, 61);
            this.textBox_Characteristic.Multiline = true;
            this.textBox_Characteristic.Name = "textBox_Characteristic";
            this.textBox_Characteristic.Size = new System.Drawing.Size(474, 252);
            this.textBox_Characteristic.TabIndex = 8;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(616, 319);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(474, 291);
            this.textBox_Description.TabIndex = 9;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 622);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_Characteristic);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.linkLabel_Basket);
            this.Controls.Add(this.button_AddProductInBasket);
            this.Controls.Add(this.comboBox_ProductType);
            this.Controls.Add(this.comboBox_ProductCategory);
            this.Controls.Add(this.comboBox_SortProduct);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShopForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_SortProduct;
        private System.Windows.Forms.ComboBox comboBox_ProductCategory;
        private System.Windows.Forms.ComboBox comboBox_ProductType;
        private System.Windows.Forms.Button button_AddProductInBasket;
        private System.Windows.Forms.LinkLabel linkLabel_Basket;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox textBox_Characteristic;
        private System.Windows.Forms.TextBox textBox_Description;
    }
}