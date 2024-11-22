namespace C._Sending_Messages
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1921/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long number_of_messages = input[0];
                long phone_charge = input[1];
                long lose_with_time = input[2];
                long lose_with_close = input[3];

                List<long> messages = Console.ReadLine()!.Split().Select(long.Parse).ToList();

                messages.Insert(0, 0);

                bool all_messages_will_be_sent = true;

                for (int i = 1; i < messages.Count; i++)
                {
                    long time_lose = (messages[i] - messages[i - 1]) * lose_with_time;

                    long min_betwenn_time_and_close = Math.Min(time_lose, lose_with_close);

                    if (min_betwenn_time_and_close < phone_charge)
                    {
                        phone_charge -= min_betwenn_time_and_close;
                    }

                    else
                    {
                        all_messages_will_be_sent = false;
                        break;
                    }
                }

                if (all_messages_will_be_sent)
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
