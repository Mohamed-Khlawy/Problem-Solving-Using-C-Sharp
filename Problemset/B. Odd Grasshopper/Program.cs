namespace B._Odd_Grasshopper
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1607/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long initialPosition = input[0]; /// X0
                long numberOfJumps = input[1];    /// n

                //Console.Write("************************ ");

                switch (Math.Abs(initialPosition) % 2)
                {
                    case 0: /// Even Starting Position
                        switch (numberOfJumps % 4)
                        {
                            case 0: /// Mod = 0
                                Console.WriteLine(initialPosition);
                                break;

                            case 1: /// Mod = 1
                                Console.WriteLine(initialPosition - numberOfJumps);
                                break;

                            case 2: /// Mod = 2
                                Console.WriteLine(initialPosition + 1);
                                break;

                            case 3: /// Mod = 3
                                Console.WriteLine(initialPosition + 1 + numberOfJumps);
                                break;
                        }
                        break;


                    case 1: /// Odd Starting Position
                        switch (numberOfJumps % 4)
                        {
                            case 0: /// Mod = 0
                                Console.WriteLine(initialPosition);
                                break;

                            case 1: /// Mod = 1
                                Console.WriteLine(initialPosition + numberOfJumps);
                                break;

                            case 2: /// Mod = 2
                                Console.WriteLine(initialPosition - 1);
                                break;

                            case 3: /// Mod = 3
                                Console.WriteLine(initialPosition - 1 - numberOfJumps);
                                break;
                        }
                        break;
                }
            }
        }
    }
}
