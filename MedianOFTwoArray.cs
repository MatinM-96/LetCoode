using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettCode
{
    internal class MedianOFTwoArray
    {



  

        //a function to merge two arrays
        // this function should take two arrays 
        // create a new arrays to append to merge the arrays 
        // retrn a new arrays to 

        public int[] myMergedArray(int[] ArrayOne, int[] ArrayTwo)
        {
            int arrayOneSize =  ArrayOne.Length;

            int arrayTWoSize = ArrayTwo.Length;  

            int lengthOFtheArray = ArrayOne.Length + ArrayTwo.Length;

            int[] resultArray = new int[lengthOFtheArray];

            int indexResult = 0;
            int indexArray = 0;

            while(arrayOneSize != 0)
            {
                resultArray[indexResult] = ArrayOne[indexArray];
                indexResult++; 
                indexArray++;
                arrayOneSize--;

            }
            indexArray = 0;

            while(arrayTWoSize != 0)
            {
                resultArray[indexResult] = ArrayTwo[indexArray];
                indexResult++;
                indexArray++;
                arrayTWoSize--;
            }
            indexArray = 0; 

            return resultArray;
        }


        // a function to sort the mergde array, it should return a new array with sorted elements
        // by calling this functuon it should sorted the given array 



        public int[] divideArray(int[] mergeArray, int left, int right)
        {
            int[] sortArray = new int[mergeArray.Length];






            return sortArray;

        }







        //another function to find the meadin
        //this function should find the median, if the length of arrays was odd n/2 
    }
}
