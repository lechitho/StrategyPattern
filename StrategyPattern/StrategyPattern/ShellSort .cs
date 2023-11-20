using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            int n = list.Count;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    string temp = list[i];
                    int j = i;

                    while (j >= gap && string.Compare(list[j - gap], temp) > 0)
                    {
                        list[j] = list[j - gap];
                        j -= gap;
                    }

                    list[j] = temp;
                }

                gap /= 2;
            }

            Console.WriteLine("ShellSorted list ");
        }
    }
}
