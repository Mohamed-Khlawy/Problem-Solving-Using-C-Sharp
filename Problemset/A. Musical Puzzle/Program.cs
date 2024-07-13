namespace A._Musical_Puzzle
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1833/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int melody_size = int.Parse(Console.ReadLine()!);

                string melody = Console.ReadLine()!;

                if (melody_size == 2)
                {
                    Console.WriteLine(1);
                }

                else
                {
                    List<string> sub_melodies = new List<string>();

                    for (int i = 0; i < melody_size - 2; i++)
                    {
                        // string sub_melody1 = melody[i].ToString() + melody[i + 1].ToString();
                        string sub_melody1 = $"{melody[i]}{melody[i + 1]}";
                        // string sub_melody2 = melody[i + 1].ToString() + melody[i + 2].ToString();
                        string sub_melody2 = $"{melody[i + 1]}{melody[i + 2]}";

                        if (sub_melodies.Where(x => x == sub_melody1).Count() == 0)
                        {
                            sub_melodies.Add(sub_melody1);
                        }

                        if (sub_melodies.Where(x => x == sub_melody2).Count() == 0)
                        {
                            sub_melodies.Add(sub_melody2);
                        }
                    }

                    // Console.Write("*** ");
                    Console.WriteLine(sub_melodies.Count);
                }
            }
        }
    }
}
