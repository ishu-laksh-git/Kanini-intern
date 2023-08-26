using System.ComponentModel.DataAnnotations;

namespace InternManagementFinalSoln.Models
{
    public class InternLog
    {
        [Key]
        public int LogNumber { get; set; }
        public int InternId { get; set; }
        public DateTime LogDate { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogOutTime { get; set; }
    }
}
