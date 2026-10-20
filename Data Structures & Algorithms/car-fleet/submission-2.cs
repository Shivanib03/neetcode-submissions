public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var car = new (int pos,double time)[position.Length];
        int fleet = 0;
        var stack = new Stack<double>();
        for(int i = 0; i < position.Length; i++)
        {
            car[i].pos = position[i]; 
            car[i].time = (double)(target - position[i])/speed[i];
        }
        Array.Sort(car,(a,b) => b.pos.CompareTo(a.pos));
        for(int i = 0; i < car.Length; i++)
        {
            //Console.WriteLine($"pos:{car[i].pos}, time: {car[i].time}");
            if(stack.TryPeek(out double top))
            {
                if(car[i].time > top)
                {
                    while(car[i].time > top && stack.Count > 0)
                    {
                        stack.Pop();
                        if(stack.TryPeek(out double t))
                        {
                            top = t;
                        }
                    }
                    fleet++;
                    stack.Push(car[i].time);
                }
            }
            else
            {
                stack.Push(car[i].time);
            }
        }
        return fleet + 1;
    }
}
