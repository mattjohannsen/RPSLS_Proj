using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Outcome
    {
        bool outcome0;
        bool outcome1;
        bool outcome2;
        bool outcome3;
        bool outcome4;

        public Outcome(bool outcome0, bool outcome1, bool outcome2, bool outcome3, bool outcome4)
        {
            this.outcome0 = outcome0;
            this.outcome1 = outcome1;
            this.outcome2 = outcome2;
            this.outcome3 = outcome3;
            this.outcome4 = outcome4;
        }
    }
}
