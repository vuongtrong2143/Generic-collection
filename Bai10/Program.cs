// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong");

List<int> danhsach = new List<int>() { 24, 150, 53, 12, 21, 43 };
Console.WriteLine("\nDANH SACH:\n");
foreach (int d in danhsach)
    Console.Write($"{d}" + " ");
int min = danhsach[0];
foreach (int d in danhsach)
    if (d < min)
        min = d;
Console.WriteLine($"\nPhan tu nho nhat trong danh sach la {min}.");


