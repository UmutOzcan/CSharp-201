namespace Interfaces.DataAccess;

class CustomerManager
{
    public void Add(ICustomerDal customerDal)
    {
        customerDal.Add();
    }
}