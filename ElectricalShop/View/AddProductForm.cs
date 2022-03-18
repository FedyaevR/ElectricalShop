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
using System.Drawing.Imaging;

namespace ElectricalShop.View
{
    public partial class AddProductForm : Form
    {
        Form _loginForm;
        Form _adminForm;
        AdminController _adminController = new AdminController();
        Image _productImage;
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
            var category = comboBox_ProductCategory.SelectedItem.ToString();
            var itemName = textBox_ItemName.Text;
            var itemPrice = numericUpDown_ItemPrice.Value;
            var itemColor = textBox_ItemColor.Text;
            var itemAmount = (int)numericUpDown_CountAmount.Value;
            var itemCharacteristic = textBox_ItemCharacteristic.Text;
            var itemDescription = textBox_ItemDescription.Text;
            textBox_ItemName.BackColor = Color.White;
            numericUpDown_ItemPrice.BackColor = Color.White;
            numericUpDown_CountAmount.BackColor = Color.White;
            try
            {
                if (await Task.Run(() => _adminController.AddProduct(type, category, itemName, itemPrice, itemColor, itemAmount, itemCharacteristic, itemDescription, _productImage)))
                {
                    MessageBox.Show("Продукт добавлен!");
                    comboBox_ProductType.SelectedIndex = 0;
                    comboBox_ProductCategory.SelectedIndex = 0;
                    textBox_ItemName.Text = "";
                    numericUpDown_ItemPrice.Value = 0;
                    textBox_ItemColor.Text = "";
                    numericUpDown_CountAmount.Value = 0;
                    textBox_ItemCharacteristic.Text = "";
                    textBox_ItemDescription.Text = "";
                }
                else
                {
                    MessageBox.Show("Продукт не добавлен!");
                }
            }
            catch (ArgumentException ex)
            {

                if (ex.Message == "Short product name")
                {
                    textBox_ItemName.BackColor = Color.Red;
                }
                if (ex.Message == "Price can't be negative")
                {
                    numericUpDown_ItemPrice.BackColor = Color.Red;
                }
                if (ex.Message == "Amount of product can't be less than one")
                {
                    numericUpDown_CountAmount.BackColor = Color.Red;
                }
            }
        }

        private async void AddProductForm_Load(object sender, EventArgs e)
        {
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

        private void button_AddItemPicture_Click(object sender, EventArgs e)
        {
            openFileDialog_AddImage.FileName = "";
            openFileDialog_AddImage.Filter = "jpeg|*.jpg|png|*.png|bmp|*.bmp";
            if (DialogResult.OK == openFileDialog_AddImage.ShowDialog())
            {
                _productImage = Image.FromFile(openFileDialog_AddImage.FileName);
                pictureBox_ItemPicture.Image = _productImage;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            _productImage = null;
            pictureBox_ItemPicture.Image = null;
        }
    }
}
