using System;
using System.Linq;

namespace CodingKatas.Array.Strings
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x >= int.MaxValue || x <= int.MinValue) return 0;
            var str=   Math.Abs(x).ToString();
          
            if (int.TryParse(string.Join("",str.ToCharArray().Reverse()), out var result))
            {
                var negative = x < 0 ? -1 : 1;
                return result * negative;
            }

            return 0;
        }
    }
}