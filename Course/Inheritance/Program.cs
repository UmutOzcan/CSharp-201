
Person[] people =
[
    new Customer
    {
        FirstName = "Ahmet"
    },
    new Student
    {
        FirstName = "Cemil",
    },
    new Person
    {
        FirstName = "Hikmet"
    }
];

foreach (var person in people)
{
    Console.WriteLine(person.FirstName);
}

Console.ReadKey();