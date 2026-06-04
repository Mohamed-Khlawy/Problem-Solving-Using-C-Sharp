namespace A._Olesya_and_Rodion
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/584/A
        static void Main(string[] args)
        {
            int[] Olesya_Rodion = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int Olesya = int.Parse(Olesya_Rodion[0].ToString());
            int Rodion = int.Parse(Olesya_Rodion[1].ToString());
            string solution = "";

            if (Rodion == 10)
            {
                if (Olesya == 1)
                {
                    Console.WriteLine(-1);
                    return;
                }

                else
                {
                    solution += 1;

                    for (int i = 0; i < Olesya - 1; i++)
                    {
                        solution += 0;
                    }

                    Console.WriteLine(solution);
                }
            }

            else
            {
                for (int i = 0; i < Olesya; i++)
                {
                    solution += Rodion;
                }

                Console.WriteLine(solution);
            }
        }
    }
}