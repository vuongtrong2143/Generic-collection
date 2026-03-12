System.Console.WriteLine("2415053122143 - Nguyen Vuong Trong");

List<int> danhsach = new List<int>() { 1,3,5,7,9 };
int sum = 0;
foreach (int i in danhsach)
{
    sum += i;
}
Console.WriteLine($"Tong la {sum}");
