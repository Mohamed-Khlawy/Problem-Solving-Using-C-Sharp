namespace A._Life_Without_Zeros
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/75/A
        public static long DeleteZeros(long number)
        {
            List<long> withoutZeros = new List<long>();

            while (number != 0)
            {
                withoutZeros.Add(number % 10);
                number /= 10;
            }

            withoutZeros.RemoveAll(x => x == 0);

            withoutZeros.Reverse();

            return long.Parse(string.Join("", withoutZeros));
        }
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine()!);
            long secondNumber = long.Parse(Console.ReadLine()!);

            long sumBefore = firstNumber + secondNumber;

            firstNumber = DeleteZeros(firstNumber);
            secondNumber = DeleteZeros(secondNumber);
            sumBefore = DeleteZeros(sumBefore);

            long sumAfter = firstNumber + secondNumber;

            //Console.Write("****************************** ");

            Console.WriteLine(sumBefore == sumAfter ? "YES" : "NO");
        }
    }
}
