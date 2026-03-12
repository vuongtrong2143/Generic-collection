// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong");

List<int> danhsach = new List<int>() { 24, 150, 53, 122, 143};
int somax = 0;
foreach (int item in danhsach)
{
    if (item > somax)
        { somax = item; }
}
Console.WriteLine($"So lon nhat trong danh sach: {somax}");