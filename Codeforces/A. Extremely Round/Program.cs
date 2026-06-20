namespace A._Extremely_Round
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1766/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> number = Console.ReadLine()!
                    .Select(digit => int.Parse(digit.ToString())).ToList();

                int extremelyRounded = 0;

                if (number.Count == 1)
                {
                    extremelyRounded = number[0];
                }

                else
                {
                    extremelyRounded = 9 + ((number.Count - 2) * 9) + number[0];
                }

                //Console.Write("***************** ");

                Console.WriteLine(extremelyRounded);
            }
        }
    }
}
