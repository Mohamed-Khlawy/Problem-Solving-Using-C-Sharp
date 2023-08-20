namespace V._PUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPUMs = int.Parse(Console.ReadLine()!);
            int lastNumber = numberOfPUMs * 4;
            int counter_4 = 1;
            int number = 1;
            while (number <= lastNumber)
            {
                if(counter_4 != 4)
                {
                    Console.Write(number + " ");
                    number++;
                    counter_4++;
                }
                else
                {
                    Console.WriteLine("PUM");
                    number++;
                    counter_4 = 1;
                }
            }
        }
    }
}