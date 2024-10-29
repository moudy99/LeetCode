public class Solution {
    public string LongestCommonPrefix(string[] strs) {
                if (strs.Length == 0) return "";

        string Prefix = strs[0];

        for (int i = 0; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(Prefix) != 0)
            {
                Prefix = Prefix.Substring(0, Prefix.Length - 1);

              if (Prefix == "") return "";
            }
        }

        return Prefix;
    }
}