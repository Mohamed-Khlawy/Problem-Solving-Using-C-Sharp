namespace B._osu_mania
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2009/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_rows = int.Parse(Console.ReadLine()!);

                List<int> notes = new List<int>();

                for (int i = 0; i < number_of_rows; i++)
                {
                    string row_input = Console.ReadLine()!;

                    int note_column = row_input.IndexOf('#');

                    notes.Add(note_column + 1);
                }

                notes.Reverse();

                //Console.WriteLine("*********************************");

                for (int i = 0; i < notes.Count; i++)
                {
                    if (i == notes.Count - 1)
                    {
                        Console.WriteLine(notes[i]);
                    }

                    else
                    {
                        Console.Write(notes[i] + " ");
                    }
                }

                //Console.WriteLine("*********************************");
            }
        }
    }
}
