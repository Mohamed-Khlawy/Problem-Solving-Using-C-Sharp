namespace B._Having_Been_a_Treasurer_in_the_Past__I_Help_Goblins_Deceive
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2072/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int goblinStringSize = int.Parse(Console.ReadLine()!);

                char[] goblinString = Console.ReadLine()!.ToCharArray();

                int upCharCount = goblinString.Count(ch => ch == '-');
                int downCharCount = goblinStringSize - upCharCount;

                long maxNumberOfFaces =
                    (long)Math.Floor((decimal)upCharCount / 2)
                    * (long)Math.Ceiling((decimal)upCharCount / 2)
                    * downCharCount;

                //Console.Write("************************ ");

                Console.WriteLine(maxNumberOfFaces);
            }
        }
    }
}
