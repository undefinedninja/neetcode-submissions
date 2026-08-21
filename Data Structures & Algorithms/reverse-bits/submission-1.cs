public class Solution {
    public uint ReverseBits(uint n) {
        uint res = 0;
        for (int i = 0; i < 32; i++)
        {
            if ((n & (1u << i)) != 0)
            {
                res = res | (1u << (31-i));
            }
        }
        return res;
    }
}
