public class Solution {
    public List<int> MajorityElement(int[] nums) {
        if(nums.Length == 1)
        {
            return new List<int>(){nums[0]};
        }
        int n1 = -1, n2 = -1;
        int[] count = new int[] {0,0};
        var res = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == n1)
            {
                count[0] += nums[i] == n1 ? 1 : 0;
            }
            else if(nums[i] == n2)
            {
                count[1] += nums[i] == n2 ? 1 : 0;
            }
            else if(count[0] == 0)
            {
                n1 = nums[i];
                count[0] = 1;
            }
            else if(count[1] == 0)
            {
                n2 = nums[i];
                count[1] = 1;
            }
            else
            {
                count[0]--; count[1]--;
            }
        }
        count[0] = count[1] = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == n1) count[0]++;
            else if(nums[i] == n2) count[1]++;
        }
        if(count[0] > nums.Length/3) res.Add(n1);
        if(count[1] > nums.Length/3 && n1 != n2)
        {
            res.Add(n2);
        }
        return res;
        // if(nums.Length == 1)
        // {
        //     return new List<int>(){nums[0]};
        // }
        // int n1 = nums[0], n2 = nums[1];
        // int[] count = new int[] {1,1};
        // var res = new List<int>();
        // for(int i = 2; i < nums.Length; i++)
        // {
        //     if(nums[i] != n1 && nums[i] != n2)
        //     {
        //         count[0]--; count[1]--;
        //     }
        //     else if(nums[i] == n1 || nums[i] == n2)
        //     {
        //     count[0] += nums[i] == n1 ? 1 : 0;
        //     count[1] += nums[i] == n2 ? 1 : 0;
        //     }
        //     else if(count[0] == 0)
        //     {
        //         n1 = nums[i];
        //     }
        //     else if(count[1] == 0)
        //     {
        //         n2 = nums[i];
        //     }
        // }
        // Console.WriteLine($"{n1}, {n2}");
        // count[0] = count[1] = 0;
        // for(int i = 0; i < nums.Length; i++)
        // {
        //     if(nums[i] == n1) count[0]++;
        //     else if(nums[i] == n2) count[1]++;
        // }
        // Console.WriteLine($"{count[0]}, {count[1]}");
        // if(count[0] > nums.Length/3) res.Add(n1);
        // if(count[1] > nums.Length/3 && n1 != n2)
        // {
        //     res.Add(n2);
        // }
        // return res;
    }
}