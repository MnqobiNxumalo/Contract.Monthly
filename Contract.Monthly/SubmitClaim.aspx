<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitClaim.aspx.cs" Inherits="Contract.Monthly.SubmitClaim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
            <asp:TextBox ID="txtHoursWorked" runat="server" Placeholder="Hours Worked"></asp:TextBox><br />
            <asp:TextBox ID="txtHourlyRate" runat="server" Placeholder="Hourly Rate"></asp:TextBox><br />
            <asp:TextBox ID="txtNotes" runat="server" Placeholder="Additional Notes"></asp:TextBox><br />
            <asp:FileUpload ID="fileUpload" runat="server" /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="SubmitClaim_Click" />
        </div>
    </form>
</body>
</html>
