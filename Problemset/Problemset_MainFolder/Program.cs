using System.Data.Common;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
                List<char> charsOfWord = 
                    Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();

                List<char> capitalCharsIndices = new List<char>();
                List<char> smallCharsIndices = new List<char>();
                
                for (int i = 0; i < charsOfWord.Count; i++)
                {
                    switch (charsOfWord[i])
                    {
                        case 'b':
                            charsOfWord.RemoveAt(i);
                            i--;
                            
                            if (smallCharsIndices.Count > 0)
                            {
                                charsOfWord.RemoveAt(charsOfWord.LastIndexOf(smallCharsIndices[^1], i));
                                i--;
                                smallCharsIndices.RemoveAt(smallCharsIndices.Count - 1);
                            }

                            break;

                        case 'B':
                            charsOfWord.RemoveAt(i);
                            i--;
                            
                            if (capitalCharsIndices.Count > 0)
                            {
                                charsOfWord.RemoveAt(charsOfWord.LastIndexOf(capitalCharsIndices[^1], i));
                                i--;
                                capitalCharsIndices.RemoveAt(capitalCharsIndices.Count - 1);
                            }

                            break;

                        default:
                            if (char.IsLower(charsOfWord[i])) /// Lower Case Char
                            {
                                smallCharsIndices.Add(charsOfWord[i]);
                            }

                            else /// Upper Case Char
                            {
                                capitalCharsIndices.Add(charsOfWord[i]);
                            }
                            break;
                    }
                }

                //Console.Write("******************** ");

                Console.WriteLine(string.Join("", charsOfWord));
            }
        }
    }
}