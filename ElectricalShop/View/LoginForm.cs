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
using ElectricalShop.Model;

namespace ElectricalShop.View
{
    public partial class LoginForm : Form
    {
        TableProduct tableProduct = new TableProduct();
        UserController _userController = new UserController();
        int _userId;
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
            RegisterForm registerForm = new RegisterForm(this);
            registerForm.ShowDialog();
          
        }

        private async void button_Enter_Click(object sender, EventArgs e)
        {
            //await tableProduct.ShowProduct(1, 1);
            this.Visible = false;
            if (await _userController.Enter(textBox_Login.Text, textBox_Password.Text) == "Пользователь")
            {
                _userId = await _userController.GetUserId(textBox_Login.Text, textBox_Password.Text);
                ShopForm _shopForm = new ShopForm(this,_userId);
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
                    AdminForm adminForm = new AdminForm(this);
                    adminForm.ShowDialog();
                }
                else
                {
                    ShopForm shopForm = new ShopForm(this,_userId);
                    shopForm.ShowDialog();
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
