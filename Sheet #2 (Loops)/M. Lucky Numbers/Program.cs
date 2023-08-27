namespace M._Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            string[] inputs = input.Split(' ');
            int number1 = int.Parse(inputs[0]);
            int number2 = int.Parse(inputs[1]);
            bool foundOneLucky = false;

            for (int i = number1; i <= number2; i++)
            {
                int copy_i = i;
                bool lucky = true;
                while (copy_i > 0)
                {
                    if (copy_i % 10 != 4 && copy_i % 10 != 7)
                    {
                        lucky = false;
                        break;
                    }
                    else
                    {
                        copy_i /= 10;
                    }
                }
                if (lucky)
                {
                    foundOneLucky = true;
                    Console.Write($"{i} ");
                }
            }
            if (!foundOneLucky)
            {
                Console.WriteLine(-1);
            }
        }
    }
}