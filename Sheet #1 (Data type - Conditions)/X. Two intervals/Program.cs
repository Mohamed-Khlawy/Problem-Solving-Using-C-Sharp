namespace X._Two_intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            int l1 = int.Parse(elements[0]);
            int r1 = int.Parse(elements[1]);
            int l2 = int.Parse(elements[2]);
            int r2 = int.Parse(elements[3]);
            int a, b;

            if (r1 < l2 || r2 < l1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                if (l1 > l2)
                {
                    a = l1;
                }
                else
                {
                    a = l2;
                }
                if (r1 < r2)
                {
                    b = r1;
                }
                else
                {
                    b = r2;
                }
                Console.WriteLine(a + " " + b);
            }
        }
    }
}