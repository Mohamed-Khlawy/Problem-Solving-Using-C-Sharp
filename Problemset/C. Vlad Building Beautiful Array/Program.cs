namespace C._Vlad_Building_Beautiful_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1833/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(numbers);

                bool weCanDoIt = true;

                #region Problem Idea

                /// If the lowest number in the array is odd,
                /// so we can generate a beautiful array from this array,
                /// so we will check in the case if the lowest number was even,
                /// and if we find at least one odd number we won't be able to generate
                /// beautiful array from this array

                #endregion

                if (numbers[0] % 2 == 0)
                {
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            weCanDoIt = false;
                            break;
                        }
                    }
                }

                //Console.Write("************************** ");

                Console.WriteLine(weCanDoIt ? "YES" : "NO");
            }
        }
    }
}
