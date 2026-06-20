namespace A._Mezo_Playing_Zoma
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1285/A
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine()!);

            string mezoCommands = Console.ReadLine()!;

            // Add the 0_position if no command is successed
            Console.WriteLine(numberOfCommands + 1);

            #region HardWay
            //int RCounter = mezoCommands.Where(command => command == 'R').Count();

            //int LCounter = mezoCommands.Where(command => command == 'L').Count();

            ////Console.Write("*********************************** ");

            //if (RCounter == 0)
            //{
            //    Console.WriteLine(LCounter + 1);
            //}

            //else if (LCounter == 0)
            //{
            //    Console.WriteLine(RCounter + 1);
            //}

            //else
            //{
            //    Console.WriteLine(LCounter + RCounter + 1);
            //}
            #endregion
        }
    }
}
