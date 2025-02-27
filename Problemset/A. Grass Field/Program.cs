namespace A._Grass_Field
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1701/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> row1 = Console.ReadLine()!.Split().Select(int.Parse).ToList();
                List<int> row2 = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int numberOfZeros = row1.Where(number => number == 0).Count() +
                                    row2.Where(number => number == 0).Count();

                //Console.Write("************************* ");

                switch (numberOfZeros)
                {
                    case 0:
                        Console.WriteLine(2);
                        break;

                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine(1);
                        break;

                    case 4:
                        Console.WriteLine(0);
                        break;
                }
            }
        }
    }
}
