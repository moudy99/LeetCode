public class Solution {
    public bool IsAnagram(string s, string t) {

// Old solution with char[]; 
        // char[] charArray1 = s.ToCharArray();
        // char[] charArray2 = t.ToCharArray();

        // Array.Sort(charArray1);
        // Array.Sort(charArray2);

        // if(new string(charArray1) == new string(charArray2)) return true;
        // return false;

// test solution with HashMap (Dictionary)-> 


    if(s.Length != t.Length) return false;

    Dictionary<char,int> dic = new Dictionary<char,int>();
    foreach(char ch in s)
    {
        if(dic.ContainsKey(ch))
        {
            dic[ch] = dic[ch]++;
        }else{
            dic[ch]=1;
        }
    }

    foreach(char ch in t)
    {
        if(dic.ContainsKey(ch) && dic[ch] >0)
        {
            dic[ch] = dic[ch]--;
        }else{
            return false;
        }
    }
    return true;
}

}