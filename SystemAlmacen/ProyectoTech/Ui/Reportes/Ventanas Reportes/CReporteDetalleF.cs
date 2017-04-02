using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTech.Ui.Reportes.Ventanas_Reportes
{
    public partial class CReporteDetalleF : Form
    {

        private static CReporteDetalleF unico = null;

        public static CReporteDetalleF Funcion()
        {
            if (unico == null)
            {
                unico = new CReporteDetalleF();
            }
            return unico;

        }


        List<Entidades.FacturaDetalles> ListaRelaciones;
        List<Entidades.Facturas> ListaFactura;


        public CReporteDetalleF()
        {

        }

        public CReporteDetalleF(List<Entidades.FacturaDetalles> listarelaciones, List<Entidades.Facturas> listaFactura)
        {
            InitializeComponent();
            this.ListaRelaciones = listarelaciones;
            this.ListaFactura = listaFactura;
           
        }


        private void CReporteDetalleF_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\antho\OneDrive - Universidad Católica Nordestana (UCNE)\Tareas de Anthony\Semestre 7\Aplicada I\Repositorios\ProyectoFinal\SystemAlmacen\ProyectoTech\Ui\Reportes\Factura.rdlc";

            ReportDataSource source = new ReportDataSource("FacturasDataSet", ListaFactura);
            ReportDataSource source1 = new ReportDataSource("DetallesSet", ListaRelaciones);

            this.reportViewer1.LocalReport.DataSources.Add(source1);
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void CReporteDetalleF_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
}
