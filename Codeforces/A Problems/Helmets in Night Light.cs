using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1876/A
    internal class Helmets_in_Night_Light
    {
        public long CalculateMinCostToNotifyAll
            (int numberOfResidents,
             int costForMain,
             int[] maxForEach,
             int[] costForEach)
        {
            long totalCost = costForMain; // Start with the cost of the main notification
            numberOfResidents--; // One resident is notified by the main notification

            var pairs = costForEach.Zip(maxForEach, (cost, max) => (cost, max))
                                   .ToArray();
            int pairsIndex = 0;

            Array.Sort(pairs); // Sort by cost for each resident, then by max if costs are equal

            while (pairs[pairsIndex].cost < costForMain && numberOfResidents > 0)
            {
                int residentsToNotify = Math.Min(pairs[pairsIndex].max, numberOfResidents);
                totalCost += (long)residentsToNotify * pairs[pairsIndex].cost;
                numberOfResidents -= residentsToNotify;
                pairsIndex++;
            }

            if (numberOfResidents > 0)
            {
                // Notify remaining residents with main notification
                totalCost += (long)numberOfResidents * costForMain;
            }

            return totalCost;
        }
    }
}
