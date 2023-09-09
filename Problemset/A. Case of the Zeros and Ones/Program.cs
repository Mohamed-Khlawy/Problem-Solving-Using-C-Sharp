namespace A._Case_of_the_Zeros_and_Ones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            string inputString = Console.ReadLine()!;

            List<int> number = new List<int>();

            for (int i = 0; i < size; i++)
            {
                number.Add(int.Parse(inputString[i].ToString()));
            }

            long counterForOne = 0;
            long counterForZero = 0;

            foreach (int element in number)
            {
                if (element == 1)
                {
                    counterForOne++;
                }
                else if (element == 0)
                {
                    counterForZero++;
                }
            }

            Console.WriteLine(Math.Abs(counterForZero - counterForOne));
        }
    }
}