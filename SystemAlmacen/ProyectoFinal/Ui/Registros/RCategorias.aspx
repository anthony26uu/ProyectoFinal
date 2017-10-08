<%@ Page Title="" Language="C#" MasterPageFile="~/Ui/Registros/Base.Master" AutoEventWireup="true" CodeBehind="RCategorias.aspx.cs" Inherits="ProyectoFinal.Ui.Registros.RCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <div class="text-center">
                <h1 class="page-header text-center"> Registro Categorias <span ></span></h1>
               </div>

     <h1 class="page-header text-center">

                  Registro Categoria <span class=" 	glyphicon glyphicon-list-alt"></span></h1  >
         

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    
         
        
                  
   <!--Texbos Buscar y descrpcion o nombre -->
           
                
             <span class="label label-primary">ID Categoria</span>
              <asp:TextBox ID="Textid" placeholder="Id a Buscar"  class="input-lg"  runat="server" Height="30px" Width="134px" ValidationGroup="buscar"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textid" ErrorMessage="**" Font-Bold="True" Font-Italic="True" ForeColor="Red" ValidationGroup="buscar"></asp:RequiredFieldValidator>
              <asp:Button ID="Button1"  CssClass="btn btn-primary btn-md boton" runat="server" Text="Buscar" OnClick="Button1_Click" Height="31px" />
     
    
             <asp:TextBox ID="Textnombre"  placeholder="Descripcion" class="input-lg" runat="server" Height="30px" Width="162px"></asp:TextBox>
 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Textnombre" ErrorMessage="**" Font-Bold="True" Font-Italic="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
 
           <br />
                <br />
             
   <!--Botones -->
         
             <div class="left">
        <asp:Button ID="Button2"  CssClass="btn btn-primary btn-md boton" runat="server" Text="Nuevo" OnClick="Button2_Click" Height="36px" />
        <asp:Button ID="Button3"  CssClass="btn btn-primary btn-md boton" runat="server" OnClick="Button3_Click" Text="Guardar" Height="36px" ValidationGroup="guardar" />
        <asp:Button ID="Button4"  CssClass="btn btn-primary btn-md boton" runat="server" Text="Eliminar" OnClick="Button4_Click" Height="36px" ValidationGroup="buscar" />
  </div>

    </form>
   

    <p>
        </p>


</asp:Content>
