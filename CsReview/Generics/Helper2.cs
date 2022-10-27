using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Generics
{
    public class Helper2<T, P>
    {
        public T Method1(T input)
        {
            return input;
        }

        public void Method2(T input1, P input2)
        {
            Console.WriteLine(input1.ToString() + input2.ToString()); 
        }
    }
}

