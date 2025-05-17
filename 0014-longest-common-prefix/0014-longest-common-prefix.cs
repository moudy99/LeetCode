public class Solution {
    public string LongestCommonPrefix(string[] strs) {
      
        StringBuilder sb = new StringBuilder(strs[0]);
        int index = 0;
        for(int i=0; i<strs.Length; i++)
        {
            index = 0;
            for(int j=0; j< sb.Length; j++)
            {
                if (  index > strs[i].Length -1 || sb[index] != strs[i][j]) 
                {
                    sb.Remove(index, sb.Length - index);
                    break;
                }
                else if(sb[index] == strs[i][j])
                {
                    index++;
                }
            }
        }
        return sb.ToString();

    }
}