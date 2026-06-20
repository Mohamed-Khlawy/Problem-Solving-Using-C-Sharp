namespace A._Greg_s_Workout
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/255/A
        static void Main(string[] args)
        {
            int number_of_exercises = int.Parse(Console.ReadLine()!);

            List<int> exercises = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int[] muscles = new int[3];
            // Zero Index   ==> Chest Muscle
            // First Index  ==> Biceps Muscle
            // Second Index ==> Back Muscle

            int max_training_for_muscle = 0;
            int max_muscle_index = 0;

            for (int i = 0; i < number_of_exercises; i++)
            {
                switch (i % 3)
                {
                    case 0:
                        muscles[0] += exercises[i];

                        if (muscles[0] > max_training_for_muscle)
                        {
                            max_training_for_muscle = muscles[0];
                            max_muscle_index = 0;
                        }
                        break;

                    case 1:
                        muscles[1] += exercises[i];

                        if (muscles[1] > max_training_for_muscle)
                        {
                            max_training_for_muscle = muscles[1];
                            max_muscle_index = 1;
                        }
                        break;

                    case 2:
                        muscles[2] += exercises[i];

                        if (muscles[2] > max_training_for_muscle)
                        {
                            max_training_for_muscle = muscles[2];
                            max_muscle_index = 2;
                        }
                        break;
                }
            }

            //Console.Write("************************************ ");

            switch (max_muscle_index)
            {
                case 0:
                    Console.WriteLine("chest");
                    break;
                case 1:
                    Console.WriteLine("biceps");
                    break;
                case 2:
                    Console.WriteLine("back");
                    break;
            }
        }
    }
}
