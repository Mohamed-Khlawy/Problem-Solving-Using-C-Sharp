namespace A._Space_Navigation
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1481/A
        public static bool CheckForUpAndDownOrders
            (int yPosition, int upCounter, int downCounter)
        {
            if (yPosition >= 0 && upCounter >= yPosition) return true;

            if (yPosition < 0 && downCounter >= Math.Abs(yPosition)) return true;

            return false;
        }
        public static bool CheckForLeftAndRightOrders
            (int xPosition, int leftCounter, int rightCounter)
        {
            if (xPosition >= 0 && rightCounter >= xPosition) return true;

            if (xPosition < 0 && leftCounter >= Math.Abs(xPosition)) return true;

            return false;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] planetCoordinates =
                    Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

                int planetX = planetCoordinates[0]; /// x
                int planetY = planetCoordinates[1]; /// y

                char[] orders = Console.ReadLine()!.ToCharArray();

                int upCounter = 0;    /// U
                int downCounter = 0;  /// D
                int leftCounter = 0;  /// L
                int rightCounter = 0; /// R

                foreach (int order in orders)
                {
                    switch (order)
                    {
                        case 'U':
                            upCounter++;
                            break;

                        case 'D':
                            downCounter++;
                            break;

                        case 'L':
                            leftCounter++;
                            break;

                        case 'R':
                            rightCounter++;
                            break;
                    }
                }

                bool weCanReachPlanet =
                    CheckForUpAndDownOrders(planetY, upCounter, downCounter) &&
                    CheckForLeftAndRightOrders(planetX, leftCounter, rightCounter);

                //Console.Write("********************** ");

                Console.WriteLine(weCanReachPlanet ? "YES" : "NO");
            }
        }
    }
}
