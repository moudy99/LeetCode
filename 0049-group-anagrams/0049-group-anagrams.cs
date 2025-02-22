public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,int> dic = new Dictionary<string,int>();
        IList<IList<string>> returnList = new List<IList<string>>();
        int index=0;
        for(int i=0; i < strs.Length; i++)
        {
            char[] tempStr =  strs[i].ToCharArray();
            Array.Sort(tempStr);
            string temp = new string(tempStr);
            if(dic.ContainsKey(temp))
            {
                int tempIndex = dic[temp];
                returnList[tempIndex].Add(strs[i]);

            }else{
                returnList.Add(new List<string>(){strs[i]});
                dic.Add(temp,index);
                index++;
            }
        }
        return returnList;
    }
}