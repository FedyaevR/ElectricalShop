using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalShop.View
{
    public partial class AdminForm : Form
    {
        Form _loginForm;
        public AdminForm(Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
            AddProductForm addProductForm = new AddProductForm(this, _loginForm);
            addProductForm.ShowDialog();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Visible = true;
        }

        private void button_DeleteProduct_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DeleteProductForm deleteProductForm = new DeleteProductForm(this,_loginForm);
            deleteProductForm.ShowDialog();
        }

        private void button_UpdateProduct_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateProductForm updateProductForm = new UpdateProductForm(this, _loginForm);
            updateProductForm.ShowDialog();
        }


    }
}
