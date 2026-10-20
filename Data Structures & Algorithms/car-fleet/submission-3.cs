public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var car = new (int pos,double time)[position.Length];
        int fleet = 1;
        var stack = new Stack<double>();
        for(int i = 0; i < position.Length; i++)
        {
            car[i].pos = position[i]; 
            car[i].time = (double)(target - position[i])/speed[i];
        }
        Array.Sort(car,(a,b) => b.pos.CompareTo(a.pos));
        var prev = car[0].time; int j = 1;
        while(j < position.Length)
        {
            if(prev < car[j].time)
            {
                fleet++;
                prev = car[j].time;
            }
            j++;
        }
        return fleet;
    }
}
