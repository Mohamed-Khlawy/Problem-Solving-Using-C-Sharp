namespace A._Shifting_Stacks
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1486/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfStacks = int.Parse(Console.ReadLine()!);

                long[] stacksHeights = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                bool weCanDoIt = true;

                long additionalBlocks = 0;

                for (int i = 0; i < numberOfStacks; i++)
                {
                    if (stacksHeights[i] >= i)
                    {
                        additionalBlocks += stacksHeights[i] - i;
                    }

                    else
                    {
                        if (additionalBlocks >= i - stacksHeights[i])
                        {
                            additionalBlocks -= i - stacksHeights[i];
                        }

                        else
                        {
                            weCanDoIt = false;
                            break;
                        }
                    }
                }

                //Console.Write("********************* ");

                Console.WriteLine(weCanDoIt ? "YES" : "NO");
            }
        }
    }
}
