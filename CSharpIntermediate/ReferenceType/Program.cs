
//value types

int num1 = 7;
int num2 = 8;
num1 = num2;
num2 = 100;

Console.WriteLine("num1 = " + num1);
Console.WriteLine();

// reference types

int[] nums = [1, 2, 3, 4, 5, 6, 7];
int[] nums2 = [10, 11, 12, 13, 14, 15];
nums = nums2; // nums içindeki eski bilgiler Heapden Garbage Collector ile toplanır.
nums2[0] = 50;

Console.WriteLine("nums[0] = " + nums[0]);
Console.WriteLine("nums2[0] = " + nums2[0]);

Console.WriteLine();

Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "Umut";
person2.FirstName = "Yusuf";

person2 = person1; // reference eşitlendi
person1.FirstName = "Ozcan";
Console.WriteLine(person2.FirstName);
Console.WriteLine();

Customer customer = new Customer
{
    FirstName = "Ayse",
    CreditCardNumber = "123456789"
};
Employee employee = new()
{
    FirstName = "Fatma"
};

Person person3 = customer; // childın reference ını alır
Console.WriteLine(person3.FirstName);
Console.WriteLine(((Customer)person3).CreditCardNumber);
Console.WriteLine();


PersonManager personManager = new();
personManager.Add(person3);
personManager.Add(employee);




Console.ReadKey();

class Person // Base class
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person) // Base class parametre
    {
        Console.WriteLine(person.FirstName);
    }
}
