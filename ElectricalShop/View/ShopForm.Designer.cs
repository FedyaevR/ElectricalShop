
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
            this.listView = new System.Windows.Forms.ListView();
            this.comboBox_SortProduct = new System.Windows.Forms.ComboBox();
            this.textBox_SearchProduct = new System.Windows.Forms.TextBox();
            this.comboBox_ProductCategory = new System.Windows.Forms.ComboBox();
            this.comboBox_ProductType = new System.Windows.Forms.ComboBox();
            this.button_AddProductInBasket = new System.Windows.Forms.Button();
            this.linkLabel_Basket = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(13, 60);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1077, 550);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // comboBox_SortProduct
            // 
            this.comboBox_SortProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SortProduct.FormattingEnabled = true;
            this.comboBox_SortProduct.Location = new System.Drawing.Point(380, 30);
            this.comboBox_SortProduct.Name = "comboBox_SortProduct";
            this.comboBox_SortProduct.Size = new System.Drawing.Size(229, 24);
            this.comboBox_SortProduct.TabIndex = 1;
            // 
            // textBox_SearchProduct
            // 
            this.textBox_SearchProduct.Location = new System.Drawing.Point(615, 32);
            this.textBox_SearchProduct.Name = "textBox_SearchProduct";
            this.textBox_SearchProduct.Size = new System.Drawing.Size(270, 22);
            this.textBox_SearchProduct.TabIndex = 2;
            // 
            // comboBox_ProductCategory
            // 
            this.comboBox_ProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductCategory.FormattingEnabled = true;
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
            this.button_AddProductInBasket.Location = new System.Drawing.Point(891, 30);
            this.button_AddProductInBasket.Name = "button_AddProductInBasket";
            this.button_AddProductInBasket.Size = new System.Drawing.Size(199, 23);
            this.button_AddProductInBasket.TabIndex = 5;
            this.button_AddProductInBasket.Text = "Добавить в корзину";
            this.button_AddProductInBasket.UseVisualStyleBackColor = true;
            // 
            // linkLabel_Basket
            // 
            this.linkLabel_Basket.AutoSize = true;
            this.linkLabel_Basket.Location = new System.Drawing.Point(988, 9);
            this.linkLabel_Basket.Name = "linkLabel_Basket";
            this.linkLabel_Basket.Size = new System.Drawing.Size(102, 17);
            this.linkLabel_Basket.TabIndex = 6;
            this.linkLabel_Basket.TabStop = true;
            this.linkLabel_Basket.Text = "Ваша корзина";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 622);
            this.Controls.Add(this.linkLabel_Basket);
            this.Controls.Add(this.button_AddProductInBasket);
            this.Controls.Add(this.comboBox_ProductType);
            this.Controls.Add(this.comboBox_ProductCategory);
            this.Controls.Add(this.textBox_SearchProduct);
            this.Controls.Add(this.comboBox_SortProduct);
            this.Controls.Add(this.listView);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShopForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox comboBox_SortProduct;
        private System.Windows.Forms.TextBox textBox_SearchProduct;
        private System.Windows.Forms.ComboBox comboBox_ProductCategory;
        private System.Windows.Forms.ComboBox comboBox_ProductType;
        private System.Windows.Forms.Button button_AddProductInBasket;
        private System.Windows.Forms.LinkLabel linkLabel_Basket;
    }
}