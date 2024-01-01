public class Solution {
    public int Search(int[] nums, int target) {
        
   int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;  // start를 더하지 않으면 배열의 시작 인덱스를 고려하지 않은 중간값이 됨

                if(nums[mid] == target)
                {
                    return mid;
                }else if(nums[mid] < target)
                {
                    left = mid + 1;
                }else
                {
                    right = mid - 1;
                }
            }

            return -1; // Target not found in the array
    }
}