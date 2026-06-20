namespace A._Arrival_of_the_General
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/144/A
        static void Main(string[] args)
        {
            int numberOfSoldiers = int.Parse(Console.ReadLine()!);
            string input = Console.ReadLine()!;
            string[] inputArray = input.Split(' ');
            int[] soldiers = new int[numberOfSoldiers];

            int maxHeight = 1;//Max soldier height
            int minHeight = 100;//Min soldier height,intialized with max height to go down until found min 
            int indexOfMaxHeight = 0;//Index of Max soldier height
            int indexOfMinHeight = 0;//Index of Min soldier height
            int movesCounter = 0;//Number of moves untill finish
            bool meetMax_Min = false;//if max index and min index meet

            for (int i = 0; i < numberOfSoldiers; i++)
            {
                soldiers[i] = int.Parse(inputArray[i]);

                if (soldiers[i] > maxHeight)
                {
                    maxHeight = soldiers[i];
                    indexOfMaxHeight = i;
                }

                if (soldiers[i] <= minHeight)
                {
                    minHeight = soldiers[i];
                    indexOfMinHeight = i;
                }
            }

            while (indexOfMaxHeight != 0 || indexOfMinHeight != soldiers.Length - 1)
            {
                //max index and min index meet
                if (indexOfMinHeight == indexOfMaxHeight - 1 && !meetMax_Min)
                {
                    meetMax_Min = true;
                    indexOfMaxHeight--;
                    indexOfMinHeight++;
                    movesCounter++;
                    //continue;
                }

                //they didn't meet so each index will be checked individually
                else
                {
                    if (indexOfMaxHeight != 0)
                    {
                        indexOfMaxHeight--;
                        movesCounter++;
                    }

                    if (indexOfMinHeight != soldiers.Length - 1)
                    {
                        indexOfMinHeight++;
                        movesCounter++;
                    }
                }

                if (indexOfMaxHeight == indexOfMinHeight)
                //Splution of test 6
                //10
                //68 47 67 29 63 71 71 65 54 56                                    
                {
                    movesCounter--;
                }
            }

            Console.WriteLine(movesCounter);
        }
    }
}