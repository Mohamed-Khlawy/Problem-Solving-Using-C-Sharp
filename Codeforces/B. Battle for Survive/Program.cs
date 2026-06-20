namespace B._Battle_for_Survive
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2013/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfFighters = int.Parse(Console.ReadLine()!);

                long[] fighters = Array.ConvertAll(Console.ReadLine()!.Split(' '), long.Parse);

                #region Problem Idea

                /// Subtract all figters ratings from 1 to n - 2 fighter from the n - 1 fighter.
                /// Then subtract the result from the nth fighter, 
                /// to get the rating of the last fighter.
                
                #endregion

                long allFightsExceptLast =
                    fighters[^2] - fighters.Take(numberOfFighters - 2).Sum();

                long lastFighterRating = fighters[^1] - allFightsExceptLast;

                //Console.Write("*********************** ");

                Console.WriteLine(lastFighterRating);
            }
        }
    }
}
