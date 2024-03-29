﻿using Intro.DataAccess.Abstract;
using OOP.Entities;

namespace OOP.DataAccess.Concrete;

// ADO.NET gibi implemente ettik
public class CourseDal : ICourseDal
{
    private readonly List<Course> courses;

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
