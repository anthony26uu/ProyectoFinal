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
    public partial class CReporteDeudas : Form
    {
        List<Entidades.Deudasclientes> ListaDeudas;
        public CReporteDeudas(List<Entidades.Deudasclientes> listaDeudas)
        {
            InitializeComponent();
            this.ListaDeudas = listaDeudas;
        }

        public CReporteDeudas()
        {

        }
        private static CReporteDeudas unico = null;

        public static CReporteDeudas Funcion()
        {
            if (unico == null)
            {
                unico = new CReporteDeudas();
            }
            return unico;

        }


        private void CReporteDeudas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\antho\OneDrive - Universidad Católica Nordestana (UCNE)\Tareas de Anthony\Semestre 7\Aplicada I\Repositorios\ProyectoFinal\SystemAlmacen\ProyectoTech\Ui\Reportes\DeudasReport.rdlc";

            ReportDataSource source = new ReportDataSource("DeudasDataSet", ListaDeudas);
           

          
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void CReporteDeudas_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
}
