using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using Index = SortingDeploy.Pages.Index;


namespace SortingDeploy.Data
{
    public class SortingMethods

    {
        
        public void CreateRandomArray(int arraySize, int[] array, int max)
        {
            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(1, max);
            }
        }

        public async Task BubbleSort(int[] array, int arraySize, Index index, int time)
        {
            int delay = TimeCalculation(time, "Bubble Sort");
            for (int i = arraySize - 1; i > 0; i--)
            {
                if (i == arraySize - 1)
                {
                    await index.Update(array);
                    //Thread.Sleep(1000);
                }
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Thread.Sleep(delay);
                        SwapArrayValues(array, j, j + 1); 
                        
                        await index.Update(array);
                        
                        Debug.WriteLine("We are here");
                    }
                }
            }
            Debug.WriteLine("Most kellene");
            Thread.Sleep(1000);
            //index.Enable();
            Debug.WriteLine("Most kellett volna");
            //await index.DisableCheck();
        }

        public void SwapArrayValues(int[] array, int firstPos, int secondPos)
        {
            int temp = array[firstPos];
            array[firstPos] = array[secondPos];
            array[secondPos] = temp;
        }

        public async Task SelectionSort(int[] array, int arraySize, Index index, int time)
        {
            int delay = TimeCalculation(time, "Selection Sort");
            for (int x = 0; x < arraySize - 1; x++)
            {
                //if (x == 0)
                //{
                //    await index.Update(array);
                //    //Thread.Sleep(1000);
                //}
                Debug.WriteLine("X: " + x);
                int min = x;
                
                for (int y = x + 1; y < arraySize; y++)
                {
                    Debug.WriteLine("Y: " + y);
                    if (array[y] < array[min])
                    {
                        min = y;
                    }
                    
                }
                
                SwapArrayValues(array, x, min);
                await index.Update(array);
                Thread.Sleep(delay);
            }
        }

        public async Task InsertionSort(int[] array, int arraySize, Index index, int time)
        {
            int delay = TimeCalculation(time, "Insertion Sort");
            for (int i = 1; i < arraySize; i++)
            {
                if (i == 1)
                {
                    await index.Update(array);
                    //Thread.Sleep(1000);
                }
                int temp = i;
                int numToInsert = array[i];
                while ((temp > 0) && (array[temp - 1] > numToInsert))
                {

                    array[temp] = array[temp - 1];
                    temp--;
                    await index.Update(array);
                    Thread.Sleep(delay);
                }

                array[temp] = numToInsert;
                
            }
        }

        private string stro;
        
        public async Task QuickSortCall(int[] array, int start, int end, Index index, int time)
        {
            //index.DisableCheck();
            int delay = TimeCalculation(time, "Quick Sort");
            await QuickSort(array, start, end, index, delay );
            await index.Update(array);
            //index.Enable();
            Debug.WriteLine("Befejezte");
        }
       
        //public async void QuickSort(int[] array, int left, int right, Index index)
        //{
        //    int i = left;
        //    int j = right;

        //    var pivot = array[(left + right) / 2];

        //    while (i <= j)
        //    {

        //        while (array[i] < pivot)

        //            i++;

        //        while (array[j] > pivot)
        //            j--;

        //        if (i <= j)
        //        {
        //            var tmp = array[i];
        //            array[i] = array[j];
        //            array[j] = tmp;
        //            Thread.Sleep(10);
        //            i++;
        //            j--;
        //        }
        //    }

        //    if (left < j)
        //        QuickSort(array, left, j, index);
        //    await index.Update(array);
        //    Thread.Sleep(timeQuick);
        //    if (i < right)
        //        QuickSort(array, i, right, index);
        //    await index.Update(array);
        //    Thread.Sleep(timeQuick);
        //}

        public async Task QuickSort(int[] array, int start, int end, Index index, int time)
        {
            int i;
            if (start < end)
            {
                //index.Update(array);
                i = Partition(array, start, end, time, index);
                //index.Update(array);
                await QuickSort(array, start, i - 1, index, time);
                //index.Update(array);
                await QuickSort(array, i + 1, end, index, time);
                //Thread.Sleep(time);
            }
            //index.Update(array);
        }

        private int Partition(int[] array, int start, int end, int delay, Index index)
        {

            int temp;
            int p = array[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                //Thread.Sleep(delay);
                if (array[j] <= p)
                {
                    i++;
                    //temp = array[i];
                    //array[i] = array[j];
                    //array[j] = temp;
                    SwapArrayValues(array, i, j);
                    index.Update(array);
                    Thread.Sleep(delay);
                }
            }

            temp = array[i + 1];

            array[i + 1] = array[end];
            array[end] = temp;
            return i + 1;
        }

        private int TimeCalculation(int time, string sort)
        {
            int delay = 50;
            if (sort == "Bubble Sort")
            {
                delay = time * 7;
            }
            else if (sort == "Selection Sort")
            {
                delay = time * 7;
            }
            else if (sort == "Insertion Sort")
            {
                delay = time * 7;
            }
            else if (sort == "Quick Sort")
            {
                delay = time * 4;
            }

            return delay;

        }
    }
}
