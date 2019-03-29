<%@ Page Title="Contact" Language="C#" MasterPageFile="~/pizzalove.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="pizzalov.Contact" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
<br />
    <br />
<br />
    <br />
    <br />


  

    <form action="sucess.html" class="was-validated" method="post">
  <div class="form-group">
    <label for="email">Email</label>
    <input type="Email" class="form-control" id="email" placeholder="Indtast Gylding Email Adresse" name="email" required>
    <div class="valid-feedback">Gyldig</div>
    <div class="invalid-feedback">Ikke gyldig Email addresse</div>
  </div>
  <div class="form-group">
    <label for="pwd">Navn</label>
    <input type="text" class="form-control" id="navn" placeholder="Indtast dit Navn" name="navn" required>
    <div class="valid-feedback">Gyldig</div>
    <div class="invalid-feedback">Må ikke være tom</div>
  </div>
   <div class="form-group">
    <label for="tlf">Tlf</label>
    <input type="number" class="form-control" id="tlf" placeholder="Indtast dit Telefonnr" name="tlf" required>
    <div class="valid-feedback">Gyldig</div>
    <div class="invalid-feedback">Må ikke være tom</div>
  </div>
<div class="form-group">
  <label for="besked">Besked:</label>

  <textarea maxlength="1500" class="form-control" rows="5" id="comment" input type="text" name="besked" class="form-control" placeholder="indtast din besked max 1500 bogstaver!" required></textarea>
  <div class="valid-feedback">Gyldig</div>
  <div class="invalid-feedback">Må ikke være tom</div>
</div>


  <div class="form-group form-check">
    <label class="form-check-label">
      <input class="form-check-input" type="checkbox" name="remember" required> Jeg godkender at dette ikke er spam
      <div class="valid-feedback">Gyldig.</div>
      <div class="invalid-feedback">Tryk i kassen for at godkende ellers kan du ikke sende</div>
    </label>
  </div>
        <asp:Button ID="Button1" runat="server" Text="Godkend" CssClass="btn btn-dark" />
  
</form>

</asp:Content>
