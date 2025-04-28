using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forecasters_FinalProject
{
    public class LeetCodeProblem041
    {
        public int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            // Step 1: Place each number in its correct position if possible
            for (int i = 0; i < n; i++)
            {
                while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                {
                    int correctIndex = nums[i] - 1;
                    // Swap nums[i] with nums[correctIndex]
                    int temp = nums[i];
                    nums[i] = nums[correctIndex];
                    nums[correctIndex] = temp;
                }
            }

            // Step 2: Find the first location where the index doesn't match the value
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }

            // If all numbers are in the correct place, the answer is n + 1
            return n + 1;
        }

    }
}