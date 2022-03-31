using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricalShop.Model;
using System.Windows.Forms;
using System.Drawing;

namespace ElectricalShop.Controller
{
    class ShopController
    {
        TableProduct _tableProduct = new TableProduct();

        public async Task<List<string>> LoadProductTypeAsync()
        {
            return await _tableProduct.ShowProductTypeAsync();
        }
        public async Task<List<string>> LoadProductCategoryAsync(string type)
        {
            return await _tableProduct.ShowProductCategoryAsync(type);
        }
        /// <summary>
        /// Вывод всех товаров
        /// </summary>
        /// <param name="treeView"></param>
        /// <returns></returns>
        public  async Task<bool> ShowAllProductAsync( TreeView treeView)
        {
            var productItems =  await _tableProduct.ShowAllDBAsync();
           
            treeView.ImageList = await ImageListCreateAsync(productItems);

            for (int i = 0; i < productItems.Count; i++)
            {
                string text = (productItems[i].ItemName + " " + Math.Round(productItems[i].ItemPrice.Value, 2) + " р. Кол-во на складе:" + productItems[i].ItemAmount).ToString();
                TreeNode treeNode = new TreeNode(text, i,i);
                treeView.Nodes.Add(treeNode);
            }
            return true;

        }

        private async Task<ImageList> ImageListCreateAsync(List<ProductItem> productItems)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(80, 80);
            var imageByte = await Task.Run(() => (from image in productItems
                                                  select image.ItemImage).ToList());

            foreach (var item in imageByte)
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(item);
                Bitmap image = await Task.Run(() => (Bitmap)Image.FromStream(memoryStream));
                await Task.Run(() => imageList.Images.Add(image));
            }
            return imageList;
        }
        public async Task<bool> ShowProductAtCategoryAsync(TreeView treeView,string type,string category)
        {
            var productItems = await _tableProduct.ShowProductAtCategoryAsync(type,category);
            
            treeView.ImageList = await ImageListCreateAsync(productItems);

            for (int i = 0; i < productItems.Count; i++)
            {
                string text = (productItems[i].ItemName + " " + Math.Round(productItems[i].ItemPrice.Value,2) + " р. Кол-во на складе:" + productItems[i].ItemAmount).ToString();
                TreeNode treeNode = new TreeNode(text, i, i);
                treeView.Nodes.Add(treeNode);
            }
            return true;
        }
        public async Task<bool> ShowProductAtPriceAscendingAsync(TreeView treeView, string type, string category)
        {
            var productItems = await _tableProduct.ShowProductAtPriceAscendingAsync(type, category);
            treeView.ImageList = await ImageListCreateAsync(productItems);

            for (int i = 0; i < productItems.Count; i++)
            {
                string text = (productItems[i].ItemName + " " + Math.Round(productItems[i].ItemPrice.Value, 2) + " р. Кол-во на складе:" + productItems[i].ItemAmount).ToString();
                TreeNode treeNode = new TreeNode(text, i, i);
                treeView.Nodes.Add(treeNode);
            }
            return true;
        }
        public async Task<bool> ShowProductAtPriceDescendingAsync(TreeView treeView, string type, string category)
        {
            var productItems = await _tableProduct.ShowProductAtPriceDescendingAsync(type, category);
            treeView.ImageList = await ImageListCreateAsync(productItems);

            for (int i = 0; i < productItems.Count; i++)
            {
                string text = (productItems[i].ItemName + " " + Math.Round(productItems[i].ItemPrice.Value, 2) + " р. Кол-во на складе:" + productItems[i].ItemAmount).ToString();
                TreeNode treeNode = new TreeNode(text, i, i);
                treeView.Nodes.Add(treeNode);
            }
            return true;
        }
        public async Task<bool> ShowProductAtExpensivePriceAsync(TreeView treeView, string type, string category)
        {
            var productItems = await _tableProduct.ShowProductAtExpensivePriceAsync(type, category);
            treeView.ImageList = await ImageListCreateAsync(productItems);

            for (int i = 0; i < productItems.Count; i++)
            {
                string text = (productItems[i].ItemName + " " + Math.Round(productItems[i].ItemPrice.Value, 2) + " р. Кол-во на складе:" + productItems[i].ItemAmount).ToString();
                TreeNode treeNode = new TreeNode(text, i, i);
                treeView.Nodes.Add(treeNode);
            }
            return true;
        }
        public async Task<bool> ShowProductIsNotAvailableAsync(TreeView treeView, string type, string category)
        {
            var productItems = await _tableProduct.ShowProductIsNotAvailableAsync(type, category);
            treeView.ImageList = await ImageListCreateAsync(productItems);

            for (int i = 0; i < productItems.Count; i++)
            {
                string text = (productItems[i].ItemName + " " + Math.Round(productItems[i].ItemPrice.Value, 2) + " р. Кол-во на складе:" + productItems[i].ItemAmount).ToString();
                TreeNode treeNode = new TreeNode(text, i, i);
                treeView.Nodes.Add(treeNode);
            }
            return true;
        }
        public async Task<string[]> ShowProductAsync(string productName)
        {
            var product =  await _tableProduct.ShowProductAsync(productName);
            string[] text = new string[2];
            text[0] = product.ItemCharacteristics;
            text[1] = product.ItemDescription;
            return text;
        }
    }
}
