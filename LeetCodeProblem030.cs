using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forecasters_FinalProject
{
    public class LeetCodeProblem030
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            List<int> result = new List<int>();
            if (words.Length == 0 || s.Length == 0) return result;

            int wordLength = words[0].Length;
            int wordCount = words.Length;
            int totalLength = wordLength * wordCount;

            // Build a frequency map of words
            Dictionary<string, int> wordDict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordDict.ContainsKey(word))
                    wordDict[word]++;
                else
                    wordDict[word] = 1;
            }

            // Check for each possible offset
            for (int i = 0; i < wordLength; i++)
            {
                int left = i;
                int right = i;
                Dictionary<string, int> windowDict = new Dictionary<string, int>();
                int count = 0;

                while (right + wordLength <= s.Length)
                {
                    string word = s.Substring(right, wordLength);
                    right += wordLength;

                    if (wordDict.ContainsKey(word))
                    {
                        if (windowDict.ContainsKey(word))
                            windowDict[word]++;
                        else
                            windowDict[word] = 1;

                        count++;

                        // If the window contains more of 'word' than needed, shrink from the left
                        while (windowDict[word] > wordDict[word])
                        {
                            string leftWord = s.Substring(left, wordLength);
                            windowDict[leftWord]--;
                            count--;
                            left += wordLength;
                        }

                        // If all words matched
                        if (count == wordCount)
                        {
                            result.Add(left);
                        }
                    }
                    else
                    {
                        // Reset the window
                        windowDict.Clear();
                        count = 0;
                        left = right;
                    }
                }
            }

            return result;
        }
    }
}