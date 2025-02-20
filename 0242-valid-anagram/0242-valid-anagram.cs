public class Solution {
    public bool IsAnagram(string s, string t) {
  if (s.Length != t.Length)
  {
      return false;
  }
  for (int i = 0; i < s.Length; i++)
  {
      if (t.Contains(s[i]))
      {

          t = t.Remove(t.IndexOf(s[i]),1);
      }
      else
      {
          return false;
      }
  }
  return true;
}}