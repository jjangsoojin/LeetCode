public class Solution {
    public int LongestPalindrome(string s) {
           int length = 0;
        bool hasOddFrequency = false;
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in s) {
            if (charCount.ContainsKey(c)) {
                charCount[c]++;
            } else {
                charCount[c] = 1;
            }
        }

        foreach (var count in charCount.Values) {
            length += count / 2 * 2;  // 짝수 횟수인 경우 모두 사용
            if (count % 2 == 1) {
                hasOddFrequency = true;  // 홀수 횟수를 가진 문자가 있음을 표시
            }
        }

        // 홀수 횟수를 가진 문자가 있으면 한 번만 사용하여 팰린드롬 길이에 추가
        if (hasOddFrequency) {
            length++;
        }

        return length;
        }
        
    }
