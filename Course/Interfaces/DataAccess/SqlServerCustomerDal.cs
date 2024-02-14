namespace Interfaces.DataAccess;

class SqlServerCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Sql added");
    }

    public void Delete()
    {
        Console.WriteLine("Sql deleted");
    }

    public void Update()
    {
        Console.WriteLine("Sql updated");
    }
}