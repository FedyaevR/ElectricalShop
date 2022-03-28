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
        
        public  async Task<bool> ShowAllProductAsync(ListView listView)
        {
            var res =  await _tableProduct.ShowAllDB();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(30, 30);
            var imageByte = await Task.Run(()=>(from image in res
                             select image.ItemImage).ToList());

            foreach (var item in imageByte)
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(item);
                Bitmap image = await Task.Run(()=>(Bitmap)Image.FromStream(memoryStream));
                await Task.Run(()=>imageList.Images.Add(image));
            }
            listView.SmallImageList = imageList;
            listView.LargeImageList = imageList;
            
            for (int i = 0; i < res.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {res[i].ItemName + " "+ res[i].ItemPrice.ToString() });
                listViewItem.ImageIndex = i;
                listView.Items.Add(listViewItem);
            }
            
            return true;

        }
        public async Task<bool> ShowProductAtCategory(ListView listView,string type,string category)
        {
            var res = await _tableProduct.ShowProductAtCategory(type,category);
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(30, 30);
            var imageByte = await Task.Run(() => (from image in res
                                                  select image.ItemImage).ToList());

            foreach (var item in imageByte)
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(item);
                Bitmap image = await Task.Run(() => (Bitmap)Image.FromStream(memoryStream));
                await Task.Run(() => imageList.Images.Add(image));
            }
            listView.SmallImageList = imageList;
            listView.LargeImageList = imageList;

            for (int i = 0; i < res.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { res[i].ItemName + " " + res[i].ItemPrice.ToString() });
                listViewItem.ImageIndex = i;
                listView.Items.Add(listViewItem);
            }

            return true;
        }

    }
}
