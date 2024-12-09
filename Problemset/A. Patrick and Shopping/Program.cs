namespace A._Patrick_and_Shopping
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/599/A
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int house_to_firstShop = input[0];
            int house_to_secondShop = input[1];
            int firstShop_to_secondShop = input[2];



            int distance1 = (house_to_firstShop * 2) + (house_to_secondShop * 2);
            int distance2 = house_to_firstShop + firstShop_to_secondShop + house_to_secondShop;
            int distance3 = (house_to_firstShop * 2) + (firstShop_to_secondShop * 2);
            int distance4 = (house_to_secondShop * 2) + (firstShop_to_secondShop * 2);

            int min_distance = Math.Min(
                               Math.Min(distance1, distance2),
                               Math.Min(distance3, distance4));

            Console.WriteLine(min_distance);
        }
    }
}
