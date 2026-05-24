
public class Solution {
    public List<int> MajorityElement(int[] nums) {
        Dictionary<int, int> freq_map = new Dictionary<int, int>();
        int n = nums.Length;
        List<int> res = new List<int>();
        foreach (int i in nums)
        {
            if (!freq_map.ContainsKey(i)) {
                freq_map[i] = 0;
            }
            freq_map[i]++;
            if (freq_map[i] > n / 3 && !res.Contains(i))
            {
                res.Add(i);
            }
        }
        return res; 
    }
};