public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        foreach(var c in ransomNote) 
        {
            if(magazine.Contains(c))
            {
                magazine = magazine.Remove(magazine.IndexOf(c),1);
            }else
            {
                return false;
            }
        }
        return true;
    }
}