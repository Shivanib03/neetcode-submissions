public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var maxTemperature = new Stack<int>();
        var result = new int[temperatures.Length];
        for(int i = temperatures.Length - 1; i >= 0; i--)
        {
            //calculate
            if(maxTemperature.TryPeek(out int t))
            {
                if(temperatures[t] > temperatures[i])
                {
                    result[i] = t-i;
                }
                else
                {
                    while(temperatures[t] <= temperatures[i])
                    {
                        maxTemperature.TryPop(out int p);
                        if(maxTemperature.TryPeek(out int top))
                        {
                            t = top;
                            result[i] = t - i;
                        }
                        else
                        {
                            result[i] = 0;
                            break;
                        }
                    }
                }
            }
            else
            {
                result[i] = 0;
            }

            //decide to insert or not
            maxTemperature.Push(i);
        }
        return result;
    }
}
