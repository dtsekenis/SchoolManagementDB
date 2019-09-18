using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    public class Trainers
    {
        public int TrainerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }


        public override string ToString()
        {
            return $"{TrainerID}) {FirstName} || {LastName} || {Subject}";
        }
    }
}

