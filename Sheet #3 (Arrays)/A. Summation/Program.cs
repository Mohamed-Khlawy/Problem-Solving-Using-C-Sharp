namespace A._Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            long sum = 0;

            for(int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > 0)
                {
                    sum += numbersArray[i];
                }
                else if (numbersArray[i] < 0)
                {
                    sum += numbersArray[i];
                }
            }

            Console.WriteLine(Math.Abs(sum));
        }
    }
}