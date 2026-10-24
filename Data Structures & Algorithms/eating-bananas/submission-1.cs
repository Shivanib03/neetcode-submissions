public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = piles.Max();
        var k = r;
        while(l < r)
        {
            int mid = l + (r - l)/2;
            int hcnt = 0;
            for(int i = piles.Length - 1; i >= 0; i--)
            {
                hcnt += (piles[i] + mid - 1)/mid; //(int)Math.Ceiling((double)piles[i]/mid);
            }
            if(hcnt > h)
            {
                l = mid + 1;
            }
            else
            {
                k = mid;
                r = mid;
            }
        }
        return k;
    }
}
