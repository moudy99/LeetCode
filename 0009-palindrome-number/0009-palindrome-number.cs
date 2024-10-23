public class Solution {
    public bool IsPalindrome(int x) {
                string st = Convert.ToString(x);
        int first = 0;
        int last = st.Length - 1;

        while (first < last)
        {
            if (st[first] != st[last]) return false;

            first++;
            last--;
        }
        return true;
    }
}