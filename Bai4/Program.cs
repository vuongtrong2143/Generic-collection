// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong");
List<int> danhsach = new List<int>() { 24, 150, 53, 122, 143};
int dem = 0;
foreach(int d in danhsach)
{
    if (d%2 == 0)
    {
        dem++;
    }
}
Console.WriteLine($"So phan tu chan la: {dem}");