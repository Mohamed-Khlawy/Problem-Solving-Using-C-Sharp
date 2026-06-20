namespace A._Twice
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2037/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> presents = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int[] presents_frequency = new int[size + 1];

                int presents_counter = 0;

                for (int i = 0; i < size; i++)
                {
                    presents_frequency[presents[i]]++;
                }

                for (int i = 1; i <= size; i++)
                {
                    presents_counter += presents_frequency[i] / 2;
                }

                //Console.Write("************************************** ");

                Console.WriteLine(presents_counter);
            }
        }
    }
}
