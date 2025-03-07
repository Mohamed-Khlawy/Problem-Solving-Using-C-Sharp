namespace A._Love_Triangle
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/939/A
        public static int CheckForLovelyTriangle(int planeIndex, int[] planes)
        {
            int loveIndex = planes[planeIndex] - 1;

            loveIndex = planes[loveIndex] - 1;

            loveIndex = planes[loveIndex] - 1;

            return loveIndex;
        }
        static void Main(string[] args)
        {
            int numberOfPlanes = int.Parse(Console.ReadLine()!);

            int[] planes = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            bool weLoveTrinagle = false;

            for (int i = 0; i < numberOfPlanes; i++)
            {
                int loveIndex = CheckForLovelyTriangle(i, planes);

                if (loveIndex == i)
                {
                    weLoveTrinagle = true;
                    break;
                }
            }

            //Console.Write("********************** ");

            Console.WriteLine(weLoveTrinagle ? "YES" : "NO");
        }
    }
}
