<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UsuarioIndex.aspx.cs" Inherits="TrabajoSocial.UsuarioIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="content">
      <div class="container-fluid">
        <div class="row">
          <div class="col-12">
            <!-- /.card -->

            <div class="card">
              <div class="card-header">
                <h3 class="card-title">Tabla Usuarios</h3>
              </div>
              <!-- /.card-header -->
              <div class="card-body">
                <asp:Button runat="server" ID="btnNuevo" Text="Nuevo Registro" OnClick="btnNuevo_Click" CssClass="btn btn-primary"/>
                <table id="example1" class="table table-bordered table-striped">
                  <thead>
            <tr>
                <th>Id</th>
                <th>Nombre Usuario</th>
                <th>Acciones</th>
            </tr>
        </thead>
                  <tbody>
                      <asp:PlaceHolder ID="TablaUsuario" runat="server"></asp:PlaceHolder>
                  </tbody>
                </table>
              </div>
              <!-- /.card-body -->
            </div>
            <!-- /.card -->
          </div>
          <!-- /.col -->
        </div>
        <!-- /.row -->
      </div>
      <!-- /.container-fluid -->
    </section>
</asp:Content>
