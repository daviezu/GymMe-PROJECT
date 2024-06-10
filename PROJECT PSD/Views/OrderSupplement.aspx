<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSupplement.aspx.cs" Inherits="PROJECT_PSD.Views.OrderSupplement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="SupplementName" HeaderText="Supplement Name"></asp:BoundField>
                    <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date"></asp:BoundField>
                    <asp:BoundField DataField="SupplementPrice" HeaderText="Price"></asp:BoundField>
                    <asp:BoundField DataField="SupplementTypeName" HeaderText="Type"></asp:BoundField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="quanlbl" runat="server" Text="Quantity"></asp:Label>
                            <asp:TextBox ID="quantxt" runat="server"></asp:TextBox>

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="addToCartbtn" runat="server" Text="add to cart" OnClick="addToCartbtn_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
