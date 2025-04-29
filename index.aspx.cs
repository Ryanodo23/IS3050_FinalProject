using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using static System.Net.Mime.MediaTypeNames;

namespace Forecasters_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Solution for LeetCode Problem #4
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };

            var solution = new LeetCodeProblem004();
            double median = solution.FindMedianSortedArrays(nums1, nums2);
            lbl1.Text = "Problem 004: Given two sorted arrays nums1 and nums2 of size m and n respectively, return" +
                "the median of the two sorted arrays. The overall run time complexity should be 0(log (m+n)).";
            lbl2.Text = "Test Case: nums1 = [1,3], nums2 = [2]";
            MessageLabel.Text = $"The median of these two arrays is: {median}.";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Solution for LeetCode Problem #30
            string s = MessageLabel.Text;  // Assuming input is set in MessageLabel somehow
            string[] words = MessageLabel.Text.Split(',');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }

            var solver = new LeetCodeProblem030();
            IList<int> indices = solver.FindSubstring(s, words);
            lbl1.Text = "Problem 030: You are given a string s and an array of strings words. " +
                "All the strings of words are of the same length.A concatenated " +
                "string is a string that exactly contains all the strings of any permutation of words concatenated." +
                "Return an array of the starting indices of all the concatenated substrings in s. You can return the answer in any order."
                ;
            lbl2.Text = "Test Case: s = 'barfoothefoobarman', words = ['foo','bar'] ";
            MessageLabel.Text = "Starting Indices: " + string.Join(", ", indices);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Solution for LeetCode Problem #41
            int[] nums = { 1, 2, 0 };

            var solution = new LeetCodeProblem041();
            lbl1.Text = "Problem 041: Given an unsorted integer array nums. Return the smallest positive integer " +
                "that is not present in nums. You must implement an algorithm that runs in 0(n) time" +
                "and uses 0(1) auxiliary space.";
            lbl2.Text = "Test Case: nums = [1,2,0]";
            MessageLabel.Text = "First Missing Positive: " + solution.FirstMissingPositive(nums).ToString();
        }

        protected void ClearSolutions_Click(object sender, EventArgs e)
        {
            // Clear MessageLabel text
            MessageLabel.Text = string.Empty;
        }
    }
}
