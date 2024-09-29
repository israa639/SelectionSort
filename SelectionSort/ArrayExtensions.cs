using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{

    /// <summary>  
    ///  static class contains extension methods for array of integers
    /// </summary>  
    public static class ArrayExtensions
    {
        /// <summary>  
        /// Swap two elements within an array  
        /// </summary>  
        /// <param name="array">The array of integers in which the elements will be swapped. .</param>  
        ///  <param name="firstElementIndex">The index of the first element to swapped.</param>  
        /// <param name="secondElementIndex">The index of the second element to swapped.</param>  
        public static void Swap(this int[] array, int firstElementIndex, int secondElementIndex)
        {
            if(firstElementIndex<array.Length||firstElementIndex>=0||secondElementIndex<array.Length||secondElementIndex>=0)
            {
                int temp = array[firstElementIndex];
                array[firstElementIndex] = array[secondElementIndex];
                array[secondElementIndex] = temp;

            }
           
        }
    }
}
