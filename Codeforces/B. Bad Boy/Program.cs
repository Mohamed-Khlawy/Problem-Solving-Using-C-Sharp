namespace B._Bad_Boy
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1537/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m_i_j = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int rows_of_room = n_m_i_j[0]; // n
                int cols_of_room = n_m_i_j[1]; // m
                int row_of_anton_cell = n_m_i_j[2]; // i
                int cols_of_anton_cell = n_m_i_j[3]; // j

                //Console.Write("****************************************** ");

                Console.WriteLine(1 + " " + 1 + " " + rows_of_room + " " + cols_of_room);
            }
        }
    }
}
