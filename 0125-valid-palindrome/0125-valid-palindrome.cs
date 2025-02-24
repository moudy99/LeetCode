public class Solution {
    public bool IsPalindrome(string s) {
             if (string.IsNullOrEmpty(s)) return true;


     int first = 0;
     int last = s.Length - 1;
     while (first < last)
     {
        if(!char.IsLetterOrDigit(s[first])) {first++; continue;}
        if(!char.IsLetterOrDigit(s[last])) {last--; continue;}
         if (char.ToLower(s[first]) == char.ToLower(s[last]))
         {
             last--;
             first++;
         }
         else
         {
             return false;
         }
     }
     return true;
        
    }
}