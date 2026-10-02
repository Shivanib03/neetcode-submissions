public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // if(m == 0|| n==0)
        //     return;
        int i = m - 1, j = n - 1;
        int k;
        for(k = m+n-1; k >= 0; k--)
        {
            if(i < 0 || j < 0)
            {    break;}
            if(nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
        }
        while(i >= 0)
        {
            nums1[k--] = nums1[i--]; 
        }
        while(j >= 0)
        {
            nums1[k--] = nums2[j];j--;
        }
    }
}