namespace A._Strong_Password
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1997/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<char> password =
                    Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();

                if (password.Count > 1)
                {
                    bool doWeInsert = false;

                    for (int i = 1; i < password.Count; i++)
                    {
                        if (password[i] == password[i - 1])
                        {
                            if (password[i] != 'z')
                            {
                                password.Insert(i, 'z');
                            }

                            else
                            {
                                password.Insert(i, 'a');
                            }

                            doWeInsert = true;
                            break;
                        }
                    }

                    if (!doWeInsert)
                    {
                        if (password[0] != 'z')
                        {
                            password.Insert(0, 'z');
                        }

                        else
                        {
                            password.Insert(0, 'a');
                        }
                    }
                }

                else // If the Password Length is 1
                {
                    if (password[0] != 'z')
                    {
                        password.Insert(0, 'z');
                    }

                    else
                    {
                        password.Insert(0, 'a');
                    }
                }

                //Console.Write("*********************************************** ");

                for (int i = 0; i < password.Count; i++)
                {
                    Console.Write(password[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
