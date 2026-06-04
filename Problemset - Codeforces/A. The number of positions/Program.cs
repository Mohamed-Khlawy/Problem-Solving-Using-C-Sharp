namespace A._The_number_of_positions
{
    internal class Program
    {
        //Proplem Link: https://codeforces.com/problemset/problem/124/A
        static void Main(string[] args)
        {
            int[] people_front_behind = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int people = people_front_behind[0];
            int front = people_front_behind[1];
            int behind = people_front_behind[2];

            if (people - front > behind)
            {
                Console.WriteLine(behind + 1);
            }
            else
            {
                Console.WriteLine(people - front);
            }
        }
    }
}