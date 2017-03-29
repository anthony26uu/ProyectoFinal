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
    public partial class CReporteClientes : Form
    {
        List<Entidades.Clientes> Lista;
      

        private static CReporteClientes unico = null;

        public static CReporteClientes Funcion()
        {
            if (unico == null)
            {
                unico = new CReporteClientes();
            }
            return unico;

        }
        public CReporteClientes()
        {

        }

        public CReporteClientes(List<Entidades.Clientes> lista)
        {
            InitializeComponent();
            this.Lista = lista;
        }


        private void CReporteClientes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\antho\OneDrive - Universidad Católica Nordestana (UCNE)\Tareas de Anthony\Semestre 7\Aplicada I\Repositorios\ProyectoFinal\SystemAlmacen\ProyectoTech\Ui\Reportes\ClienteReport.rdlc";

            ReportDataSource source = new ReportDataSource("ClienteDataSet", Lista);
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
          
        }

        private void CReporteClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
}
