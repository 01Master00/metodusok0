namespace metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kosonto();
            Console.WriteLine(osszeadas(18, 90));
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

    }
}
