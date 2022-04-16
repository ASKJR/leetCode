namespace C_Sharp.ConcatenationOfArray
{
    public class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] answer = new int[nums.Length*2];
            int index = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    answer[index] = nums[j];
                    ++index;
                }
            }

            return answer;
        }
    }
}
