using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.InheritancePolymorphism
{
    public class Student: Person
    {
        public override void PrintName()
        {
            Console.WriteLine("I am a Student");
        }
    }
}
