using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEF_Core.Model
{
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CertificateName { get; set; }

        public string College { get; set; }
        public string Location { get; set; }
        public string Contry { get; set; }
    }
}
