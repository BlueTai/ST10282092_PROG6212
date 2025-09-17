namespace ST10282092_PROG6212_POE.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public string ContractId { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string LecturerName { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string Status { get; set; }  // Pending, Approved, Rejected
    }
}

