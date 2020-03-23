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
        
        public int RandomNumber(int max)
        {
            Random random = new Random();
            return random.Next(1, max);
        }

        public void CreateRandomArray(int arraySize, int[] array, int max)
        {
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = RandomNumber(max);
            }
        }

    public async Task BubbleSort(int[] array, int arraySize, Index index, int time)
        {
            
            for (int i = arraySize - 1; i > 0; i--)
            {
                if (i == arraySize - 1)
                {
                    await index.Update(array);
                    Thread.Sleep(1000);
                }
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Thread.Sleep(time);
                        SwapArrayValues(array, j, j + 1); 
                        
                        await index.Update(array);
                        
                        Debug.WriteLine("We are here");
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
                if (x == 0)
                {
                    await index.Update(array);
                    Thread.Sleep(1000);
                }
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
                Thread.Sleep(time);
                SwapArrayValues(array, x, min);
                await index.Update(array);
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
                    Thread.Sleep(1000);
                }
                int temp = i;
                int numToInsert = array[i];
                while ((temp > 0) && (array[temp - 1] > numToInsert))
                {

                    array[temp] = array[temp - 1];
                    temp--;
                    await index.Update(array);
                    Thread.Sleep(time);
                }

                array[temp] = numToInsert;
                
            }
            index.DisableCheck();
        }

        //public void printArray(int[] array, int arraySize)
        //{
        //    System.out.println("---------");
        //    for (int i = 0; i < arraySize; i++)
        //    {
        //        System.out.println("| " + i + " |");
        //        System.out.println(array[i] + " |");
        //        System.out.println("---------");
        //    }
        //}

        //public void basicArrayVisualize(int[] array, int arraySize, int i, int j)
        //{
        //    for (int n = 0; n < 51; n++) System.out.print("-");
        //    System.out.println();
        //    for (int n = 0; n < arraySize; n++)
        //    {
        //        System.out.print("| " + n + "  ");
        //    }
        //    System.out.println("|");
        //    for (int n = 0; n < 51; n++) System.out.print("-");
        //    System.out.println();
        //    for (int n = 0; n < arraySize; n++)
        //    {
        //        System.out.print("| " + array[n] + " ");
        //    }
        //    System.out.println("|");
        //    for (int n = 0; n < 51; n++) System.out.print("-");
        //    System.out.println();
        //    if (j != -1)
        //    {
        //        for (int k = 0; k < ((j * 5) + 2); k++) System.out.print(" ");
        //        System.out.print(j);
        //    }
        //    if (i != -1)
        //    {
        //        for (int l = 0; l < (5 * (i - j) - 1); l++) System.out.print(" ");
        //        System.out.print(i);
        //    }


        //    System.out.println();

        //        System.out.println("------------");
        //        for (int n = 0; n < arraySize; i++)
        //        {
        //            System.out.print("| " + n + "  ");
        //        }
        //        System.out.println("|");
        //        System.out.println("------------");
        //        System.out.println();
        //        for (int n = 0; n < arraySize; i++)
        //        {
        //            System.out.print("| " + array[n] + "  ");
        //        }
        //        System.out.println("|");
        //        System.out.println("------------");
        //        System.out.println();
        //
        //        if(j != -1){
        //            for(int k = 0; k < ((j*5)+2); k++)System.out.print(" ");
        //            System.out.print(j);
        //        }
        //        if(j != -1){
        //            for(int l = 0; l < (5*(i - j)-1); l++)System.out.print(" ");
        //
        //            System.out.print(j);
        //        }
        //}








    }
}
