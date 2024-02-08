using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            var list = new List<Person>();
            return list;
        }
    }
}
