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

        public static RegistrarVenta Funcion()
        {
            if (unico == null)
            {
                unico = new RegistrarVenta();
            }
            return unico;

        }


        private static Entidades.Usuarios UsuarioG = null;
        FacturaDetalles detalle;
        Facturas facturaG;
        Entidades.Articulos articulo;
        //LIST Necesarias para detalle de la factura
        private static List<Entidades.FacturaDetalles> listaRelaciones = new List<FacturaDetalles>();
        private static List<Entidades.Articulos> listadoArticulos = new List<Entidades.Articulos>();



        //Calcular 
        const int COLUMNAPRECIO = 4;
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

        private void addData(int idDetalle, int idFactura, string ArticuloN, string nombreProducto, decimal precioProducto, int cantidad, int totalarticulo)
        {

            string[] row = { idDetalle.ToString(), idFactura.ToString(), comboBoxNombreAr.Text, nombreProducto, precioProducto.ToString(), cantidad.ToString(), totalarticulo.ToString() };

            dataGridViewVenta.Rows.Add(row);
            CalcularFactura();

        }

        private void CalcularDevuelta()
        {
            if (Convert.ToDouble(EfectivomaskedTextBox.Text) < Convert.ToDouble(TotalmaskedTextBox.Text))
            {
                MessageBox.Show("Dinero insuficiente ");
                EfectivomaskedTextBox.Clear();
                EfectivomaskedTextBox.Focus();

            }
            else
            {
                if (descuentoMaskedTextBox.Text != null)
                {
                    double devuelta = Convert.ToDouble(EfectivomaskedTextBox.Text) - Convert.ToDouble(descuentoMaskedTextBox);
                    double resultado = Convert.ToDouble(TotalmaskedTextBox.Text) - devuelta;
                    textBoxDevuelta.Text = resultado.ToString();
                }
                else
                {
                    double devuelta = Convert.ToDouble(EfectivomaskedTextBox.Text);
                    double resultado = Convert.ToDouble(TotalmaskedTextBox.Text) - devuelta;
                    textBoxDevuelta.Text = resultado.ToString();
                }

            }


        }

        private void RefreshDataGridView()
        {
            Entidades.Articulos db = new Articulos();
            addData(detalle.IdDetalle, facturaG.IdFactura, comboBoxNombreAr.Text, idArticuloComboBox.Text, db.PrecioCompra, Utilidades.TOINT(textBoxCantidad.Text), Utilidades.TOINT(TotalmaskedTextBox.Text));
        }
        private void ComprobarCantidad(int existencia)
        {
            Entidades.Articulos articulo;
            articulo = BLL.ArticuloBLL.BuscarB(Utilidades.TOINT(idArticuloComboBox.Text));

            if (existencia > articulo.Existencia)
            {
                errorProviderTodo.SetError(textBoxCantidad, "Cantidad Excede existencia");
                dataGridViewVenta.Rows.Clear();
                MessageBox.Show("Cantidad del articulo selecionado es ( " + articulo.Existencia + " )");
                textBoxCantidad.ResetText();
            }
        }

        private void CalcularFactura()
        {
            double total = 0;

            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {
                total += Convert.ToDouble(row.Cells[6].Value);
                //   totalItbs += Convert.ToDouble(row.Cells[5].Value);

            }
            TotalmaskedTextBox.Text = total.ToString();
            TotalmaskedTextBox.Text = total.ToString();
        }


        private void EliminarExitencia(int existencia)
        {

            foreach (DataGridViewRow producto in dataGridViewVenta.Rows)
            {
                Entidades.Articulos arti = new Articulos();
                int productoId = Convert.ToInt32(producto.Cells[3].Value);


                arti = BLL.ArticuloBLL.BuscarB(productoId);
                arti.Existencia = arti.Existencia - existencia;
                BLL.ArticuloBLL.Mofidicar(arti);

            }

        }
        private void LlenarInstancia()
        {
            string idArticuloInstancia = idArticuloComboBox.Text;
            string clienteInstancia = clienteComboBox.Text;
            string cantidadproducto = Convert.ToString(textBoxCantidad.Value);
            int itbs = Utilidades.TOINT(ItbsArticultextBox.Text);
            decimal itbsd = Convert.ToDecimal(itbs);
            facturaG = new Facturas(0, UsuarioLabel.Text, Utilidades.TOINT(idArticuloInstancia), DateTime.Now,
            clienteInstancia, tipoVentaComboBox.Text, Utilidades.TOINT(cantidadproducto), itbsd);
        }


        //Usuario y tipo de Usuario
        private void LlenarLabel()
        {
            UsuarioLabel.Text = Login.InsetarU().NombreUsuario;
            TipoUsuarioLabel.Text = Login.InsetarU().Tipo;
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

        private void LimpiarColunna()
        {
            dataGridViewVenta.DataMember = null;
        }
        private void Limpiar()
        {
            dataGridViewVenta.Rows.Clear();
            dataGridViewVenta.Refresh();

            comboBoxNombreAr.Text = null;
            textBoxCantidad.ResetText();
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

            textBoxTotalArticlo.Clear();
            tipoVentaComboBox.Text = null;
            textBoxCantidad.Text = "0";
            articulo = new Articulos();
            textBoxCantidad.Enabled = false;

        }
        //Clientes
        public void LlenarComboClientes()
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
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }



        private void RegistrarVenta_Load(object sender, EventArgs e)
        {

            LlenarLabel();
            LlenarComboClientes();
            LlenarComboArticulo();

        }

        private void AsiganarDatosArticulos()
        {
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
            }
            else
            {

                articulo = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == Utilidades.TOINT(idArticuloComboBox.Text));


                LlenarInstancia();

                if (BLL.FacturaBLL.Guardar(facturaG) != null)
                {
                    EliminarExitencia(Utilidades.TOINT(textBoxCantidad.Text));
                }

                foreach (DataGridViewRow producto in dataGridViewVenta.Rows)
                {

                    int productoId = Convert.ToInt32(producto.Cells[3].Value);
                    BLL.ArticuloBLL.Buscar(x => x.IdArticulo == productoId);
                    FacturaDetalles factura = new FacturaDetalles(0, facturaG.IdFactura, productoId, Convert.ToInt32(producto.Cells[4].Value), Convert.ToInt32(producto.Cells[5].Value));

                }


                Limpiar();
                LimpiarColunna();
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            articulo = BLL.ArticuloBLL.BuscarB(Utilidades.TOINT(idArticuloComboBox.Text));
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
                AsiganarDatosArticulos();
                if (textBoxCantidad.Value == 0)
                {
                    errorProviderTodo.SetError(textBoxCantidad, "Antes debe selecionar Cantidad");
                }
                else
                {
                    errorProviderTodo.Clear();
                    Entidades.Articulos producto = (Articulos)idArticuloComboBox.SelectedItem;
                    addData(detalle.IdDetalle, facturaG.IdFactura, comboBoxNombreAr.Text, idArticuloComboBox.Text, producto.PrecioCompra, Utilidades.TOINT(textBoxCantidad.Text), Utilidades.TOINT(textBoxTotalArticlo.Text));
                }



            }

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarColunna();

        }

        private void Nuevo_Cliente_Click(object sender, EventArgs e)
        {
            Ui.Registros.RegistroClientes.Funcion().Show();
            RegistroClientes.Funcion().Activate();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewVenta.Rows.Clear();
            dataGridViewVenta.Refresh();
            Entidades.Facturas db;
            int id = Utilidades.TOINT(maskedTextBoxId.Text);

         

            db=  BLL.FacturaBLL.Buscar(p=> p.IdFactura== id)
     /*
                if(db!=null)
            {
                facturaG
            }
            */
    
        }
    }
}