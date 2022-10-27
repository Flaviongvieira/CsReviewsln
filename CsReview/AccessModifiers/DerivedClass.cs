using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.AccessModifiers
{
    public class DerivedClass: BaseClass
    {
        void DFunc()
        {
            //BPrivate = 1;    // ERROR : Nobody can view private vars of another class
            BProtected = 1;  //OK : derived class has access to protected vars of base class
            BPublic = 1;     //OK : Everybody has access to public members of any class
        }
    }
}
