namespace E._Hady_Rides_the_Train
{
    internal class Program
    {
        // This was hard but i got it alone
        static void Main(string[] args)
        {
            long seatIndex = long.Parse(Console.ReadLine()!);
            long rowIndex = seatIndex / 4;
            long columnIndex;

            if (rowIndex % 2 == 0)
            {
                columnIndex = seatIndex % 4;
            }
            else
            {
                columnIndex = 3 - (seatIndex % 4);
            }

            Console.WriteLine(rowIndex.ToString("F0") + " " + columnIndex);
        }
    }
}