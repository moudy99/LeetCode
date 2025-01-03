public class Solution {
            public int NumberOfSteps(int num) {
                int totalSteps = 0;
        int number = num;
        while (number > 0)
        {
            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = number - 1;
            }

            totalSteps++;
        }

        return totalSteps;
            }
}