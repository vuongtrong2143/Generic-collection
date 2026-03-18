// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");
List<Student> danhsach = new List<Student>()
{
    new Student { Id = 1, Name = "An" },
    new Student { Id = 2, Name = "Binh" },
    new Student { Id = 3, Name = "Chuong" }
};

foreach (Student s in danhsach)
    Console.WriteLine($"Id: {s.Id}, Name: {s.Name}");
Console.WriteLine("Nhap ten sinh vien can tim:");
string tensv = Console.ReadLine() ?? "";

bool found = false;
for (int i = 0; i < danhsach.Count; i++)
{
    if (danhsach[i].Name == tensv)
    {
        Console.WriteLine($"Id: {danhsach[i].Id}, Name: {danhsach[i].Name}");
        found = true;
    }
}
if (!found)
{
    Console.WriteLine($"\nKhong co ten {tensv}");
}
class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
}