using Business.Abstract;
using Entities.Concrete;
using MernisForeignerServiceReference;

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
            KPSPublicYabanciDogrulaSoapClient client = new
                (KPSPublicYabanciDogrulaSoapClient.EndpointConfiguration.KPSPublicYabanciDogrulaSoap);
            return client.YabanciKimlikNoDogrulaAsync(new YabanciKimlikNoDogrulaRequest(new YabanciKimlikNoDogrulaRequestBody
                (person.NationalIdentity, person.FirstName, person.LastName,null,null, person.DateOfBirth))).Result.Body.YabanciKimlikNoDogrulaResult;
        }

        public List<Person> GetAll()
        {
            var list = new List<Person>();
            return list;
        }
    }
}
