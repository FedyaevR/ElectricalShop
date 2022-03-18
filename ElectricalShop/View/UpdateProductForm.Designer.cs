
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
            this.button_UpdateData = new System.Windows.Forms.Button();
            this.button_CancelUpdate = new System.Windows.Forms.Button();
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
            // button_UpdateData
            // 
            this.button_UpdateData.Location = new System.Drawing.Point(516, 24);
            this.button_UpdateData.Name = "button_UpdateData";
            this.button_UpdateData.Size = new System.Drawing.Size(179, 36);
            this.button_UpdateData.TabIndex = 1;
            this.button_UpdateData.Text = "Сохранить изменения";
            this.button_UpdateData.UseVisualStyleBackColor = true;
            // 
            // button_CancelUpdate
            // 
            this.button_CancelUpdate.Location = new System.Drawing.Point(701, 24);
            this.button_CancelUpdate.Name = "button_CancelUpdate";
            this.button_CancelUpdate.Size = new System.Drawing.Size(179, 36);
            this.button_CancelUpdate.TabIndex = 2;
            this.button_CancelUpdate.Text = "Отмена";
            this.button_CancelUpdate.UseVisualStyleBackColor = true;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 597);
            this.Controls.Add(this.button_CancelUpdate);
            this.Controls.Add(this.button_UpdateData);
            this.Controls.Add(this.dataGridView_AllProduct);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProductForm";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_AllProduct;
        private System.Windows.Forms.Button button_UpdateData;
        private System.Windows.Forms.Button button_CancelUpdate;
    }
}