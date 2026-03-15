// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong");

List<int> danhsach = new List<int>() { 1,2,3,5,8,13,21,4,6,2,8,10,12,14};
List<int> danhsachmoi = new List<int>();

foreach (int i in danhsach)
{
    if (danhsachmoi.Contains(i) == false)
        danhsachmoi.Add(i);
}

foreach (int i in danhsachmoi)
    Console.Write($"{i}" + " ");

