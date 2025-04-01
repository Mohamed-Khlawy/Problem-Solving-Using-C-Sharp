namespace B._MEXor_Mixup
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1567/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] MEX_XOR = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int neededMEX = MEX_XOR[0];
                int neededXOR = MEX_XOR[1];

                int XOR_result = ((neededMEX - 1) % 4) switch
                {
                    0 => neededMEX - 1,
                    1 => 1,
                    2 => neededMEX,
                    _ => 0 /// 3
                };

                //Console.Write("************************ ");

                if (XOR_result == neededXOR) Console.WriteLine(neededMEX);

                else if ((XOR_result ^ neededXOR) != neededMEX) Console.WriteLine(neededMEX + 1);

                else Console.WriteLine(neededMEX + 2);
            }
        }
    }
}
