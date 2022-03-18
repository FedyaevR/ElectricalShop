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
        public async Task<List<string>> LoadProductType()
        {
            return await _tableProduct.ShowProductType();

        }
        public async Task<List<string>> LoadProductCategory(string type)
        {
            return await _tableProduct.ShowProductCategory(type);
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

        public async Task<bool> ShowProduct(DataGridView dataGridView)
        {

          
            dataGridView.DataSource =  await _tableProduct.ShowDB();
            dataGridView.Columns.RemoveAt(5);
          
           
           
            return true;
        }
    }
}
