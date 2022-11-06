using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace CS30_Linq
{
    class Program
    {
        //LINQ (Language Integrared Query) : Ngôn ngữ truy vấn kết hợp
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();
            List<Brand> brands = new List<Brand>(){
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 3, Name = "Công ty CCC"},
            };
            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };
            // viết câu truy vấn, lưu vào ketqua
            var ketqua = from product in products                  // các sản phẩm trong products
                         group product by product.Price into gr    // nhóm thành gr theo giá
                         let count = gr.Count()                    // số phần tử trong nhóm
                         select new
                         {                              // trả về giá và số sản phầm có giá này
                             price = gr.Key,
                             number_product = count
                         };

            foreach (var item in ketqua)
            {
                Console.WriteLine($"{item.price} - {item.number_product}");
            }
        }
    }
}