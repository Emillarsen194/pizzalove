<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/pizzalove.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="pizzalov._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <br />
    <br />
    <br />
    <br />
<div id="carouselExampleSlidesOnly" class="carousel slide" data-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img class="d-block w-100" src="graphic/slider3.jpg" alt="First slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="graphic/slider3.jpg" alt="Second slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="graphic/slider3.jpg" alt="Third slide">
    </div>
  </div>
</div>


<!-- Cheap offers needs graphic update + opinons! -->
    <br />
    <br />
    <br />
    <br />
  <div id="move" class ="move" style="margin-left:3%">
        <asp:Image ID="Image4" runat="server" Height="299px" ImageUrl="~/graphic/tilbud11.png" Width="250px" />
        &nbsp;&nbsp;<asp:Image ID="Image3" runat="server" Height="299px" ImageUrl="~/graphic/tilbud22.png" Width="250px" />
  
        &nbsp;&nbsp;<asp:Image ID="Image2" runat="server" Height="299px" ImageUrl="~/graphic/tilbud33.png" Width="250px" />
        &nbsp;&nbsp;<asp:Image ID="Image1" runat="server" Height="299px" ImageUrl="~/graphic/tilbud44.png" Width="250px" />
      </div>
     <br />
    <br />
    <br />
    <br />
     <br />
    <br />
    <br />
    <br />
</asp:Content>
