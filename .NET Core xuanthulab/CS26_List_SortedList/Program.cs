using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS26_List_SortedList
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }

            public int Price { get; set; }

            public int ID { get; set; }

            public string Origin { get; set; }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            // List<Product> products = new List<Product>(){
            //     new Product(){Name = "Iphone x", Price = 1000, ID = 1, Origin = "Trung Quoc"},
            //     new Product(){Name = "Iphone xr", Price = 950, ID = 2, Origin = "Trung Quoc"},
            //     new Product(){Name = "Iphone xs", Price = 1200, ID = 3, Origin = "Viet Nam"},
            //     new Product(){Name = "Iphone xs max", Price = 1500, ID = 4, Origin = "Viet Nam"},
            // };
            // products.Sort((p1, p2) => {
            //         if (p1.Price == p2.Price) return 0;
            //         if (p1.Price > p2.Price) return 1;
            //         return -1;
            //         // return p1.Price - p2.Price;
            //     });

            // products.ForEach(e => {
            //         System.Console.WriteLine($"{e.Name} - {e.Price}");
            //     });
            //vd2
            SortedList<string, Product>products = new SortedList<string, Product>();
            products["sp1"] = new Product(){Name = "Iphone x", Price = 1000, ID = 1, Origin = "China"};
            products["sp2"] = new Product(){Name = "Iphone xr", Price = 960, ID = 2, Origin = "China"};
            products.Add("sp3", new Product(){Name = "Iphone xs", Price = 1200, ID = 3, Origin = "Viet Nam"});

            var keys = products.Keys;
            var value = products.Values;
            foreach (KeyValuePair<string, Product> item in products)
            {
                var key = item.Key;
                var val = item.Value;
                System.Console.WriteLine($"{key} - {val.Name}");
            }
        }
    }
}
