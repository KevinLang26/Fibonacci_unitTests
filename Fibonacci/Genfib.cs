using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public class Genfib
    {
        public int Generate(int num)
        {
            int[] fibSeq = new int[num + 1];
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            fibSeq[0] = 0;
            fibSeq[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                fibSeq[i] = fibSeq[i - 1] + fibSeq[i - 2];
            }
            return fibSeq[num];
        }
    }
}
