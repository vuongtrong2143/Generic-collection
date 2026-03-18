// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<Student> danhsach = new List<Student>()
{
    new Student { Name = "Zero", Score = 9},
    new Student { Name = "An", Score = 6.5},
    new Student { Name = "Binh", Score = 7.2},
    new Student { Name = "Bao", Score = 7.5},
    new Student { Name = "Chau", Score = 8.2},
    new Student { Name = "OreZ", Score = 9.3}
};

string tensv = danhsach[0].Name;
double max = danhsach[0].Score;

for (int i = 1; i < danhsach.Count; i++)
{
    if (max <  danhsach[i].Score)
    {
        max = danhsach[i].Score;
        tensv = danhsach[i].Name;
    }
}
Console.WriteLine($"Sinh vien {tensv} co diem cao nhat ({max} diem).");
class Student
{
    public double Score { get; set; }
    public string Name { get; set; } = "";
}