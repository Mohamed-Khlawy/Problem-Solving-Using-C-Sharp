namespace A._Common_Subsequence
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1382/A
        public static void MakeArray1TheBiggest(ref int[] array1, ref int[] array2)
        {
            if (array1.Length < array2.Length)
                (array1, array2) = (array2, array1);
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] inputSizes = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int array1Size = inputSizes[0];
                int array2Size = inputSizes[1];


                int[] array1Numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                int[] array2Numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                /// Always make array1 is the Bigger
                MakeArray1TheBiggest(ref array1Numbers, ref array2Numbers);

                int firstCommonNumber = 0;

                for (int i = 0; i < array1Numbers.Length; i++)
                {
                    for (int j = 0; j < array2Numbers.Length; j++)
                    {
                        if (array1Numbers[i] == array2Numbers[j])
                        {
                            firstCommonNumber = array1Numbers[i];
                            break;
                        }
                    }
                }

                //Console.WriteLine("************************* ");

                Console.WriteLine(firstCommonNumber != 0 ? $"YES \n1 {firstCommonNumber}" : "NO");

                //Console.WriteLine("************************* ");
            }
        }
    }
}
