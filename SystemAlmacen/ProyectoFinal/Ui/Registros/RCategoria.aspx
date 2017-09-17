<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RCategoria.aspx.cs" Inherits="ProyectoFinal.Ui.RCategoria" %>

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

                <asp:Button ID="Button5" runat="server" Text="INICIO" PostBackUrl="~/Ui/Inicio.aspx" />   &nbsp;Registro Categoria</h1>
            <h1 class="page-header text-center">&nbsp;<span class="glyphicon glyphicon-user"></span><asp:Image ID="Image2" runat="server" Height="103px" ImageUrl="~/Ui/Logos/logo-elalmacen.png" Width="245px" />
                </h1>
        </header>

         

        
          <div class="Central">
               <div class="fondo">
              
       <div class="label">
             <label for="idCategoria">ID Categoriaria</lab
             <br />
              <asp:TextBox ID="Textid" runat="server"></asp:TextBox>
              <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
       </div>
     

     
     <div class="label">
             <label for="NombreCategoria">Nombre</label>        
             <br />
             <asp:TextBox ID="Textnombre" runat="server"></asp:TextBox>
      </div>
             </div>
                     </div>
         <div class="btn-group">
        <asp:Button ID="Button2" runat="server" Text="Nuevo" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Guardar" style="width: 68px" />
        <asp:Button ID="Button4" runat="server" Text="Eliminar" OnClick="Button4_Click" />
  </div>

    </form>
   

    <p>
        </p>
</body>
</html>