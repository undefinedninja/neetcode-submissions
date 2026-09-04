public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for(int i =0; i < matrix.Length; i++)
        {
            int[] array = matrix[i];
            int n = array.Length - 1;
            if(array[n] == target)
            {
                return true;
            }
            else if(array[n] > target)
            {
                int left = 0;
                int right = n;

                while(left <= right)
                {
                    int mid = left + (right - left)/2;
                    if(array[mid] == target) 
                    {
                        return true;
                    }
                    else if(array[mid] > target)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }
            else 
            {
                continue;
            }
        }
        return false;
    }
}
