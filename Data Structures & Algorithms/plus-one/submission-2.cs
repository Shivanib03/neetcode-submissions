public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 1;
        for(int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i] += carry;
            if(digits[i] == 10)
            {
                digits[i] = 0;
                carry = 1;
            }
            else
            {
                carry = 0;
                break;
            }
        }
        if(carry == 1)
        {
            var res = new int[digits.Length + 1];
            res[0] = carry;
            return res;
        }
        return digits;
    }
}
