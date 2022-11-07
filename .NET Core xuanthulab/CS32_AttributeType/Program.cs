using System;
using System.Reflection;
using System.Linq;
using System.Text;
namespace CS32_AttributeType
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)] // mô tả dduowjc sử dụng ở đâu(class, property, method)
    class MotaAttribute : Attribute
    {
        public string Thongtinchitiet { get; set; }
        public MotaAttribute(string _Thongtinchitiet)
        {
            Thongtinchitiet = _Thongtinchitiet;
        }
    }
    [Mota("Lop chua thong tin ve User tren he thong")]
    class User
    {
        [Mota("Tên người dùng")]
        public string Name { get; set; }
        [Mota("Dữ liệu tuổi")]
        public int Age { get; set; }
        [Mota("Số điện thoại cá nhân")]
        public string PhoneNumber { get; set; }
        [Mota("Địa chỉ email")]
        public string Email { get; set; }
        [Obsolete("Phương thức này không nên sử dụng nữa, cần thay bởi ShowInfo")]
        public void PrintInfo()
        {
            System.Console.WriteLine(Name);
        }
    }
    class Program
    {
        // ObsoleteAttribute
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();
            User user = new User()
            {
                Name = "XuanThuLab",
                Age = 20,
                PhoneNumber = "123123132",
                Email = "lch.ryu2001@gmail.com"
            };
            var properties = user.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                foreach (var attr in property.GetCustomAttributes(false))
                {
                    MotaAttribute mota = attr as MotaAttribute;
                    if (mota != null)
                    {
                        System.Console.WriteLine(mota.Thongtinchitiet);
                        var value = property.GetValue(user);
                        var name = property.Name;
                        System.Console.WriteLine($"({name}) {mota.Thongtinchitiet}: {value}");
                    }
                }
            }
        }
    }
}