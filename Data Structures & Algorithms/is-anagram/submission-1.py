class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        d = {};
        if len(s) != len(t):
            return False
        for i in s:
            d[i] = d.get(i, 0) + 1
        for i in t:
            if i not in d or d[i] <= 0:
                return False
            else:
                d[i] = d[i] - 1
        return True