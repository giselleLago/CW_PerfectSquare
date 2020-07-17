using System;
using System.Collections.Generic;
using System.Text;

namespace CW_PerfectSquare
{
    public class Kata
    {
        public long FindNextSquare(long num)
        {
            var sr = Math.Sqrt(num);
            if (sr - Math.Floor(sr) == 0)
            {
                return (long)Math.Pow((sr + 1),2);
                
            }
            return -1;
        }
    }
}
