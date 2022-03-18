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
    public partial class UpdateProductForm : Form
    {
        AdminController _adminController = new AdminController();
        public UpdateProductForm(Form adminForm, Form loginForm)
        {
            InitializeComponent();
        }

        private async void UpdateProductForm_Load(object sender, EventArgs e)
        {
            await  _adminController.ShowProduct(dataGridView_AllProduct);
            
        }
    }
}
