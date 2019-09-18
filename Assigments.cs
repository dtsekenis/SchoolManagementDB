using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    public class Assigments
    {
        public int AssigmentID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public override string ToString()
        {
            return $"{AssigmentID}) {Title} || {Description} || {SubDateTime}";
        }
    }
}

