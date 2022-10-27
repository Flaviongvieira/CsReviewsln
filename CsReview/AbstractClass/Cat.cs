using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.AbstractClass
{
    public class Cat: AnimalAbstractClass
    {
        public override void Move()
        {
            Console.WriteLine("I am Cat, I'm lazy and I dont move!");

            // Other Cat Code
        }
    }
}
