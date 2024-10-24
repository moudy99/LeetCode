public class Solution {
    public  int LengthOfLongestSubstring(string s)
    {
   int maxLength = 0;
  int start = 0;
  Dictionary<char, int> map = new Dictionary<char, int>();

  for (int i = 0; i < s.Length; i++)
  {
      if (map.ContainsKey(s[i]))
      {
          start = Math.Max(start, map[s[i]] + 1);
      }

      map[s[i]] = i;

      maxLength = Math.Max(maxLength, i - start + 1);
  }

  return maxLength;
    }


}