// Source : https://leetcode.com/problems/wildcard-matching/ 
// Author : codeyu 
// Date : Monday, October 31, 2016 12:18:24 AM 

/**********************************************************************************
*
* Implement wildcard pattern matching with support for '?' and '*'.
* 
* 
* '?' Matches any single character.
* '*' Matches any sequence of characters (including the empty sequence).
* 
* The matching should cover the entire input string (not partial).
* 
* The function prototype should be:
* bool isMatch(const char *s, const char *p)
* 
* Some examples:
* isMatch("aa","a") ? false
* isMatch("aa","aa") ? true
* isMatch("aaa","aa") ? false
* isMatch("aa", "*") ? true
* isMatch("aa", "a*") ? true
* isMatch("ab", "?*") ? true
* isMatch("aab", "c*a*b") ? false
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution044
    {
        public static bool IsMatch(string s, string p)
        {
            if (p.Length == 0)
                return s.Length == 0;
            bool[] res = new bool[s.Length + 1];
            res[0] = true;
            for (int j = 0; j < p.Length; j++)
            {
                if (p[j] != '*')
                {
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        res[i + 1] = res[i] && (p[j] == '?' || s[i] == p[j]);
                    }
                }
                else
                {
                    int i = 0;
                    while (i <= s.Length && !res[i])
                        i++;
                    for (; i <= s.Length; i++)
                    {
                        res[i] = true;
                    }
                }
                res[0] = res[0] && p[j] == '*';
            }
            return res[s.Length];

        }
    }
}

