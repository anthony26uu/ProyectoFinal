<%@ Page Title="" Language="C#" MasterPageFile="~/Ui/Base.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProyectoFinal.Ui.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <script src="../Scripts/popper.min.js"></script>
 

    <div class="jumbotron">

        <div class="panel panel-success">
            <div class="panel-heading">
                <h3 class="panel-title"></h3>
            </div>
            <div class="panel-body">
                <h2>Bienvenido  </h2>
                <h4>**Usuario** </h4>
            </div>
        </div>



        <p>
            <asp:Image ID="Image1" runat="server" Height="363px" ImageUrl="~/Content/Img/warehouse.jpg" Width="874px" />
        </p>

        <p><a href="" class="btn btn-primary btn-lg">Informacion</a></p>
    </div>

</asp:Content>
