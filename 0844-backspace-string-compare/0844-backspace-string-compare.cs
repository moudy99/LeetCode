public class Solution {
    public bool BackspaceCompare(string s, string t) {
        StringBuilder s1= new StringBuilder();
        StringBuilder s2= new StringBuilder();

        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == '#' && s1.Length >0)
            {
                s1.Remove(s1.Length -1 , 1);
            }else if(s[i] != '#')
            {
                s1.Append(s[i]);
            }
        }

        for(int i=0; i<t.Length; i++)
        {
            if(t[i] == '#' && s2.Length >0)
            {
                s2.Remove(s2.Length -1 , 1);
            }else if (t[i] != '#')
            {
                s2.Append(t[i]);
            }
        }

        return ((new string(s1.ToString())) == (new string(s2.ToString())));
    }
}