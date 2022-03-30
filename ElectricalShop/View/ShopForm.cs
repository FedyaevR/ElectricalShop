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
        ListBox _listBoxProductAtCart = new ListBox();
        int _userId;
        public ShopForm(Form loginForm, int userId)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _userId = userId;
            this.comboBox_ProductType.SelectedIndexChanged += ComboBox_ProductType_SelectedIndexChanged1;
            this.comboBox_SortProduct.SelectedIndexChanged += ComboBox_SortProduct_SelectedIndexChanged;
            
            comboBox_ProductCategory.SelectedIndex = 0;
            comboBox_SortProduct.SelectedIndex = 0;
           
        }

        private async void ComboBox_SortProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ProductCategory.SelectedIndex <= 0) return;
            treeView.Nodes.Clear();
            switch (comboBox_SortProduct.SelectedIndex)
            {
                case 0:
                    await _shopController.ShowProductAtPriceAscendingAsync(treeView,comboBox_ProductType.SelectedItem.ToString(),comboBox_ProductCategory.SelectedItem.ToString());
                    break;
                case 1:
                    await _shopController.ShowProductAtPriceDescendingAsync(treeView, comboBox_ProductType.SelectedItem.ToString(), comboBox_ProductCategory.SelectedItem.ToString());
                    break;
                case 2:
                    await _shopController.ShowProductAtExpensivePriceAsync(treeView, comboBox_ProductType.SelectedItem.ToString(), comboBox_ProductCategory.SelectedItem.ToString());
                    break;
                case 3:
                    await _shopController.ShowProductIsNotAvailableAsync(treeView, comboBox_ProductType.SelectedItem.ToString(), comboBox_ProductCategory.SelectedItem.ToString());
                    break;
                default:
                    break;
            }
        }

        private async void ShopForm_Load(object sender, EventArgs e)
        {
            
            var resultType = await _shopController.LoadProductTypeAsync();
            comboBox_ProductType.Items.AddRange(resultType.ToArray());
            comboBox_ProductType.SelectedIndex = 0;

            var resultCategory = await _shopController.LoadProductCategoryAsync(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.Clear();
            comboBox_ProductCategory.Items.Add("Выберите категорию");
            comboBox_ProductCategory.SelectedIndex = 0;
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());
            await _shopController.ShowAllProductAsync(treeView);

        }
        private async void ComboBox_ProductType_SelectedIndexChanged1(object sender, EventArgs e)
        {
            comboBox_ProductCategory.Items.Clear();
            comboBox_ProductCategory.Items.Add("Выберите категорию");
            comboBox_ProductCategory.SelectedIndex = 0;
            var resultCategory = await _shopController.LoadProductCategoryAsync(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());
        }

        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Close();
        }

        private async void comboBox_ProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ProductCategory.SelectedIndex <= 0) return;
            treeView.Nodes.Clear();
            await _shopController.ShowProductAtCategory(treeView, comboBox_ProductType.SelectedItem.ToString(),comboBox_ProductCategory.SelectedItem.ToString());
        }

        private async void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var res =  await _shopController.ShowProductAsync(treeView.SelectedNode.Text);
            textBox_Characteristic.Text = res[0];
            textBox_Description.Text = res[1];
        }

        private void button_AddProductInBasket_Click(object sender, EventArgs e)
        {
            _listBoxProductAtCart.Items.Add(treeView.SelectedNode.Text);
        }

        private void linkLabel_Basket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerCartForm customerCartForm = new CustomerCartForm(this, _listBoxProductAtCart);
            this.Visible = false;
            customerCartForm.ShowDialog();
           
        }
    }
}
