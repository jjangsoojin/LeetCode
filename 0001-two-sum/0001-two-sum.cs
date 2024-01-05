public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
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

        }
    }
