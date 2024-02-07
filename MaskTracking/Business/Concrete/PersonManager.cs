using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
namespace Business.Concrete;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetAll()
    {
        return [];
    }

    public bool CheckPerson(Person person) // Web Service ile tc kontrolü
    {
        KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
            (person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
    }
}