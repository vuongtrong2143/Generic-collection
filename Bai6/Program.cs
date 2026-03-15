// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong");

List<string> danhsach = new List<string>() { "Chuoi A", "chuoi b", "Chuoi AbC", "chuoi ABC"};

Console.WriteLine("\nDANH SACH:\n");
foreach (string chuoi in danhsach)
{
    Console.WriteLine(chuoi);
}
Console.WriteLine("\nNhap chuoi can kiem tra:\n");
string kiemtrachuoi = Console.ReadLine() ?? "";

bool COchuoi = danhsach.Contains(kiemtrachuoi);
if (COchuoi)
{
    Console.WriteLine($"\nTon tai chuoi {kiemtrachuoi} trong danh sach.");
}
else
{
    Console.WriteLine($"\nKhong ton tai chuoi {kiemtrachuoi} trong danh sach.");
}