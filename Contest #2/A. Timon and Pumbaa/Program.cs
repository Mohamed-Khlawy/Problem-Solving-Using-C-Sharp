namespace A._Timon_and_Pumbaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            string[] inputArray = input.Split(' ');

            int timonCandies = int.Parse(inputArray[0]);
            int pumbaaCandies = int.Parse(inputArray[1]);

            if (timonCandies - pumbaaCandies >= 0)
            {
                Console.WriteLine(timonCandies - pumbaaCandies);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}