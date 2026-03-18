// See https://aka.ms/new-console-template for more information

Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<Student> danhsach = new List<Student>()
{
    new Student { Id = 1, Name = "An"},
    new Student { Id = 2, Name = "Binh"},
    new Student { Id = 3, Name = "Chuong"},
    new Student { Id = 4, Name = "Du"}
};
foreach (Student student in danhsach)
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
Console.WriteLine($"Tong so sinh vien la: {danhsach.Count}");
class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}