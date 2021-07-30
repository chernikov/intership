

namespace SimpleSorting 
{

    public class Sorting
    {

        // To sort an array of size n in ascending order: 
        // 1: Iterate from arr[1] to arr[n] over the array. 
        // 2: Compare the current element (key) to its predecessor. 
        // 3: If the key element is smaller than its predecessor, compare it to the elements before. 
        // Move the greater elements one position up to make space for the swapped element.
        public int[] InsertSort(int[] array)  {

            for (int i = 1; i < array.Length; i++) {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key) {
                    array[j+1] = array[j];
                    j = j - 1;
                }
            }
            return array;
        }




        // 1) The subarray which is already sorted. 
        // 2) Remaining subarray which is unsorted.
        // In every iteration of selection sort, the minimum element (considering ascending order)
        // from the unsorted subarray is picked and moved to the sorted subarray. 
        public int[] SelectionSort(int[] array)  {
            return array;
        }

        //Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
        public int[] BubbleSort(int[] array)  {
            return array;
        }


    }

}