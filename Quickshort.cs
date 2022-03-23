using System;

namespace Quick_Sort
{
    class Program
    {
        private static void Quick_Sort(int[] arr, int left, int right) 
        {
            if (left < right)
            {
                int ctr = Ptr(arr, left, right);

                if (ctr > 1) {
                    Quick_Sort(arr, left, ctr - 1);
                }
                if (ctr + 1 < right) {
                    Quick_Sort(arr, ctr + 1, right);
                }
            }
        
        }

        private static int Ptr(int[] arr, int left, int right)
        {
            int ctr = arr[left];
            while (true) 
            {

                while (arr[left] < ctr) 
                {
                    left++;
                }

                while (arr[right] > ctr)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else 
                {
                    return right;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 5, -4, 11, 0, 10, 12, 7, 15, 20,-5 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);    
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length-1);
            
            Console.WriteLine();
            Console.WriteLine("Sorted array : ");
           
		   foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
                    }
    }
}