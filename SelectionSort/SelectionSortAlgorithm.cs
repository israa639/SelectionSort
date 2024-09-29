
namespace SelectionSort
{
    public class SelectionSortAlgorithm
    {
        
       public void Sort(int[] array) {
            
            for (int i=0;i<array.Length-1;i++)
            {
                 for(int j=i+1;j<array.Length;j++)
                {
                    if (array[i] > array[j])
                    {
                        array.Swap(i, j);
                    }
                }
            }


  }
    }
}
