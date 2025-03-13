namespace A._Alex_and_a_Rhombus
{
    internal class Program
    {
        // Proble Link : https://codeforces.com/problemset/problem/1180/A
        static void Main(string[] args)
        {
            int orderRhombus = int.Parse(Console.ReadLine()!);

            int totalCells = (orderRhombus * 2) - 1; /// Middle row of the Rhombus

            for (int i = 0; i < orderRhombus - 1; i++)
            {
                int rowCells = ((i * 2) + 1) * 2;

                totalCells += rowCells;
            }

            //Console.Write("****************** ");

            Console.WriteLine(totalCells);
        }
    }
}
