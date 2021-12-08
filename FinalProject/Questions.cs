using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Questions
    {
        public int ID { get; set; }
        public String Content { get; set; }
        public String ABC { get; set; }

        public Questions()
        {
            this.ID = 0;
            this.Content = "";
            this.ABC = string.Empty;
        }

        public Questions (String sID, String CT, String abc)
        {
            this.ID = int.Parse(sID);
            this.Content = CT;
            this.ABC = abc;
        }

        public override string ToString()
        {
            return this.ID.ToString() + ". " + this.Content + " _ " + this.ABC;
        }
    }
}
