using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Generics
{
    public class GenericList<T>
    {
        private T[] items = new T[100];

        public void Add(T input, int position)
        {
            if (position < 100)
                items[position] = input;
        }

        public void WriteItem(int position)
        {
            if (position >= 0 && position < 100)
                Console.Write("Item is " + items[position].ToString());
        }
    }
}
