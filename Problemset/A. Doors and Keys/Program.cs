namespace A._Doors_and_Keys
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1644/A
        public static bool CanWeReachToPrincess(int RedDoor, int RedKey, int BlueDoor,
            int BlueKey, int GreenDoor, int GreenKey)
        {
            if (RedDoor > RedKey &&
                BlueDoor > BlueKey &&
                GreenDoor > GreenKey)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string doorsAndKeys = Console.ReadLine()!;

                int RedDoor = 0;
                int BlueDoor = 0;
                int GreenDoor = 0;

                int RedKey = 0;
                int BlueKey = 0;
                int GreenKey = 0;

                for (int i = 0; i < doorsAndKeys.Length; i++)
                {
                    switch (doorsAndKeys[i])
                    {
                        case 'R':
                            RedDoor = i;
                            break;

                        case 'r':
                            RedKey = i;
                            break;

                        case 'B':
                            BlueDoor = i;
                            break;

                        case 'b':
                            BlueKey = i;
                            break;

                        case 'G':
                            GreenDoor = i;
                            break;

                        case 'g':
                            GreenKey = i;
                            break;
                    }
                }

                //Console.Write("********************* ");

                Console.WriteLine(
                    CanWeReachToPrincess(RedDoor, RedKey, BlueDoor, BlueKey, GreenDoor, GreenKey) ?
                    "YES" : "NO");
            }
        }
    }
}
