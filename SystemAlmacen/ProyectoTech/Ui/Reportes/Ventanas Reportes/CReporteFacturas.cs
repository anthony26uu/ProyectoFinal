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
    public partial class CReporteFacturas : Form
    {
        List<Entidades.Facturas> Lista;


        private static CReporteFacturas unico = null;

        public static CReporteFacturas Funcion()
        {
            if (unico == null)
            {
                unico = new CReporteFacturas();
            }
            return unico;

        }

        public CReporteFacturas()
        {

        }
        public CReporteFacturas(List<Entidades.Facturas> lista)
        {
            this.Lista = lista;
            
            InitializeComponent();
        }

        private void CReporteFacturas_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }

        private void CReporteFacturas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\antho\OneDrive - Universidad Católica Nordestana (UCNE)\Tareas de Anthony\Semestre 7\Aplicada I\Repositorios\ProyectoFinal\SystemAlmacen\ProyectoTech\Ui\Reportes\FacturaReport.rdlc";

            ReportDataSource source = new ReportDataSource("FacturasDataSet", Lista); 
            ReportDataSource source1 = new ReportDataSource("DetallesSet", Lista);
            
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.LocalReport.DataSources.Add(source1);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
