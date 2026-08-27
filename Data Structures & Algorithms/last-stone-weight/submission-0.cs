public class Solution {
    public int LastStoneWeight(int[] stones) {
        var maxHeap = new PriorityQueue<int, int>(
            Comparer<int>.Create((x, y) => y.CompareTo(x))
        );        foreach(int i in stones)
        {
            maxHeap.Enqueue(i, i);
        }
        while(maxHeap.Count > 1)
        {
            int f = maxHeap.Dequeue();
            int s = maxHeap.Dequeue();
            maxHeap.Enqueue(f - s, f - s);
        }
        return maxHeap.Dequeue();
    }
}
