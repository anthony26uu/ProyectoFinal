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

        public static List<Entidades.Categorias> Lista { get; set; }

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
            dataGridView1.DataSource = null;
            buttonImprimir.Enabled = false;
            Llenar();
            comboBox1.Text = null;
            errorProvider.Clear();
            buscaText.Enabled = false;
        }


        public void Llenar()
        {

            comboBox1.Items.Insert(0, "NOMBRE");
            comboBox1.Items.Insert(1, "Todo");
            comboBox1.Items.Insert(2, "ID");
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombre";


        }

        public void Selecionar(string nombre)
        {

            errorProvider.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(buscaText.Text))
                {
                    errorProvider.SetError(buscaText, "Por favor llenar este campo.");
                }
                else
                {


                    Entidades.Categorias db = new Entidades.Categorias();

                    db = BLL.CategoriaBLL.Buscar(p => p.NombreCategoria == nombre);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        buscaText.Clear();
                        MessageBox.Show("Nombre de la categoria no registrado");
                        maskedTextBoxId.Clear();
                    }
                    else
                    {
                        Lista = BLL.CategoriaBLL.GetList(p => p.NombreCategoria == nombre);
                        dataGridView1.DataSource = Lista;
                        errorProvider.Clear();

                        buttonImprimir.Enabled = true;
                    }
                }



            }

            else if (comboBox1.SelectedIndex == 1)
            {
                buscaText.Enabled = false;
                maskedTextBoxId.Enabled = false;
                dataGridView1.DataSource = BLL.CategoriaBLL.GetListodo();

                buttonImprimir.Enabled = true;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                if (string.IsNullOrEmpty(maskedTextBoxId.Text))
                {
                    errorProvider.SetError(maskedTextBoxId, "Por favor llenar este campo.");
                }

                else
                {
                    Entidades.Categorias db = new Entidades.Categorias();
                    int id = Utilidades.TOINT(maskedTextBoxId.Text);
                    db = BLL.CategoriaBLL.Buscar(p => p.CategoriaId == id);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Id de la categoria no registrado");
                        maskedTextBoxId.Clear();
                    }
                    else
                    {
                        Lista = BLL.CategoriaBLL.GetList(p => p.CategoriaId == id);
                        dataGridView1.DataSource = Lista;
                        buttonImprimir.Enabled = true;
                        errorProvider.Clear();
                    }
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
                button1.Enabled = true;
                dataGridView1.DataSource = null;
                buttonImprimir.Enabled = false;
                Selecionar(buscaText.Text);
            }
            if (comboBox1.SelectedIndex == 1)
            {

                buscaText.Enabled = false;
                maskedTextBoxId.Enabled = false;
                dataGridView1.DataSource = null;
                button1.Enabled = false;
                dataGridView1.DataSource = null;
                buttonImprimir.Enabled = false;

                if (BLL.CategoriaBLL.GetListodo().Count == 0)
                {
                    MessageBox.Show("NO se ha registrado Categorias");
                }
                else
                {
                    Lista = BLL.CategoriaBLL.GetListodo();
                    dataGridView1.DataSource = Lista;
                    buttonImprimir.Enabled = true;
                }




            }
            if (comboBox1.SelectedIndex == 2)
            {
                button1.Enabled = true;
                buscaText.Enabled = false;
                buscaText.Clear();
                maskedTextBoxId.Clear();
                maskedTextBoxId.Enabled = true;
                buttonImprimir.Enabled = false;
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

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
