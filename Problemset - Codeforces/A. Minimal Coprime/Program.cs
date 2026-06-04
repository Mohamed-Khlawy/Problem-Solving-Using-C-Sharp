namespace A._Minimal_Coprime
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2063/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] inputSegement = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int leftOfSegement = inputSegement[0];  /// l
                int rightOfSegement = inputSegement[1]; /// r

                int numberOfMinimalCoprimeSegements =
                    rightOfSegement - leftOfSegement;

                //Console.Write("*************************** ");

                Console.WriteLine((numberOfMinimalCoprimeSegements == 0 && rightOfSegement == 1) ?
                    1 : numberOfMinimalCoprimeSegements);
            }
        }
    }
}
