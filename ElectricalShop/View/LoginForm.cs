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
    public partial class LoginForm : Form
    {
        UserController _userController = new UserController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            RegisterForm _registerForm = new RegisterForm(this);
            _registerForm.ShowDialog();
          
        }

        private async void button_Enter_Click(object sender, EventArgs e)
        {
        
            this.Visible = false;
            if (await _userController.Enter(textBox_Login.Text, textBox_Password.Text) == "Пользователь")
            {
                ShopForm _shopForm = new ShopForm(this);
                _shopForm.ShowDialog();
            }
        }

        private async void linkLabel_AdminLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            try
            {
                if (await _userController.Enter(textBox_Login.Text, textBox_Password.Text, true) == "Администратор")
                {
                    AdminForm _adminForm = new AdminForm(this);
                    _adminForm.ShowDialog();
                }
                else
                {
                    ShopForm _shopForm = new ShopForm(this);
                    _shopForm.ShowDialog();
                }
            }
            catch (ArgumentException ex)
            {
                if (ex.Message == "Wrong login or password")
                {
                    MessageBox.Show("Неврный логин или пароль для администратора");
                }
            }
        }
    }
}
