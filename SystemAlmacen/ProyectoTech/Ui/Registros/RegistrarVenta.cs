using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTech.Ui.Registros
{
    public partial class RegistrarVenta : Form
    {
        FacturaDetalle detalle;
        public RegistrarVenta()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Limpiar();
        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            LlenarComboArticulo();
        }

        private void Limpiar()
        {
            detalle = new FacturaDetalle();
            idFacturaTextBox.Clear();
            clienteComboBox.Text = null;
            descuentoMaskedTextBox.Clear();
            idArticuloComboBox.Text = null;

            PreciotextBox.Clear();
            TotalmaskedTextBox.Clear();
            SubTotalmaskedTextBox.Clear();
            textBoxCantidad.ResetText();
            textBoxTotalArticlo.Clear();
            tipoVentaComboBox.Text = null;
        }

        private float CalcularIBTS()
        {
            float retorno = 0;


            return retorno;
        }

        public void LlenarCombo()
        {
            List<Entidades.Clientes> lista = BLL.ClientesBLL.GetListodo();
            clienteComboBox.DataSource = lista;
            clienteComboBox.DisplayMember = "Nombres";
            clienteComboBox.ValueMember = "ClienteId";


        }

        public void LlenarComboArticulo()
        {

                      

            List<Entidades.Articulos> lista = BLL.ArticuloBLL.GetListodo();
            idArticuloComboBox.DataSource = lista;
            comboBoxNombreAr.DataSource = lista;

            idArticuloComboBox.DisplayMember = "IdArticulo";
            idArticuloComboBox.ValueMember = "IdArticulo";
            if(idArticuloComboBox.ValueMember == "IdArticulo")
            {
                comboBoxNombreAr.DisplayMember = "NombreArticulo";
            }

            


        }


        public void datos()
        {

        }
       


        private void timer1_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            labelHORA.Text = DateTime.Now.ToLongTimeString();
            //Fecha
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void ItbsArticultextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (textBoxCantidad.Value > 0)
            {
                decimal total1 = (detalle.articulosDetalle.PrecioVenta * textBoxCantidad.Value) * detalle.articulosDetalle.ITBIS;
              
                textBoxTotalArticlo.Text = total1.ToString();
            }
            else
            {
               TotalmaskedTextBox.Text = "0";
            }

         //   Agregarbutton.Focus();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void idArticuloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(idArticuloComboBox.Text);


                detalle.articulosDetalle = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == id);

                if (detalle.articulosDetalle != null)
                {
                    PreciotextBox.Text = detalle.articulosDetalle.PrecioVenta.ToString();
                    ItbsArticultextBox.Text = detalle.articulosDetalle.ITBIS.ToString();

                
                    textBoxCantidad.Focus();
                }
            

        }
    }
}
