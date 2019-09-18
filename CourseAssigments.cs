using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    public class CourseAssigments
    {
        public int CourseID { get; set; }
        public int AssigmentID { get; set; }
        public string Title { get; set; }
        public string AssignmentTitle { get; set; }
        public override string ToString()
        {
            return $"{CourseID} || {AssigmentID} || {Title} || {AssignmentTitle}";
        }

    }
}
