namespace A._Tanya_and_Stairways
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1005/A
        static void Main(string[] args)
        {
            int pronouncedNumbers = int.Parse(Console.ReadLine()!);

            int[] numbers = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            int numberOfStairways = 1;

            int lastStart = 0;

            List<int> stariwaysSteps = new List<int>();

            for (int i = 1; i < pronouncedNumbers; i++)
            {
                if (numbers[i] == 1)
                {
                    numberOfStairways++;

                    int currentStairwaySteps = i - lastStart;

                    lastStart = i;

                    stariwaysSteps.Add(currentStairwaySteps);
                }

                if (i == pronouncedNumbers - 1)
                {
                    stariwaysSteps.Add(numbers[i]);
                }
            }

            //Console.WriteLine("**************************************");

            string stepsString = string.Join(" ", stariwaysSteps);

            if (stepsString.Length == 0)
            {
                stepsString = "1";
            }

            Console.WriteLine($"{numberOfStairways}\n{stepsString}");

            //Console.WriteLine("**************************************");
        }
    }
}
