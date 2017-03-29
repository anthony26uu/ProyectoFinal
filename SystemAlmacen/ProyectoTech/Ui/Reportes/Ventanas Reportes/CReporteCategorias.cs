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
    public partial class CReporteCategorias : Form
    {
        private static CReporteArticulos unico = null;
        List<Entidades.Categorias> Lista;

        public static CReporteArticulos Funcion()
        {
            if (unico == null)
            {
                unico = new CReporteArticulos();
            }
            return unico;

        }

        public CReporteCategorias(List<Entidades.Categorias> lista)
        {
            InitializeComponent();
            this.Lista=lista;
        }

        private void CReporteCategorias_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\antho\OneDrive - Universidad Católica Nordestana (UCNE)\Tareas de Anthony\Semestre 7\Aplicada I\Repositorios\ProyectoFinal\SystemAlmacen\ProyectoTech\Ui\Reportes\CategoriasReport.rdlc";

            ReportDataSource source = new ReportDataSource("CategoriasDataSet", Lista);
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();

            
        }

        private void CReporteCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
}
