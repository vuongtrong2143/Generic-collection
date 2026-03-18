// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

Dictionary<char,int> danhsach = new Dictionary<char,int>();

Console.WriteLine("Nhap chuoi: ");
string chuoi = Console.ReadLine() ?? "";

foreach (char ch in chuoi)
{
    if (danhsach.ContainsKey(ch))
    {
        danhsach[ch]++;
    }
    else
    {
        danhsach.Add(ch, 1);
    }
}
Console.WriteLine($"So lan xuat hien cua tung ky tu cua chuoi {chuoi} la: ");
foreach (var c in danhsach)
{
    Console.Write($"{c.Key} : {c.Value} ");
}