Console.Clear();
static void BinhPhuong(ref int x){
    x = x * x;
    System.Console.WriteLine(x);
}
int a = 2;
BinhPhuong(ref a);
BinhPhuong(ref a);
BinhPhuong(ref a);
System.Console.WriteLine(a);