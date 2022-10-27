using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.InheritancePolymorphism
{
    public class Person
    {
        /*The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class. 
         * For example, this method can be overridden by any class that inherits it:*/
        public virtual void PrintName()
        {
            Console.WriteLine("I am a person");
        }
    }
}
