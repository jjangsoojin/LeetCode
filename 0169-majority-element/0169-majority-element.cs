public class Solution {
    public int MajorityElement(int[] nums) {
        /*
        // 기존에 짰던 코드 
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
*/
     // O(n) 시간복잡도
     // majority element는 n/2보다 많이 등장하는 원소를 의미 - 전체원소의 과반수를 초과
        
     int candidate = 0;
        int count = 0;

        foreach (int num in nums) {
            if (count == 0) {       
                candidate = num;            // 만약 count가 0이라면 새로운 후보를 선택하고 count를 1로 설정
                count = 1;
            } else if (candidate == num) {      // 현재 요소가 후보와 같다면 count를 증가
                count++;    
            } else {                            // 현재 요소가 후보와 다르다면 count를 감소
                count--;
            }
        }

        // Majority element 항상 존재한다고 가정하였으므로 따로 체크할 필요 없음
        return candidate;
        
    }
}
