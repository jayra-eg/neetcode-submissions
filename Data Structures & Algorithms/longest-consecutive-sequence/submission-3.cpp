class Solution {
public:
    int longestConsecutive(vector<int>& nums) {
        unordered_map<int,int> pres;
        int m = 1;
        if(nums.size()==0)
            return 0;
        if(nums.size()==1)
            return 1;
        sort(nums.begin(),nums.end());
        for(int i = 0;i<nums.size();i++)
        {
            if(pres.find(nums[i]-1)!=pres.end()) {
                pres[nums[i]] = pres[nums[i]-1]+1;
                m = max(pres[nums[i]],m);
            }
            else if (pres.find(nums[i]) == pres.end())
                pres[nums[i]] = 1;
        }
        return m;
    }
};