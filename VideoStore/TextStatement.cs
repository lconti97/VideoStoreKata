using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class TextStatement : Statement
    {
        public TextStatement(Customer customer) : base(customer)
        { }

        public override String Print()
        {
            return ToString("\n", "\t");
        }
    }
}
