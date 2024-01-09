public class Solution {
    public int MajorityElement(int[] nums) {
        
       
         Dictionary<int, int> dic = new Dictionary<int, int>();
         int maxvalue = 0;
         int max = 0;

         foreach (int x in nums)
         {
             if (dic.ContainsKey(x))
             {
                 dic[x]++;
             }
             else
             {
                 dic[x] = 1;
             }

         }

         foreach (var x in dic)
         {
             if (x.Value > 1 && x.Value > maxvalue)
             {
                 maxvalue = x.Value;
                 max = x.Key;
             }
         }

        if(nums.Length == 1)
         {
             return nums[0];
         }

         return max;

    }
}