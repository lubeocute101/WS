using System;
using Newtonsoft.Json;
namespace CS31_nuget
{
    class Product
    {
        public string Name { get; set; }
        public DateTime Expiry { get; set; }
        public string[] Sizes { get; set; }
    }
    class Program
    {
        // dotnet add package Newtonsoft.Json 
        // dotnet remove package Newtonsoft.Json
        // dotnet restore
        static void Main(string[] args)
        {
            Console.Clear();
            // Product p = new Product();
            // p.Name = "Apple";
            // p.Expiry = new DateTime(2008, 12, 28);
            // p.Sizes = new string[] { "small" };
            // string json = JsonConvert.SerializeObject(p);
            // System.Console.WriteLine(json);
            string json = @"
            {
                ""Name"": ""Dien thoai Iphone"",
                ""Expiry"": ""2021-1-30T00:00:00"",
                ""Size"": [""Large"", ""Small""]
            }
            ";
            var p = JsonConvert.DeserializeObject<Product>(json);
            System.Console.WriteLine(p.Name);
            System.Console.WriteLine(p.Expiry.ToLongDateString());
            // System.Console.WriteLine(p.Name);
        }
    }

}