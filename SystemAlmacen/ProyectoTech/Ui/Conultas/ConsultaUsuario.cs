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
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        private static ConsultaUsuario unico = null;

        public static ConsultaUsuario Funcion()
        {
            if (unico == null)
            {
                unico = new ConsultaUsuario();
            }
            return unico;

        }


        public void Selecionar(int id)
        {

            if (comboBox1.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(buscaText.Text))
                {
                    errorProvider.SetError(buscaText, "Campo Vaccio");
                }
                else
                {

                    errorProvider.Clear();
                    if(BLL.UserBLL.GetList(p => p.Id == id)!=null)
                    {
                        dataGridView1.DataSource = BLL.UserBLL.GetList(p => p.Id == id);
                        errorProvider.Clear();
                       
                    }
                    else if(dataGridView1.DataSource==null)
                    {
                        MessageBox.Show("Id No Existe");
                        errorProvider.Clear();
                    }
                   
                }
            }


        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selecionar(Utilidades.TOINT(buscaText.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                errorProvider.Clear();
                buscaText.Clear();
                buscaText.Enabled = false;
                dataGridView1.DataSource = BLL.UserBLL.GetListodo();

               // Selecionar(Utilidades.TOINT(buscaText.Text));
            }
            if (comboBox1.SelectedIndex == 1)
            {
               
                    buscaText.Enabled = true;
                    dataGridView1.DataSource = null;
                                     
                    Selecionar(Utilidades.TOINT(buscaText.Text));
               

            }
        }

        private void ConsultaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}