namespace A._Halloumi_Boxes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1903/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_boxes = n_k[0];
                int max_reverse = n_k[1];

                List<int> boxes = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<int> copy_boxes = new List<int>(boxes);

                boxes.Sort();

                for (int i = 0; i <= copy_boxes.Count - max_reverse; i++)
                {
                    int start_index = i;
                    int end_index = i + max_reverse - 1;

                    List<int> sub_list = copy_boxes.
                                        Skip(start_index).
                                        Take(end_index - start_index + 1).
                                        ToList();

                    List<int> copy_sub_list = new List<int>(sub_list);

                    sub_list.Sort();

                    if (!sub_list.SequenceEqual(copy_sub_list))
                    {
                        copy_boxes.RemoveRange(start_index, end_index - start_index + 1);

                        copy_boxes.InsertRange(start_index, sub_list);

                        i -= 2;
                    }
                }

                if (boxes.SequenceEqual(copy_boxes))
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
