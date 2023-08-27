namespace B._Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            int first = int.Parse(elements[0]);
            
            if (first <= 1)
            {
                Console.WriteLine(-1);
                return;
            }
            for (int i = 2; i <= first; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}