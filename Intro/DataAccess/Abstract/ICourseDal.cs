using OOP.Entities;

namespace Intro.DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetCourses();
    void Add(Course course);
}
