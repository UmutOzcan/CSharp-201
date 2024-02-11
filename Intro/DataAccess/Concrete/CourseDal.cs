using OOP.Entities;

namespace OOP.DataAccess.Concrete;

public class CourseDal
{
    public CourseDal()
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
    }

    public List<Course> GetCourses()
    { 
        return []; 
        // DB works
    }
}
