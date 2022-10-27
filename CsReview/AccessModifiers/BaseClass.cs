using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.AccessModifiers
{
    public class BaseClass
    {
        private int BPrivate { get; set; }
        protected int BProtected { get; set; }
        public int BPublic { get; set; }


        void BFunc()
        {
            //Class has access to all its OWN members (private ,protected,public)
            BPrivate = 1;
            BProtected = 1;
            BPublic = 1;
        }

        private void privateMethod()
        {
            Console.WriteLine("Private : can only be callled from methods in my own class");
        }

        protected void protectedMethod()
        {
            Console.WriteLine("protecte : can only be callled from methods in my own class AND DERIVED classes");
        }

        public void publicMethod()
        {
            Console.WriteLine("public : can be called form any class");
        }
    }
}
