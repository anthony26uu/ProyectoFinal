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
    public partial class CReporteUsuarios : Form
    {
        List<Entidades.Usuarios> Lista;

        public CReporteUsuarios()
        {

        }
        public CReporteUsuarios(List<Entidades.Usuarios> lista)
        {
            InitializeComponent();
            this.Lista = lista;
        }

   


        private static CReporteUsuarios unico = null;

        public static CReporteUsuarios Funcion()
        {
            if (unico == null)
            {
                unico = new CReporteUsuarios();
            }
            return unico;

        }

        private void CReporteUsuarios_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\antho\OneDrive - Universidad Católica Nordestana (UCNE)\Tareas de Anthony\Semestre 7\Aplicada I\Repositorios\ProyectoFinal\SystemAlmacen\ProyectoTech\Ui\Reportes\UsuariosReport.rdlc";

            ReportDataSource source = new ReportDataSource("UsuarioSet", Lista);
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
           
      
            this.reportViewer1.RefreshReport();
        }

        private void CReporteUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
}
