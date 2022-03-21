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
        Image _productImage;

        public UpdateProductForm(Form adminForm, Form loginForm)
        {
            InitializeComponent();
            dataGridView_AllProduct.CellClick += DataGridView_AllProduct_CellClick;
            dataGridView_AllProduct.CellValueChanged += DataGridView_AllProduct_CellValueChanged;
        }

        private async void DataGridView_AllProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var res = dataGridView_AllProduct.Rows[dataGridView_AllProduct.SelectedCells[0].RowIndex];
            await _adminController.UpdateProduct((int)res.Cells[1].Value, res.Cells[2].Value.ToString(), (decimal)res.Cells[3].Value,
            res.Cells[7].Value.ToString(), (int)res.Cells[8].Value, res.Cells[5].Value.ToString(), res.Cells[6].Value.ToString(), (byte[])res.Cells[4].Value,_productImage);
            
        }

        private void DataGridView_AllProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] byteArray = { };
            if (dataGridView_AllProduct.SelectedCells[0].ValueType == byteArray.GetType())
            {
                openFileDialog_UpdateImage.FileName = "";
                openFileDialog_UpdateImage.Filter = "jpeg|*.jpeg|png|*.png|bmp|*.bmp";
                if (DialogResult.OK == openFileDialog_UpdateImage.ShowDialog())
                {
                    _productImage = Image.FromFile(openFileDialog_UpdateImage.FileName);
                }
            }
         
        }

        private async void UpdateProductForm_Load(object sender, EventArgs e)
        {
            await _adminController.ShowAllProduct(dataGridView_AllProduct);
            var resultType = await _adminController.LoadProductTypeAsync();
            comboBox_ProductType.Items.AddRange(resultType.ToArray());
            comboBox_ProductType.SelectedIndex = 0;

            var resultCategory = await _adminController.LoadProductCategoryAsync(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.Clear();
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());
        }

        private async void comboBox_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ProductCategory.Items.Clear();
            var resultCategory = await _adminController.LoadProductCategoryAsync(comboBox_ProductType.SelectedItem.ToString());
            comboBox_ProductCategory.Items.AddRange(resultCategory.ToArray());
            
        }

        private async void comboBox_ProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _adminController.ShowProductAtCategory(comboBox_ProductType.Text, comboBox_ProductCategory.Text);
        }

        private async void button_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView_AllProduct.SelectedCells.Count > 0)
            {
                var res = dataGridView_AllProduct.Rows[dataGridView_AllProduct.SelectedCells[0].RowIndex];
                if (MessageBox.Show($"Вы уверены, что хотите удалить данный товар: {res.Cells[2].Value}", "Удалить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await _adminController.DeleteProductAsync((int)res.Cells[1].Value);
                    await _adminController.ShowAllProduct(dataGridView_AllProduct);
                }
            }
      
        }
    }
}
