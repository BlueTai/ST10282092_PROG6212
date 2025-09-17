using Microsoft.AspNetCore.Mvc;
using ST10282092_PROG6212_POE.Models;
using DateTime = System.DateTime;


namespace ST10282092_PROG6212_POE.Controllers
{
    public class ClaimsController : Controller
    {
        // Mock data (replace with DB later)
        private static readonly List<Claim> Claims = new List<Claim>
        {
            new Claim { ClaimId = 1001, ContractId="C-001", Title="Project Alpha Fee", Amount=500, LecturerName="Jane Doe", DateSubmitted=DateTime.Parse("2025-04-10"), Status="Pending" },
            new Claim { ClaimId = 1002, ContractId="C-002", Title="December Contract", Amount=700, LecturerName="John Smith", DateSubmitted=DateTime.Parse("2025-03-25"), Status="Approved" },
            new Claim { ClaimId = 1003, ContractId="C-003", Title="January Contract", Amount=600, LecturerName="Jane Doe", DateSubmitted=DateTime.Parse("2025-02-15"), Status="Rejected" }
        };

        // Lecturer Dashboard
        public IActionResult Lecturer()
        {
            var lecturerClaims = Claims.Where(c => c.LecturerName == "Jane Doe").ToList();
            return View(lecturerClaims);
        }

        // Manager Dashboard
        public IActionResult Manager()
        {
            var pendingClaims = Claims.Where(c => c.Status == "Pending").ToList();
            return View(pendingClaims);
        }

        // Handle submission of new claim
        [HttpPost]
        public IActionResult SubmitClaim(Claim newClaim)
        {
            newClaim.ClaimId = Claims.Max(c => c.ClaimId) + 1;
            newClaim.DateSubmitted = DateTime.Now;
            newClaim.Status = "Pending";
            newClaim.LecturerName = "Jane Doe"; // hardcoded for demo
            Claims.Add(newClaim);

            return RedirectToAction("Lecturer");
        }

        // Manager Approves Claim
        public IActionResult Approve(int id)
        {
            var claim = Claims.FirstOrDefault(c => c.ClaimId == id);
            if (claim != null) claim.Status = "Approved";
            return RedirectToAction("Manager");
        }

        // Manager Rejects Claim
        public IActionResult Reject(int id)
        {
            var claim = Claims.FirstOrDefault(c => c.ClaimId == id);
            if (claim != null) claim.Status = "Rejected";
            return RedirectToAction("Manager");
        }
    }
}

