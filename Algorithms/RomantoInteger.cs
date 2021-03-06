// Source : https://leetcode.com/problems/roman-to-integer/ 
// Author : codeyu 
// Date : 10/5/16 

/***************************************************************************************
*
* Given a roman numeral, convert it to an integer.
* Input is guaranteed to be within the range from 1 to 3999.
*
**********************************************************************************/
using System.Collections.Generic;
namespace Algorithms
{
    public class Solution013 
    {
        public static int RomanToInt(string s) 
        {

            Dictionary<char,int> dict = new Dictionary<char,int>{
                 {'M',1000},
                 {'D',500},
                 {'C',100},
                 {'L',50},
                 {'X',10},
                 {'V',5},
                 {'I',1}
            };
            int i = s.Length-1;
		    int ret = dict[s[i--]];
            while(i>=0)
            {
                if(dict[s[i+1]] > dict[s[i]])
                    ret -= dict[s[i--]];
                else
                    ret += dict[s[i--]];
            }     
            return ret;

        }
    }
}

