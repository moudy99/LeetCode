public class Solution {
    public IList<string> FizzBuzz(int n) {
        IList<string> answers = new List<string>();
        for(int i=1 ; i<= n; i++)
        {
            if(i % 3 ==0 && i%5 ==0) answers.Add("FizzBuzz");
            else if(i% 3 ==0) answers.Add("Fizz");
            else if(i% 5 ==0) answers.Add("Buzz");
            else
            {
                answers.Add(i.ToString());
            }
        }
        return answers;
    }
}