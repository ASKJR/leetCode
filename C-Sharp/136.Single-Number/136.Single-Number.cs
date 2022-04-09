using System.Linq;

namespace C_Sharp.SingleNumber
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var x = nums
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key)
                .ToArray();
           return x[0];  
        }
    }
}
