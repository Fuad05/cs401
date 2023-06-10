namespace sual3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con=Console.ReadLine();
            int m=int.Parse(con);
            int n = int.Parse(Console.ReadLine());

            double t = Math.Pow(m, n);
            Console.WriteLine(t);
            
        }
    }
}
