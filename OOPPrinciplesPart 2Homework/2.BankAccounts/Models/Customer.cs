using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts.Models
{
    public class Customer
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format(this.Name);
        }
    }
}
