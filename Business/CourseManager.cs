using intro.Entities;
using System;
using System.Threading.Channels;
namespace intro.Business;

public class CourseManager
{
    Course[] courses = new Course[2];
    public CourseManager()
    {        
        Course course1 = new();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8";
        course1.Price = 0;

        Course course2 = new()
        {
            Id = 2,
            Name = "Java",
            Description = "Java 17",
            Price = 10
        };
        courses[0] = course1;
        courses[1] = course2;
    }
    public Course[] GetAll()
    {
        return courses;
    }
}