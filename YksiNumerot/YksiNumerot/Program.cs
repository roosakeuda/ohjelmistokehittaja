namespace YksiNumerot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.WriteLine("11");
            Console.WriteLine("101");
            Console.WriteLine("1001");

            Console.Write("Anna y:n arvo: ");
            string y = Console.ReadLine();
            int x = 3;
            int uusiy = int.Parse(y);
            Console.WriteLine("Tulos = " + (x + uusiy));
        }
    }
}
