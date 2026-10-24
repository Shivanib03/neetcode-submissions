public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l = 0, r = matrix.Length - 1;
        int m = 0;
        while(l < r)
        {
            m = l + (r - l)/2;
            if(matrix[m][0] == target)
                return true;
            if(matrix[m][0] <= target && matrix[m][matrix[0].Length - 1] >= target)
            {
                l = m;
                break;
            }
            else if(matrix[m][0] <= target)
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }
        int left = 0, right = matrix[0].Length - 1;
        while(left < right)
        {
            int mid = left + (right - left)/2;
            if(matrix[l][mid] == target)
                return true;
            if(matrix[l][mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        if(matrix[l][left] == target)
            return true;
        return false;
    }
}
