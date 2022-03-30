
namespace ElectricalShop.View
{
    partial class CustomerCartForm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.button_CancelProduct = new System.Windows.Forms.Button();
            this.button_Buy = new System.Windows.Forms.Button();
            this.numericUpDown_Amount = new System.Windows.Forms.NumericUpDown();
            this.label_Amount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(535, 260);
            this.listBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(553, 180);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Итого:";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(609, 180);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(0, 17);
            this.label_Total.TabIndex = 2;
            // 
            // button_CancelProduct
            // 
            this.button_CancelProduct.Location = new System.Drawing.Point(556, 12);
            this.button_CancelProduct.Name = "button_CancelProduct";
            this.button_CancelProduct.Size = new System.Drawing.Size(142, 52);
            this.button_CancelProduct.TabIndex = 3;
            this.button_CancelProduct.Text = "Убрать из списка";
            this.button_CancelProduct.UseVisualStyleBackColor = true;
            this.button_CancelProduct.Click += new System.EventHandler(this.button_CancelProduct_Click);
            // 
            // button_Buy
            // 
            this.button_Buy.Location = new System.Drawing.Point(556, 220);
            this.button_Buy.Name = "button_Buy";
            this.button_Buy.Size = new System.Drawing.Size(142, 52);
            this.button_Buy.TabIndex = 4;
            this.button_Buy.Text = "Оплатить";
            this.button_Buy.UseVisualStyleBackColor = true;
            this.button_Buy.Click += new System.EventHandler(this.button_Buy_Click);
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.Location = new System.Drawing.Point(556, 124);
            this.numericUpDown_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.Size = new System.Drawing.Size(142, 22);
            this.numericUpDown_Amount.TabIndex = 5;
            this.numericUpDown_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Amount.ValueChanged += new System.EventHandler(this.numericUpDown_Amount_ValueChanged);
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(556, 101);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(107, 17);
            this.label_Amount.TabIndex = 6;
            this.label_Amount.Text = "Кол-во товара:";
            // 
            // CustomerCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 292);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.numericUpDown_Amount);
            this.Controls.Add(this.button_Buy);
            this.Controls.Add(this.button_CancelProduct);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label);
            this.Controls.Add(this.listBox);
            this.Name = "CustomerCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerCart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerCartForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_CancelProduct;
        private System.Windows.Forms.Button button_Buy;
        private System.Windows.Forms.NumericUpDown numericUpDown_Amount;
        private System.Windows.Forms.Label label_Amount;
    }
}