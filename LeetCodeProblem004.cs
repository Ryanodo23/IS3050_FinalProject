using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forecasters_FinalProject
{
    public class LeetCodeProblem004
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            int m = nums1.Length;
            int n = nums2.Length;
            int total = m + n;
            int half = total / 2;

            int left = 0, right = m;
            while (left <= right)
            {
                int i = (left + right) / 2;
                int j = half - i;

                int nums1Left = (i == 0) ? int.MinValue : nums1[i - 1];
                int nums1Right = (i == m) ? int.MaxValue : nums1[i];
                int nums2Left = (j == 0) ? int.MinValue : nums2[j - 1];
                int nums2Right = (j == n) ? int.MaxValue : nums2[j];

                if (nums1Left <= nums2Right && nums2Left <= nums1Right)
                {
                    if (total % 2 == 0)
                    {
                        return (Math.Max(nums1Left, nums2Left) + Math.Min(nums1Right, nums2Right)) / 2.0;
                    }
                    else
                    {
                        return Math.Min(nums1Right, nums2Right);
                    }
                }
                else if (nums1Left > nums2Right)
                {
                    right = i - 1;
                }
                else
                {
                    left = i + 1;
                }
            }

            return 0.0;
        }
    }
}