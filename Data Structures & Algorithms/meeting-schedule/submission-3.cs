/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        int[] res = new int[1000000];
        for(int i = 0; i < intervals.Count ; i++)
        {
            for(int j = intervals[i].start; j < intervals[i].end; j++)
            {
                if(res[j] > 0)
                    return false;
                res[j]++;
            }
        }
        return true;
    }
}
