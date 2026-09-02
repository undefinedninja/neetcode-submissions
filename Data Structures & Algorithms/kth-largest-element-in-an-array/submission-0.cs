public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> q = new PriorityQueue<int, int>();

        foreach(int i in nums)
        {
            q.Enqueue(i, i);
            if(q.Count > k)
                q.Dequeue();
        }
        return q.Dequeue();
    }
}
