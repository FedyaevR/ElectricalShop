﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricalShop.Model;
namespace ElectricalShop.Controller
{
    class CartController
    {
        TableProduct _tableProduct = new TableProduct();

        public async Task<bool> BuyProduct(string productName, int amount)
        {
           return await _tableProduct.BuyProduct(productName, amount);
        }
    }
}
