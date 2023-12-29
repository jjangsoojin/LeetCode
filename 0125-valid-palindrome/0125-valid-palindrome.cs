using System;
using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        
            string news = Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", "", RegexOptions.Singleline);
            char[] arr = news.ToCharArray();


            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;

    }
}
