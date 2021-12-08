using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THI
{
    class Questions
    {
        public  String  id { get; set; }
        public  String Content { get; set; }

        public String A { get; set; }
        public String B { get; set; }
        public String C { get; set; }
        public String D { get; set; }

        public Questions()
        {

        }

        public override string ToString()
        {
            return this.id + ". " + this.Content +". " + this.A + ". " + this.B + ". " + this.C + ". " + this.D;
        }
    }
    
}
