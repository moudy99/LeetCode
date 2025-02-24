public class Solution {
    public bool IsPalindrome(string s) {
             if (string.IsNullOrEmpty(s)) return true;
     StringBuilder newStr = new StringBuilder();
     foreach(char c in s)
     {
         if (char.IsLetterOrDigit(c))
             newStr.Append(c);
     }

    string newStr2= newStr.ToString().ToLower();
     int first = 0;
     int last = newStr2.Length - 1;
     while (first < last)
     {
         if (newStr2[first] == newStr2[last])
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