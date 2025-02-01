namespace A._Lunch_Rush
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/276/A
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int numberOfResturants = input[0]; /// n
            int coachTime = input[1];          /// k

            int maxJoyValue = int.MinValue;

            for (int i = 0; i < numberOfResturants; i++)
            {
                List<int> iResturant = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int resutrantJoy = iResturant[0];  /// f
                int resturantTime = iResturant[1]; /// t

                int tempJoy = 0;

                if (resturantTime > coachTime)
                {
                    tempJoy = resutrantJoy - (resturantTime - coachTime);
                }

                else
                {
                    tempJoy = resutrantJoy;
                }

                maxJoyValue = tempJoy > maxJoyValue ? tempJoy : maxJoyValue;
            }

            //Console.Write("************************* ");

            Console.WriteLine(maxJoyValue);
        }
    }
}
