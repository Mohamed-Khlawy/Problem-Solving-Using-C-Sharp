using System.Diagnostics;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problemset_MainFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_cells = n_k[0]; // n
                int consecutive_black_cells = n_k[1]; // k

                List<char> cells = Console.ReadLine()!
                                  .Select(c => char.Parse(c.ToString())).ToList();

                int min_repainted_from_W_to_B = 0;

                int left_index;
                int right_index;

                for (int i = 0; i <= cells.Count - consecutive_black_cells; i++)
                {
                    left_index = i;
                    right_index = i + consecutive_black_cells - 1;

                    int min_in_substr = 0;

                    if (left_index == 0)
                    {
                        for (int j = 0; j <= right_index; j++)
                        {
                            if (cells[j] == 'W')
                            {
                                min_in_substr++;
                            }
                        }

                        min_repainted_from_W_to_B = min_in_substr;
                    }

                    else
                    {
                        min_in_substr = min_repainted_from_W_to_B;

                        if (cells[left_index - 1] == 'W')
                        {
                            min_in_substr--;
                        }

                        if (cells[right_index] == 'W')
                        {
                            min_in_substr++;
                        }


                        if (min_repainted_from_W_to_B > min_in_substr && 
                            min_in_substr >= 0)
                        {
                            min_repainted_from_W_to_B = min_in_substr;
                        }
                    }


                    //for (int j = i; j < i + consecutive_black_cells; j++)
                    //{
                    //    if (cells[j] == 'W')
                    //    {
                    //        min_in_substr++;
                    //    }
                    //}

                    
                }

                Console.WriteLine(min_repainted_from_W_to_B);
            }
        }
    }
}