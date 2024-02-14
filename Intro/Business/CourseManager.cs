using Intro.DataAccess.Abstract;
using OOP.Entities;

namespace OOP.Business;

public class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        // DAL newlenmez
        return _courseDal.GetCourses();
    }
}