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
        public CustomerCartForm(Form shopForm, ListBox listBoxProductAtCart)
        {
            InitializeComponent();
            _shopForm = shopForm;
            _listBoxProductAtCart = listBoxProductAtCart;
            foreach (var item in listBoxProductAtCart.Items)
            {
                listBox.Items.Add(item);
            }
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
            try
            {
                if (await _cartController.BuyProduct(listBox.Items[listBox.SelectedIndex].ToString(), (int)numericUpDown_Amount.Value))
                {
                    MessageBox.Show("Товар куплен!");
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
    }
}
