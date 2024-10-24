using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contract.Monthly
{
    public partial class SubmitClaim : Page
    {
        protected void SubmitClaim_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (decimal.TryParse(txtHoursWorked.Text, out decimal hoursWorked) &&
                decimal.TryParse(txtHourlyRate.Text, out decimal hourlyRate) &&
                fileUpload.HasFile)
            {
                // Validate file type and size
                string[] allowedExtensions = { ".pdf", ".docx", ".xlsx" };
                string fileExtension = Path.GetExtension(fileUpload.FileName).ToLower();
                int maxFileSize = 5 * 1024 * 1024; // 5 MB

                if (Array.Exists(allowedExtensions, extension => extension == fileExtension) &&
                    fileUpload.PostedFile.ContentLength <= maxFileSize)
                {
                    // Save the uploaded file
                    string filePath = Server.MapPath("~/Uploads/" + fileUpload.FileName);
                    fileUpload.SaveAs(filePath);

                    // Create new claim and save to the database (database code not shown)
                    Claim claim = new Claim
                    {
                        LecturerName = "Lecturer1", 
                        HoursWorked = hoursWorked,
                        HourlyRate = hourlyRate,
                        Notes = txtNotes.Text,
                        SupportingDocument = filePath // Store the path to the uploaded document
                    };

                    // Here, you would save the claim to your database
                    // SaveClaimToDatabase(claim); // Implement this method as needed

                    lblMessage.Text = "Claim submitted successfully!";
                }
                else
                {
                    lblMessage.Text = "Invalid file type or file size exceeds 5 MB.";
                }
            }
            else
            {
                lblMessage.Text = "Please enter valid details and upload a document.";
            }

        }
    }
}