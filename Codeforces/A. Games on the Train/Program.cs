namespace A._Games_on_the_Train
{
    internal class Program
    {
        public static int[] GetMaxAndMinHeights(int[] towers)
        {
            int[] result = new int[2];

            result[0] = towers[0]; // Initialize max height
            result[1] = towers[0]; // Initialize min height

            for (int i = 1; i < towers.Length; i++)
            {
                if (towers[i] > result[0])
                {
                    result[0] = towers[i]; // Update max height
                }

                else if (towers[i] < result[1])
                {
                    result[1] = towers[i]; // Update min height
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfTowers = int.Parse(Console.ReadLine()!);

                int[] towers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int[] maxAndMinHeights = GetMaxAndMinHeights(towers);

                int maxHeight = maxAndMinHeights[0];
                int minHeight = maxAndMinHeights[1];

                int requiredValue = maxHeight + 1 - minHeight;

                //Console.Write("*****************");
                Console.WriteLine(requiredValue);
            }
        }
    }
}
