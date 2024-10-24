using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contract.Monthly
{
    public partial class CoordinatorView : System.Web.UI.Page
    {
        protected void gridClaims_RowCommand(object sender, GridViewCommandEventArgs e)
{
    int claimId = Convert.ToInt32(e.CommandArgument);
    // Fetch claim from database (not implemented)
    
    if (e.CommandName == "Approve")
    {
        // Update the status in the database to Approved
        lblMessage.Text = $"Claim {claimId} has been approved.";
    }
    else if (e.CommandName == "Reject")
    {
        // Update the status in the database to Rejected
        lblMessage.Text = $"Claim {claimId} has been rejected.";
    }

    // Rebind the GridView to show updated status
}
    }
}