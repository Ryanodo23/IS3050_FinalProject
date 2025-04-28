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

            MessageLabel.Text = "Starting Indices: " + string.Join(", ", indices);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Solution for LeetCode Problem #41
            int[] nums = { 1, 2, 0 };

            var solution = new LeetCodeProblem041();
            MessageLabel.Text = "First Missing Positive: " + solution.FirstMissingPositive(nums).ToString();
        }

        protected void ClearSolutions_Click(object sender, EventArgs e)
        {
            // Clear MessageLabel text
            MessageLabel.Text = string.Empty;
        }
    }
}
