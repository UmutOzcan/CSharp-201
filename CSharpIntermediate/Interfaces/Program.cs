
//IPersonManager personManager = new(); Interfaceler newlenemez

//class - inherits ---------- interface - implements

CustomerManager customerManager = new();
customerManager.Add();

EmployeeManager employeeManager = new();
employeeManager.Add();

Console.WriteLine();

// Project Managerda interface ile parametre istediğimizden iki farklı classı interface sayesinde aynı parametre olarak kullanabiliriz
ProjectManager projectManager = new(); 
projectManager.Add(new EmployeeManager());
projectManager.Add(new CustomerManager());






Console.ReadKey();

//class PersonManager
//{
//    // implemented operation
//    public void Add()
//    {
//        Console.WriteLine("Eklendi");
//    }
//}

interface IPersonManager
{
    // unimplemented operation
    void Add();
    void Delete();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri Eklendi");
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel Eklendi");
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}