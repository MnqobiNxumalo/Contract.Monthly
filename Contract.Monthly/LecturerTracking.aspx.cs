using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contract.Monthly
{
    public partial class LecturerTracking : System.Web.UI.Page
    {
        protected void CheckStatus_Click(object sender, EventArgs e)
        {
            int claimId = 123; // Hardcoded for simplicity, in reality, you'll fetch claim ID
                               // Fetch claim status from the database (not implemented)
            string claimStatus = "Pending"; // Example

            lblStatus.Text = $"Your claim status is: {claimStatus}";
        }
    }
}