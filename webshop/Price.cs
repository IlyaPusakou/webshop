﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    class Price
    {
        public decimal Ammount { get; set; }
        public string Currency { get; set; }
        List<ProductAbstract> ListOfProducts { get; set; }
        public Dictionary<decimal, Buyer> DiscountPriceList { get; set; }
        public Price(List<ProductAbstract> list = null)
        {
            ListOfProducts = list;
        }
        public void MakeDiscount()
        {

        }
        public void ChangeThePrice()
        {

        }
        public void CalculateTheProfit()
        {

        }
}
}
