using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {

        static Dictionary<long, double> Memoization = new Dictionary<long, double>()
        { { 0,0},{1,1 } };  //
     


        /*Very solw*/


        public long  BasicRecrusive(long i )
        {
            if (i == 0)
                return 0;
            else if (i == 1)
                return 1;
            else
                return BasicRecrusive(i - 1) + BasicRecrusive(i - 2);

        }


        /*Memoization*/

        public double MemoizationRecrusive(int i)
        {
            if (Memoization.ContainsKey(i))
                return Memoization[i];

            var value = MemoizationRecrusive(i - 1) + MemoizationRecrusive(i - 2);

            Memoization[i] = value;

            return value;


        }




    }
}
