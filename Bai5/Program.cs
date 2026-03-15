// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("2415053122143 - Nguyen Vuong Trong");
List<string> dsTen = new List<string>() { "An", "Binh", "Nghia", "Lan", "Lam", "Mai" };

Console.WriteLine("Danh sach ten ban dau:\n");
foreach (string t in dsTen)
    Console.Write($"{t}"+" ");

Console.WriteLine("\n\nNhap ten can xoa: ");
string tennhap = Console.ReadLine() ?? ""; // Toán tử Null-coalescing ?? 0.0

dsTen.Remove(tennhap);

Console.WriteLine($"\nDanh sach ten sau khi xoa ten <{tennhap}> la: ");
foreach (string t in dsTen)
    Console.Write($"{t}" + " ");