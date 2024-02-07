using Business.Abstract;
using Entities.Concrete;
namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _applicantService; // Bağımlılığı azaltmak için Dependency Injection kullanılır

    public PttManager(IApplicantService applicantService) // DI için ctor da oluştuğu an çalışır
    {
        _applicantService = applicantService;
    }

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