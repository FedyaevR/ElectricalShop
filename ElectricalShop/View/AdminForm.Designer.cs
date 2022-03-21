
namespace ElectricalShop.View
{
    partial class AdminForm
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
            this.button_AddProduct = new System.Windows.Forms.Button();
            this.button_UpdateProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_AddProduct
            // 
            this.button_AddProduct.Location = new System.Drawing.Point(12, 57);
            this.button_AddProduct.Name = "button_AddProduct";
            this.button_AddProduct.Size = new System.Drawing.Size(277, 69);
            this.button_AddProduct.TabIndex = 0;
            this.button_AddProduct.Text = "Добавить продукт";
            this.button_AddProduct.UseVisualStyleBackColor = true;
            this.button_AddProduct.Click += new System.EventHandler(this.button_AddProduct_Click);
            // 
            // button_UpdateProduct
            // 
            this.button_UpdateProduct.Location = new System.Drawing.Point(12, 188);
            this.button_UpdateProduct.Name = "button_UpdateProduct";
            this.button_UpdateProduct.Size = new System.Drawing.Size(277, 69);
            this.button_UpdateProduct.TabIndex = 2;
            this.button_UpdateProduct.Text = "Редактировать продукт";
            this.button_UpdateProduct.UseVisualStyleBackColor = true;
            this.button_UpdateProduct.Click += new System.EventHandler(this.button_UpdateProduct_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 321);
            this.Controls.Add(this.button_UpdateProduct);
            this.Controls.Add(this.button_AddProduct);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddProduct;
        private System.Windows.Forms.Button button_UpdateProduct;
    }
}