<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UsuarioAdmin.aspx.cs" Inherits="TrabajoSocial.UsuarioAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-info">
        <div class="card-header">
            <h3 class="card-title">Administrar Usuarios</h3>
        </div>
        <div class="card-body">
            <div class="row">
                <div class="col form-group">
                    <label>Usuario</label>
                    <input type="text" class="form-control" placeholder="joshua.quezda" id="txtUsername" runat="server">
                    <label id="msjErrorUsuario" visible="false" runat="server">El campo esta Vacio</label>
                </div>
                <div class="col form-group">
                    <label>Contraseña</label>
                    <input type="text" class="form-control" placeholder="Contraseña" id="txtContraseña" runat="server">
                    <label id="msjErrorContraseña" visible="false" runat="server">El campo esta Vacio</label>
                </div>
            </div>
            <asp:Button runat="server" ID="btnguardar" Text="Guardar" OnClick="btnguardar_Click" CssClass="btn btn-success" />
            <asp:Button runat="server" ID="btnEditar" Text="Editar" OnClick="btnEditar_Click" CssClass="btn btn-success" />
        </div>
    </div>
</asp:Content>
