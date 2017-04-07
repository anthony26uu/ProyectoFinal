using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTech.Ui.Incio
{
    public partial class SaldarDeudasFrom : Form
    {
        public SaldarDeudasFrom()
        {
            InitializeComponent();
        }

        public void Llenar()
        {

            comboBox1.Items.Insert(0, "NOMBRE");
            comboBox1.Items.Insert(1, "Todo");
            comboBox1.Items.Insert(2, "ID");
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombre";



        }

        private void SaldarDeudasFrom_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            buttonImprimir.Enabled = false;
            Llenar();
            comboBox1.Text = null;
            errorProvider.Clear();
            buscaText.Enabled = false;
        }
    }
}
