<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioReport.aspx.cs" Inherits="ProyectoFinal.Ui.Reportes.Ventanas.UsuarioReport" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" 
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 

    
      <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="785px" BackColor="" ClientIDMode="AutoID" Height="647px" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226">
   <ServerReport ReportServerUrl="http://AContosoDepartment/ReportServer" ReportPath="Ui\Reportes\UsuariosReport.rdlc"/>
        <localreport reportpath="Ui\Reportes\UsuariosReport.rdlc">
            <datasources>
                <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="UsuarioSet" />
            </datasources>
        </localreport>
        </rsweb:ReportViewer>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegistrosDbConnectionString2 %>" SelectCommand="SELECT [Id], [nombreUsuario], [PassUsuario], [Tipo], [FechaIngreso] FROM [Usuarios]"></asp:SqlDataSource>
           </form>

</body>
</html>
