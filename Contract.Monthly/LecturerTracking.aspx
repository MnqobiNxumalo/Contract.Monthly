<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LecturerTracking.aspx.cs" Inherits="Contract.Monthly.LecturerTracking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStatus" runat="server" Text="Claim Status"></asp:Label><br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnCheckStatus" runat="server" Text="Check Status" OnClick="CheckStatus_Click" />
        </div>
    </form>
</body>
</html>
