using System;
using System.Collections.Generic;
using System.Drawing;
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
        public async void AddProduct(string productType, string productCategory, string productName, decimal productPrice,
            string productColor, int productAmount, string productCharacteristic, string productDescription, Image image = null)
        {

        }
    }
}
