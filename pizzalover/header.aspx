<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="header.aspx.cs" Inherits="pizzalover.header" %>



   
			<nav class="navbar fixed-top navbar-expand-lg" id="background" "navbar-dark justify-content center">
  <!-- Brand -->
  <a class="navbar-brand" href="index.html">
    <img src="pictures\logo.png" alt="Logo"/>
</a>
  <!-- Links -->
  <ul class="navbar-nav">
    <li class="nav-item">
    </li>

    <li class="nav-item">
      <a class="nav-link" href="index.aspx">Forside</a>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="menu.aspx">Priser</a>
    </li>
        <li class="nav-item">
      <a class="nav-link" href="#">Mere info</a>

    </li>
   

    <!-- Dropdown -->
    <li class="nav-item dropdown">
      <a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">
        Info
      </a>
      <div class="dropdown-menu">
 <a class="dropdown-item" href="infoone.html">Kontakt</a>
        <a class="dropdown-item" href="infotwo.html">Åbningstider</a>
  
      </div>
    </li>
  </ul>
</nav>
