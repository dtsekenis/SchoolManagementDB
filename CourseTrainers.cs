using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    public class CourseTrainers
    {
        //public int CourseID { get; set; }
        //public int TrainerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }


        public override string ToString()
        {
            return $"{FirstName} || {LastName} || {Title}";
        }
    }
}
