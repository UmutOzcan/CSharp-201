// See https://aka.ms/new-console-template for more information
using Intro.Entities;
using Intro.Business;

Console.WriteLine("Hello, World!");

string message = "Credits ";
int term = 12;
double amount = 10000;

// variables -> camelCase
bool isAuthenticated = false;
Console.WriteLine(message + " term = " + term + " amount = " + amount);

//condition
if(isAuthenticated )
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("You must Log In!");
}

Console.WriteLine("Code is done!");

string[] loans = { "Credit 1", "Credit 2", "Credit 3", "Credit 4" };
// string[] loans2 = new string[6];
// loans[0] = "Credit 1";

Console.WriteLine();
// start ; condition ; increment
for(int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Console.WriteLine();
//---------------------------------------------

CourseManager courseManager = new();
Course[] courses = courseManager.GetAll();

foreach(Course course in courses)
{ 
    Console.WriteLine(course.Name + " / " + course.Price); 
}

Console.ReadKey();