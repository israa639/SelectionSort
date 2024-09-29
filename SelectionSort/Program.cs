namespace SelectionSort
{
    internal class Program
    {
        /// <summary>  
        /// this method print the elements of an array
        /// </summary> 
        /// <param name="array">The array of integers to be printed</param>  
        static void DisplayArray(int[]array)
        {
            WriteLine("Elements of the array :");
             foreach(var element in array)
            {
                Write($"{element} ");
            }
        }
        /// <summary>  
        /// this method takes input from user and makes sure the data is valid
        /// </summary>  
        /// <returns>An array of integers entered by the user.</returns>  

        static int[] GetUserInputArray()
        {
            WriteLine("Enter the size of your array");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                WriteLine("Please enter a valid size");
            }
            int[] Nums = new int[size];
            WriteLine("Enter the elements of your array");
            for (int i = 0; i < size; i++)
            {
                int element;
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                    WriteLine("Please enter a valid element");

                }

                Nums[i] = element;
            }
            return Nums;

        }
        static void Main(string[] args)
        {
            int[] Nums = GetUserInputArray();
            SelectionSortAlgorithm selectionSortAlgorithm = new SelectionSortAlgorithm();
            selectionSortAlgorithm.Sort(Nums);
            DisplayArray(Nums);
        }
        }
    }

