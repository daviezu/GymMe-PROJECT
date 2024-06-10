<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="PROJECT_PSD.Views.TransactionDetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>TRANSACTION DETAIL PAGE</h1>
        <div>
            <asp:GridView ID="TransactionDetailGV" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="TransactionID"></asp:BoundField>
                    <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date"></asp:BoundField>
                    <asp:BoundField DataField="Status" HeaderText="Status"></asp:BoundField>
                    <asp:BoundField DataField="SupplementName" HeaderText="Name"></asp:BoundField>
                    <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date"></asp:BoundField>
                    <asp:BoundField DataField="SupplementPrice" HeaderText="Price"></asp:BoundField>
                    <asp:BoundField DataField="SupplementTypeName" HeaderText="Type"></asp:BoundField>
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity"></asp:BoundField>
                </Columns>
                <Columns>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
