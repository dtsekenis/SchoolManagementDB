using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    public class MoreThanOne
    {
        
        public int StudentID { get; set; }
        public string FirstName { get; set; }

        public override string ToString()
        {
            return $"{StudentID} || {FirstName}";
        }
    }
}
