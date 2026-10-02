public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length-1);
        return nums;
    }
    private static void MergeSort(int[] nums, int left, int right)
    {
        if(left >= right)
        {
            return;
        }
        int mid = left + (right - left)/2;
        MergeSort(nums, left, mid);
        MergeSort(nums, mid+1, right);
        Merge(nums, left, mid, right);
    }
    private static void Merge(int[] nums, int left, int mid, int right)
    {
        var temp = new int[right - left + 1];
        int i = left, j = mid + 1;
        int k = 0;
        while( i <= mid && j <= right)
        {
            if(nums[i] <= nums[j])
            {
                temp[k++] = nums[i++];
            }
            else
            {
                temp[k++] = nums[j++];
            }
        }
        while(i <= mid)
        {
            temp[k++] = nums[i++];
        }
        while(j <= right)
        {
            temp[k++] = nums[j++];
        }
        for(int index = 0; index < temp.Length; index++)
        {
            nums[left + index] = temp[index];
        }
    }
}