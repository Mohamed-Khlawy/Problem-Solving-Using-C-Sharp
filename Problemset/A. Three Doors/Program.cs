namespace A._Three_Doors
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1709/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int key_on_hand = int.Parse(Console.ReadLine()!);

                List<int> remaining_keys = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<int> keys_found = new List<int>();

                keys_found.Add(key_on_hand);

                for (int i = 0; i < remaining_keys.Count; i++)
                {
                    if (remaining_keys[key_on_hand - 1] != 0)
                    {
                        keys_found.Add(remaining_keys[key_on_hand - 1]);
                        key_on_hand = remaining_keys[key_on_hand - 1];
                    }

                    else
                    {
                        break;
                    }
                }

                if (keys_found.Contains(1) &&
                    keys_found.Contains(2) &&
                    keys_found.Contains(3))
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
