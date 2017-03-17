using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTech.Ui.Conultas
{
    public partial class ConsultaArticulos : Form
    {
        public ConsultaArticulos()
        {
            InitializeComponent();
        }

        public void Llenar()
        {

            comboBox1.Items.Insert(0, "NOMBRE");
            comboBox1.Items.Insert(1, "FECHA");
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
              
            
        }

        private void ConsultaArticulos_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selecionar();
        }
    }
}
