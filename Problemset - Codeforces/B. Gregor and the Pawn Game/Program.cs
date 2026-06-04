namespace B._Gregor_and_the_Pawn_Game
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1549/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int chessBoardSize = int.Parse(Console.ReadLine()!);

                char[] enemyPawns = Console.ReadLine()!.ToCharArray();  /// UP
                char[] gregorPawns = Console.ReadLine()!.ToCharArray(); /// DOWN

                int reached = 0;
                int availableMove = 0;
                int wantToMove = 0;

                for (int i = 0; i < chessBoardSize; i++)
                {
                    /// One of them should have 1.
                    if (enemyPawns[i] != '0' || gregorPawns[i] != '0')
                    {
                        /// If 1Up (Enemy) and 0Down (Gregor)
                        if (enemyPawns[i] == '1' && gregorPawns[i] == '0')
                        {
                            if (wantToMove == 1)
                            {
                                reached++;
                                wantToMove = 0;
                                availableMove = 0;
                            }

                            else availableMove = 1;
                        }

                        /// If 1Up (Enemy) and 1Down (Gregor)
                        else if (enemyPawns[i] == '1' && gregorPawns[i] == '1')
                        {
                            if (availableMove == 1 && wantToMove == 1)
                            {
                                reached += 2;
                                availableMove = 0;
                                wantToMove = 0;
                            }

                            else if (availableMove == 1)
                            {
                                reached++;
                            }

                            else if (i != chessBoardSize - 1)
                            {
                                wantToMove = 1;
                                availableMove = 1;
                            }
                        }

                        /// If 0Up (Enemy) and 1Down (Gregor)
                        else if (enemyPawns[i] == '0' && gregorPawns[i] == '1')
                        {
                            if (availableMove == 1)
                            {
                                reached++;
                                availableMove = 0;
                                wantToMove = 0;
                            }

                            else
                            {
                                reached++;
                            }
                        }
                    }

                    /// If 0UP and 0Down, Just reset counters
                    else
                    {
                        availableMove = 0;
                        wantToMove = 0;
                    }
                }

                if (availableMove == 1 && wantToMove == 1) reached++;

                //Console.Write("******************* ");

                Console.WriteLine(reached);
            }
        }
    }
}
