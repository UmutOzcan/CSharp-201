using Business.Abstract;
using Entities.Concrete;
namespace Business.Concrete;

public class PttManager(IApplicantService applicantService) : ISupplierService
{
    private readonly IApplicantService _applicantService = applicantService; // Bağımlılığı azaltmak için Dependency Injection kullanılır

    public void GiveMask(Person person)
    {
        //PersonManager personManager = new PersonManager(); Bu şekilde bağımlılık oluşur bu yüzden Interface kullanılır
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verilebilir.");
        }
        else
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " için maske VERİLEMEDİ. Çünkü verilen bilgiler yanlış!");
        }
    }
}