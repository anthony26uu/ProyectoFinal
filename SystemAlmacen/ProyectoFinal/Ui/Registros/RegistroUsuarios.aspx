<%@  Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="ProyectoFinal.Ui.Registros.RegistroUsuarios" %>


<!DOCTYPE html>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="../CSS/Estilo.css" />
<link rel="stylesheet" href="../JQuery/Jquery.js />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
        <form id="form1" runat="server">
            <div class=" Central">

            
         <header>
              <div class="Central">

                  <h1 class="page-header text-center">

                <asp:Button ID="Button1" runat="server" Text="INICIO" PostBackUrl="~/Ui/Inicio.aspx" />   Registro Usuario <span class="glyphicon glyphicon-user"></span></h1>
                </div>

            <h1 class="page-header text-center">

               <asp:Image ID="Image1" runat="server" Height="109px" ImageUrl="~/Ui/Logos/usuario_318-10541.jpg" Width="94px" style="margin-top: 0px" />
               <asp:Image ID="Image2" runat="server" Height="150px" ImageUrl="~/Ui/Logos/logo-elalmacen.png" Width="322px" />
                </h1>
             </div>
           

            
        </header>
       <div class="Central">
                 

                <div class="label">
            <asp:Label ID="Label1" runat="server" Text="ID Usuario"></asp:Label>
            <br />
                      </div>
                   
           
            <asp:TextBox ID="TextBoxID"  runat="server" Width="157px"></asp:TextBox>
            <asp:Button ID="BotonBuscar" CssClass="btn btn-primary btn-md boton" runat="server" Text="Buscar" OnClick="BotonBuscar_Click" style="height: 26px" />

            </div>
           
         

            <div class="Central">
                  <div class="fondo">

           
    
             
               
            <div class="label">
                

                <asp:Label ID="Label2" runat="server" Text="Nombre De Usuario"></asp:Label>
                <br />
                <asp:TextBox ID="TextBoxNombre" runat="server" class="form-control" Width="158px"></asp:TextBox>
            </div>
                     
               
             
            <div class="label">
                 
                <asp:Label ID="Label3" runat="server" Text="Tipo de Usuario"></asp:Label>
                <br />
                <asp:DropDownList ID="DropTipo" runat="server" Height="16px" Width="162px">
                    <asp:ListItem>Administrador</asp:ListItem>
                    <asp:ListItem>Empleado</asp:ListItem>
                </asp:DropDownList>
                
            </div>
          <div class="label">

               <asp:Label ID="Label6" runat="server" Text="Fecha Ingreso"></asp:Label>

               <br />

               <asp:TextBox ID="TextFecha" runat="server" OnTextChanged="TextFecha_TextChanged" ReadOnly="True" Width="158px">00/00/0000 - 10:30 AM</asp:TextBox>

          </div>

            <div class="label">

                <asp:Label ID="Label4" runat="server" Text="Contraseña"></asp:Label>
                <br />
                <asp:TextBox ID="TextBoxPass" TextMode="Password" runat="server" OnTextChanged="TextBoxPass_TextChanged" Width="158px"></asp:TextBox>
            </div>
             
          
            <div class="label">

                <asp:Label ID="Label5" runat="server" Text="Confirmar Contraseña"></asp:Label>
                <br />
                <asp:TextBox ID="TextBoxConfirm" TextMode="Password" runat="server" Width="158px"></asp:TextBox>
            </div>



              </div>   
                     </div>
                
                <div class="text-center">
                <div class="btn-group">
                     
                <asp:Button ID="Button4" CssClass="btn btn-primary btn-md boton"  runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" Height="29px" Width="88px" />
                <asp:Button ID="Button2" CssClass="btn btn-primary btn-md boton"  runat="server" Text="Guardar" OnClick="Guardar_Click" Height="30px" Width="88px" />
                <asp:Button ID="Button3" CssClass="btn btn-primary btn-md boton"  runat="server" Text="Eliminar" OnClick="Eliminar_Click" Height="29px" Width="88px" />

            </div>
                    </div>
                
      
               
    </form>
          
            <footer>
            <div class="page-footer">
                <p><span class="glyphicon glyphicon-copyright-mark"></span>Anthony Santana 2014-0527.</p>

            </div>
        </footer>
            
</body>
</html>
