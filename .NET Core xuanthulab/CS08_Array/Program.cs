// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text;
Console.Clear();
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
// int []numbers = {11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// System.Console.WriteLine($"Số phần tử: {numbers.Length}");
// System.Console.WriteLine($"Rank: {numbers.Rank}");
// System.Console.WriteLine($"Min: {numbers.Min()}");
// System.Console.WriteLine($"MAX: {numbers.Max()}");
// System.Console.WriteLine($"Sum: {numbers.Sum()}");
// Array.Sort(numbers);
// foreach (var i in numbers){
//     System.Console.WriteLine(i);
// }


// Mảng 2 chiều
double [,]numbers = new double[2, 3]{{1, 2, 3}, {4, 5, 6}};
for (int i = 0; i < 2; i++){
    for (int j = 0; j < 3; j++){
        System.Console.Write(numbers[i, j] + " ");
    }
    System.Console.WriteLine();
}