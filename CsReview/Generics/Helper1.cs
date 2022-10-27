using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Generics
{
    public class Helper1<T>
    {
        public void Method1(T input)
        {
            Console.WriteLine(input.ToString()); 
        }
    }
}
