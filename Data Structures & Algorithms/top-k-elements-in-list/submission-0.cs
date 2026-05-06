public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // 1. Map frequencies
        var dict = new Dictionary<int, int>();
        foreach (int num in nums) {
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        }

        // 2. Initialize Max-Priority Queue 
        // We pass a custom comparer to make it act as a Max-Heap
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        // 3. Enqueue elements with their frequency as priority
        foreach (var entry in dict) {
            pq.Enqueue(entry.Key, entry.Value);
        }

        // 4. Extract the top K elements
        int[] res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = pq.Dequeue();
        }

        return res;
    }
}
