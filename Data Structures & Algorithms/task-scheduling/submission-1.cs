    public class Solution {
        public int LeastInterval(char[] tasks, int n) {
            Dictionary<char, int> f = new Dictionary<char, int>();
            PriorityQueue<(char, int), int> pq = new  PriorityQueue<(char, int), int>();
            Queue<(char, int, int)> cq = new Queue<(char, int, int)>();
            foreach(char c in tasks)
            {
                if(f.ContainsKey(c))
                    f[c]++;
                else
                    f.Add(c, 1);
            }

            foreach(char c in f.Keys)
            {
                pq.Enqueue((c, f[c]), -f[c]);
            }
            int time = 0;
            while(pq.Count > 0 || cq.Count > 0)
            {
                while(cq.Count > 0 && cq.Peek().Item3 <= time)
                {
                    (char, int, int) avlTask = cq.Dequeue();
                    pq.Enqueue((avlTask.Item1, avlTask.Item2), -avlTask.Item2);
                }
                    // add to heap
                if(pq.Count > 0)
                {
                        var task = pq.Dequeue();

                        int remaining = task.Item2 - 1;

                        if(remaining > 0)
                        {
                            cq.Enqueue((task.Item1, remaining, time + n + 1));
                        }

                        time++;
                }
                else
                    time++;
            }
            return time;
        }
    }
