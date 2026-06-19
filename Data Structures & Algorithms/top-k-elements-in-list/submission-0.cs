public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        foreach(int num in nums)
        {
            if(d.ContainsKey(num))
                d[num]++;
            else
                d[num] = 1;
        }
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();

        foreach(var kv in d)
        {
            heap.Enqueue(kv.Key, kv.Value);
            if(heap.Count > k)
                heap.Dequeue();
        }
        int[] result = new int[k];
        for(int i = 0; i < k; i++)
        {
            result[i] = heap.Dequeue();
        }
        return result;
    }
}
