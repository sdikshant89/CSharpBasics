namespace CshrpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Could've been done without using namespace and class
            // Just Console.WriteLine and it would work
            Console.WriteLine("Hello, World!");
            System.Console.WriteLine("Using System Package");
            Console.WriteLine("\n");

            // If the strings aren't actual numbers, say they have characters too, the functions below would throw error
            Console.WriteLine("Converted string to int " + System.Convert.ToInt32("-25"));
            Console.WriteLine("Converted string to long " + System.Convert.ToInt64("-900000000"));
            Console.WriteLine("Converted string to double " + System.Convert.ToDouble("-26.8"));
            Console.WriteLine("Converted string to Float " + System.Convert.ToSingle("-1.04569"));

            int a = 23;
            decimal b = -12.45745623M;
            Console.Write("\nType of number when an int and decimal is added: " + (a + b).GetType());
            Console.Write("\nType of number when a string and int is added: " + ("string" + 10).GetType());

            Console.WriteLine("\n" + string.Format("{0: 0.00} {1: 1.#}", 7.85923789243, 1.2568));
        }
    }
}