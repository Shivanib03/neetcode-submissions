public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int i = 0, j = people.Length - 1, boats = 0;
        while(i <= j)
        {
            if(people[j] == limit)
            {
                j--;
                boats++;
            }
            else if(people[j] < limit && people[j] + people[i] > limit)
            {
                j--; boats++;
            }
            else
            {
                i++;j--; boats++;
            }
        }
        return boats;
    }
}