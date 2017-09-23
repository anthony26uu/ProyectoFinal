<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RCategoria.aspx.cs" Inherits="ProyectoFinal.Ui.RCategoria" %>

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

</head>
<body>
    <form id="form1" runat="server" >
         
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
						<li><a href="RegistroUsuarios.aspx">Registro Usuario</a></li>
						<li><a href="RCategoria.aspx">Categoria</a></li>
						<li><a href="RegistroArticulos.aspx">Registro Articulos</a></li>
                        <li><a href="RegistroClientes.aspx">Registro Clientes</a></li>
						
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

        

 
     

          <h1 class="page-header text-center">

                  Registro Categoria <span class="  glyphicon glyphicon-shopping-cart"></span></h1  >
         

        
                  
   <!--Texbos Buscar y descrpcion o nombre -->
           
                
             <span class="label label-primary">ID Categoria</span>
              <asp:TextBox ID="Textid" placeholder="Id a Buscar"  class="input-lg"  runat="server" Height="30px" Width="134px"></asp:TextBox>
              <asp:Button ID="Button1"  CssClass="btn btn-primary btn-md boton" runat="server" Text="Buscar" OnClick="Button1_Click" Height="31px" />
     
    
             <asp:TextBox ID="Textnombre"  placeholder="Descripcion" class="input-lg" runat="server" Height="30px" Width="162px"></asp:TextBox>
 
           <br />
                <br />
             
   <!--Botones -->
         
             <div class="left">
        <asp:Button ID="Button2"  CssClass="btn btn-primary btn-md boton" runat="server" Text="Nuevo" OnClick="Button2_Click" Height="36px" />
        <asp:Button ID="Button3"  CssClass="btn btn-primary btn-md boton" runat="server" OnClick="Button3_Click" Text="Guardar" Height="36px" />
        <asp:Button ID="Button4"  CssClass="btn btn-primary btn-md boton" runat="server" Text="Eliminar" OnClick="Button4_Click" Height="36px" />
  </div>

    </form>
   

    <p>
        </p>

                 <!--Mensaje de copyright -->
        <div class="list-group-item-success">

            <div class="text-center">

           
             
                <p><span class="glyphicon glyphicon-copyright-mark"></span>     Anthony Javier Santana  Polanco 2014-0527       </p>
           
                    </div>
                
       </div>


</body>
</html>