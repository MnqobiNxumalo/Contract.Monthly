using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contract.Monthly
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public string LecturerName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; } = "Pending"; // Default status
        public string SupportingDocument { get; set; }
       
        
    }
}