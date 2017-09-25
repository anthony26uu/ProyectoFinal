<%@  Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="ProyectoFinal.Ui.Registros.RegistroUsuarios" %>


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
       <form id="form1" runat="server" >
       
    
            <!--Menu -->
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
				font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
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

		<div id="header" >
			<ul class="nav">
				<li><a href="../Inicio.aspx">Inicio</a></li>
                <li><a href=""> Punto de Ventas</a></li>

				<li><a href="">Registros</a>
					<ul>
						<li><a href="RegistroUsuarios.aspx">Registro Usuario</a></li>
						<li><a href="RCategoria.aspx"> Categoria</a></li>
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
                        <li><a href="../Consultas/ConsultaCategorias.aspx">Categorias</a></li>
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
            
       
        
       
      
                
          <div class="text-center">
                <h1 class="page-header text-center"> Registro Usuario <span class="glyphicon glyphicon-user"></span></h1>
               </div>
        <span class="label label-primary">ID Usuario</span>
         
            <asp:TextBox ID="TextBoxID" class="input-lg" placeholder="ID a buscar "  runat="server"   Height="30px"  Width="160px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxID" ErrorMessage="**" Font-Bold="True" Font-Italic="True" ForeColor="Red" ValidationGroup="buscar"></asp:RequiredFieldValidator>
            <asp:Button ID="BotonBuscar" CssClass="btn btn-primary btn-md boton" runat="server" Text="Buscar" OnClick="BotonBuscar_Click" Height="32px" ValidationGroup="buscar" />
        
             <br />
        
        <br />
                   <br />
              <!--Texbox -->
             
             <div class="input-group">
         
                <asp:TextBox ID="TextBoxNombre" placeholder="Nombre Usuario"  class="input-lg"   runat="server"  Height="30px" Width="199px"></asp:TextBox>
   
           <!--Texbox -->
        
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxNombre" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
        
               <asp:TextBox ID="TextFecha" runat="server" placeholder="00/00/0000 "  class="input-lg" OnTextChanged="TextFecha_TextChanged" ReadOnly="True" Width="199px" Height="30px"></asp:TextBox>

       
          <!--Texbox -->

                <asp:TextBox ID="TextBoxPass" placeholder="Contraseña"  class="input-lg" TextMode="Password" runat="server" OnTextChanged="TextBoxPass_TextChanged"  Height="30px" Width="199px"></asp:TextBox>

       
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>

       
                  <!--Texbox -->

                        <asp:TextBox ID="TextBoxConfirm" placeholder="Confirma Pass"  class="input-lg"  TextMode="Password" runat="server"    Height="30px" Width="199px"></asp:TextBox>

                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxConfirm" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>

               <!--Select -->
               
                <asp:DropDownList ID="DropTipo" runat="server" class="custom-select"  Height="30px" Width="199px">
                    <asp:ListItem>Administrador</asp:ListItem>
                    <asp:ListItem>Empleado</asp:ListItem>
                </asp:DropDownList>   
           
                <br />
                <br />
                     </div>

   
             <!--Botones -->
         
             <div class="left">
                <asp:Button ID="Button4"  CssClass="btn btn-primary btn-md boton"  runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" Height="36px" Width="88px" />
                <asp:Button ID="Button2" CssClass="btn btn-primary btn-md boton"  runat="server" Text="Guardar" OnClick="Guardar_Click" Height="36px" Width="88px" ValidationGroup="guardar" />
                <asp:Button ID="Button3" CssClass="btn btn-primary btn-md boton"  runat="server" Text="Eliminar" OnClick="Eliminar_Click" Height="36px" Width="88px" ValidationGroup="buscar" />
            </div>
                      
          <br />

                  <!--Mensaje de copyright -->
        <div class="list-group-item-success">

            <div class="text-center">

           
             
                <p><span class="glyphicon glyphicon-copyright-mark"></span>     Anthony Javier Santana  Polanco 2014-0527       </p>
           
                    </div>
                
       </div>

            
                
           
      
               
    </form>
        
     
          
</body>
     
                
</html>
