
Customer customer = new() // Default Constructor
{
    Id = 1,
    FirstName = "Ahmet",
    LastName = "Sozen",
    City = "Istanbul"
};
Console.WriteLine(customer.FirstName + " " + customer.LastName);

Console.WriteLine();

Customer customer2 = new(2, "Mehmet", "Yılmaz", "Anakara"); // Parametreli Ctor
Console.WriteLine(customer2.FirstName + " " + customer2.LastName);


Console.ReadKey();

class Customer
{
    public Customer()
    {
        Console.WriteLine("new() yapıldıgı an ctor calisir");
    }
    public Customer(int id, string firstName, string lastName, string city) // ctor
    {
        Console.WriteLine("new(id,firstName,lastName,city) yapıldıgı an ctor calisir");
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}