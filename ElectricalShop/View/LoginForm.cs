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
        UserController _userController = new UserController();
        int _userId;
        public LoginForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Переход в форму регистрации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            RegisterForm registerForm = new RegisterForm(this);
            registerForm.ShowDialog();
          
        }
        /// <summary>
        /// Вход в приложение как пользователь.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_Enter_Click(object sender, EventArgs e)
        {
            textBox_Login.BackColor = Color.White;
            maskedTextBox_Password.BackColor = Color.White;
           
            try
            {
                
                if (await _userController.EnterAsync(textBox_Login.Text, maskedTextBox_Password.Text) == "Пользователь")
                {
                    this.Visible = false;
                    _userId = await _userController.GetUserId(textBox_Login.Text, maskedTextBox_Password.Text);
                    ShopForm _shopForm = new ShopForm(this, _userId);
                    _shopForm.ShowDialog();
                }
            }
            catch (ArgumentException ex)
            {

                if (ex.Message == "Wrong login or password")
                {
                    textBox_Login.BackColor = Color.Red;
                    maskedTextBox_Password.BackColor = Color.Red;
                    
                }
                if (ex.Message == "This login doesn't exist")
                {
                    textBox_Login.BackColor = Color.Red;
                }
            }
           
           
        }
        /// <summary>
        /// Вход в приложение как администратор.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void linkLabel_AdminLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_Login.BackColor = Color.White;
            maskedTextBox_Password.BackColor = Color.White;
           
            
            if (await _userController.EnterAsync(textBox_Login.Text, maskedTextBox_Password.Text, true) == "Администратор")
            {
                this.Visible = false;
                AdminForm adminForm = new AdminForm(this);
                adminForm.ShowDialog();
            }
            else
            {
                
                textBox_Login.BackColor = Color.Red;
                maskedTextBox_Password.BackColor = Color.Red;
            }

        }
    }
}
