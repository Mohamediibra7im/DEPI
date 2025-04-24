namespace CMS.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; } // PK
        public string Semester { get; set; }
        public DateTime CreationDate { get; set; } // = Date only show file EnrollmentConfiguration
    }
}