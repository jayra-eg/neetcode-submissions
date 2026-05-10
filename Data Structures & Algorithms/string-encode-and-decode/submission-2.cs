public class Solution {
    char delimitter = '\n';
    public string Encode(IList<string> strs) {
        string encoded = "";
        foreach(string str in strs)
        {
            encoded = encoded + str + delimitter;
        }
        return encoded;
    }

    public List<string> Decode(string s) {
        int n = s.Length;
        int i = 0;
        List<string> res = new List<string>();
        string temp = "";
        while(i<n)
        {
            if(s[i]!=delimitter)
            {
                temp+=s[i];
            }
            else
            {
                res.Add(temp);
                temp = "";
            }
            ++i;
        }
        return res;

   }
}
