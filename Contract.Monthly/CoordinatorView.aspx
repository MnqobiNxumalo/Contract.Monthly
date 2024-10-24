<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoordinatorView.aspx.cs" Inherits="Contract.Monthly.CoordinatorView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:GridView ID="gridClaims" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="ClaimID" HeaderText="Claim ID" />
        <asp:BoundField DataField="LecturerName" HeaderText="Lecturer Name" />
        <asp:BoundField DataField="HoursWorked" HeaderText="Hours Worked" />
        <asp:BoundField DataField="HourlyRate" HeaderText="Hourly Rate" />
        <asp:BoundField DataField="Status" HeaderText="Status" />
        <asp:ButtonField ButtonType="Button" CommandName="Approve" Text="Approve" />
        <asp:ButtonField ButtonType="Button" CommandName="Reject" Text="Reject" />
    </Columns>
</asp:GridView>
</body>
</html>
