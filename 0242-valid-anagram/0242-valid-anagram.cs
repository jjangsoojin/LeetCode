
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;
        
        // 각 문자의 빈도수를 저장할 Dictionary 생성
        Dictionary<char, int> charCountS = new Dictionary<char, int>(); 
        Dictionary<char, int> charCountT = new Dictionary<char, int>();
        
        // 문자열 s의 각 문자의 빈도수 계산
        foreach(char c in s){
            if(charCountS.ContainsKey(c)){
                charCountS[c]++;
            } else {
                charCountS[c] = 1;
            }
        }
        
        // 문자열 t의 각 문자의 빈도수 계산
        foreach(char c in t){
            if(charCountT.ContainsKey(c)){
                charCountT[c]++;
            } else {
                charCountT[c] = 1;
            }
        }
        
        // 문자열 s와 t의 빈도수 비교
        foreach (char key in charCountS.Keys)
        {
            if (!charCountT.ContainsKey(key) ||  charCountT[key] != charCountS[key])
                return false;
        }
      
        // 모든 조건을 통과하면 true를 반환
        return true;
    }
}
