using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class NodeInt
    {
        private int data;
        public NodeInt Left, Right;

        public NodeInt(int item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}