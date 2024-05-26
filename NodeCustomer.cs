using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class NodeCustomer
    {
        private Customer data;
        public NodeCustomer Left, Right;

        public NodeCustomer(Customer item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public Customer Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}