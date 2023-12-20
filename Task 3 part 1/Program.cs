namespace Taks_3_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            Console.WriteLine("Enter numbers seperated by a (,) \nexample: 1,2,3,4,5,2,6");
            string[] userInputArray = Console.ReadLine().Split(",");

            foreach (string userInput in userInputArray)
            {
                nums.Add(Convert.ToInt32(userInput));
            }

            void checkForDuplicates(List<int> numsList)
            {
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    for (int j = i + 1; j < nums.Count; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            throw new Exception($"Duplicates found at the index {i} and the index {j}");
                        }
                    }
                }
            }
            try
            {
                checkForDuplicates(nums);
                Console.WriteLine("No Duplicates");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
