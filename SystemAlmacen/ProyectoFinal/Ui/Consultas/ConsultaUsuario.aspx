<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="ProyectoFinal.Ui.Consultas.ConsultaUsuario" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

             <!--Bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" ></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" ></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
   


  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

    <!--Hoja de estilos Css -->

</head>
<body>
    <form id="form1" runat="server">

          <html>
	<head>
		<title>Menu Desplegable</title>
<style type="text/css">
			
			* {
				margin:0px;
				padding:0px;
			}
			
			#header {
                border:ridge;
				margin:auto;
				width:100%;
				font-family:Arial, Helvetica, sans-serif;
            height: 60px;
        }
			
			ul, ol {

				list-style:none;
			}
			
			.nav {
				width:100%;
				margin:auto;
            height: 55px;
        }
 
			.nav > li {
				float:left;
			}
			
			.nav li a {
				background-color:steelblue;
				color:#fff;
				text-decoration:none;
				padding:10px 12px;
				display:block;
			}
			
			.nav li a:hover {
				background-color:#434343;
			}
			
			.nav li ul {

				display:none;
				position:absolute;
				min-width:140px;
			}
			
			.nav li:hover > ul {
				display:block;
			}
			
			.nav li ul li {
				position:relative;
			}
			
			.nav li ul li ul {
				right:-140px;
				top:0px;
			}
			
		.boton {
           
		}
			
		</style>

	</head>
	<body>
		<div id="header">
			<ul class="nav">
				<li><a href="../Inicio.aspx">Inicio</a></li>
                <li><a href=""> Punto de Ventas</a></li>

				<li><a href="">Registros</a>
					<ul>
						<li><a href="../Registros/RegistroUsuarios.aspx">Registro Usuario</a></li>
						<li><a href="../Registros/RCategoria.aspx">Registro Categoria</a></li>
						<li><a href="../Registros/RegistroArticulos.aspx">Registro Articulos</a></li>
                        <li><a href="../Registros/RegistroClientes.aspx">Registro Clientes</a></li>
						
					</ul>
				</li>
				<li><a href="">Consultas</a>
					<ul>
						<li><a href="../Consultas/ConsultaUsuario.aspx">Usuario</a></li>
						<li><a href="../Consultas/ConsultaArticulos.aspx">Articulos</a></li>
						<li><a href="../Consultas/ConsultaClientes.aspx">Clientes</a></li>
						<li><a href="../Consultas/ConsultaDeudas.aspx">Deudas</a></li>
					</ul>
				</li>
				<li><a href="../SaldarDeudas.aspx">Sadar Deudas</a></li>
                <li><a href="">Acerca de</a>
                <ul>
									<li><a href="">Contactos</a></li>
									<li><a href="">Version</a></li>
									
								</ul>
                </li>
                <li></li>
                <li></li>
			    <li>
                    <br />
                </li>
			</ul>
		</div>
	</body>
</html>


          <header>
            <h1 class="page-header text-center">

                  Consulta Usuario <span class="glyphicon glyphicon-user"></span></h1>
        </header>

         
       
          <span class="label label-primary">Selecione-</span>
          <asp:DropDownList ID="DropFiltro" CssClass="custom-select" runat="server" Height="30px" OnSelectedIndexChanged="DropFiltro_SelectedIndexChanged" OnTextChanged="DropFiltro_TextChanged"> 
            
              <asp:ListItem>Todo</asp:ListItem>
              <asp:ListItem>ID</asp:ListItem>
              <asp:ListItem>Fecha</asp:ListItem>
              <asp:ListItem>Nombre</asp:ListItem>
          </asp:DropDownList>
      
               

       
           
          <span class="label label-primary">ID / Nombre</span>
        
          <asp:TextBox ID="buscaText" runat="server"    class="input-lg" placeholder="ID a buscar" Height="30px" OnTextChanged="buscaText_TextChanged"></asp:TextBox>
          <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
              <br />
              <br />
        
         <span class="label label-primary">Desde</span>
          
            Desde </label>

            &nbsp;&nbsp;<asp:TextBox ID="desdeFecha"  class="input-lg" placeholder="00/00/0000 "  runat="server" Width="141px" Height="30px"></asp:TextBox>
          &nbsp;&nbsp;  <span class="label label-primary">Hasta</span>
            
            <asp:TextBox ID="hastaFecha"   class="input-lg" placeholder="00/00/0000 " runat="server" Height="30px" Width="162px"></asp:TextBox>
          <br />    
        <br />
             


                <asp:GridView ID="UsuarioGrid" runat="server">
                </asp:GridView>
    
                <asp:LinkButton ID="LinkButton1"  href="../Reportes/Ventanas/UsuarioReport.aspx"  runat="server">LinkButton</asp:LinkButton>
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" Height="56px" ImageUrl="~/Ui/Logos/Impresora.png" OnClick="ImageButton1_Click1" Width="68px" />
     

        </form>
             <!--Mensaje de copyright -->
        <div class="list-group-item-success">

            <div class="text-center">

           
             
                <p><span class="glyphicon glyphicon-copyright-mark"></span>     Anthony Javier Santana  Polanco 2014-0527       </p>
           
                    </div>
            

</body>
</html>
