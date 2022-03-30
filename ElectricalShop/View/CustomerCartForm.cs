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
    public partial class CustomerCartForm : Form
    {
        Form _shopForm;
        CartController _cartController = new CartController();
        ListBox _listBoxProductAtCart;
        int[] _amountProduct;
        public CustomerCartForm(Form shopForm, ListBox listBoxProductAtCart)
        {
            InitializeComponent();
            _shopForm = shopForm;
            _listBoxProductAtCart = listBoxProductAtCart;
            if (_listBoxProductAtCart.Items.Count > -1)
            {
                _amountProduct = new int[_listBoxProductAtCart.Items.Count];
                for (int i = 0; i < _amountProduct.Count(); i++)
                {
                    _amountProduct[i] = 1;
                }
            }
            int amountCounter = 0;
            foreach (var item in listBoxProductAtCart.Items)
            {
                
                listBox.Items.Add(item + $". В корзине: {_amountProduct[amountCounter]} товар(а)");
                amountCounter++;
            }
            listBox.HorizontalScrollbar = true;
            numericUpDown_Amount.ReadOnly = true;
            
        }
        private void CustomerCartForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            _shopForm.Visible = true;
        }

        private void button_CancelProduct_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                _listBoxProductAtCart.Items.RemoveAt(listBox.SelectedIndex);
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }

        private async void button_Buy_Click(object sender, EventArgs e)
        {
            List<bool> buyResult = new List<bool>();
            try
            {
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    buyResult.Add(await _cartController.BuyProduct(listBox.Items[i].ToString(), _amountProduct[i]));
                }
                if(buyResult.All(i=> i == true))
                {
                    MessageBox.Show("Товар(ы) куплен!");
                }
            }
            catch (ArgumentException ex)
            {
                if (ex.Message == "This quantity is not in stock")
                {
                    MessageBox.Show("Товара недостаточно на складе");
                }
            }
        }
        private void numericUpDown_Amount_ValueChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                numericUpDown_Amount.Value = 1;
                return;
            }
            
            var selectedItem = listBox.SelectedItem;
            var selectedindex = listBox.SelectedIndex;
            listBox.Items.Clear();
            int amountCounter = 0;
            foreach (var item in _listBoxProductAtCart.Items)
            {
                if (selectedItem.ToString().Contains(item.ToString()) == true)
                {
                    _amountProduct[selectedindex] = (int)numericUpDown_Amount.Value;
                    listBox.Items.Add(item + $". В корзине: {_amountProduct[selectedindex]} товар(а)");
                }
                else
                {
                   
                    listBox.Items.Add(item + $". В корзине: {_amountProduct[amountCounter]} товар(а)");
                }
                amountCounter++;
            }
        
        }
    }
}
