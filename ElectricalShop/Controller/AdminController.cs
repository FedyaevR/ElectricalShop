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
        /// <summary>
        /// Загрузка типов продукта.
        /// </summary>
        /// <returns>Список типов</returns>
        public async Task<List<string>> LoadProductTypeAsync()
        {
            return await _tableProduct.ShowProductTypeAsync();

        }
        /// <summary>
        /// Загрузка категорий продукта.
        /// </summary>
        /// <param name="type">Тип продукта.</param>
        /// <returns>Список категорий.</returns>
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
        public async Task<bool> AddProductAsync(string productType, string productCategory, string productName, decimal productPrice,
            string productColor, int productAmount, string productCharacteristic, string productDescription, Image productImage = null)
        {
            if (await _tableProduct.AddProductAsync(productType, productCategory, productName, productPrice, productColor, productAmount, productCharacteristic, productDescription, productImage))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Вывод всех продуктов.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns>Удалось ли вывести список продуктов.</returns>
        public async Task<bool> ShowAllProductAsync(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            _dataGridView.DataSource =  await _tableProduct.ShowAllDBAsync();
            _dataGridView.Columns.RemoveAt(9); //удаление лишнего столбца 
            return true;
        }
        /// <summary>
        /// Вывод продукта в категории.
        /// </summary>
        /// <param name="type">Тип</param>
        /// <param name="category">Категория</param>
        /// <returns>Удалось ли вывести список продуктов в категории.</returns>
        public async Task<bool> ShowProductAtCategoryAsync(string type, string category)
        {
            _dataGridView.DataSource = await _tableProduct.ShowProductAtCategoryAsync(type,category);
            _dataGridView.Columns.RemoveAt(9); //удаление лишнего столбца 
            return true;
        }
        /// <summary>
        /// Изменение данных продукта с сохранением в БД.
        /// </summary>
        /// <param name="itemId">ID товара</param>
        /// <param name="productName">Название товара</param>
        /// <param name="productPrice">Стоимость товара</param>
        /// <param name="productColor">Цвет</param>
        /// <param name="productAmount">Кол-во товара на складе</param>
        /// <param name="productCharacteristic">Характеристика товара</param>
        /// <param name="productDescription">Описание товара</param>
        /// <param name="oldImage">Прежнее изображение</param>
        /// <param name="productImage">Новое изображение(при изменении) по умолчанию = null</param>
        /// <returns>Результат обновления товара</returns>
        public async Task<bool> UpdateProductAsync(int itemId, string productName, decimal productPrice,
            string productColor, int productAmount, string productCharacteristic, string productDescription,byte[] oldImage, Image productImage = null)
        {
            if (await _tableProduct.UpdateProductAsync(itemId, productName, productPrice, productColor,
                productAmount,productCharacteristic, productDescription, oldImage, productImage))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Удаление товара из списка и БД.
        /// </summary>
        /// <param name="itemId">Id товара</param>
        /// <returns></returns>
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
