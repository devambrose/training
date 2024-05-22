// See https://aka.ms/new-console-template for more information


namespace insertion_sort 
{
    public class Program
    {

        public static void Main()
        {
           int[] nums = new int[7];

            for (int i = 0; i < nums.Length; i++)
            {
                Random rnd = new Random();

                nums[i] = rnd.Next(0,50);
            }

           PrintArray(nums);

           nums = InsertionSort(nums);

           PrintArray(nums);
         
        } 

        private static int[] InsertionSort(int[] nums)
        {
            //{a,b, c, d ,e ,f}
            //  0   1  2
            // 11 20 13
            for (int i = 1; i < nums.Length; i++)
            {
                int j = i;

                //3 2 1 0
                while (j > 0 && nums[j - 1] > nums[j])
                {
                    //swapping 
                    int temp = nums[j];

                    nums[j] = nums[j - 1];

                    nums[j - 1] = temp;

                    j--;
                }

            }

            return nums;
        }

        private static void PrintArray(int[] nums)
        {
            string myArray = "";

            foreach (int x in nums)
            {
                myArray += "," + x;
            }

            Console.WriteLine(myArray);
        }
    }
}










