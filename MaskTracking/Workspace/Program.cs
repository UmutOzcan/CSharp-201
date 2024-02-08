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

Person person2 = new()
{
    FirstName = "JACK",
    LastName = "SULLY",
    DateOfBirth = 1998,
    NationalIdentity = 15789465434
};

Console.WriteLine("PTT ile bir vatandaşa maske vermek için kimlik bilgilerini doğrulama");
Console.WriteLine();

PttManager pttManager = new(new PersonManager());
pttManager.GiveMask(person1);

Console.WriteLine();

PttManager pttManager2 = new(new ForeignerManager());
pttManager2.GiveMask(person2);

Console.ReadKey();