namespace A._Satisfying_Constraints
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1920/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfConstrains = int.Parse(Console.ReadLine()!);

                List<int> DontTakeMe = new List<int>();

                int minElement = int.MinValue; /// First Element in the Interval
                int maxElement = int.MaxValue; /// Last Element in the Interval

                int neededIntegers = 0;

                for (int i = 0; i < numberOfConstrains; i++)
                {
                    List<int> iConstrain = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                    int constrainType = iConstrain[0];

                    int constrainValue = iConstrain[1];

                    switch (constrainType)
                    {
                        case 1: /// Greater Than or Equal Constraint, Work with minElement
                            if (constrainValue > minElement)
                            {
                                minElement = constrainValue;
                            }
                            break;

                        case 2: /// Less Than or Equal Constraint, Work with maxElement
                            if (constrainValue < maxElement)
                            {
                                maxElement = constrainValue;
                            }
                            break;

                        case 3: /// Not Equal Constraint
                            DontTakeMe.Add(constrainValue);
                            break;
                    }
                }

                if (maxElement - minElement + 1 > 0)
                {
                    neededIntegers = maxElement - minElement + 1;

                    for (int i = 0; i < DontTakeMe.Count; i++)
                    {
                        if (DontTakeMe[i] >= minElement && DontTakeMe[i] <= maxElement)
                        {
                            neededIntegers--;
                        }
                    }
                }

                //Console.Write("*************************************** ");

                Console.WriteLine(neededIntegers);
            }
        }
    }
}
