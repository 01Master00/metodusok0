namespace metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kosonto();
            Console.WriteLine(osszeadas(18, 90));
            int a = 5;
            Console.WriteLine(dupla(a));
            Console.WriteLine(a);
            Console.WriteLine(osszeg(2, 7));
            Console.WriteLine(osszeg(2));
            int num1 = 4, num2 = 7;
            csere(ref num1, ref num2);
            Console.WriteLine(num1 + " " + num2);
        }
        static int n(int szam1)
        {
            return 0;
        }

        static string n()
        {
            return ""
        }
        static void kosonto()
        {
            Console.WriteLine("helló világ");
        }
        static int osszeadas(int a, int b)
        {
            int osszeg = a + b;
            return osszeg;  // VAGY return a+b
        }

        static int dupla(int a)
        {
            return a * 2;
        }

        static int osszeg(int a, int b = 5)
        {
            return a + b;
        }

        static void csere(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
