public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        //if (strs == null || strs.Length == 0) return ""; 
        // StringBuilder sb = new StringBuilder(strs[0]);
        // int index = 0;
        // for(int i=0; i<strs.Length; i++)
        // {
        //     index = 0;
        //     for(int j=0; j< sb.Length; j++)
        //     {
        //         if (  index > strs[i].Length -1 || sb[index] != strs[i][j]) 
        //         {
        //             sb.Remove(index, sb.Length - index);
        //             break;
        //         }
        //         else if(sb[index] == strs[i][j])
        //         {
        //             index++;
        //         }
        //     }
        // }
        // return sb.ToString();

        // update and optmized solution ->

         if (strs == null || strs.Length == 0) return ""; 

        string common = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(common))
            {
                common = common.Substring(0, common.Length - 1);
                if (common == "") return "";
            }
        }
        return common;
    }
}