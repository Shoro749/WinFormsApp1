using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Good
    {
        public string name { get; set; }
        public int price { get; set; }

        public Good()
        {
            name = string.Empty;
            price = 0;
        }

        public Good(string Name, int Price)
        {
            name = Name;
            price = Price;
        }
        public string getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
        public override string ToString()
        {
            return $"{name} - {price}$";
        }
    }
}
