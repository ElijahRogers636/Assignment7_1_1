namespace Assignment7_1_1
{
    internal class Program
    {
        // write a program to sort exam scores in ascending order using the selection sort algorithm
        static void Main(string[] args)
        {
            int[] grades = { 98, 72, 83, 12, 34, 99, 100, 67, 58, 70 };
            Print(grades);
            Console.WriteLine();
            SelectionSort(grades);
            Print(grades);
        }

        // Set the min to the end of the sorted portion, check for a value smaller than min in the nested loop
        // if smaller change the min to found index(j), once nested loop is done, swap index of i and index of min
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                (arr[min], arr[i]) = (arr[i], arr[min]);
            }
        }

        static void Print(int[] arr)
        {
            Console.Write("|");
            foreach (int i in arr)
            {
                Console.Write($" {i} |");
            }
            Console.WriteLine();
        }
    }
}
