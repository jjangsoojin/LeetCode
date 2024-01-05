using System.Collections.Generic;

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
         
    Dictionary<char, int> ransomNoteFrequency = new Dictionary<char, int>();
    Dictionary<char, int> magazineFrequency = new Dictionary<char, int>();

    // ransomNote 문자열의 각 문자의 빈도수를 ransomNoteFrequency에 저장
    foreach (char c in ransomNote)
    {
        if (ransomNoteFrequency.ContainsKey(c))
        {
            ransomNoteFrequency[c]++;
        }
        else
        {
            ransomNoteFrequency[c] = 1;
        }
    }

    // magazine 문자열의 각 문자의 빈도수를 magazineFrequency에 저장
    foreach (char c in magazine)
    {
        if (magazineFrequency.ContainsKey(c))
        {
            magazineFrequency[c]++;
        }
        else
        {
            magazineFrequency[c] = 1;
        }
    }

    // magazine 문자로 ransomNote를 구성할 수 있는지 체크
    foreach (char key in ransomNoteFrequency.Keys)
    {
        // ransomNote에 존재하는 문자인지 확인
        if (magazineFrequency.ContainsKey(key))
        {
            // magazine의 해당 문자 빈도수가 ransomNote의 빈도수보다 작으면 false 반환
            if (magazineFrequency[key] < ransomNoteFrequency[key])
            {
                return false;
            }
        }
        else
        {
            // magazine에 해당 문자가 없으면 false 반환
            return false;
        }
    }

    // 모든 조건을 통과하면 true 반환
    return true;
}
}