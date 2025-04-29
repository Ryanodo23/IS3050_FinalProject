/* File Name: LeetCodeProblem041.cs
 * Name: Ryan O'Donnell
 * Email:odonnerl@mail.uc.edu
 * Assignment Number: Final Project
 * Due Date: 04/29/2025
 * Course #/Section: 3050/001
 * Semester/Year: Spring/2025
 * Brief Description of the assignment: Solving a LeetCode problem and printing it onto a web page.
 * Brief Description of what this module does: Allows us the show off our skills using asp controls.
 * Citations: https://chatgpt.com/ the prompt was "Given an unsorted integer array nums. Return the smallest positive integer that is not present in nums
You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space." and then i asked it to write it in C#.
 */
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