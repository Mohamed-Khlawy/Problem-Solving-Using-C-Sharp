namespace A._Quintomania
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2036/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int melody_notes = int.Parse(Console.ReadLine()!);

                List<int> notes = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                bool isMelodyPerfect = true;

                for (int i = 1; i < notes.Count; i++)
                {
                    if (Math.Abs(notes[i] - notes[i - 1]) != 5 &&
                        Math.Abs(notes[i] - notes[i - 1]) != 7)
                    {
                        isMelodyPerfect = false;
                        break;
                    }
                }

                if (isMelodyPerfect)
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
