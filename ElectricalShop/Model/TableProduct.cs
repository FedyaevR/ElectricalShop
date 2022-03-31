using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalShop.Model
{
    class TableProduct
    {
        /// <summary>
        /// Вывод типов продукта
        /// </summary>
        /// <returns>Список типов продукта</returns>
        public async Task<List<string>> ShowProductTypeAsync()
        {
            using (Product_DB db = new Product_DB())
            {
                return await Task.Run(() => (from row in db.ProductType
                                                        select row.Type).ToList<string>());
            }
        }
        /// <summary>
        /// Вывод категорий продукта
        /// </summary>
        /// <returns>Список категорий продукта</returns>
        public async Task<List<string>> ShowProductCategoryAsync(string type)
        {
            using (Product_DB db = new Product_DB())
            {
                return await Task.Run(() => (from category in db.ProductCategory
                                             where category.Id == db.ProductType.FirstOrDefault(i => i.Type.ToString() == type).Id
                                             select category.Category).ToList<string>());
            }
        }
        /// <summary>
        /// Метод добавления продукта в БД.
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

            CheckInputData(productName, productPrice, productAmount);

            using (Product_DB db = new Product_DB())
            {
                //Проверка уникален ли товар.
                var uniqueProduct = await Task.Run(() => db.ProductItem.FirstOrDefault(i => i.ItemName == productName));
                if (uniqueProduct != null)
                {
                    return false;
                }
                var productCategoryId = db.ProductCategory.FirstOrDefault(i => i.Category == productCategory).Id;
                byte[] image = { 1,2,3};
               
                if (productImage != null)
                {
                    ImageConverter(ref image, productImage);
                }
                await Task.Run(() => db.ProductItem.Add(new ProductItem() {ItemName = productName, ItemPrice = productPrice, ItemColor = productColor,
                ItemAmount = productAmount, ItemCharacteristics = productCharacteristic, ItemDescription = productDescription, ItemImage = image, CategoryId = productCategoryId}));
                var count = await db.SaveChangesAsync();
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// Проверка входящих параметров.
        /// </summary>
        /// <param name="productName">Название продукта</param>
        /// <param name="productPrice">Стоимость</param>
        /// <param name="productAmount">Кол-во товара</param>
        private void CheckInputData(string productName, decimal productPrice, int productAmount)
        {
            if (productName.Length < 3)
            {
                throw new ArgumentException("Short product name");
            }
            if (productPrice < 0)
            {
                throw new ArgumentException("Price can't be negative");
            }
            if (productAmount < 1)
            {
                throw new ArgumentException("Amount of product can't be less than one");
            }
        }
        /// <summary>
        /// Метод конвертации изображения в byte[]
        /// </summary>
        /// <param name="image"></param>
        /// <param name="productImage">Изображение на конвертацию</param>
        private void ImageConverter(ref byte[] image, Image productImage)
        {
           
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            if (productImage.RawFormat.Equals(ImageFormat.Jpeg))
            {
                productImage.Save(memoryStream, ImageFormat.Jpeg);
                image = memoryStream.ToArray();
            }
            else if (productImage.RawFormat.Equals(ImageFormat.Png))
            {
                productImage.Save(memoryStream, ImageFormat.Png);
                image = memoryStream.ToArray();
            }
            else if (productImage.RawFormat.Equals(ImageFormat.Bmp))
            {
                productImage.Save(memoryStream, ImageFormat.Bmp);
                image = memoryStream.ToArray();
            }
        
        }
        /// <summary>
        /// Вывод всех продуктов.
        /// </summary>
        /// <returns>Список продуктов</returns>
        public async Task<List<ProductItem>> ShowAllDBAsync()
        {
            using (Product_DB db = new Product_DB())
            {
                return await Task.Run(() => db.ProductItem.ToList());
            }
        }
        /// <summary>
        /// Вывод продуктов в категории.
        /// </summary>
        /// <param name="type">Тип товара</param>
        /// <param name="category">Категория товара</param>
        /// <returns>Список продуктов.</returns>
        public async Task<List<ProductItem>> ShowProductAtCategoryAsync(string type, string category)
        {
            using (Product_DB db = new Product_DB())
            {
                return await Task.Run(() => (from item in db.ProductItem
                       where item.ProductCategory.ProductType.Type == type && item.ProductCategory.Category == category
                       select item).ToList<ProductItem>());
            }
        }
        /// <summary>
        /// Обновление данных продукта
        /// </summary>
        /// <param name="itemId">ID продукта</param>
        /// <param name="productName">Название</param>
        /// <param name="productPrice">Стоимость</param>
        /// <param name="productColor">Цвет</param>
        /// <param name="productAmount">Кол-во товара на складе</param>
        /// <param name="productCharacteristic">Характеристика</param>
        /// <param name="productDescription">Описание товара</param>
        /// <param name="oldImage">Прежние изображение</param>
        /// <param name="productImage">Новое изображение. По умолчанию null</param>
        /// <returns>Результат добавление</returns>
        public async Task<bool> UpdateProductAsync(int itemId ,string productName, decimal productPrice,
            string productColor, int productAmount, string productCharacteristic, string productDescription,byte[] oldImage ,Image productImage = null)
        {
            CheckInputData(productName, productPrice, productAmount);
            using (Product_DB db = new Product_DB())
            {
                //Проверка уникален ли товар.
                var uniqueProduct = await Task.Run(() => db.ProductItem.FirstOrDefault(i => i.ItemName == productName));
                if (uniqueProduct != null)
                {
                    return false;
                }
                var product = await Task.Run(() => db.ProductItem.FirstOrDefault(i => i.ItemId == itemId));
                if (oldImage != null)
                {
                    byte[] image = { 1, 2, 3 };
                    if (productImage != null)
                    {
                        ImageConverter(ref image, productImage);
                        oldImage = image;
                    }
                   
                }
                product.ItemName = product.ItemName;
                product.ItemPrice = productPrice;
                product.ItemDescription = productDescription;
                product.ItemAmount = productAmount;
                product.ItemColor = productColor;
                product.ItemCharacteristics = productCharacteristic;
                product.ItemImage = oldImage;

                int count = await db.SaveChangesAsync();
                if (count > 0 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
           
        }
        /// <summary>
        /// Метод удаления продукта.
        /// </summary>
        /// <param name="itemId">ID продукта в БД</param>
        /// <returns>Результат удаления</returns>
        public async Task<bool> DeleteProductAsync(int itemId)
        {
            using (Product_DB db = new Product_DB())
            {
                await Task.Run(()=>db.ProductItem.Remove(db.ProductItem.FirstOrDefault(p => p.ItemId == itemId)));
                int count = await db.SaveChangesAsync();
                if (count>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// Вывод продукта по запросу: цена по возрастанию
        /// </summary>
        /// <param name="type">Тип продукта</param>
        /// <param name="category">Категория продукта</param>
        /// <returns>Список продуктов</returns>
        public async Task<List<ProductItem>> ShowProductAtPriceAscendingAsync(string type, string category)
        {
            
            using (Product_DB db = new Product_DB())
            {
                var res =  await Task.Run(() => (from item in db.ProductItem
                                             where item.ProductCategory.ProductType.Type == type && item.ProductCategory.Category == category
                                             select item).ToList<ProductItem>());
              return await Task.Run(()=> res.OrderBy(i=> i.ItemPrice).ToList<ProductItem>());
            }
        }
        /// <summary>
        /// Вывод продукта по запросу: цена по убыванию
        /// </summary>
        /// <param name="type">Тип продукта</param>
        /// <param name="category">Категория продукта</param>
        /// <returns>Список продуктов</returns>
        public async Task<List<ProductItem>> ShowProductAtPriceDescendingAsync(string type, string category)
        {
            using (Product_DB db = new Product_DB())
            {
                var res = await Task.Run(() => (from item in db.ProductItem
                                                where item.ProductCategory.ProductType.Type == type && item.ProductCategory.Category == category
                                                select item).ToList<ProductItem>());
                return await Task.Run(() => res.OrderByDescending(i => i.ItemPrice).ToList<ProductItem>());
            }
        }
        /// <summary>
        /// Вывод продукта по запросу: топ 10 дорогих товаров в категории.
        /// </summary>
        /// <param name="type">Тип продукта</param>
        /// <param name="category">Категория продукта</param>
        /// <returns>Список продуктов</returns>
        public async Task<List<ProductItem>> ShowProductAtExpensivePriceAsync(string type, string category)
        {
            
            using (Product_DB db = new Product_DB())
            {
                var listProduct = await Task.Run(() => (from item in db.ProductItem
                                                where item.ProductCategory.ProductType.Type == type && item.ProductCategory.Category == category
                                                select item).ToList<ProductItem>());
                var res =  await Task.Run(() => listProduct.OrderByDescending(i => i.ItemPrice).ToList<ProductItem>());
                if (res.Count > 10)
                {
                    res.RemoveRange(10, res.Count);
                }
                return res;
            }
        }
        /// <summary>
        /// Вывод продукта по запросу: нет товара на складе
        /// </summary>
        /// <param name="type">Тип продукта</param>
        /// <param name="category">Категория продукта</param>
        /// <returns>Список продуктов</returns>
        public async Task<List<ProductItem>> ShowProductIsNotAvailableAsync(string type, string category)
        {
            using (Product_DB db = new Product_DB())
            {
                return await Task.Run(() => (from item in db.ProductItem
                                                        where item.ProductCategory.ProductType.Type == type && item.ProductCategory.Category == category && item.ItemAmount <= 0
                                                        select item).ToList<ProductItem>());
            }
        }
        /// <summary>
        /// Вывод уникального продукта
        /// </summary>
        /// <param name="productName">Название продукта</param>
        /// <returns>Уникальный продукт</returns>
        public async Task<ProductItem> ShowProductAsync(string productName)
        {
            using (Product_DB db = new Product_DB())
            {
                return await Task.Run(() => db.ProductItem.FirstOrDefault(i => productName.Contains(i.ItemName)));
            }
        }
        /// <summary>
        /// Асинхронный метод покупки товара
        /// </summary>
        /// <param name="productName">название товара</param>
        /// <param name="amount">Кол-во товара на покупку.</param>
        /// <returns>Успешна ли покупка</returns>
        public async Task<bool> BuyProductAsync(string productName, int amount)
        {
            using (Product_DB db = new Product_DB())
            {
                var res = await Task.Run(() => db.ProductItem.FirstOrDefault(i => productName.Contains(i.ItemName)));
                if (res.ItemAmount < amount)
                {
                    throw new ArgumentException("This quantity is not in stock");
                }
                else
                {
                   await Task.Run(()=> db.ProductItem.FirstOrDefault(i => productName.Contains(i.ItemName)).ItemAmount -= amount);
                }
                var count = await db.SaveChangesAsync();
                if (count > 0)
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
}
