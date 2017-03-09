using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solu=new Solution();
            int result=solu.TitleToNumber("ABC");
            Console.WriteLine("result: {0}", result);
        }
    }
    
    
    public class Solution {
        public int TitleToNumber(string s) {
            char[] charArray=s.ToCharArray();
            int column=0;
            
            if(charArray.Length==0)
            {
                return 0;
            }else
            {
                int Base=1;
                for(var i=charArray.Length-1;i>=0;i--,Base*=26)
                {
                    column+=(charArray[i]-64)*Base;
                }
                return column;
            }
            
            return 0;
        }
    }
}
