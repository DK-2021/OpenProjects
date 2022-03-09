using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class SortingDictionary
    {
        public static int[] BubbleSort(int[] arrBubble)
        {
            int temporaryNum = 0;

            for (var forLength = 0; forLength < arrBubble.Length; forLength++)
            {
                for (var secondPass = 0; secondPass < arrBubble.Length - 1; secondPass++)
                {
                    if (arrBubble[secondPass] > arrBubble[secondPass + 1])
                    {
                        temporaryNum = arrBubble[secondPass + 1];
                        arrBubble[secondPass + 1] = arrBubble[secondPass];
                        arrBubble[secondPass] = temporaryNum;
                    }
                }
            }
            return arrBubble; // Returns an array for further use
        } 
        public static int[] SelectionSort(int[] arrSelection)
        {
            int temporaryNum;
            int smallerNum;

            for (int forLength = 0; forLength < arrSelection.Length - 1; forLength++)
            {
                smallerNum = forLength;
                for (int compare = forLength + 1; compare < arrSelection.Length; compare++)
                {
                    if (arrSelection[compare] < arrSelection[smallerNum]) 
                    { 
                        smallerNum = compare;
                    }
                }
                temporaryNum = arrSelection[smallerNum];
                arrSelection[smallerNum] = arrSelection[forLength];
                arrSelection[forLength] = temporaryNum;
            }
            return arrSelection;
        }
        public static void MergeSort(int[] inputArray)
        {
            int inputLength = inputArray.Length;
            if (inputLength < 2) // Checking to see if array is already at one
            {
                return;
            }
            int midIndex = inputLength / 2;
            int[] leftSide = new int[midIndex]; // Creates left side array by size mid
            int[] rightSide = new int[inputLength - midIndex]; // Creates right side array by overal length - midsize (accounts for odd numbered array size)

            for (int i = 0; i < midIndex; i++)
            {
                leftSide[i] = inputArray[i];
            }
            
            // Don't reset [j] to '0', must be assigned to midIndex.
            for (int j = midIndex; j < inputLength; j++)             
            {    
                    rightSide[j - midIndex] = inputArray[j];
            }
            // Recursion to separate the arrays
            MergeSort(leftSide);
            MergeSort(rightSide);

            // Call the local function method to place sorted values back into inputArray
            Merge(leftSide, rightSide, inputArray); 

            void Merge(int[] left, int[] right, int[] inputArray)
            {
                int leftLen = left.Length;
                int rightLen = right.Length;
                int i = 0, j = 0, k = 0; // Position [k] is designated for the inputArray

                // Compares both separate arrays for input sorting
                while (i < leftLen && j < rightLen)
                {
                    if (left[i] <= right[j])
                    {
                        inputArray[k] = left[i]; 
                        i++;
                    }
                    else
                    {
                        inputArray[k] = right[j];
                        j++;
                    }
                    k++;
                }
                
                // Below cleans up any number left out
                while (i < leftLen)
                {
                    inputArray[k] = left[i];
                    i++;
                    k++;
                }
                while (j < rightLen)
                {
                    inputArray[k] = right[j];
                    j++;
                    k++;
                }
            }
        }

        //QuickSort
    }
}
