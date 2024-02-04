using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{
    readonly Course[] courses = new Course[3];

    // ctor newlendiği an çalışır
    public CourseManager()
    {
        Course course1 = new()
        {
            Id = 1,
            Name = "C#",
            Description = ".Net 8.0",
            Price = 99.99
        };

        Course course2 = new()
        {
            Id = 2,
            Name = "Java",
            Description = "Java 17",
            Price = 89.99
        };

        Course course3 = new()
        {
            Id = 3,
            Name = "Pyhton",
            Description = "Pyhton 3.12",
            Price = 79.99
        };

        courses = [course1, course2, course3];
    }

    public Course[] GetAll()
    {
        //// Normal şartlarda veri DBden çekilir
        //Console.WriteLine("Courses are listed!");

        return courses;
    }
}
