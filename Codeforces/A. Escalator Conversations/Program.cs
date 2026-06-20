namespace A._Escalator_Conversations
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1851/A
        static bool CanHaveConversation(int vlad_height, int person_height, int number_of_steps,
            int steps_height_difference)
        {
            int height_difference = Math.Abs(vlad_height - person_height);

            if (height_difference % steps_height_difference == 0)
            {
                height_difference /= steps_height_difference;

                if (height_difference > 0 && height_difference < number_of_steps)
                {
                    return true;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m_k_H = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_people = n_m_k_H[0]; // n
                int number_of_steps = n_m_k_H[1]; // m
                int steps_height_difference = n_m_k_H[2]; // k
                int vlad_height = n_m_k_H[3]; // H

                List<int> people_heights = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int people_to_conversate_with = 0;

                for (int i = 0; i < people_heights.Count; i++)
                {
                    if (CanHaveConversation(vlad_height, people_heights[i],
                                            number_of_steps, steps_height_difference))
                    {
                        people_to_conversate_with++;
                    }
                }

                //Console.Write("*************************************** ");

                Console.WriteLine(people_to_conversate_with);
            }
        }
    }
}
