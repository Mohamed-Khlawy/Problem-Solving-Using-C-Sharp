namespace B._The_Corridor_or_There_and_Back_Again
{
    internal class Program
    {

        // Problem Link : https://codeforces.com/problemset/problem/1872/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfTraps = int.Parse(Console.ReadLine()!);

                int maxRoom = int.MaxValue;

                #region Problem Note
                /// Maybe the answer is complicated so to understand it, 
                /// you should draw one of the problem cases on a paper and iterate
                /// on the solution steps and you will understand it easily!
                #endregion

                for (int i = 0; i < numberOfTraps; i++)
                {
                    List<int> iTrap = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                    int trapPosition = iTrap[0]; /// Di
                    int trapTime = iTrap[1]; /// Si

                    int closingTime = trapPosition - 1 + trapTime;

                    closingTime -= trapPosition;

                    if (closingTime % 2 == 1)
                        closingTime--;

                    closingTime /= 2;

                    int tempMaxRoom = closingTime + trapPosition;

                    if (tempMaxRoom < maxRoom)
                        maxRoom = tempMaxRoom;
                }

                //Console.Write("********************************* ");

                Console.WriteLine(maxRoom);
            }
        }
    }
}
