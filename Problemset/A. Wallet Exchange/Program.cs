namespace A._Wallet_Exchange
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1919/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] alice_bob = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int alice_wallet = alice_bob[0];
                int bob_wallet = alice_bob[1];

                // Based on that Alice will start with the first turn:
                // If the sum of the 2 wallets is EVEN ==> Bob Wins
                // If the sum of the 2 wallets is ODD  ==> Alice Wins

                // Console.Write("***");

                // If both wallets is Even or both wallets is Odd ==> Summation is EVEN
                if ((alice_wallet % 2 != 0 && bob_wallet % 2 != 0) ||
                    (alice_wallet % 2 == 0 && bob_wallet % 2 == 0))
                {
                    Console.WriteLine("Bob");
                }

                // If a wallet is Even and the other wallet is Odd ==> Summation is ODD
                else
                {
                    Console.WriteLine("Alice");
                }
            }
        }
    }
}
