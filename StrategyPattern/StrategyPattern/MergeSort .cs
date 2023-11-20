using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            MergeStringSort(list);
            Console.WriteLine("MergeSorted list ");
        }

        private void MergeStringSort(List<string> list)
        {
            if (list.Count <= 1)
                return;

            int middle = list.Count / 2;

            List<string> left = new List<string>();
            List<string> right = new List<string>();

            for (int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }

            for (int i = middle; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            MergeStringSort(left);
            MergeStringSort(right);
            Merge(list, left, right);
        }

        private void Merge(List<string> list, List<string> left, List<string> right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Count && j < right.Count)
            {
                if (string.Compare(left[i], right[j]) < 0)
                {
                    list[k] = left[i];
                    i++;
                }
                else
                {
                    list[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Count)
            {
                list[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Count)
            {
                list[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
