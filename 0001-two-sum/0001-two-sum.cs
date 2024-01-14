public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        /*
        // 기존에 풀었던 O(n2) 
       int[] num = new int[2];
           
                   for (int i = 0; i < nums.Length; i++)
            {
                
                for (int j = 1; j <= nums.Length - 1; j++)
                {
                     if (i!=j && nums[i] + nums[j] == target)
 {
     num[0] = i;
     num[1] = j;
     return num;
 }

                }
            }
            return num;
*/

        
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            int[] num = new int[2];


            for(int i=0; i<nums.Length; i++)
            {
                int diff = target - nums[i];


                if (dic.ContainsKey(diff))
                {
                    return new int[] { dic[diff],i};
                }

                dic[nums[i]] = i;

            }

            return nums;
        }
    }
