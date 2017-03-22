﻿using Entidades;
using ProyectoTech.Ui.Incio;
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
     private static Entidades.Usuarios UsuarioG = null;
        FacturaDetalles detalle;
        Facturas facturaG;
        Entidades.Articulos articulo;
        //LIST Necesarias para detalle de la factura
        private static List<Entidades.FacturaDetalles> listaRelaciones = new List<FacturaDetalles>();
        private static List<Entidades.Articulos> listadoArticulos = new List<Entidades.Articulos>();



        //Calcular 
        const int COLUMNAPRECIO = 3;
        decimal total1 = 0;
        decimal total2 = 0;
        decimal data = 0;


        public RegistrarVenta()
        {
            InitializeComponent();
            //HOra y Fecha
            timer1.Enabled = true;
            Limpiar();
        }

     

          


        

        private void LlenarInstancia()
        {

         
            string idArticuloInstancia = idArticuloComboBox.Text;
            string clienteInstancia = clienteComboBox.Text;
            string cantidadproducto = Convert.ToString(textBoxCantidad.Value);
            int itbs = Utilidades.TOINT(ItbsArticultextBox.Text);
            decimal itbsd = Convert.ToDecimal(itbs);
            facturaG = new Facturas(0, label6.Text, Utilidades.TOINT(idArticuloInstancia), DateTime.Now,
            clienteInstancia, tipoVentaComboBox.Text, Utilidades.TOINT(cantidadproducto),itbsd );
          

        }

        private void RefreshDataGridView()
        {
            dataGridViewVenta.DataSource = null;
            dataGridViewVenta.DataSource = listadoArticulos;
         
        }
        //Usuario y tipo de Usuario
        private void LlenarLabel()
        {

            label6.Text = Login.InsetarU().NombreUsuario;
            label7.Text = Login.InsetarU().Tipo;


        }
        public static Entidades.Usuarios InsetarU()
        {
        
            return UsuarioG;
        }
        //Validar
        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(clienteComboBox.Text))
            {
                errorProviderTodo.SetError(clienteComboBox, "Campo Obligatorio");
                retorno = false;
            }

            if (string.IsNullOrWhiteSpace(tipoVentaComboBox.Text))
            {
                errorProviderTodo.SetError(tipoVentaComboBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(idArticuloComboBox.Text))
            {
                errorProviderTodo.SetError(idArticuloComboBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(comboBoxNombreAr.Text))
            {
                errorProviderTodo.SetError(comboBoxNombreAr, "Campo Obligatorio");
                retorno = false;
            }

            return retorno;
        }
       
        private void Limpiar()
        {
            listadoArticulos = new List<Articulos>();
            facturaG = new Facturas();
            detalle = new FacturaDetalles();
            clienteComboBox.Text = null;
            descuentoMaskedTextBox.Clear();
            idArticuloComboBox.Text = null;
            dataGridViewVenta.DataSource = null;
            PreciotextBox.Clear();
            ItbsArticultextBox.Clear();
            TotalmaskedTextBox.Clear();
            textBoxCantidad.ResetText();
            textBoxTotalArticlo.Clear();
            tipoVentaComboBox.Text = null;
            articulo = new Articulos();
            textBoxCantidad.Enabled = false;
        }
        //Clientes
        public void LlenarCombo()
        {
            List<Entidades.Clientes> lista = BLL.ClientesBLL.GetListodo();
            clienteComboBox.DataSource = lista;
            clienteComboBox.DisplayMember = "Nombres";
            clienteComboBox.ValueMember = "ClienteId";

        }
        //Articulos
        public void LlenarComboArticulo()
        {
            List<Entidades.Articulos> lista = BLL.ArticuloBLL.GetListodo();
            idArticuloComboBox.DataSource = lista;
            comboBoxNombreAr.DataSource = lista;

            idArticuloComboBox.DisplayMember = "IdArticulo";
            idArticuloComboBox.ValueMember = "IdArticulo";
            if (idArticuloComboBox.ValueMember == "IdArticulo")
            {
                comboBoxNombreAr.DisplayMember = "NombreArticulo";
            }


        }
        //Reloj
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            labelHORA.Text = DateTime.Now.ToLongTimeString();
            //Fecha

            labelFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void IdFactura ()
        {
            textBoxFacturaId.Text = facturaG.IdFactura.ToString();
        }
/*
        private void Total()
        {
            decimal total=0;
            decimal subtotal=0;
            const int COLUMNAPRECIO=2;

            if(dataGridViewVenta.Rows.Count>0)
            {
                foreach(DataGridViewRow precio in dataGridViewVenta.Rows )
                {
                    subtotal += (int)precio.Cells[COLUMNAPRECIO].Value;
                    SubTotalmaskedTextBox.Text = subtotal.ToString();
                }
                if(descuentoMaskedTextBox.Text==null)
                {
                    decimal totaldescuento = Convert.ToDecimal(Utilidades.TOINT(descuentoMaskedTextBox.Text));
                    total = subtotal - totaldescuento;
                    subtotal = subtotal - totaldescuento;
                    SubTotalmaskedTextBox.Text = subtotal.ToString();
                    TotalmaskedTextBox.Text = total.ToString();

                }
                if(ItbsArticultextBox.Text != null)
                {
                    decimal totalitbs = Convert.ToDecimal(Utilidades.TOINT(ItbsArticultextBox.Text));
                    total = subtotal + totalitbs;
                    SubTotalmaskedTextBox.Text = subtotal.ToString();
                    TotalmaskedTextBox.Text = total.ToString();
                }
            }
            else
            {
                MessageBox.Show("Error");
                Limpiar();
            }

        }
        */
        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
            
            IdFactura();
            LlenarLabel();
            LlenarCombo();
            LlenarComboArticulo();

        }

        /*
        private Articulos llenarCamposArticulo()
        {


            // peliculas.ActorId = Utilidades.TOINT(actores);
            //    articulo.Categoria = Utils.TOINT(categoria);
           articulo = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == Utilidades.TOINT(idArticuloComboBox.Text));
            // articulo = new Articulos();
            //     articulo = new Articulos();
            var existencia= new Articulos();
            articulo.Existencia = existencia.;
            int cantidad = Utilidades.TOINT(textBoxCantidad.Text); ;
            int resultado = existencia - cantidad;
            
          
            articulo.Existencia = resultado;

            return articulo;
        }
        */

        private void ItbsArticultextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AsiganarDatosArticulos()
        {
            int descuento = Utilidades.TOINT(descuentoMaskedTextBox.Text);
            decimal descuentod = Convert.ToDecimal(descuento);
            total1 = (detalle.articulosDetalle.PrecioVenta * textBoxCantidad.Value) * detalle.articulosDetalle.ITBIS;
            total2 = total1 - descuentod;
            data = total2;
            textBoxTotalArticlo.Text = total2.ToString();

         
        }
        private void textBoxCantidad_ValueChanged(object sender, EventArgs e)
        {
          

            if (textBoxCantidad.Value > 0)
            {

                AsiganarDatosArticulos();

            


            }
            else
            {
            //    Limpiar();
                PreciotextBox.Clear();
                ItbsArticultextBox.Clear();
                textBoxTotalArticlo.Clear();
                clienteComboBox.Focus();

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
                       
                if (detalle.articulosDetalle.Existencia == 0)
                {
                    errorProviderTodo.SetError(idArticuloComboBox, "No Existe Unidades de este articulo");
                    textBoxCantidad.Enabled = false;
                    TotalmaskedTextBox.Clear();
                    ItbsArticultextBox.Clear();
                    PreciotextBox.Clear();
                    idArticuloComboBox.Focus();
  
                }
                else
                {
                    errorProviderTodo.Clear();
                    textBoxCantidad.Enabled = true;
                    textBoxCantidad.Enabled = true;
                    PreciotextBox.Text = detalle.articulosDetalle.PrecioVenta.ToString();
                    ItbsArticultextBox.Text = detalle.articulosDetalle.ITBIS.ToString();
                    textBoxCantidad.Focus();
                   
                }
               
                }
            

        }

        //Button Agregar
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            int descuento = Utilidades.TOINT(descuentoMaskedTextBox.Text);
            decimal descuentod = Convert.ToDecimal(descuento);

            int precio = Utilidades.TOINT(PreciotextBox.Text);
            decimal preciod = Convert.ToDecimal(precio);


            listaRelaciones = new List<FacturaDetalles>();
            listaRelaciones.Add(new FacturaDetalles(0, facturaG.IdFactura, Utilidades.TOINT(idArticuloComboBox.Text+1), 
            preciod, Utilidades.TOINT(textBoxCantidad.Value.ToString()), descuentod));
            listadoArticulos.Add(BLL.ArticuloBLL.Buscar(p => p.IdArticulo == idArticuloComboBox.SelectedIndex + 1));
            

            RefreshDataGridView();
            AsiganarDatosArticulos();
            foreach (DataGridViewRow precio1 in dataGridViewVenta.Rows)
            {
                data += (int)precio1.Cells[2].Value;
                TotalmaskedTextBox.Text = data.ToString();
            }

        }









        private void button2_Click(object sender, EventArgs e)
        {
            articulo = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == Utilidades.TOINT(idArticuloComboBox.Text));

            if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {

                articulo = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == Utilidades.TOINT(idArticuloComboBox.Text));
                LlenarInstancia();
                //    articulo=   llenarCamposArticulo();
                    //Modifica si es necesario  de lo contrario guarda 
                    if ( facturaG!=null)
                    {

                   bool relaciong = true;
                 
                    BLL.FacturaBLL.Guardar(facturaG);
            //        articulo = new Articulos();
                  // if(Utilidades.TOINT( idArticuloComboBox.Text) == articulo.IdArticulo)
                    //{
                        BLL.ArticuloBLL.Mofidicar(articulo);
                    //}
                    foreach (var relacion in listaRelaciones)
                        {
                            relacion.IdFactura = facturaG.IdArticulo;
                            if (BLL.FacturaDetallesBLL.Guardar(relacion) == false)
                            {
                                relaciong = false;
                                break;
                            }
                        }
                        if (facturaG != null && relaciong)
                        {
                            MessageBox.Show("Correcto");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }

                    }
                   
                }
                Limpiar();
          
        }

        private void RegistrarVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            listaRelaciones = null;
            listadoArticulos = null;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
