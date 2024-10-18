//Array
using System;

class Program
{
    static void Main()
    {
        int[] customArray = new int[5];


        for (int i = 0; i < customArray.Length; i++)
        {
            customArray[i] = i * 10;
        }


        foreach (int value in customArray)
        {
            Console.WriteLine(value);
        }
    }
}


//Merge sort

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 34, 7, 23, 32, 5, 62 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
    }

    // MergeSort function
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            
            MergeSort(arr, left, middle);

            
            MergeSort(arr, middle + 1, right);

            
            Merge(arr, left, middle, right);
        }
    }

    
    static void Merge(int[] arr, int left, int middle, int right)
    {
        
        int n1 = middle - left + 1;
        int n2 = right - middle;

        
        int[] L = new int[n1];
        int[] R = new int[n2];

        
        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            R[j] = arr[middle + 1 + j];

        
        int k = left;  
        int iIndex = 0, jIndex = 0;  

        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex] <= R[jIndex])
            {
                arr[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                arr[k] = R[jIndex];
                jIndex++;
            }
            k++;
        }

        
        while (iIndex < n1)
        {
            arr[k] = L[iIndex];
            iIndex++;
            k++;
        }

        
        while (jIndex < n2)
        {
            arr[k] = R[jIndex];
            jIndex++;
            k++;
        }
    }

   
    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

