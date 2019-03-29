<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/pizzalove.Master" CodeBehind="menu.aspx.cs" Inherits="pizzalov.menu" %>




<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <br />



    

    
     

    <br />

    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Height="55px" BackColor="#DBE8DF" Font-Size="20px" Width="265px"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="33px" ImageUrl="~/graphic/search.png" OnClick="ImageButton1_Click" Width="34px" />
    <br />
    <div class="menubox1" dir="auto" style="">
        Menukort</div>
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
        <Columns>
            <asp:CommandField ShowSelectButton="True" ButtonType="Image" SelectImageUrl="~/graphic/plusicon.png" SelectText="" />
        </Columns>
        </asp:GridView> 

 
        


      <asp:SqlDataSource ID="SqlDataSource1" runat="server" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
    <div class="menubox2" dir="auto">
        Din Bestilling</div>

 
  

   
    <asp:GridView ID="GridView3" runat="server" OnSelectedIndexChanged="GridView3_SelectedIndexChanged1" CssClass="table table-striped " OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
        <Columns>
            <asp:CommandField ButtonType="Image" SelectImageUrl="~/graphic/minus.png" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
  

   
      <br />
  

   
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/graphic/checkout.png" OnClick="ImageButton2_Click" />
    Checkout<br />
    <br />
    <br />
    <br />

    <br />
    <br />
    <br />
    <br />

    

    </asp:Content>
