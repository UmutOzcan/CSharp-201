using Interfaces.DataAccess;

PersonManager personManager = new();
Customer customer = new() { Id = 1, Name = "Jack", Adress = "London", Email = "jack.london@gmail.com" };
Student student = new() { Id = 2, Name = "John", Department = "SAU", Email = "john@sakarya.edu.tr" };

personManager.Add(customer);
personManager.Add(student);

//CustomerManager customerManager = new();
//customerManager.Add(new SqlServerCustomerDal());
//customerManager.Add(new OracleCustomerDal());

Console.WriteLine();

ICustomerDal[] customerDals =
[
    new SqlServerCustomerDal(),
    new OracleCustomerDal()
];

foreach (var dal in customerDals)
{
    dal.Add();
}


Console.ReadKey();