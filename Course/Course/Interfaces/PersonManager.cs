










class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.Id + " " + person.Name + " " + person.Email);
    }
}