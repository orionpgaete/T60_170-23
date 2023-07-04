<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StarCapWEB.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div classs="mensajes">
                <asp:Label runat="server" ID="mensaje" CssClass="text-sucesss"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Cliente</h3>
                </div>
                <div class="card-body">                    
                    <div class="form-group">
                        <label for="nombretxt">Nombre</label>
                        <asp:TextBox ID="nombretxt" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ruttxt">Rut</label>
                        <asp:TextBox ID="ruttxt" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="bebidaDdl">Bebida Favorita</label>
                        <asp:DropDownList runat="server" ID="bebidaDdl" CssClass="form-select">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="nivelRbl">Nivel</label>
                        <asp:RadioButtonList runat="server" ID="nivelRbl" CssClass="form-control">
                            <asp:ListItem Selected="True" Value="1" Text="Silver"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Gold"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Platinum"></asp:ListItem>
                          </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click" Text="Agregar" 
                            CssClass="btn btn-primary btn-lg" />
                    </div>

                </div>
            </div>
        </div>
    </div>





</asp:Content>
