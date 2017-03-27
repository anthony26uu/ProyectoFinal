using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoTech.Ui.Registros;

namespace ProyectoTech.Ui.Conultas
{
    public partial class ConsultaArticulos : Form
    {
        private static ConsultaArticulos unico = null;
        public ConsultaArticulos()
        {
            InitializeComponent();
        }

        public static ConsultaArticulos Funcion()
        {
            if (unico == null)
            {
                unico = new ConsultaArticulos();
            }
            return unico;
          
       }

    public void Llenar()
        {

            comboBox1.Items.Insert(0, "NOMBRE");
            comboBox1.Items.Insert(1, "FECHA");
            comboBox1.Items.Insert(2, "Todo");
            //    comboBox1.Items.Insert(2, "TODO");

            //Si Colocas DiplayMember arriba no funcoina
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombre";


        }

        public void Selecionar()
        {

          
            if (comboBox1.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = BLL.ArticuloBLL.Buscar(p => p.NombreArticulo == buscaText.Text);
                }

            if (comboBox1.SelectedIndex == 1)
            {
                if (desdeDateTimePicker.Value.Date <= HastadateTimePicker1.Value.Date)
                {
                    dataGridView1.DataSource = BLL.ArticuloBLL.Buscar(p => p.FechaIngreso >= desdeDateTimePicker.Value.Date && p.FechaIngreso <= HastadateTimePicker1.Value.Date);
                }
            }
            else if (comboBox1.SelectedIndex != 3)
            {
                if (string.IsNullOrEmpty(buscaText.Text))
                {
                    errorProvider.SetError(buscaText, "Por favor llenar este campo.");
                }
            }
                if (comboBox1.SelectedIndex == 2)
            {
                buscaText.Enabled = false;
                dataGridView1.DataSource = BLL.ArticuloBLL.GetListodo();
            }


        }

        private void ConsultaArticulos_Load(object sender, EventArgs e)
        {
            buscaText.Enabled = false;
            HastadateTimePicker1.Enabled = false;
            desdeDateTimePicker.Enabled = false;
            Llenar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        public static implicit operator ConsultaArticulos(RegistroClientes v)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                errorProvider.Clear();
                buscaText.Clear();
               // CampoVacioerrorProvider.Clear();
                buscaText.Enabled = true;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;
                Selecionar();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                errorProvider.Clear();
                buscaText.Clear();
                // CampoVacioerrorProvider.Clear();
                buscaText.Enabled = false;
                desdeDateTimePicker.Enabled = true;
                HastadateTimePicker1.Enabled = true;
             //   Selecionar();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                errorProvider.Clear();
                buscaText.Clear();
                // CampoVacioerrorProvider.Clear();
                buscaText.Enabled = false;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;
              //  Selecionar();
            }
        }
    }
}
