using System.Collections.Generic;
using System.Linq;

namespace C_Sharp.TopKFrequentElements
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numsTopFrequent = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(!numsTopFrequent.ContainsKey(nums[i]))
                {
                    numsTopFrequent.Add(nums[i],1);
                } 
                else
                {
                    ++numsTopFrequent[nums[i]];
                }
                
            }

            return numsTopFrequent.OrderByDescending(n => n.Value).Take(k).Select(k => k.Key).ToArray();
        }
    }
}
