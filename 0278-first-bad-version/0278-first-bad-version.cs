/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
/*
이진 탐색을 사용하여 첫 번째 bad를 찾는다.
변수 left는 현재 검사 중인 범위의 왼쪽 끝을 나타내고, right는 오른쪽 끝을 나타냄.
이진 탐색을 통해 중간 지점(mid)을 찾고 IsBadVersion(mid)를 호출하여 bad를 찾아냄.

IsBadVersion(mid) - false > mid 오른쪽에 bad 값 존재
IsBadVersion(mid) - true  > mid or mid 왼쪽에 bad 값 존재

*/
public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1;
        int right = n;

       while(left<right){  
            int mid = left + (right - left) / 2;    // 중간값
           
            if (IsBadVersion(mid)) {            // true면 mid or mid 왼쪽에 bad 값 존재
                 right = mid;  
            } else {                            // false면 mid 오른쪽에 bad 값 존재
                left = mid + 1;
            }
           
       }
        return left;            // 첫번째 bad값 저장되어 있음
    }
}