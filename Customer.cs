using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Customer : IComparable<Customer>
    {
        private string name;
        private int age;
        private string address;
        private float amountOwed;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public float AmountOwed
        {
            get { return amountOwed; }
            set { amountOwed = value; }
        }

        public string GetInformation()
        {
            return "Name: " + Name + ", Age: " + Age + ", Address: " + Address + ", Amount Owed: £" + AmountOwed.ToString("F2");
        }

        public int CompareTo(Customer other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}