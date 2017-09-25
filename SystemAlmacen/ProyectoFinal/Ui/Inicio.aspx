<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ProyectoFinal.Ui.Inicio" %>

<!DOCTYPE html>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>


    <form id="form1" runat="server">
        <div>
            

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
				width:40%;
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
             
      
           
          
            <h1 class="page-header text-center">

                  EL ALMACEN  <span class="glyphicon glyphicon-shopping-cart"></span></h1>

	<body>
      
		
			<ul class="nav">
			
                <li><a href=""> Punto de Ventas</a></li>

				<li><a href="">Registros</a>
					<ul>
						<li><a href="Registros/RegistroUsuarios.aspx">Registro Usuario</a></li>
						<li><a href="Registros/RCategoria.aspx">Registro Categoria</a></li>
						<li><a href="Registros/RegistroArticulos.aspx">Registro Articulos</a></li>
                        <li><a href="Registros/RegistroClientes.aspx">Registro Clientes</a></li>
						
					</ul>
				</li>
				<li><a href="">Consultas</a>
					<ul>
						<li><a href="Consultas/ConsultaUsuario.aspx">Usuario</a></li>
						<li><a href="Consultas/ConsultaArticulos.aspx">Articulos</a></li>
						<li><a href="Consultas/ConsultaClientes.aspx">Clientes</a></li>
						<li><a href="Consultas/ConsultaDeudas.aspx">Deudas</a></li>
					</ul>
				</li>
				<li><a href="SaldarDeudas.aspx">Sadar Deudas</a></li>
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


    
         
            <p>
                  <h1 class="page-header text-center">

                 <Tipo botón = "botón" class = "glyphicon glyphicon-shopping-cart" style = "font-size: 60px">
                      

 </ Button>



      
          


               <asp:Image ID="Image2" runat="server" Height="230px" ImageUrl="~/Ui/Logos/logo-elalmacen.png" Width="383px" />
        </p>
           
  
        </div>

    </form>
    <p>
        </p>
</body>
</html>

