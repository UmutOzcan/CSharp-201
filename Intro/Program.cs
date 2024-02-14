using OOP.Business;
using OOP.DataAccess.Concrete;
using OOP.Entities;

IndividualCustomer customer1 = new()
{
    Id = 1,
    NationalIdentity = "1234567890",
    FirstName = "Ezel",
    LastName = "Bayraktar",
    CustomerNumber = "123456"
};

IndividualCustomer customer2 = new()
{
    Id = 2,
    NationalIdentity = "1234567899",
    FirstName = "Eyşan",
    LastName = "Tezcan",
    CustomerNumber = "456789"
};

CoorporateCustomer customer3 = new()
{
    Id = 3,
    Name = "Trendyol",
    CustomerNumber = "987654",
    TaxNumber = "1234567890",
};

CoorporateCustomer customer4 = new()
{
    Id = 4,
    Name = "HepsiBurada",
    CustomerNumber = "987650",
    TaxNumber = "1234567891",
};

int number = 30;
int number2 = 40;
number = number2;
Console.WriteLine(number);
Console.WriteLine();

string[] cities = ["Ankara", "Istanbul", "Izmir"];
string[] cities2 = ["Bursa", "Sakarya", "Kocaeli"];
cities = cities2;
Console.WriteLine(cities[0]);
Console.WriteLine();

// value-type -> int,bool,double..
// reference-type -> array,class,interface..

BaseCustomer[] customers = [customer1, customer2, customer3, customer4];

// Polymorphism
foreach (var customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}
Console.WriteLine();

// Ef - ADO.Net gibi farklı kullanımlarda sadece yöntem değiştirilir
// Sadece bağımlılık değiştirerek kod yükünden kurtuluruz
CourseManager courseManager = new(new EfCourseDal());
//CourseManager courseManager = new(new CourseDal());

List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}


Console.ReadKey();