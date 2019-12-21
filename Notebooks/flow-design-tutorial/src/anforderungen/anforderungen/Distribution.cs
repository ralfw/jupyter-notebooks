using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace anforderungen
{
    public class Distribution
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Distribution(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Sync()
        {
            var rnd = new Random();
            var numbers1 = Enumerable.Range(1,5000).Select(_ => rnd.Next(0,1000)).ToArray();
            var numbers2 = Enumerable.Range(1,10000).Select(_ => rnd.Next(0,1000)).ToArray();
            var start = DateTime.Now;
            BubbleSort(numbers1);
            _testOutputHelper.WriteLine($"after numbers1: {DateTime.Now.Subtract(start).Milliseconds}");
            BubbleSort(numbers2);
            _testOutputHelper.WriteLine($"after numbers2: {DateTime.Now.Subtract(start).Milliseconds}");
        }
        
        [Fact]
        public void Parallel()  {
            var rnd = new Random();
            var numbers1 = Enumerable.Range(1,5000).Select(_ => rnd.Next(0,1000)).ToArray();
            var numbers2 = Enumerable.Range(1,10000).Select(_ => rnd.Next(0,1000)).ToArray();
            var start = DateTime.Now;
            var task1 = Task.Run(() => BubbleSort(numbers1));
            var task2 = Task.Run(() => BubbleSort(numbers2));
            Task.WaitAll(task1, task2);
            _testOutputHelper.WriteLine($"after numbers2: {DateTime.Now.Subtract(start).Milliseconds}");
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
    }
}