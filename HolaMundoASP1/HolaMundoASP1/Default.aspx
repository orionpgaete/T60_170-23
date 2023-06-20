<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HolaMundoASP1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <h1 runat="server" id="mensajeh1">Hola Mundo ASP</h1>
        </div>
        <div class="form-group">
            <label for="nombretxt">Nombre</label>
            <asp:TextBox runat="server" ID="nombreTxt" CssClass="form-control"></asp:TextBox>

        </div>
        <div class="form-group">
            <asp:Button runat="server" OnClick="saludarbtn_Click" ID="saludarbtn" CssClass="btn btn-primary " Text="Saludame" />
        </div>
    </form>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
</body>
</html>
