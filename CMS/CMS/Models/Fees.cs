namespace CMS.Models
{
    public class Fees
    {
        public int FeeId { get; set; } // PK
        public int Amount { get; set; }
        public DateTime DueDate { get; set; } // Date and time not date only
        public string Status { get; set; }
    }
}