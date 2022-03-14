using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalShop.Model
{
    class TableProduct
    {
       
        public async Task<List<ProductItem>> ShowProduct(int _category, int _type)
        {
            using (Product_DB db = new Product_DB())
            {
                var Type = db.ProductType.Find(_type);
                var Category = db.ProductCategory.Find(_category);
                var list = db.ProductItem.Where(i => i.ProductCategory.ProductType.Id == _type && i.ProductCategory.CategoryId == _category);
                foreach (var item in list)
                {
                    MessageBox.Show(item.ItemName + Environment.NewLine);
                }
                return list as List<ProductItem>;
            }
           
        }
    }
}
