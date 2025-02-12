namespace C._Dominant_Piranha
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1433/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                int[] piranhas = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int maxPiranha = piranhas.Max();

                int DominantIndex = -1;

                for (int i = 0; i < size; i++)
                {
                    if (piranhas[i] == maxPiranha)
                    {
                        if ((i > 0 && piranhas[i - 1] < maxPiranha) ||
                            (i < size - 1 && piranhas[i + 1] < maxPiranha))
                        {
                            DominantIndex = i + 1;
                            break;
                        }
                    }
                }

                //Console.Write("*************************** ");

                Console.WriteLine(DominantIndex);
            }
        }
    }
}
