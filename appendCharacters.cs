using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettCode
{
    internal class appendCharacters
    {


        public static int  appendCharacter (string s, string t)
        {
            int tCount = 0;
            int sCount = 0;


            int tLength = t.Length;
            int sLength = s.Length;


            while (sLength != 0 && tLength != 0) 
            { 
            
                if (s[sCount] == t[tCount])
                {
                    sCount++;
                    tCount++;
                    tLength--; 
                }
                else
                {
                    sCount++;
                }


                sLength--;

            }
            return tLength; 
        }
    }
}
