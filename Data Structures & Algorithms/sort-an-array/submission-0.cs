public class Solution {
    public int[] SortArray(int[] nums) {
        
        if(nums == null || nums.Length <= 1)
            return nums;

        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    public static void MergeSort(int[] num , int l , int r)
    {
        if(l < r)
        {
            int m = l + (r - l) / 2;
            MergeSort(num, l , m);
            MergeSort(num, m + 1, r);

            Merge(num, l, m, r);
        }
        return;
    }

    public static void Merge(int[] num, int l, int m, int r)
    {
        int l1 = m - l + 1;
        int l2 = r - m;
        int[] left = new int[l1];
        int[] right = new int[l2];

        for(int k=0; k<l1 ; k++)
            left[k] = num[l + k];

        for(int k=0; k<l2; k++)
            right[k] = num[k + m + 1];

        int pointer = l;
        int i=0 ,j=0;
        while(i<l1 && j<l2)
        {
            if(left[i] <= right[j])
            {
                num[pointer] = left[i];
                i++;
            }
            else
            {
                num[pointer] = right[j];
                j++;
            }
            pointer++;
        }

        while(i<l1)
        {
            num[pointer] = left[i];
            i++;
            pointer++;
        }

        while(j<l2)
        {
            num[pointer] = right[j];
            j++;
            pointer++;

        }
    }
}