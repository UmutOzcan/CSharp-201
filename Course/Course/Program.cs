using Course;

Console.WriteLine(Days.Friday);
Console.WriteLine((int)Days.Friday);
Console.WriteLine();

// Ctrl-K + Ctrl-D düzenleme
// Ctrl-K + Ctrl-C comment yapma
// Ctrl-K + Ctrl-U comment kaldırma

Add();
int num1 = 7;
int num2 = 9;
Console.WriteLine(Add2(num1, num2));
Console.WriteLine(Add3(ref num1, ref num2));
Console.WriteLine();
Console.WriteLine(Add4(1, 2, 3, 4, 5, 6, 7, 8, 9));
Console.WriteLine();

string[,] regions =
{
    {"İstanbul","Tekirdağ","Sakarya" },
    {"Ankara","Konya","Sivas" },
    {"İzmir","Aydın","Muğla" }
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine();
}

int num3 = 23;
if (isPrime(num3)) Console.WriteLine(num3 + " is Prime!");
else Console.WriteLine(num3 + " is Not Prime!");

Console.WriteLine();

// static class
ProductManager.Add();
ProductManager.Remove();

Console.WriteLine();

CustomerManager customerManager = new();
customerManager.Add();
customerManager.Remove();

Console.WriteLine();

Product product = new()
{
    Id = 1,
    Name = "Monster",
    Model = "Abra"
};
Console.WriteLine(product.Id + " " + product.Name + " " + product.Model);

Console.WriteLine();

Console.ReadKey();


// Functions
static void Add()
{
    Console.WriteLine("Hello World!");
}
static int Add2(int num1, int num2)
{
    return num1 + num2;
}
static int Add3(ref int num1, ref int num2) // ref
{
    num1 = 1; num2 = 2;
    return num1 + num2;
}
static int Add4(params int[] arr) // params
{
    return arr.Sum();
}
static bool isPrime(int num)
{
    bool result = true;
    if(num > 1)
    {
        for (int i = 2; i < num; i++)
        {
            if(num% i == 0)
            {
                result = false; break;
            }
        }
    }
    else 
    {
        result = false; 
    }
    return result;
}
enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}