<%@ Page Title="" Language="C#" MasterPageFile="~/pizzalove.Master" AutoEventWireup="true" CodeBehind="Betal.aspx.cs" Inherits="pizzalov.Betal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    </asp:GridView>
    <br />
    Ny kunde opret dig først!
  
        <br />
    <br />
    Fornavn:<br />
    <asp:TextBox ID="Fornavn" runat="server"></asp:TextBox>
    <br />
    <br />
    Efternavn:<br />
    <asp:TextBox ID="Efternavn" runat="server"></asp:TextBox>
    <br />
    <br />
    Tlfnr:<br />
    <asp:TextBox ID="Tlfnr" runat="server" Height="30px"></asp:TextBox>
    <br />
    <br />
    Adresse<br />
    <asp:TextBox ID="Adresse" runat="server"></asp:TextBox>
    <br />
    <br />
    Postnr:<br />
    <asp:TextBox ID="Postnr" runat="server"></asp:TextBox>
    <asp:Button ID="Opretb" runat="server" OnClick="Opretb_Click" Text="Opret dig" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
    Eller Betal nu!<br />
    Telefonnr: <br />

    <asp:TextBox ID="Kid" runat="server" OnTextChanged="Kid_TextChanged"></asp:TextBox>

    <br />
    <asp:Button ID="Betalb" runat="server" OnClick="Betalb_Click" Text="Betal" />
    <br />
    <asp:Label ID="betalt" runat="server"></asp:Label>
    <br />
    <br />

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />


</asp:Content>
