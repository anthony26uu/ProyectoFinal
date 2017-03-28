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
            comboBox1.Items.Insert(3, "ID");
          
            //    comboBox1.Items.Insert(2, "TODO");

            //Si Colocas DiplayMember arriba no funcoina
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombre";


        }
    
        public void Selecionar(string nombre)
        {
            if(comboBox1.SelectedIndex==0)
            {
                if (string.IsNullOrEmpty(buscaText.Text))
                {
                    errorProvider.SetError(buscaText, "Por favor llenar este campo.");
                }
                else
                {
                    errorProvider.Clear();

                    Entidades.Articulos db = new Entidades.Articulos();

                   
                    db = BLL.ArticuloBLL.Buscar(p => p.NombreArticulo == nombre);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Nombre del Articulo no registrado");
                        maskedTextBoxId.Clear();
                    }
                    else
                    {
                        dataGridView1.DataSource = BLL.ArticuloBLL.GetList(p => p.NombreArticulo == nombre);
                        errorProvider.Clear();

                    }



                }

            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (desdeDateTimePicker.Value.Date <= HastadateTimePicker1.Value.Date)
                {

                    dataGridView1.DataSource = BLL.ArticuloBLL.GetList(p => p.FechaIngreso >= desdeDateTimePicker.Value.Date && p.FechaIngreso <= HastadateTimePicker1.Value.Date);

                }
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                buscaText.Enabled = false;
                maskedTextBoxId.Enabled = false;
                dataGridView1.DataSource = BLL.ArticuloBLL.GetListodo();
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                if (string.IsNullOrEmpty(maskedTextBoxId.Text))
                {
                    errorProvider.SetError(maskedTextBoxId, "Por favor llenar este campo.");
                }

                else
                {
                    errorProvider.Clear();
                    Entidades.Articulos db = new Entidades.Articulos();

                    int id = Utilidades.TOINT(maskedTextBoxId.Text);
                    db = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == id);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Id del Articulo no registrado");
                        maskedTextBoxId.Clear();
                    }
                    else
                    {
                        
                        dataGridView1.DataSource = BLL.ArticuloBLL.GetList(p => p.IdArticulo == id);
                        errorProvider.Clear();
                    }


                      


                }
            }

     
        }

        private void ConsultaArticulos_Load(object sender, EventArgs e)
        {
            buscaText.Enabled = false;
            HastadateTimePicker1.Enabled = false;
            desdeDateTimePicker.Enabled = false;
            Llenar();
           
            errorProvider.Clear();
            maskedTextBoxId.Enabled = true;
            comboBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(buscaText.Enabled==false)
            {
                Selecionar(maskedTextBoxId.Text);
            }
            else
            {
                  Selecionar(buscaText.Text);
            }
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
                buscaText.Enabled = true;
                maskedTextBoxId.Enabled = false;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;
                button1.Enabled = true;
                Selecionar(buscaText.Text);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                errorProvider.Clear();
                buscaText.Clear();
                maskedTextBoxId.Enabled = false;
                maskedTextBoxId.Clear();
                buscaText.Enabled = false;
                desdeDateTimePicker.Enabled = true;
                HastadateTimePicker1.Enabled = true;
                button1.Enabled = true;
                Selecionar(buscaText.Text);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                errorProvider.Clear();
                buscaText.Clear();
                maskedTextBoxId.Clear();
                maskedTextBoxId.Enabled = false;
                buscaText.Enabled = false;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;
                button1.Enabled = false;
                dataGridView1.DataSource = BLL.ArticuloBLL.GetListodo();

            }
            if (comboBox1.SelectedIndex == 3)
            {
                maskedTextBoxId.Enabled = true;
                button1.Enabled = true;
                errorProvider.Clear();
                buscaText.Clear();
                buscaText.Enabled = false;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;               
                Selecionar(maskedTextBoxId.Text);

            }
           
        }

        private void ConsultaArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
}
