namespace Workspace
{
    public class Class1
    {
        public static void SelamVer(string name = "NoName")
        {
            Console.WriteLine("Hello, " + $"{name}" + "!");
        }

        public static int Sayı()
        {
            return 5;
        }

        public static int Topla(int sayi1 = 3, int sayi2 = 5)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Result = "+ sonuc.ToString());
            return sonuc;
        }
    }
}
