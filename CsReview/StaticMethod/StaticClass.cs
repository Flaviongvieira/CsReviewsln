using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.StaticMethod
{
    //Note : I cant create an instance (object) from the StaticClass  static class (i.e  StaticClass m = new StaticClass())
    //I must call methods straight off the class   

    /*A static class is basically the same as a non-static class, but there is one difference: 
     * a static class cannot be instantiated.In other words, you cannot use the new operator to 
     * create a variable of the class type. Because there is no instance variable, you access 
     * the members of a static class by using the class name itself.*/

    public class StaticClass
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

    }
}
