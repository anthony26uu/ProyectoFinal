<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoFinal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        
<!-- Bootstrap 4.0.0 -->
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<!-- Bootswatch Darkly theme-->
<link href="../../Content/bootstraptheme.min.css" rel="stylesheet" />



                <script src="../../Scripts/popper.min.js"></script>
      <div class="text-center">
        <h1 class="page-header text-center">INICIO <span></span></h1>
    </div>


      
          <div class="panel panel-success">
        <div class="text-center">


            <!--Texbos Buscar y descrpcion o nombre -->



            <br />
            <asp:TextBox ID="Textid" placeholder="Usuario" class="input-lg" runat="server" Height="30px" Width="134px" ></asp:TextBox>
            <br />

            <br />


            <asp:TextBox ID="Textnombre" placeholder="Contraseña" class="input-lg" runat="server" Height="30px" Width="162px"></asp:TextBox>

            <br />
            <br />
        </div>

        <!--Botones -->

        <div class="text-center">
            <asp:Button ID="Button3" CssClass="btn btn-primary btn-md boton" runat="server" Text="Iniciar" Height="36px" OnClick="Button3_Click1"  />
        </div>
               </div>

    </form>
</body>
</html>
