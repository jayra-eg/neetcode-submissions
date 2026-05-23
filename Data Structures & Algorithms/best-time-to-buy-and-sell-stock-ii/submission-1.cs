public class Solution {

    Dictionary<string, int> dp = new Dictionary<string, int>();

    public int dfs(int st, int[] arr, bool op)
    {
        if (st == arr.Length)
            return 0;

        string key = st + "-" + op;

        if (dp.ContainsKey(key))
            return dp[key];

        int m = 0;

        // Buy
        if (op == false)
        {
            m = -arr[st] + dfs(st, arr, !op);
        }
        // Sell
        else
        {
            for (int i = st; i < arr.Length; i++)
            {
                if (arr[i] >= arr[st])
                {
                    m = Math.Max(m,
                        arr[i] + dfs(i + 1, arr, !op));
                }
            }
        }

        dp[key] = m;

        return m;
    }

    public int MaxProfit(int[] prices) {

        int m = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            m = Math.Max(m, dfs(i, prices, false));
        }

        return m;
    }
}