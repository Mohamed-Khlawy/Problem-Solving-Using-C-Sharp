namespace A._Food_for_Animals
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1675/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int dog_food = input[0]; // a
                int cat_food = input[1]; // b
                int both_food = input[2]; // c
                int poly_dogs = input[3]; // x
                int poly_cats = input[4]; // y

                int dog_need = 0;
                int cat_need = 0;

                if (poly_dogs - dog_food <= 0)
                {
                    dog_need = 0;
                }

                else
                {
                    dog_need = poly_dogs - dog_food;
                }

                if (poly_cats - cat_food <= 0)
                {
                    cat_need = 0;
                }

                else
                {
                    cat_need = poly_cats - cat_food;
                }

                // Console.Write("***");

                if (dog_need + cat_need > both_food)
                {
                    Console.WriteLine("NO");
                }

                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
