// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong");
List<Student> danhsach = new List<Student>()
{
    new Student { Id = 1, Name = "An"},
    new Student { Id = 2, Name = "Binh"},
    new Student { Id = 3, Name = "Chuong"}
};

foreach (Student sv in danhsach)
    Console.WriteLine($"Id: {sv.Id}, Name: {sv.Name}");

class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}