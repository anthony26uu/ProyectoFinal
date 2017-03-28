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
    public partial class ConsultaCategoria : Form
    {
        private static ConsultaCategoria unico = null;

        public static ConsultaCategoria Funcion()
        {
            if (unico == null)
            {
                unico = new ConsultaCategoria();
            }
            return unico;

        }

        public ConsultaCategoria()
        {
            InitializeComponent();
        }

        private void ConsultaCategoria_Load(object sender, EventArgs e)
        {
            Llenar();
        }


        public void Llenar()
        {

            comboBox1.Items.Insert(0, "NOMBRE");
            comboBox1.Items.Insert(1, "Todo");
          
            comboBox1.Items.Insert(2, "ID");
            //    comboBox1.Items.Insert(2, "TODO");

            //Si Colocas DiplayMember arriba no funcoina
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombre";


        }

        public void Selecionar(string nombre)
        {

            errorProvider.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = BLL.CategoriaBLL.GetList(p => p.NombreCategoria == nombre);

                errorProvider.Clear();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                buscaText.Enabled = false;
                maskedTextBoxId.Enabled = false;
                dataGridView1.DataSource = BLL.CategoriaBLL.GetListodo();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                if (string.IsNullOrEmpty(maskedTextBoxId.Text))
                {
                    errorProvider.SetError(maskedTextBoxId, "Por favor llenar este campo.");
                }

                else
                {
                  

                        int id = Utilidades.TOINT(maskedTextBoxId.Text);
                        dataGridView1.DataSource = BLL.CategoriaBLL.GetList(p => p.CategoriaId == id);
                        errorProvider.Clear();



                    

                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                errorProvider.Clear();
                buscaText.Clear();
                maskedTextBoxId.Enabled = false;
                maskedTextBoxId.Clear();
                dataGridView1.DataSource = null;
                buscaText.Clear();
                buscaText.Enabled = true;

                Selecionar(buscaText.Text);
            }
            if (comboBox1.SelectedIndex == 1)
            {

                buscaText.Enabled = false;
                maskedTextBoxId.Enabled = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = BLL.CategoriaBLL.GetListodo();
            }
            if(comboBox1.SelectedIndex == 2)
            {
                buscaText.Enabled = false;
                buscaText.Clear();
                maskedTextBoxId.Clear();
                maskedTextBoxId.Enabled = true;

                dataGridView1.DataSource = null;
                Selecionar(maskedTextBoxId.Text);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buscaText.Enabled == false)
            {
                Selecionar(maskedTextBoxId.Text);
            }
            else
            {
                Selecionar(buscaText.Text);
            }
        }

        private void ConsultaCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
}
