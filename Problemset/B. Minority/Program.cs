namespace B._Minority
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1633/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string str = Console.ReadLine()!;

                //Console.Write("**************************** ");

                switch (str.Length)
                {
                    case 1:
                    case 2:
                        Console.WriteLine(0);
                        break;

                    default: /// Any size larger than 2 will go here
                        int numberOfZeros = str.Where(c => c == '0').Count();
                        int numberOfOnes = str.Where(c => c == '1').Count();

                        /// Both of them are right because if they are equal,
                        /// it doesn't matter which one to romeve from either zero or one
                        Console.WriteLine(numberOfZeros == numberOfOnes ? numberOfZeros - 1 :
                            Math.Min(numberOfZeros, numberOfOnes));
                        //Console.WriteLine(numberOfZeros == numberOfOnes ? numberOfOnes - 1 :
                        //    Math.Min(numberOfZeros, numberOfOnes));
                        break;
                }
            }
    }
}
