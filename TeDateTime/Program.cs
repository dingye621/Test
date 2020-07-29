using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VS2010TeDate;

namespace TeDateTime
{
    public class Program
    {
        public delegate void D1();
        D1 hadnder;

        static void Main(string[] args)
        {
            Methods.PlusOne(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6});
        }
    }
}
