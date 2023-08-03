namespace Two.Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[5] { 1, 2, 6, 3, 7 };

            var results = FindTwoSum(values, 8);

            Console.WriteLine(results);
        }

        public static Tuple<int,int> FindTwoSum(int[] nums, int sum) 
        {
            Tuple<int, int> matchingValues = new(0,0);

            for(int i = 0; i < nums.Length; i++)
            {
                var firstNum = nums[i];
                var secondNum = nums[i + 1];

                var total = firstNum + secondNum;

                if (total == sum)
                {
                    matchingValues = new Tuple<int, int>(firstNum, secondNum);
                }
            }

            return matchingValues;
        }
    }
}