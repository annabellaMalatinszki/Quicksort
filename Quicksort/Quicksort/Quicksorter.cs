using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class Quicksorter
    {
        public static int[] QuickSort(int[] array, int first, int last)
        {
            int left = first;
            int right = last;
            int pivot = array[(first + last) / 2];

            while (left <= right)
            {
                while (array[left].CompareTo(pivot) < 0)
                {
                    left++;
                }

                while (array[right].CompareTo(pivot) > 0)
                {
                    right--;
                }

                if (left <= right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }

                if (first < right)
                {
                    QuickSort(array, first, right);
                }
                if (left < last)
                {
                    QuickSort(array, left, last);
                }
            }
            return array;
        }
    }
}
