public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0)
            return 0;
        var numbers = new HashSet<int>(nums);
        var consecutive = 1;
        var currConsecutive = 1;
        foreach(int num in numbers)
        {
            if(numbers.Contains(num - 1))
            {
                continue;
            }
            var find = num + 1;
            while(numbers.Contains(find))
            {
                currConsecutive += 1;
                find++;
            }
            if(currConsecutive > consecutive)
                consecutive = currConsecutive;
            currConsecutive = 1;
        }
        return consecutive;
    }
}
