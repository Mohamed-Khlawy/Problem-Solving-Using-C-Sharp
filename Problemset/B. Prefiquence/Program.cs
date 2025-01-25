namespace B._Prefiquence
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1968/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] listSizes = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int list1Size = listSizes[0];
                int list2Size = listSizes[1];

                List<char> list1 = Console.ReadLine()!
                                  .Select(c => char.Parse(c.ToString()))
                                  .ToList();
                List<char> list2 = Console.ReadLine()!
                                  .Select(c => char.Parse(c.ToString()))
                                  .ToList();

                int pointer1 = 0;
                int pointer2 = 0;

                while (pointer1 != list1Size && pointer2 != list2Size)
                {
                    if (list1[pointer1] == list2[pointer2])
                    {
                        pointer1++;
                        pointer2++;
                    }

                    else
                    {
                        pointer2++;
                    }
                }

                //Console.Write("******************************** ");

                Console.WriteLine(pointer1);
            }
        }
    }
}
