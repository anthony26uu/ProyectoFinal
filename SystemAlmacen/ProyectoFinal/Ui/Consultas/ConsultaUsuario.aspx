<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="ProyectoFinal.Ui.Consultas.ConsultaUsuario" %>

<!DOCTYPE html>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="../CSS/Estilo.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

          <header>
            <h1 class="page-header text-center">

                <asp:Button ID="Button2" runat="server" Text="Atras" PostBackUrl="~/Ui/Inicio.aspx" />   Consulta Usuario <span class="glyphicon glyphicon-user"></span></h1>
        </header>

         
        <div class="Central">
     
          <asp:Label ID="Label1" runat="server" Text="Selecione"></asp:Label>
          <asp:DropDownList ID="DropFiltro" runat="server" OnSelectedIndexChanged="DropFiltro_SelectedIndexChanged" OnTextChanged="DropFiltro_TextChanged"> 
            
              <asp:ListItem>Todo</asp:ListItem>
              <asp:ListItem>ID</asp:ListItem>
              <asp:ListItem>Fecha</asp:ListItem>
          </asp:DropDownList>
      
               

       
           
        
          <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
          <asp:TextBox ID="buscaText" runat="server" OnTextChanged="buscaText_TextChanged"></asp:TextBox>
          <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
              </div>
            <div> 
                <asp:GridView ID="UsuarioGrid" runat="server">
                </asp:GridView>
        </div>


        </form>
    <footer>
            <div class="page-footer">
                <p>Anthony Santana 2014-0527.</p>

            </div>
        </footer>
            

</body>
</html>
