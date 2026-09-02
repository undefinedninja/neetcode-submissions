public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int, double> q = new PriorityQueue<int, double>();
        int  o = 0;
        foreach(int[] p in points)
        {
            double d = Math.Sqrt(Math.Pow(p[0], 2) + Math.Pow(p[1], 2));
            q.Enqueue(o, d);
            o++;
        }
        int[][] res = new int[k][];
        for(int i = 0; i < k ; i++)
        {
            res[i] = points[q.Dequeue()];
        }
        return res;
    }
}
