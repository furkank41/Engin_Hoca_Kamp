using intro.DataAccess.Abstracts;
using intro.Entities;

namespace intro.DataAccess.Concrates;

public class EfCourseDal : ICourseDal
{
    List<Course> courses;
    public EfCourseDal()
    {
        Course course1 = new();
        course1.Id = 1;
        course1.Name = "Java";
        course1.Description = ".Net 8";
        course1.Price = 0;

        Course course2 = new()
        {
            Id = 2,
            Name = "Python",
            Description = "Java 17",
            Price = 10
        };
        courses = new List<Course> { course1, course2 };
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetAll()
    {
        return courses;
    }
}