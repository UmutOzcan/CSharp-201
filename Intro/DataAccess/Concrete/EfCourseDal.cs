using Intro.DataAccess.Abstract;
using OOP.Entities;

namespace OOP.DataAccess.Concrete;

// Ef gibi implemente ettik
public class EfCourseDal : ICourseDal
{
    private readonly List<Course> courses;

    public EfCourseDal()
    {
        Course course1 = new()
        {
            Id = 1,
            Name = "JavaScript",
            Description = ".Net 8.0",
            Price = 109.99
        };

        Course course2 = new()
        {
            Id = 2,
            Name = "Go",
            Description = "Go 3",
            Price = 29.99
        };

        Course course3 = new()
        {
            Id = 3,
            Name = "Rust",
            Description = "Rust 1.0",
            Price = 39.99
        };

        courses = [course1, course2, course3];
    }

    public List<Course> GetCourses()
    {
        return courses;
        // DB works
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
