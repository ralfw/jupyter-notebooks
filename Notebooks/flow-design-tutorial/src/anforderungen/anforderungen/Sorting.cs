using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace anforderungen
{
    public class Sorting
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Sorting(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test_bubblesort()
        {
            var rnd = new Random();
            var numbers = Enumerable.Range(1,10000).Select(_ => rnd.Next(0,1000)).ToArray();
            var start = DateTime.Now;
            BubbleSort(numbers);
            _testOutputHelper.WriteLine(DateTime.Now.Subtract(start).Milliseconds.ToString());
        }
        
        
        void BubbleSort(int[] values) {
            var flag = true;
            for (int i = 1; (i <= (values.Length - 1)) && flag; i++) {  
                flag = false;  
                for (int j = 0; j < (values.Length - 1); j++)  
                {  
                    if (values[j + 1] > values[j])  
                    {  
                        var temp = values[j];  
                        values[j] = values[j + 1];  
                        values[j + 1] = temp;  
                        flag = true;  
                    }  
                }  
            }  
        }


        [Fact]
        public void Test_quicksort()
        {
            var numbers = Enumerable.Range(1,10000).ToArray();
            var start = DateTime.Now;
            QuickSort(numbers);
            _testOutputHelper.WriteLine(DateTime.Now.Subtract(start).Milliseconds.ToString());
        }


        void QuickSort(int[] values) => QuickSort(values, 0, values.Length - 1);
        
        void QuickSort(int[] values, int left, int right) {
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

        int Partition(int[] values, int left, int right)  {
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