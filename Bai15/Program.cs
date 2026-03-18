// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");
Dictionary<string,string> tudienAnhViet = new Dictionary<string, string>()
{
    {"Hello", "Xin chao"},
    {"Goodbye", "Tam biet" },
    {"One", "Mot" },
    {"Two", "Hai" },
    {"Three", "Ba" },
    {"Four", "Bon" },
    {"Five", "Nam" }
};

Console.WriteLine("Danh sach tu dien:");
foreach (var c in tudienAnhViet)
    Console.WriteLine($"{c.Key} : {c.Value}");

Console.WriteLine("Nhap tu tieng Anh can tra: ");
string tucantra = Console.ReadLine() ?? "";

if (tudienAnhViet.TryGetValue(tucantra, out string? tiengViet))
{
    Console.WriteLine($"{tucantra} - {tiengViet}");
}
else
{
    Console.WriteLine($"Khong co tu {tucantra} trong tu dien.");
}

