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
    public partial class ConsultaDeudas : Form
    {
        public ConsultaDeudas()
        {
            InitializeComponent();
        }

        public List<Entidades.Deudasclientes> Lista { get; set; }
        private static ConsultaDeudas unico = null;

        public static ConsultaDeudas Funcion()
        {
            if (unico == null)
            {
                unico = new ConsultaDeudas();
            }
            return unico;

        }


        private void Llenar()
        {
            comboBox1.Items.Insert(0, "NOMBRE");
            comboBox1.Items.Insert(1, "Todo");
            comboBox1.Items.Insert(2, "ID");

            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombre";
        }


        private void CalcularTotal()
        {
            decimal total = new decimal();

            foreach (DataGridViewRow producto in dataGridView1.Rows)
            {

                dataGridView1.Refresh();


                total += Convert.ToDecimal(producto.Cells[2].Value);

                dataGridView1.Refresh();



            }
            textBoxTotalArticlo.Text = total.ToString();
        }

        private void ConsultaDeudas_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = null;
            buttonImprimir.Enabled = false;
            Llenar();
            comboBox1.Text = null;
            errorProvider.Clear();
            buscaText.Enabled = false;
        }

        public void Selecionar(string nombre)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(buscaText.Text))
                {
                    errorProvider.SetError(buscaText, "Por favor llenar este campo.");
                }
                else
                {

                    Entidades.Deudasclientes db = new Entidades.Deudasclientes();
                    db = BLL.DeudasclientesBLL.Buscar(p => p.Cliente == nombre);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Nombre del Cliente no registrado");
                        buscaText.Clear();
                    }
                    else
                    {
                        errorProvider.Clear();

                        Lista = BLL.DeudasclientesBLL.GetList(p => p.Cliente == nombre);
                        dataGridView1.DataSource = Lista;
                        errorProvider.Clear();
                        CalcularTotal();
                        buttonImprimir.Enabled = true;


                    }

                }

            }



            else if (comboBox1.SelectedIndex == 2)
            {
                maskedTextBoxId.Enabled = true;
                if (string.IsNullOrEmpty(maskedTextBoxId.Text))
                {
                    errorProvider.SetError(maskedTextBoxId, "Por favor llenar este campo.");
                }

                else
                {
                    errorProvider.Clear();

                    Entidades.Deudasclientes db = new Entidades.Deudasclientes();

                    int id = Utilidades.TOINT(maskedTextBoxId.Text);
                    db = BLL.DeudasclientesBLL.Buscar(p => p.IdDeudas == id);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Id del cliente no registrado");
                        maskedTextBoxId.Clear();
                    }
                    else
                    {
                        Lista = BLL.DeudasclientesBLL.GetList(p => p.IdDeudas == id);
                        dataGridView1.DataSource = Lista;
                        errorProvider.Clear();
                        CalcularTotal();
                        buttonImprimir.Enabled = true;
                    }

                }
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                errorProvider.Clear();
                buscaText.Enabled = true;
                maskedTextBoxId.Enabled = false;

                button1.Enabled = true;
                maskedTextBoxId.Clear();
                buttonImprimir.Enabled = false;
                dataGridView1.DataSource = null;
                Selecionar(buscaText.Text);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                errorProvider.Clear();
                buscaText.Clear();
                maskedTextBoxId.Clear();
                maskedTextBoxId.Enabled = false;
                buscaText.Enabled = false;

                button1.Enabled = false;


                if (BLL.DeudasclientesBLL.GetListodo().Count == 0)
                {
                    MessageBox.Show("No se han registrado Deudas");
                }
                else
                {
                    dataGridView1.DataSource = null;
                    Lista = BLL.DeudasclientesBLL.GetListodo();
                    dataGridView1.DataSource = Lista;
                    CalcularTotal();
                    buttonImprimir.Enabled = true;
                }



            }
            if (comboBox1.SelectedIndex == 2)
            {


                errorProvider.Clear();
                buscaText.Clear();

                maskedTextBoxId.Clear();
                buscaText.Enabled = false;

                button1.Enabled = true;
                buttonImprimir.Enabled = false;
                dataGridView1.DataSource = null;
                maskedTextBoxId.Enabled = false;
                Selecionar(maskedTextBoxId.Text);

            }

        }

        private void ConsultaDeudas_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
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

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            new Ui.Reportes.Ventanas_Reportes.CReporteDeudas(Lista).Show();
            new Ui.Reportes.Ventanas_Reportes.CReporteDeudas(Lista).Activate();
        }
    }
}
