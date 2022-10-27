using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Indexer
{
    public class WebConnection
    {
        private string[] connections;
        private int _size;
        public WebConnection(int size)
        {
            connections = new string[size];
            _size = size;
        }
        public string this[int index]
        {
            get { return connections[index]; }
            set { connections[index] = value; }
        }
        public int Length() { return _size; }
        public int FreeConnection()
        {
            for (int i = 0; i < this.Length(); i++)
            {
                if (this[i] == null)
                    return i;
            }
            throw new IndexOutOfRangeException("No connections available");
        }
    }
}
