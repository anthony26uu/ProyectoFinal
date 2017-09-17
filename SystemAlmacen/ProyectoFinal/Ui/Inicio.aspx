<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ProyectoFinal.Ui.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
        <h2>
            INICIO
        </h2>
            <p>
               <asp:Image ID="Image2" runat="server" Height="103px" ImageUrl="~/Ui/Logos/logo-elalmacen.png" Width="245px" />
        </p>
            
            <ul>
              
                <li><a href="Consultas/ConsultaUsuario.aspx">Consulta Usuario</a>&nbsp;&nbsp; <a href="Registros/RegistroUsuarios.aspx">Registro Usuario</a>&nbsp;    <a href="Registros/RCategoria.aspx">Registro Categoria</a>c<a href="">Reportes</a>    </li> 
              
            </ul>
        </div>

    </form>
    <p>
        </p>
</body>
</html>
