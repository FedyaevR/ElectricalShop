using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task<bool> AddProduct(string productType, string productCategory, string productName, decimal productPrice,
            string productColor, int productAmount, string productCharacteristic, string productDescription, Image productImage = null)
        {
            if (await Task.Run(() => _tableProduct.AddProduct(productType, productCategory, productName, productPrice, productColor, productAmount, productCharacteristic, productDescription, productImage)))
            {
                return true;
            }
            return false;
        }
    }
}
