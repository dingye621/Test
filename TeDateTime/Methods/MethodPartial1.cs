using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS2010TeDate
{
    public partial class Methods
    {
        public static int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length <= 0)
                return digits;
            long res = 0;
            var ti = 0;
            for (int i = digits.Length - 1; i >=0; i--)
            {
                res += Convert.ToInt64(Math.Pow(10,ti) * digits[i]);
                ti++;
            }
            res++;
            var tmp = res.ToString().ToArray();
            int[] arr2 = new int[tmp.Length];
            for (int i = 0; i < arr2.Length ; i++)
            {
                arr2[i] = Convert.ToInt32(tmp[i].ToString());
            }
            return arr2;
        }

        public int FirstBadVersion(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                if (IsBadVersion(i))
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
