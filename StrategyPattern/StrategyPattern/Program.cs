using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Peter");
            studentRecords.Add("Mary");
            studentRecords.Add("John");
            studentRecords.Add("Alex");
            studentRecords.Add("Kyle");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
        }
    }
}
