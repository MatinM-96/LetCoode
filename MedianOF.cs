using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/**
 
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

 

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

Constraints:

    nums1.length == m
    nums2.length == n
    0 <= m <= 1000
    0 <= n <= 1000
    1 <= m + n <= 2000
    -106 <= nums1[i], nums2[i] <= 106

 */





namespace lettCode
{
    public class Solution
    {

        public bool IsSortede(int[] array)
        {
            if (array.Length < 2) return true; // array with one or 0 elements

            if(array.Length<0)

            for (int i = 0; i<array.Length-1; i++)
            {
                if (array[i]> array[i+1] )
                {
                    
                    return false;
                }
            }

            return true; 
            
        }

        public bool ISempty(int [] array)
        {
            if (array.Length < 1) return true;

            return false; 
        }


        


        void AddToList(int[]array, List<int> merge)
        {

            if(!ISempty(array))
                for(int i = 0; i<array.Length; i++)
                { merge.Add(array[i]);}
             
       
        }


       //in  c++ we use the refrence to pass the list or array for manipulating



        public List <int> sort(int[] array)
        {
            List<int> list2 = new List<int>();
            return list2; 
        }




        public void FindMedianSortedArrays(int[] array1, int[] array2)
        {
            Console.WriteLine(ISempty(array1));




            List<int> list = new List<int> ();

            AddToList(array2, list);
            AddToList(array1, list);







            //need some research about log(n+m)


            foreach (int item in list)
            {  Console.WriteLine(item); }
                         

            if(IsSortede(array1))
            {
                Console.WriteLine("the array is sorted");
            }
            else
            {
                Console.WriteLine("the array is not sorted"); 
            }
            
        }

        
    }
}
