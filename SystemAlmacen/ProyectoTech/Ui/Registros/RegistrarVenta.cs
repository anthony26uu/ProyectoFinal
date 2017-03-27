using Entidades;
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

        private static RegistrarVenta unico = null;
        private static Entidades.Usuarios UsuarioG = null;
        FacturaDetalles detalle;
        Facturas facturaG;
        Entidades.Articulos articulo;

        int devuelta = 0;
        int descuento = 0;

       
        public static RegistrarVenta Funcion()
        {
            if (unico == null)
            {
                unico = new RegistrarVenta();
            }
            return unico;

        }

        private void RefreshDataGridView()
        {
            dataGridViewVenta.DataSource = null;
            dataGridViewVenta.DataSource = listadoArticulos;


            dataGridViewVenta.Columns["PrecioCompra"].Visible = false;
            dataGridViewVenta.Columns["Categoria"].Visible = false;
            dataGridViewVenta.Columns["FechaIngreso"].Visible = false;
            dataGridViewVenta.Columns["CategoriaId"].Visible = false;
         //   dataGridViewVenta.Columns["PrecioCompra"].Visible = false;

        }



        private static List<FacturaDetalles> listaRelaciones = null;
        private static List<Articulos> listadoArticulos = null;



        private void Refrescar()
        {
            dataGridViewVenta.DataSource = null;
            dataGridViewVenta.DataSource = listadoArticulos;
         
        }


        public RegistrarVenta()
        {

            InitializeComponent();
            //HOra y Fecha
            timer1.Enabled = true;
            Limpiar();    
        }
        private void EliminarExitencia(int existencia)
        {

            foreach (DataGridViewRow producto in dataGridViewVenta.Rows)
            {
                Entidades.Articulos arti = new Articulos();
                int productoId = Convert.ToInt32(producto.Cells[1].Value);


                arti = BLL.ArticuloBLL.BuscarB(productoId);
                arti.Existencia = arti.Existencia - existencia;
                BLL.ArticuloBLL.Mofidicar(arti);
            }

        }
        private void CalcularDevuelta()
        {
            if(string.IsNullOrWhiteSpace(EfectivomaskedTextBox.Text))
            {
                errorProviderTodo.SetError(EfectivomaskedTextBox, "Ingrese Dinero");
            }
            else
            {
                if (Convert.ToDouble(EfectivomaskedTextBox.Text) < Convert.ToDouble(TotalmaskedTextBox.Text))
                {
                    errorProviderTodo.Clear();
                    MessageBox.Show("Dinero insuficiente ");
                    EfectivomaskedTextBox.Clear();
                    EfectivomaskedTextBox.Focus();

                }
                else
                {
                    
                        errorProviderTodo.Clear();
                        double devuelta = Convert.ToDouble(EfectivomaskedTextBox.Text);
                        double resultado =  devuelta- Convert.ToDouble(TotalmaskedTextBox.Text);
                        textBoxDevuelta.Text = resultado.ToString();
                    

                }
            }
            

          
        }
        private void ComprobarCantidad(int existencia)
        {
            Entidades.Articulos articulo;
            articulo = BLL.ArticuloBLL.BuscarB(Utilidades.TOINT(idArticuloComboBox.Text));

            if (existencia > articulo.Existencia)
            {
                errorProviderTodo.SetError(textBoxCantidad, "Cantidad Excede existencia");
                dataGridViewVenta.Rows.Clear();
                MessageBox.Show("Cantidad del articulo selecionado es ( " + articulo.Existencia+" )");
               textBoxCantidad.ResetText();   
            }  
        }
        private void CalcularFactura()
        {
          
            double totalg = 0;
            double total;
          
            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {
                total = Convert.ToDouble(row.Cells[4].Value)  * Convert.ToDouble(row.Cells[6].Value); ;

                row.Cells[1].Value= textBoxCantidad.Text;
                row.Cells[0].Value = total.ToString();
                totalg += Convert.ToDouble(row.Cells[0].Value);


            }

            TotalmaskedTextBox.Text = totalg.ToString();
            TotalmaskedTextBox.Text = totalg.ToString();
        }
        private void LlenarFactura()
        {
            facturaG = new Facturas( UsuarioLabel.Text, DateTime.Now, clienteComboBox.Text, tipoVentaComboBox.Text, Convert.ToInt32(textBoxCantidad.Text));
        }

        private void LlenarLabel()
        {
            UsuarioLabel.Text = Login.InsetarU().NombreUsuario;
            TipoUsuarioLabel.Text = Login.InsetarU().Tipo;
        }
        public static Entidades.Usuarios InsetarU()
        { 
            return UsuarioG;
        }
        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(clienteComboBox.Text))
            {
                errorProviderTodo.SetError(clienteComboBox, "Campo Obligatorio");
                retorno = false;
            }
            
            if (string.IsNullOrWhiteSpace(EfectivomaskedTextBox.Text))
            {
                errorProviderTodo.SetError(EfectivomaskedTextBox, "Campo Obligatorio");
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
            comboBoxNombreAr.Text = null;
            textBoxCantidad.ResetText();
            listadoArticulos = new List<Articulos>();
            listaRelaciones = new List<FacturaDetalles>();
            facturaG = new Facturas();
            detalle = new FacturaDetalles();
            clienteComboBox.Text = null;
            descuentoMaskedTextBox.Clear();
            idArticuloComboBox.Text = null;
            dataGridViewVenta.DataSource = null;
            PreciotextBox.Clear();
            ItbsArticultextBox.Clear();
            TotalmaskedTextBox.Clear();          
            textBoxTotalArticlo.Clear();
            tipoVentaComboBox.Text = null;
            textBoxCantidad.Text = "0";
            articulo = new Articulos();
            textBoxCantidad.Enabled = false;

        }
        public void LlenarComboClientes()
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
            if (idArticuloComboBox.ValueMember == "IdArticulo")
            {
                comboBoxNombreAr.DisplayMember = "NombreArticulo";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            labelHORA.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
           
        
            listaRelaciones = new List<FacturaDetalles>();
            listadoArticulos = new List<Articulos>();
            LlenarLabel();
            LlenarComboClientes();
            LlenarComboArticulo();
            Limpiar();
            Estado(false);
            idArticuloComboBox.Enabled = true;
            clienteComboBox.Enabled = true;
            tipoVentaComboBox.Enabled = true;
            //   EfectivomaskedTextBox.Enabled = true;
        }
        private void AsiganarDatosArticulos()
        {
            decimal total1 = 0;
            decimal total2 = 0;
            decimal data = 0;
            decimal descuentod = Convert.ToDecimal(Utilidades.TOINT(descuentoMaskedTextBox.Text));
            total1 = (detalle.articulosDetalle.PrecioVenta * textBoxCantidad.Value) * detalle.articulosDetalle.ITBIS;
            total2 = total1 - descuentod;
            data = total2;
            textBoxTotalArticlo.Text = total2.ToString();

        }
        private void textBoxCantidad_ValueChanged(object sender, EventArgs e)
        {

            if (textBoxCantidad.Value > 0)
            {
                PreciotextBox.Enabled = true;
                ItbsArticultextBox.Enabled = true;
                textBoxTotalArticlo.Enabled = true;
                AsiganarDatosArticulos();
            }
            else
            {
                PreciotextBox.Enabled = false;
                ItbsArticultextBox.Enabled = false;
                textBoxTotalArticlo.Enabled = false;
                clienteComboBox.Focus();
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void idArticuloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estado(true);
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

                    PreciotextBox.Enabled = false;
                    ItbsArticultextBox.Enabled = false;
                    textBoxTotalArticlo.Enabled = false;
                    buttonAgregar.Enabled = false;
                    buttonGuardar.Enabled = false;

                }
                else
                {
                    errorProviderTodo.Clear();

                    PreciotextBox.Enabled = true;
                    ItbsArticultextBox.Enabled = true;
                    textBoxTotalArticlo.Enabled = true;
                    textBoxCantidad.Enabled = true;
                    textBoxCantidad.Enabled = true;
                    buttonAgregar.Enabled = true;
                    buttonGuardar.Enabled = true;
                    PreciotextBox.Text = detalle.articulosDetalle.PrecioVenta.ToString();
                    ItbsArticultextBox.Text = detalle.articulosDetalle.ITBIS.ToString();
                    textBoxCantidad.Focus();
                   
                }
               
             }
            

        }
        private void RegistrarVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
            listaRelaciones = null;
            listadoArticulos = null;
        }
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                CalcularDevuelta();
            }         
        }  
        private void buttonGuardar_Click(object sender, EventArgs e)
        {


            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos");
               
                Limpiar();
            }
            else
            {
                LlenarFactura();
                bool guardadoRelacion = true;
            
                if(facturaG != null)
                {
                    if (BLL.FacturaBLL.Guardar(facturaG) != null)
                    {
                        EliminarExitencia(Utilidades.TOINT(textBoxCantidad.Text));
                    }

                    foreach (var relacion in listaRelaciones)
                    {
                    
                        relacion.IdDetalle = facturaG.IdFactura;
                        relacion.IdFactura = facturaG.IdFactura;
                      
                        if (BLL.FacturaDetallesBLL.Guardar(relacion) == false)
                        {
                            guardadoRelacion = false;
                            break;
                        }
                    }
                }

                if (facturaG != null && guardadoRelacion)
                {
                    MessageBox.Show("Guardado");
                }
                else
                {
                    MessageBox.Show("Error");
                }

               
                Limpiar();
                clienteComboBox.Focus();
               
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            articulo = BLL.ArticuloBLL.BuscarB(Utilidades.TOINT(idArticuloComboBox.Text));

            if (string.IsNullOrWhiteSpace(idArticuloComboBox.Text))
            {
                errorProviderTodo.SetError(idArticuloComboBox, "Primero Selecione Articulo");
            }
            else
            {
                if (Utilidades.TOINT(textBoxCantidad.Text) > articulo.Existencia)
                {
                    errorProviderTodo.SetError(textBoxCantidad, "Cantidad Excede existencia");
                    MessageBox.Show("Articulo Selecionado es: " + articulo.NombreArticulo + "\n Cantidad del articulo es ( " + articulo.Existencia + " )");
                    textBoxCantidad.ResetText();
                    idArticuloComboBox.Text = null;
                    textBoxCantidad.Text = "0";
                    textBoxCantidad.Enabled = false;
                    idArticuloComboBox.Focus();
                }
                else
                {

                    Entidades.Articulos art = new Articulos();
                    art = BLL.ArticuloBLL.BuscarB(Utilidades.TOINT(idArticuloComboBox.Text));
                    listaRelaciones.Add(new FacturaDetalles(0,facturaG.IdFactura, idArticuloComboBox.SelectedIndex +1 ,art.PrecioVenta, Utilidades.TOINT(textBoxCantidad.Text) ));
                    listadoArticulos.Add(BLL.ArticuloBLL.BuscarB( idArticuloComboBox.SelectedIndex+1));

                    RefreshDataGridView();

                    CalcularFactura();
               }
           }
           

        }

        private void Estado(bool condicion)
        {
           // condicion=false;
            if(condicion== false)
            {
                idArticuloComboBox.Enabled = false;
                buttonAgregar.Enabled = false;
                EfectivomaskedTextBox.Enabled = false;
                textBoxDevuelta.Enabled = false;
                buttonGuardar.Enabled = false;

                Nuevo_Cliente.Enabled = false;
                clienteComboBox.Enabled=false;
                tipoVentaComboBox.Enabled = false;
                
                comboBoxNombreAr.Enabled = false;
                textBoxCantidad.Enabled = false;
                descuentoMaskedTextBox.Enabled = false;
                buttonImprimir.Enabled = false;
            }
            else if(condicion==true)
            {
                buttonGuardar.Enabled = true;

                idArticuloComboBox.Enabled = true;
                buttonAgregar.Enabled = true;
                buttonImprimir.Enabled = true;
                textBoxDevuelta.Enabled = true;
                comboBoxNombreAr.Enabled = true;
                descuentoMaskedTextBox.Enabled = true;
                Nuevo_Cliente.Enabled = true;
                clienteComboBox.Enabled = true;
                tipoVentaComboBox.Enabled = true;
                EfectivomaskedTextBox.Enabled = true;
            
                //s   textBoxCantidad.Enabled = true;
            }
            
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Estado(false);
            idArticuloComboBox.Enabled = true;
            clienteComboBox.Enabled = true;
            tipoVentaComboBox.Enabled = true;
        }

        private void Nuevo_Cliente_Click(object sender, EventArgs e)
        {
            Ui.Registros.RegistroClientes.Funcion().Show();
            RegistroClientes.Funcion().Activate();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
        
            facturaG = BLL.FacturaBLL.BuscarB( Utilidades.TOINT(BusquedamaskedTextBoxId.Text));
            if (facturaG != null)
            {
                listadoArticulos = new List<Entidades.Articulos>();

                listaRelaciones = BLL.FacturaDetallesBLL.GetListado(R => R.IdFactura == facturaG.IdFactura); //r.factura FUunciona
                foreach (var relacion in listaRelaciones)
                {
                    listadoArticulos.Add(BLL.ArticuloBLL.BuscarB(relacion.IdArticulo)); // articulo
                }

                tipoVentaComboBox.Text = facturaG.TipoVenta;
                clienteComboBox.Text = facturaG.Cliente;

                RefreshDataGridView();

                CalcularFactura();
                MessageBox.Show("Correcto");

            }
            else
            {
                MessageBox.Show("Error");
            }



        }

        private void descuentoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Keys)e.KeyChar == Keys.Enter)
            {
             

                if (descuentoMaskedTextBox.Text != null)
                {

                    int efectivo = Utilidades.TOINT(EfectivomaskedTextBox.Text);
                    descuento = Utilidades.TOINT(descuentoMaskedTextBox.Text);
                    devuelta = Utilidades.TOINT(TotalmaskedTextBox.Text) - descuento;
                    decimal resultado = efectivo - devuelta;
                    textBoxDevuelta.Text = resultado.ToString();
                }
            }
        }
    }
    }

