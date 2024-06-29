using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lettCode
{
    internal class MedianOfTwoArray
    {



  

        //a function to merge two arrays
        // this function should take two arrays 
        // create a new arrays to append to merge the arrays 
        // retrn a new arrays to 

        public int[] MergTwoArrays(int[] arrayOne, int[] arrayTwo)
        {
            int arrayOneSize =  arrayOne.Length;

            int arrayTWoSize = arrayTwo.Length;  

            int lengthOfArray = arrayOne.Length + arrayTwo.Length;

            int[] resultArray = new int[lengthOfArray];

            int indexResult = 0;
            int indexArray = 0;

            while(arrayOneSize != 0)
            {
                resultArray[indexResult] = arrayOne[indexArray];
                indexResult++; 
                indexArray++;
                arrayOneSize--;

            }
            indexArray = 0;

            while(arrayTWoSize != 0)
            {
                resultArray[indexResult] = arrayTwo[indexArray];
                indexResult++;
                indexArray++;
                arrayTWoSize--;
            }
            indexArray = 0; 

            return resultArray;
        }


        // a function to sort the merge array, it should return a new array with sorted elements
        // by calling this function it should sorted the given array 


        //using divide and conquer
        public void DivideArray(int[] array, int left, int right)
        {
            if (left<right)
            {

                int middel = left + (right - left) / 2;

                // from the start to the middle of array 
                DivideArray(array, left, middel);
                DivideArray(array, middel + 1, right);

                //merge sub-arrays 
                MergeArray(array,left,right, middel);
            }
        }

        public void MergeArray(int[] array, int left, int right, int middle)
        {

            //create a temporary sub arrays
            // initialize the length of the sub array 

            int sizeArrayA = middle- left+1;
            int sizeArrayB = right - middle;
            
            int[] arrayA = new int[sizeArrayA];
            int[] arrayB = new int[sizeArrayB];
            
            Array.Copy(array, left, arrayA,0, sizeArrayA);
            Array.Copy(array, middle + 1,arrayB, 0, sizeArrayB);


            int i = 0;
            int j = 0; 
            int k = left; 


            //scenario where both array have the same sizes 

            while(i<sizeArrayA  && j <sizeArrayB)
            {
                if (arrayA[i] <= arrayB[j])
                {
                    array[k] = arrayA[i];
                    i++;
                }
                else
                {
                    array[k] = arrayB[j];
                    j++;
                }
                k++; 
            }

            //scenario where  array-A is bigger then  array-B
            
            while(i<sizeArrayA)
            {
                array[k] = arrayA[i];
                i++;
                k++; 
            }

            //scenario where array-B is bigger than array A

            while(j< sizeArrayB)
            {  
                array[k] = arrayB[j]; 
                j++;
                k++;
            }           
        }
        //another function to find the median
        //this function should find the median, if the length of arrays was odd n/2 


        public double MedianOfArray(int[] array)
        {
            double median = 0 ;
    
            
            if (array.Length > 0)
            {
                if (array.Length% 2==0)
                {
                    median = (array[array.Length/2] + array[array.Length/2 - 1])/2.0 ; 
                }
                else
                {
                    median = array[array.Length/2];
                }
            }
            else
            {
                median = -1; 
            }
            return median; 
        }
        
        
    }
}
