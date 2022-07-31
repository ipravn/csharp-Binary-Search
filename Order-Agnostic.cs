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
        int[] arr = { 76, 71, 54, 45, 12, 1 };
        int target = 71;
        int result = BinarySearch(arr, target);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    static int BinarySearch(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;
        
        bool check;

        if (arr[start] < arr[end])
        {
            check = true;
        }
        else
        {
            check = false;
        }

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (mid == target)
            {
                return mid;
            }


            if (check == true) { 
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
                    return mid;
                } 
        }
        else
        {
            if (arr[mid] < target)
            {
                end = mid - 1;
            }
            else if (target < arr[mid])
            {
                start = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        }
        return -1;
    }

}
