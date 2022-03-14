using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricalShop.Controller;
using System.Windows.Forms;

namespace ElectricalShop.View
{
    public partial class RegisterForm : Form
    {
        Form _loginForm;
        public RegisterForm(Form _loginForm)
        {
            InitializeComponent();
            comboBox_UserCategory.SelectedIndex = 0;
            this._loginForm = _loginForm;
        }

        private async void button_Register_Click(object sender, EventArgs e)
        {
            button_Register.Enabled = false;
            UserController _userController = new UserController();
            textBox_Login.BackColor = Color.White;
            textBox_Password.BackColor = Color.White;
            textBox_FirstName.BackColor = Color.White;
            textBox_LastName.BackColor = Color.White;
            try
            {
              
                if (await _userController.AddUser(textBox_FirstName.Text, textBox_LastName.Text, (int)numericUpDown_Age.Value,
                    comboBox_UserCategory.SelectedItem.ToString(), textBox_Login.Text, textBox_Password.Text))
                {
                    
                    MessageBox.Show("Добавлен!");
                    this.Close();
                }
            }
            catch (ArgumentException ex)
            {
                if (ex.Message == "Short login or password")
                {
                    textBox_Login.BackColor = Color.Red;
                    textBox_Password.BackColor = Color.Red;
                }
                if (ex.Message == "Short FirstName or LastName")
                {
                    textBox_FirstName.BackColor = Color.Red;
                    textBox_LastName.BackColor = Color.Red;
                }
                if (ex.Message == "Login is already used")
                {
                    textBox_Login.Text = "Логин уже используется";
                    textBox_Login.BackColor = Color.Red;
                }

            }
            button_Register.Enabled = true;
            textBox_Login.Text = "";
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Visible = true;
        }
    }
}
