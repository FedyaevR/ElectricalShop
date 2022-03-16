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
    public partial class AddProductForm : Form
    {
        Form _loginForm;
        Form _adminForm;
        AdminController _adminController = new AdminController();
        public AddProductForm(Form loginForm, Form adminForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _adminForm = adminForm;
          
        }

        private void button_ItemColor_Click(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                textBox_ItemColor.Text = colorDialog.Color.Name;
            }
        }

        private async void button_AddProduct_Click(object sender, EventArgs e)
        {
            var type = comboBox_ProductType.SelectedItem.ToString();
            var category = comboBox_ProductCategory.SelectedIndex.ToString();
            var itemName = textBox_ItemName.Text;
            var itemPrice = numericUpDown_ItemPrice.Value;
            var itemColor = textBox_ItemColor.Text;
            var itemAmount = (int)numericUpDown_CountAmount.Value;
            var itemCharacteristic = textBox_ItemCharacteristic.Text;
            var itemDescription = textBox_ItemDescription.Text;
            await  Task.Run(()=>_adminController.AddProduct(type, category,itemName,itemPrice,itemColor,itemAmount,itemCharacteristic, itemDescription));
        }

        private async void AddProductForm_Load(object sender, EventArgs e)
        {
            var resultType = await _adminController.LoadProductType();
            comboBox_ProductType.Items.AddRange(resultType.ToArray());
            comboBox_ProductType.SelectedIndex = 0;
            var resultCategory = await _adminController.LoadProductCategory(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());
        }

        private async void comboBox_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ProductCategory.Items.Clear();
            var resultCategory = await _adminController.LoadProductCategory(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());
        }
    }
}
