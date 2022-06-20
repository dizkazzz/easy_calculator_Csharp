using System;
using System.Collections.Generic;
using System.Text;

namespace AppWorking
{
    internal class Arguments
    {
        public int Summ (int x , int y)
        {
            return x + y;
        }

        public int Minus (int x , int y)
        {
            return x - y;
        }

        public int Delenie (int x , int y)
        { 

            try { return x / y; }
            catch (Exception ex) { return 0; };
        }

        public int Umn(int x, int y)
        {
            return x * y;
        }
    }
}
