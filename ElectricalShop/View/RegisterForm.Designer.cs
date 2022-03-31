
namespace ElectricalShop.View
{
    partial class RegisterForm
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
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.numericUpDown_Age = new System.Windows.Forms.NumericUpDown();
            this.label_Age = new System.Windows.Forms.Label();
            this.comboBox_UserCategory = new System.Windows.Forms.ComboBox();
            this.button_Register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Age)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(104, 32);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(174, 22);
            this.textBox_FirstName.TabIndex = 0;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(103, 82);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(174, 22);
            this.textBox_LastName.TabIndex = 1;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(103, 128);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(174, 22);
            this.textBox_Login.TabIndex = 2;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(11, 32);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(39, 17);
            this.label_FirstName.TabIndex = 3;
            this.label_FirstName.Text = "Имя:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(11, 85);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(74, 17);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "Фамилия:";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(11, 128);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(51, 17);
            this.label_Login.TabIndex = 5;
            this.label_Login.Text = "Логин:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(103, 166);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(174, 22);
            this.textBox_Password.TabIndex = 6;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(11, 169);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(61, 17);
            this.label_Password.TabIndex = 7;
            this.label_Password.Text = "Пароль:";
            // 
            // numericUpDown_Age
            // 
            this.numericUpDown_Age.Location = new System.Drawing.Point(372, 32);
            this.numericUpDown_Age.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Age.Name = "numericUpDown_Age";
            this.numericUpDown_Age.Size = new System.Drawing.Size(94, 22);
            this.numericUpDown_Age.TabIndex = 8;
            this.numericUpDown_Age.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Location = new System.Drawing.Point(300, 35);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(66, 17);
            this.label_Age.TabIndex = 9;
            this.label_Age.Text = "Возраст:";
            // 
            // comboBox_UserCategory
            // 
            this.comboBox_UserCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "Покупатель",
            "Администратор"});
            this.comboBox_UserCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UserCategory.FormattingEnabled = true;
            this.comboBox_UserCategory.Items.AddRange(new object[] {
            "Пользователь",
            "Администратор"});
            this.comboBox_UserCategory.Location = new System.Drawing.Point(303, 80);
            this.comboBox_UserCategory.Name = "comboBox_UserCategory";
            this.comboBox_UserCategory.Size = new System.Drawing.Size(163, 24);
            this.comboBox_UserCategory.TabIndex = 10;
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(104, 231);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(262, 44);
            this.button_Register.TabIndex = 11;
            this.button_Register.Text = "Зарегистрироваться";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 304);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.comboBox_UserCategory);
            this.Controls.Add(this.label_Age);
            this.Controls.Add(this.numericUpDown_Age);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.NumericUpDown numericUpDown_Age;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.ComboBox comboBox_UserCategory;
        private System.Windows.Forms.Button button_Register;
    }
}