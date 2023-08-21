namespace A._Twins
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/160/A
        static void Main(string[] args)
        {
            int numberOfCoins = int.Parse(Console.ReadLine()!);

            string input = Console.ReadLine()!;
            string[] elements = input.Split(' ');
            int[] coins = new int[numberOfCoins];

            int totalCoins = 0;//To know total number of coins
            int halfOfTotal;//To get the half of total
            int myTotalCoins = 0;//To try to be more than half of total
            int myNumberOfCoins = 0;//To get number of coins until i get more than half

            for (int i = 0; i < numberOfCoins; i++)
            {
                coins[i] = int.Parse(elements[i]);
                totalCoins += coins[i];
            }

            halfOfTotal = totalCoins / 2;

            //Sort coins to iterate on it from (back) until i get more than half coins
            Array.Sort(coins);

            for (int i = coins.Length - 1; i >= 0; i--)
            {
                if (myTotalCoins <= halfOfTotal)
                {
                    //Still didn't get more than half
                    myTotalCoins += coins[i];
                    myNumberOfCoins++;
                }
                else
                {
                    //Already got more than half so we break, and print number of coins
                    //that i needed to get more than half
                    break;
                }
            }

            Console.WriteLine(myNumberOfCoins);
        }
    }
}