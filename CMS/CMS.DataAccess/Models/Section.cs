namespace CMS.Models
{
    public class Section
    {
        public int SectionId { get; set; } // PK
        public string RoomNumber { get; set; }
        public string TAName { get; set; } // Teacher assistant for this section
        public DateTime MeetingTime { get; set; }
        public string SectionNum { get; set; }
        public int Capacity { get; set; }
        public string Semester { get; set; }
    }
}
