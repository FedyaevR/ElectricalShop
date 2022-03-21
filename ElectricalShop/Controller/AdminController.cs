using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectricalShop.Model;

namespace ElectricalShop.Controller
{
    class AdminController
    {
        TableProduct _tableProduct = new TableProduct();
        DataGridView _dataGridView;
        public async Task<List<string>> LoadProductTypeAsync()
        {
            return await _tableProduct.ShowProductTypeAsync();

        }
        public async Task<List<string>> LoadProductCategoryAsync(string type)
        {
            return await _tableProduct.ShowProductCategoryAsync(type);
        }
        /// <summary>
        /// Метод обращается к методу класса TableProduct для добавления продукта в БД.
        /// </summary>
        /// <param name="productType">Тип продукта.</param>
        /// <param name="productCategory">Категория продукта.</param>
        /// <param name="productName">Имя продукта.</param>
        /// <param name="productPrice">Стоимость продукта.</param>
        /// <param name="productColor">Цвет продукта.</param>
        /// <param name="productAmount">Количество продукта в наличии.</param>
        /// <param name="productCharacteristic">Хар-ки продукта.</param>
        /// <param name="productDescription">Описание продукта.</param>
        /// <param name="productImage">Изображение продукта.(Может отсутсвовать)</param>
        /// <returns>Метод возвращет true в случае успешного добавления продукта, false в случае если продукт в БД не добавлен.</returns>
        public async Task<bool> AddProduct(string productType, string productCategory, string productName, decimal productPrice,
            string productColor, int productAmount, string productCharacteristic, string productDescription, Image productImage = null)
        {
            if (await _tableProduct.AddProduct(productType, productCategory, productName, productPrice, productColor, productAmount, productCharacteristic, productDescription, productImage))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> ShowAllProduct(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            _dataGridView.DataSource =  await _tableProduct.ShowAllDB();
            _dataGridView.Columns.RemoveAt(9);
            return true;
        }
        public async Task<bool> ShowProductAtCategory(string type, string category)
        {
            _dataGridView.DataSource = await _tableProduct.ShowProductAtCategory(type,category);
            _dataGridView.Columns.RemoveAt(9);
            return true;
        }
        public async Task<bool> UpdateProduct(int itemId, string productName, decimal productPrice,
            string productColor, int productAmount, string productCharacteristic, string productDescription,byte[] oldImage, Image productImage = null)
        {
            if (await _tableProduct.UpdateProduct(itemId, productName, productPrice, productColor,
                productAmount,productCharacteristic, productDescription, oldImage, productImage))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> DeleteProductAsync(int itemId)
        {
            if (await _tableProduct.DeleteProductAsync(itemId) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
