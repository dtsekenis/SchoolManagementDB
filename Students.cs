using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    public class Students
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal TuitionFees { get; set; }

        //public static List<Students> Student = new List<Students>();
        public override string ToString()
        {
            return $"{StudentID}) {FirstName} || {LastName} || {DateOfBirth} || {TuitionFees}";
        }
    }
}

