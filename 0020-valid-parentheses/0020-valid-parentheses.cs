public class Solution {
    public bool IsValid(string s) {
    if(s.Length % 2 != 0) return false;
     Stack<char> stc = new Stack<char>();

     foreach(char c in s.ToCharArray())
     {
        if( c=='[' || c=='{' || c=='(')
        {
            stc.Push(c);
        }else
        {
        if(stc.Count ==0) return false;
            if(c ==']' && stc.Pop() != '[') return false;
            if(c =='}' && stc.Pop() != '{') return false;
            if(c ==')' && stc.Pop() != '(') return false;
        }
     }   
    if(stc.Count ==0) {
         return true;
    }else{
        return false;
    }
    }
}