using System.ComponentModel.DataAnnotations;

namespace InternManagementFinalSoln.Models
{
    public class InternTicket
    {
        [Key]
        public int TicketNumber { get; set; }

        public int InternId { get; set; }
        public DateTime DateOfTicket { get; set; }
        public string? IssueTitle { get; set; }
        public string? IssueDetails { get; set; }

        public Boolean SolutionProvided { get; set; }
        public DateTime ResolvedDate { get; set; }
    }
}
