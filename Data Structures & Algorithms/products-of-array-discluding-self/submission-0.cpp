class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        int no_z_prod = 1;
        int c = 0;
        for(auto i:nums)
        {
            if(i==0)
                ++c;
            else
            {
                no_z_prod *=i;
            }
        }
        vector<int> res;
        if(c==0)
        {
            for(auto i:nums)
                res.push_back(no_z_prod/i);
        }
        else if(c==1)
        {
            for(auto i:nums){
                if(i==0)
                    res.push_back(no_z_prod);
                else
                    res.push_back(0);
            }
        }
        else{
            for(auto i:nums)
                res.push_back(0);
        }
        return res;
    }
};
