namespace A._Business_trip
{
    internal class Program
    {
        //Proplem Link: https://codeforces.com/problemset/problem/149/A
        static void Main(string[] args)
        {
            int fewestCentimeters = int.Parse(Console.ReadLine()!);
            int[] growthForEachMounth = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Array.Sort(growthForEachMounth);

            int minNumberOfMounths = 0;
            int index = growthForEachMounth.Length - 1;

            while (fewestCentimeters > 0 && index >= 0)
            {
                fewestCentimeters -= growthForEachMounth[index];
                index--;
                minNumberOfMounths++;
            }

            if (fewestCentimeters <= 0)
            {
                Console.WriteLine(minNumberOfMounths);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}