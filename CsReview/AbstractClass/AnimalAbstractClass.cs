using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.AbstractClass
{
    public abstract class AnimalAbstractClass
    {

        // Abstract Class cannot be new object - it can only be referenced as object type
        // Animal a = new Animal();    <= WRONG

        public bool IsAlive { get; set; }

        public void Breathe()
        {
            Console.Write("I am Breathing! ");
        }

        abstract public void Move();

    }
}
