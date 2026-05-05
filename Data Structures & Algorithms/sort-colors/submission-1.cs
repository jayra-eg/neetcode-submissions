public class Solution {
    public void SortColors(int[] nums) {
        int st = 0;
        for(int i = 0;i<=2;i++)
        {
           int e = nums.Length - 1;
            while(st<e)
            {
                if(nums[st]==i)
                {
                    st++;
                    continue;
                }
                else
                {
                    if(nums[e]==i){
                        (nums[st],nums[e]) = (nums[e],nums[st]);
                        st++;
                        }
                    else{
                        e--;
                    }
                }
            }
        }
    }
}