public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var res = new int[2];
        // for(int i = 0; i< numbers.Length; i++)
        // {
        //     int find = target;
        //     find -= numbers[i];
        //     for(int j = i+1; j < numbers.Length; j++)
        //     {
        //         if(find == numbers[j])
        //         {
        //             res[0] = numbers[i];
        //             res[1] = numbers[j];
        //             return res;
        //         }
        //     }
        // }
        int i = 0, j = numbers.Length - 1;
        while(i<j)
        {
            if(numbers[i] + numbers[j] == target)
            {
                res[0] = i + 1;
                res[1] = j + 1;
                return res;
            }
            else if(numbers[j] + numbers[i] > target)
            {
                j--;
            }
            else
            {
                i++;
            }
        }
        return res;
    }
}
