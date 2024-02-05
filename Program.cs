using intro.Business;
using intro.Entities;

string message1 = "Krediler";
bool isAuthenticated = true;

if (isAuthenticated)
    Console.WriteLine("Hoşgeldin Engin");
else
    Console.WriteLine("Giriş yapılmadı.");

Console.WriteLine("kod bitti");

string[] loans = new string[]
{
    "Kredi 1",
    "Kredi 2",
    "Kredi 3",
    "Kredi 4"
};

foreach (var item in loans)
{
    Console.WriteLine(item);
}

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".Net 8";
course1.Price = 0;

Course course2 = new Course()
{
    Id = 2,
    Name = "Java",
    Description = "Java 17",
    Price = 10
};

List<Course> courses = new List<Course>() { course1, course2 };
foreach (var item in courses)
{
    Console.WriteLine(item.Name + " " + item.Price);
}

CourseManager courseManager = new CourseManager();

Course[] courses2 = courseManager.GetAll();

foreach (Course course in courses2)
{
    Console.WriteLine(course.Name);
}