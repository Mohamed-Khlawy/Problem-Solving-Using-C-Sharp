namespace A._Average_Height
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1509/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfMembers = int.Parse(Console.ReadLine()!);

                int[] membersHeights = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                List<int> arrangedHeights = new List<int>();

                #region Problem Idea

                /// We will make the even heights from first and the odd heights from last.

                #endregion

                for (int i = 0; i < numberOfMembers; i++)
                {
                    if (membersHeights[i] % 2 == 0) /// Even Height
                    {
                        arrangedHeights.Insert(0, membersHeights[i]);
                    }

                    else /// Odd Height
                    {
                        arrangedHeights.Add(membersHeights[i]);
                    }
                }

                //Console.Write("************************ ");

                Console.WriteLine(string.Join(" ", arrangedHeights));
            }
        }
    }
}
