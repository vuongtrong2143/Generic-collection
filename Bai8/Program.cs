// See https://aka.ms/new-console-template for more information

Console.WriteLine("2415053122143 - Nguyen Vuong Trong");

List<int> danhsach = new List<int>() { 24, 150, 53, 12, 21, 43 };
Console.WriteLine("\nDanh sach ban dau:");
foreach (int i in danhsach)
{
    Console.Write($"{i}" + " ");
}

danhsach.Reverse();

Console.WriteLine("\n\nDanh sach dao nguoc:");
foreach (int i in danhsach)
{
    Console.Write($"{i}" + " ");
}