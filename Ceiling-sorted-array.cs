// Binary Search Algorithm Using C#
// Praveen Kumar - https://github.com/ipravn/

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 11,18,19,89,99};
        int target = 94;
        int result = BinarySearch(arr, target);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    static int BinarySearch(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (arr[mid] > target)
            {
                end = mid - 1;
            }
            else if (target > arr[mid])
            {
                start = mid + 1;
            }
            else
            {
                return start;
            }
        }
        return arr[start] ;
    }

}
