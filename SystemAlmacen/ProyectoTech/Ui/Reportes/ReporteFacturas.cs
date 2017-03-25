using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTech.Ui.Reportes
{
    public partial class ReporteFacturas : Form
    {
        private static Ui.Registros.RegistrarVenta factura;
        public ReporteFacturas()
        {
            InitializeComponent();
        }
       
        private void ReporteFacturas_Load(object sender, EventArgs e)
        {

            this.editorialesReportViewer.Reset();
            this.editorialesReportViewer.ProcessingMode = ProcessingMode.Local;
            this.editorialesReportViewer.LocalReport.ReportPath = @"C:\Users\antho\OneDrive - Universidad Católica Nordestana (UCNE)\Tareas de Anthony\Semestre 7\Aplicada I\Repositorios\ProyectoFinal\SystemAlmacen\ProyectoTech\Ui\Reportes\Facturas.rdlc";
         
         //   ReportDataSource source = new ReportDataSource("RegistrosDbDataSet", Ui.Conultas.ConsultaArticulos.lista);
      //      this.editorialesReportViewer.LocalReport.DataSources.Add(source);
            this.editorialesReportViewer.RefreshReport();


         
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
