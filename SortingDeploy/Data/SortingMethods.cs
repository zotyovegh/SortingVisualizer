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
            for (int i = arraySize - 1; i > 0; i--)
            {
                if (i == arraySize - 1)
                {
                    await index.Update(array);                    
                }
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        if(time != 0)
                        {
                        await Task.Delay(time);
                        //Thread.Sleep(time);
                        }
                        SwapArrayValues(array, j, j + 1);                         
                        await index.Update(array);                        
                    }
                }
            }
            index.DisableCheck();            
        }
        public void SwapArrayValues(int[] array, int firstPos, int secondPos)
        {
            int temp = array[firstPos];
            array[firstPos] = array[secondPos];
            array[secondPos] = temp;
        }
        public async Task SelectionSort(int[] array, int arraySize, Index index, int time)
        {
            for (int x = 0; x < arraySize - 1; x++)
            {
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
                await Task.Delay(time);
            }
            index.DisableCheck();
        }
        public async Task InsertionSort(int[] array, int arraySize, Index index, int time)
        {
            for (int i = 1; i < arraySize; i++)
            {
                if (i == 1)
                {
                    await index.Update(array);
                }
                int temp = i;
                int numToInsert = array[i];
                while ((temp > 0) && (array[temp - 1] > numToInsert))
                {
                    array[temp] = array[temp - 1];
                    temp--;
                    await index.Update(array);
                    if (time != 0)
                    {
                        await Task.Delay(time);
                    }
                }
                array[temp] = numToInsert;                
            }
            index.DisableCheck();
        }

    }
}
