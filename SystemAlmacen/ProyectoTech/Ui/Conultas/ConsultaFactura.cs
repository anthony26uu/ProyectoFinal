﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTech.Ui.Conultas
{
    public partial class ConsultaFactura : Form
    {
        public ConsultaFactura()
        {
            InitializeComponent();
        }

        private static ConsultaFactura unico = null;
        public static ConsultaFactura Funcion()
        {
            if (unico == null)
            {
                unico = new ConsultaFactura();
            }
            return unico;

        }

        public void Llenar()
        {

            comboBox1.Items.Insert(0, "Usuario");
            comboBox1.Items.Insert(1, "Fecha Venta"); 
            comboBox1.Items.Insert(2, "Todo"); 
            comboBox1.Items.Insert(3, "ID"); 
            comboBox1.Items.Insert(4, "Cliente"); 
            comboBox1.Items.Insert(5, "Tipo de Venta");

            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Usuario";


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
                    errorProvider.Clear();

                    Entidades.Facturas db = new Entidades.Facturas();


                    db = BLL.FacturaBLL.Buscar(p => p.NombreUsuario == nombre);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Nombre de usuario no realizado ventas \n o \n No esta Registrado");
                        maskedTextBoxId.Clear();
                    }
                    else
                    {
                        dataGridView1.DataSource = BLL.FacturaBLL.GetList(p => p.NombreUsuario == nombre);
                        errorProvider.Clear();
                        buttonImprimir.Enabled = true;

                    }



                }

            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (desdeDateTimePicker.Value.Date <= HastadateTimePicker1.Value.Date)
                {

                    dataGridView1.DataSource = BLL.FacturaBLL.GetList(p => p.FechaVenta >= desdeDateTimePicker.Value.Date && p.FechaVenta <= HastadateTimePicker1.Value.Date);
                    buttonImprimir.Enabled = true;
                }
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                buscaText.Enabled = false;
                maskedTextBoxId.Enabled = false;
                dataGridView1.DataSource = BLL.FacturaBLL.GetListodo();
                buttonImprimir.Enabled = true;
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
                    Entidades.Facturas db = new Entidades.Facturas();

                    int id = Utilidades.TOINT(maskedTextBoxId.Text);
                    db = BLL.FacturaBLL.Buscar(p => p.IdFactura == id);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Id de factura no registrado");
                        maskedTextBoxId.Clear();
                    }
                    else
                    {

                        dataGridView1.DataSource = BLL.FacturaBLL.GetList(p => p.IdFactura == id);
                        errorProvider.Clear();
                        buttonImprimir.Enabled = true;
                    }


                }
            }

            if (comboBox1.SelectedIndex == 5)
            {
                if (string.IsNullOrEmpty(buscaText.Text))
                {
                    errorProvider.SetError(buscaText, "Por favor llenar este campo.");
                }
                else
                {
                    errorProvider.Clear();

                    Entidades.Facturas db = new Entidades.Facturas();


                    db = BLL.FacturaBLL.Buscar(p => p.TipoVenta == nombre);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("No sean realizado factura al "+ nombre);
                        maskedTextBoxId.Clear();
                    }
                    else
                    {
                        dataGridView1.DataSource = BLL.FacturaBLL.GetList(p => p.TipoVenta == nombre);
                        errorProvider.Clear();
                        buttonImprimir.Enabled = true;

                    }



                }

            }

            else if (comboBox1.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(buscaText.Text))
                {
                    errorProvider.SetError(buscaText, "Por favor llenar este campo.");
                }
                else
                {
                    errorProvider.Clear();

                    Entidades.Facturas db = new Entidades.Facturas();


                    db = BLL.FacturaBLL.Buscar(p => p.Cliente == nombre);
                    if (db == null)
                    {
                        errorProvider.Clear();
                        MessageBox.Show("Nombre del cliente no realizado compras \n o \n No esta Registrado");
                        maskedTextBoxId.Clear();

                    }
                    else
                    {
                        dataGridView1.DataSource = BLL.FacturaBLL.GetList(p => p.Cliente == nombre);
                        errorProvider.Clear();
                        buttonImprimir.Enabled = true;

                    }



                }

            }


        }

        private void ConsultaFactura_Load(object sender, EventArgs e)
        {
            buttonImprimir.Enabled = false;
            buscaText.Enabled = false;
            HastadateTimePicker1.Enabled = false;
            desdeDateTimePicker.Enabled = false;
            Llenar();

            errorProvider.Clear();
            maskedTextBoxId.Enabled = true;
            comboBox1.Text = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = null;
                errorProvider.Clear();
                buscaText.Clear();
                buscaText.Enabled = true;
                maskedTextBoxId.Enabled = false;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;
                button1.Enabled = true;
                buttonImprimir.Enabled = false;
                Selecionar(buscaText.Text);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = null;
                errorProvider.Clear();
                buscaText.Clear();
                buscaText.Clear();
                maskedTextBoxId.Enabled = false;
                maskedTextBoxId.Clear();
                buscaText.Enabled = false;
                desdeDateTimePicker.Enabled = true;
                HastadateTimePicker1.Enabled = true;
                button1.Enabled = true;
                buttonImprimir.Enabled = false;
                Selecionar(buscaText.Text);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = null;
                errorProvider.Clear();
                buscaText.Clear();
                maskedTextBoxId.Clear();
                maskedTextBoxId.Enabled = false;
                buscaText.Enabled = false;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;
                button1.Enabled = false;
                dataGridView1.DataSource = BLL.FacturaBLL.GetListodo();
                buttonImprimir.Enabled = true;

            }
            if (comboBox1.SelectedIndex == 3)
            {
                dataGridView1.DataSource = null;
                maskedTextBoxId.Enabled = true;
                button1.Enabled = true;
                errorProvider.Clear();
                buscaText.Clear();
                buscaText.Enabled = false;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;
                buscaText.Clear();
                buttonImprimir.Enabled = false;
                Selecionar(maskedTextBoxId.Text);

            }

            if (comboBox1.SelectedIndex == 4)
            {
                dataGridView1.DataSource = null;
                buscaText.Clear();
                errorProvider.Clear();
                buscaText.Enabled = true;
                maskedTextBoxId.Enabled = false;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;
                button1.Enabled = true;
                buttonImprimir.Enabled = false;
                Selecionar(buscaText.Text);
            }

            if (comboBox1.SelectedIndex == 5)
            {
                dataGridView1.DataSource = null;
                buscaText.Clear();
                errorProvider.Clear();
                buscaText.Enabled = true;
                maskedTextBoxId.Enabled = false;
                desdeDateTimePicker.Enabled = false;
                HastadateTimePicker1.Enabled = false;
                button1.Enabled = true;
                buttonImprimir.Enabled = false;
                Selecionar(buscaText.Text);
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

        private void ConsultaFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
}
