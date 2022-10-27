using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Generics
{
    public static class GenericMethodsSample
    {
        //Sample method that accepts generic parameter
        public static void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }

        //Sample method that accepts 2 generic parameter and return a generic parameter
        public static T ReturnSomething<T, P>(T item1, T Item2, P var1)
        {
            if (var1 == null)
                return item1;
            else
                return Item2;
        }
        
    }
}
