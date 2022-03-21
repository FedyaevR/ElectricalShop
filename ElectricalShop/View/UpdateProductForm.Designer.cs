
namespace ElectricalShop.View
{
    partial class UpdateProductForm
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
            this.dataGridView_AllProduct = new System.Windows.Forms.DataGridView();
            this.comboBox_ProductType = new System.Windows.Forms.ComboBox();
            this.comboBox_ProductCategory = new System.Windows.Forms.ComboBox();
            this.openFileDialog_UpdateImage = new System.Windows.Forms.OpenFileDialog();
            this.button_DeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_AllProduct
            // 
            this.dataGridView_AllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllProduct.Location = new System.Drawing.Point(13, 66);
            this.dataGridView_AllProduct.Name = "dataGridView_AllProduct";
            this.dataGridView_AllProduct.RowHeadersWidth = 51;
            this.dataGridView_AllProduct.RowTemplate.Height = 24;
            this.dataGridView_AllProduct.Size = new System.Drawing.Size(867, 519);
            this.dataGridView_AllProduct.TabIndex = 0;
            // 
            // comboBox_ProductType
            // 
            this.comboBox_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductType.FormattingEnabled = true;
            this.comboBox_ProductType.Location = new System.Drawing.Point(13, 36);
            this.comboBox_ProductType.Name = "comboBox_ProductType";
            this.comboBox_ProductType.Size = new System.Drawing.Size(172, 24);
            this.comboBox_ProductType.TabIndex = 3;
            this.comboBox_ProductType.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProductType_SelectedIndexChanged);
            // 
            // comboBox_ProductCategory
            // 
            this.comboBox_ProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductCategory.FormattingEnabled = true;
            this.comboBox_ProductCategory.Location = new System.Drawing.Point(191, 36);
            this.comboBox_ProductCategory.Name = "comboBox_ProductCategory";
            this.comboBox_ProductCategory.Size = new System.Drawing.Size(172, 24);
            this.comboBox_ProductCategory.TabIndex = 4;
            this.comboBox_ProductCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProductCategory_SelectedIndexChanged);
            // 
            // openFileDialog_UpdateImage
            // 
            this.openFileDialog_UpdateImage.FileName = "openFileDialog1";
            // 
            // button_DeleteProduct
            // 
            this.button_DeleteProduct.Location = new System.Drawing.Point(709, 36);
            this.button_DeleteProduct.Name = "button_DeleteProduct";
            this.button_DeleteProduct.Size = new System.Drawing.Size(171, 24);
            this.button_DeleteProduct.TabIndex = 5;
            this.button_DeleteProduct.Text = "Удалить продукт";
            this.button_DeleteProduct.UseVisualStyleBackColor = true;
            this.button_DeleteProduct.Click += new System.EventHandler(this.button_DeleteProduct_Click);
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 597);
            this.Controls.Add(this.button_DeleteProduct);
            this.Controls.Add(this.comboBox_ProductCategory);
            this.Controls.Add(this.comboBox_ProductType);
            this.Controls.Add(this.dataGridView_AllProduct);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProductForm";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_AllProduct;
        private System.Windows.Forms.ComboBox comboBox_ProductType;
        private System.Windows.Forms.ComboBox comboBox_ProductCategory;
        private System.Windows.Forms.OpenFileDialog openFileDialog_UpdateImage;
        private System.Windows.Forms.Button button_DeleteProduct;
    }
}