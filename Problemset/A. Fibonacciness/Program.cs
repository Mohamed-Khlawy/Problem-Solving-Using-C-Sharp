namespace A._Fibonacciness
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2060/A
        public static int CountFibonacciness(int thirdElement, ref int[] fiboArray)
        {
            fiboArray[2] = thirdElement;

            int fibonaccinessCounter = 0;

            if (fiboArray[0] + fiboArray[1] == fiboArray[2]) fibonaccinessCounter++;
            if (fiboArray[1] + fiboArray[2] == fiboArray[3]) fibonaccinessCounter++;
            if (fiboArray[2] + fiboArray[3] == fiboArray[4]) fibonaccinessCounter++;

            return fibonaccinessCounter;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int[] fiboArray = new int[5];

                fiboArray[0] = input[0]; /// First is First
                fiboArray[1] = input[1]; /// Second is Second
                /// Our Task to find Third FiboArray number 
                /// to maximize the Fibonacciness of this array
                fiboArray[3] = input[2]; /// Fourth is Third
                fiboArray[4] = input[3]; /// Fifth is Fourth

                int option1 = CountFibonacciness(fiboArray[0] + fiboArray[1], ref fiboArray);
                int option2 = CountFibonacciness(fiboArray[3] - fiboArray[1], ref fiboArray);
                int option3 = CountFibonacciness(fiboArray[4] - fiboArray[3], ref fiboArray);

                //Console.Write("******************** ");

                Console.WriteLine(Math.Max(option1, Math.Max(option2, option3)));
            }
        }
    }
}
