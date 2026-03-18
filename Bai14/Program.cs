// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");
List<Student> danhsach = new List<Student>()
{
    new Student { Id = 1, Name = "An"},
    new Student { Id = 2, Name = "Binh"},
    new Student { Id = 3, Name = "Chuong"},
    new Student { Id = 4, Name = "Du"}
};

Console.WriteLine("Danh sach TRUOC xoa: ");
foreach (Student student in danhsach)
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");

Console.Write("\nNhap Id cua sinh vien can xoa: ");
string MaId = Console.ReadLine() ?? "";

if (int.TryParse(MaId, out int Ma))
{
    for (int i = 0; i < danhsach.Count; i++)
    {
        if (danhsach[i].Id == Ma)
        {
            danhsach.RemoveAt(i);
            break;
        }
    }
    Console.WriteLine("Danh sach SAU xoa:");
    foreach (Student student in danhsach)
        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
}
else
{
    Console.WriteLine("Loi: Phai nhap so nguyen");
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}