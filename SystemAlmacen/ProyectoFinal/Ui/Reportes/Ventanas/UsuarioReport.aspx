﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioReport.aspx.cs" Inherits="ProyectoFinal.Ui.Reportes.Ventanas.UsuarioReport" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" 
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 

    
       <form id="formulario" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" ProcessingMode="Local" Height="715px" Width="967px" style="margin-right: 57px">
            <ServerReport ReportPath="" ReportServerUrl="" />
        </rsweb:ReportViewer>

    </form>

</body>
</html>
