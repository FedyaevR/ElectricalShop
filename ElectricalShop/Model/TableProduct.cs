using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalShop.Model
{
    class TableProduct
    {
       
        public async Task<List<ProductItem>> ShowProduct(int category, int type)
        {
            using (Product_DB db = new Product_DB())
            {
                var Type = await db.ProductType.FindAsync(type);
                var Category = await db.ProductCategory.FindAsync(category);
                var list = await Task.Run(()=>db.ProductItem.Where(i => i.ProductCategory.ProductType.Id == type && i.ProductCategory.CategoryId == category));
                foreach (var item in list)
                {
                    await Task.Run(() => MessageBox.Show(item.ItemName + Environment.NewLine));
                }
                return list as List<ProductItem>;
            }
        }
        public async Task<List<string>> ShowProductType()
        {
            using (Product_DB db = new Product_DB())
            {
                return await Task.Run(() => (from row in db.ProductType
                                                        select row.Type).ToList<string>());
            }
        }
        public async Task<List<string>> ShowProductCategory(string type)
        {
            using (Product_DB db = new Product_DB())
            {
                return await Task.Run(() => (from category in db.ProductCategory
                                             where category.Id == db.ProductType.FirstOrDefault(i => i.Type.ToString() == type).Id
                                             select category.Category).ToList<string>());
            }
        }
        public async Task<bool> AddProduct(string productType, string productCategory, string productName, decimal productPrice,
            string productColor, int productAmount, string productCharacteristic, string productDescription, Image productImage = null)
        {
            
            if (productName.Length < 3 )
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
            
            using (Product_DB db = new Product_DB())
            {
                var productCategoryId = db.ProductCategory.FirstOrDefault(i => i.Category == productCategory).Id;
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                byte[] image = { 1,2,3};
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
    }
}
