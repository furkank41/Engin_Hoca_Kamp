using intro.DataAccess.Abstracts;
using intro.DataAccess.Concrates;
using intro.Entities;

namespace intro.Business;
public class CourseManager
{
    // dependency Injection
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }
 
}