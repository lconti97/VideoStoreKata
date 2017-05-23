using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class HTMLStatement : Statement
    {
        public HTMLStatement(Customer customer) : base(customer)
        { }

        public override String Print()
        {
            return ToString("<br />", "&nbsp");
        }
    }
}
