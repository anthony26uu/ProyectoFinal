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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private static ConsultaCliente unico = null;

        public static ConsultaCliente Funcion()
        {
            if (unico == null)
            {
                unico = new ConsultaCliente();
            }
            return unico;

        }


        public void Llenar()
        {

            comboBox1.Items.Insert(0, "NOMBRE");
            comboBox1.Items.Insert(1, "Todo");
            comboBox1.Items.Insert(2, "ID");
            comboBox1.Items.Insert(3, "Sexo");

            //    comboBox1.Items.Insert(2, "TODO");

            //Si Colocas DiplayMember arriba no funcoina
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombre";


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

                    Entidades.Clientes db = new Entidades.Clientes();

                 
                    db = BLL.ClientesBLL.Buscar(p => p.Nombres == nombre);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Nombre del Cliente no registrado");
                        buscaText.Clear();
                    }
                    else
                    {
                        errorProvider.Clear();




                        dataGridView1.DataSource = BLL.ClientesBLL.GetList(p => p.Nombres == nombre);
                        errorProvider.Clear();
                        buttonImprimir.Enabled = true;
                        

                    }

                }

            }

          

            else if (comboBox1.SelectedIndex == 1)
            {
                buscaText.Enabled = false;
                maskedTextBoxId.Enabled = false;
                dataGridView1.DataSource = BLL.ClientesBLL.GetListodo();
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
                    errorProvider.Clear();

                    Entidades.Clientes db = new Entidades.Clientes();

                    int id = Utilidades.TOINT(maskedTextBoxId.Text);
                    db = BLL.ClientesBLL.Buscar(p => p.ClienteId == id);
                    if(db==null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Id del cliente no registrado");
                        maskedTextBoxId.Clear();
                    }else
                    {
                        dataGridView1.DataSource = BLL.ClientesBLL.GetList(p => p.ClienteId == id);
                        errorProvider.Clear();
                        buttonImprimir.Enabled = true;
                    }
                   


                }
            }

            else if (comboBox1.SelectedIndex == 3)
            {
              
                if(string.IsNullOrWhiteSpace(Sexo_comboBox.Text))
                {
                   errorProvider.SetError(Sexo_comboBox, "Selecione");
                }
                else
                {
                    errorProvider.Clear();
                    dataGridView1.DataSource = BLL.ClientesBLL.GetList(p => p.Sexo == nombre);
                    errorProvider.Clear();
                    Sexo_comboBox.Text = null;
                    buttonImprimir.Enabled = true;
                }
                   



            }


        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            buscaText.Enabled = false;
            Sexo_comboBox.Text = null;
            Sexo_comboBox.Enabled = false;
            buttonImprimir.Enabled = false;
            dataGridView1.DataSource = null;

            Llenar();

            errorProvider.Clear();
            maskedTextBoxId.Enabled = true;
            comboBox1.Text = null;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                errorProvider.Clear();
                buscaText.Enabled = true;
                maskedTextBoxId.Enabled = false;
                buttonImprimir.Enabled = false;
                dataGridView1.DataSource = null;
                Sexo_comboBox.Enabled = false;
                button1.Enabled = true;
                Selecionar(buscaText.Text);
            }
        
            if (comboBox1.SelectedIndex == 1)
            {
                errorProvider.Clear();
                buscaText.Clear();
                button1.Enabled = false;
                maskedTextBoxId.Clear();
                maskedTextBoxId.Enabled = false;
                buscaText.Enabled = false;
               
                Sexo_comboBox.Enabled = false;
                dataGridView1.DataSource = BLL.ClientesBLL.GetListodo();
                buttonImprimir.Enabled = true;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                button1.Enabled = true;
                maskedTextBoxId.Enabled = true;
                errorProvider.Clear();
                buscaText.Clear();
                buscaText.Enabled = false;
                buttonImprimir.Enabled = false;
                dataGridView1.DataSource = null;
                Sexo_comboBox.Enabled = false;
                Selecionar(maskedTextBoxId.Text);

            }
            if (comboBox1.SelectedIndex == 3)
            {
                maskedTextBoxId.Clear();
                maskedTextBoxId.Enabled = false;
                errorProvider.Clear();
                buscaText.Clear();
                buscaText.Enabled = false;
                button1.Enabled = true;

                buttonImprimir.Enabled = false;
                dataGridView1.DataSource = null;
                buscaText.Enabled = false;
                Sexo_comboBox.Enabled = true;
                Selecionar(Sexo_comboBox.SelectedIndex.ToString());

            }
        }

        private void ConsultaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buscaText.Enabled == false && Sexo_comboBox.Enabled == false)
            {
                Selecionar(maskedTextBoxId.Text);
            }
            else if (buscaText.Enabled == false && maskedTextBoxId.Enabled == false)
            {
              
                Selecionar(Sexo_comboBox.SelectedIndex.ToString());
               
            }

            else if(maskedTextBoxId.Enabled== false &&  Sexo_comboBox.Enabled ==false)
 
            {
                Selecionar(buscaText.Text);
            }
        }
    }
}
