<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="pizzalov.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Pizzaid" DataSourceID="SqlDataSource1" OnSelectedIndexChanging="GridView2_SelectedIndexChanging">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Pizzaid" HeaderText="Pizzaid" ReadOnly="True" SortExpression="Pizzaid" />
                <asp:BoundField DataField="Pris" HeaderText="Pris" SortExpression="Pris" />
                <asp:BoundField DataField="Navn" HeaderText="Navn" SortExpression="Navn" />
                <asp:BoundField DataField="Størrelse" HeaderText="Størrelse" SortExpression="Størrelse" />
                <asp:BoundField DataField="Indhold" HeaderText="Indhold" SortExpression="Indhold" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pizzaloveConnectionString %>" SelectCommand="SELECT * FROM [Pizza]"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
