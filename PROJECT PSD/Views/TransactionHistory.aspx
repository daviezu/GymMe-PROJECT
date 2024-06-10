<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="PROJECT_PSD.Views.TransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>TRANSACTION HISTORY PAGE</h1>
        <div>
            <asp:GridView ID="TransactionHistoryGV" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="TransactionId" HeaderText="Transaction Id"></asp:BoundField>
                    <asp:BoundField DataField="TransactionDate" HeaderText="Date"></asp:BoundField>
                    <asp:BoundField DataField="Status" HeaderText="Status"></asp:BoundField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="Detail_btn" runat="server" Text="Details" OnClick="Detail_btn_Click" CommandArgument='<%# Eval("TransactionId") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
