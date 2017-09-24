using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Ui.Reportes.Ventanas
{
    public partial class UsuarioReport : System.Web.UI.Page
    {
        Consultas.ConsultaUsuario usuarioC = new Consultas.ConsultaUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            this.ReportViewer1.Reset();

          
            this.ReportViewer1.LocalReport.ReportPath = @"C:\Users\antho\Desktop\Aplicada II\Repos\ProyectoFinal\SystemAlmacen\ProyectoFinal\Ui\Reportes\UsuariosReport.rdlc";
            ReportViewer1.LocalReport.DataSources.Clear();


            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("Usuarios", Consultas.ConsultaUsuario.Lista));
            ReportViewer1.LocalReport.Refresh();



            //        ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"Usuario.rdlc");




        }

        public UsuarioReport()
        {

        }

    
        
        public List<Entidades.Usuarios> Lista { get; set; }

        public UsuarioReport(List<Entidades.Usuarios> lista)
        {
            this.Lista = lista;
        }
        
      



    }
}