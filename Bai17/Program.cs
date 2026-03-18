// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<int> danhsach = new List<int>() { 1,2,3,5,1,2,9,6,5,4,1,2,3,5,8,7,4,1,2,3,2,5,1,2,3};

Dictionary<int, int> danhsachKV = new Dictionary<int, int>();

foreach (int i in danhsach)
{
    if (danhsachKV.ContainsKey(i)) // if (danhsachKV.TryGetValue(i, out int count))
    {
        danhsachKV[i]++; // danhsachKV[i] = count + 1;
    }
    else
    {
        danhsachKV.Add(i, 1); // danhsachKV[i] = 1;
    }
}

int Socantim = 0;
int Solanxuathien = 0;

foreach (var c in danhsachKV)
{
    if (c.Value > Solanxuathien)
    {
        Socantim = c.Key;
        Solanxuathien = c.Value;
    }
}
Console.WriteLine($"So {Socantim} xuat hien nhieu lan nhat ({Solanxuathien} lan).");

