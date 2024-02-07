using Business.Concrete;
using Entities.Concrete;

Console.WriteLine();

Person person1 = new()
{
    FirstName = "UMUT",
    LastName = "OZCAN",
    DateOfBirth = 2000,
    NationalIdentity = 1234567890
};

Console.WriteLine("PTT ile bir vatandaşa maske vermek için kimlik bilgilerini doğrulama");
Console.WriteLine();
PttManager pttManager = new(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadKey();