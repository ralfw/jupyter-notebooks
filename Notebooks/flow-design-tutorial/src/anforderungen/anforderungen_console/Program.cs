using System;
using System.Linq;

namespace anforderungen_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var numbers = Enumerable.Range(1,10000).Select(_ => rnd.Next(0,1000)).ToArray();
            var start = DateTime.Now;
            QuickSort(numbers);
            Console.WriteLine(DateTime.Now.Subtract(start).Milliseconds.ToString());
        }
        
        
        static void QuickSort(int[] values) => QuickSort(values, 0, values.Length - 1);
        
        static void QuickSort(int[] values, int left, int right) {
            if (left < right) {
                int pivot = Partition(values, left, right);

                if (pivot > 1) {
                    QuickSort(values, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    QuickSort(values, pivot + 1, right);
                }
            }
        }

        static int Partition(int[] values, int left, int right)  {
            int pivot = values[left];
            while (true) {
                while (values[left] < pivot) {
                    left++;
                }

                while (values[right] > pivot) {
                    right--;
                }

                if (left < right) {
                    if (values[left] == values[right]) return right;

                    int temp = values[left];
                    values[left] = values[right];
                    values[right] = temp;
                }
                else {
                    return right;
                }
            }
        }
    }
}