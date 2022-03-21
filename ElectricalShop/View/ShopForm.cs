using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectricalShop.Controller;
namespace ElectricalShop.View
{
    public partial class ShopForm : Form
    {
        Form _loginForm;
        ShopController _shopController = new ShopController();
        public ShopForm(Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
           
        }

        private async void ShopForm_Load(object sender, EventArgs e)
        {
            var resultType = await _shopController.LoadProductTypeAsync();
            comboBox_ProductType.Items.AddRange(resultType.ToArray());
            comboBox_ProductType.SelectedIndex = 0;

            var resultCategory = await _shopController.LoadProductCategoryAsync(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.Clear();
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());

            await _shopController.ShowAllProductAsync(listView);
        }
        private async void ComboBox_ProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ProductCategory.Items.Clear();
            var resultCategory = await _shopController.LoadProductCategoryAsync(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());
        }
    }
}
