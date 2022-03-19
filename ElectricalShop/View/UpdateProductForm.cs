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
           await _adminController.ShowAllProduct(dataGridView_AllProduct);
            var resultType = await _adminController.LoadProductType();
            comboBox_ProductType.Items.AddRange(resultType.ToArray());
            comboBox_ProductType.SelectedIndex = 0;

            var resultCategory = await _adminController.LoadProductCategory(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.Clear();
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());
        }

        private async void comboBox_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ProductCategory.Items.Clear();
            var resultCategory = await _adminController.LoadProductCategory(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());
            
        }

        private async void comboBox_ProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _adminController.ShowProductAtCategory(comboBox_ProductType.Text, comboBox_ProductCategory.Text);
        }
    }
}
