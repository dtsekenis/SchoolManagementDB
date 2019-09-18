using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    public class StudentAssigments
    {
        public string CourseTitle { get; set; }
        public string AssignmentTitle { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{CourseTitle} , {AssignmentTitle} || {FirstName} || {LastName}";
        }

    }
}
