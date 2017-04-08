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

        bool bandera = false;
        bool Moodifica = false;
        int identificador = 0;

        public RegistrarVenta()
        {

            InitializeComponent();
            timer1.Enabled = true;
            Limpiar();
        }
        int p = 0;

        int devuelta = 0;
        int descuento = 0;
        public List<Entidades.Facturas> Lista = null;
        private static RegistrarVenta unico = null;
        private static Entidades.Usuarios UsuarioG = null;
        FacturaDetalles detalle;
        Facturas facturaG;
        Entidades.Articulos articulo;

        public static List<Entidades.Clientes> lista;
        private static List<FacturaDetalles> listaRelaciones = null;
        private static List<Articulos> listadoArticulos = null;

        private void timer1_Tick(object sender, EventArgs e)
        {

            labelHORA.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();



        }
        public static RegistrarVenta Funcion()
        {
            if (unico == null)
            {
                unico = new RegistrarVenta();
            }
            return unico;

        }

        private void RefreshListaRelciones()
        {
            dataGridViewVenta.DataSource = null;
            dataGridViewVenta.DataSource = listaRelaciones;


            dataGridViewVenta.Columns["IdDetalle"].Visible = false;
            dataGridViewVenta.Columns["IdFactura"].Visible = false;
            dataGridViewVenta.Columns["Articulo"].Visible = false;


        }

        private void EliminarExitencia()
        {

            decimal descuento = 0;
            foreach (DataGridViewRow producto in dataGridViewVenta.Rows)
            {
                dataGridViewVenta.Refresh();
                int productoId = Convert.ToInt32(producto.Cells[2].Value); ///Celda 2 es el idArticulo antes esta detalleid y facturaid
                descuento = Convert.ToDecimal(producto.Cells[4].Value); //Celda 4 es la cantiddad

                detalle.Articulo = BLL.ArticuloBLL.BuscarB(productoId);
                detalle.Articulo.Existencia -= Convert.ToInt32(descuento);
                BLL.ArticuloBLL.Mofidicar(detalle.Articulo);
            }

        }

        private void SumarExistencia()
        {
            decimal descuento = 0;
            foreach (DataGridViewRow producto in dataGridViewVenta.Rows)
            {
                dataGridViewVenta.Refresh();
                int productoId = Convert.ToInt32(producto.Cells[2].Value); ///Celda 2 es el idArticulo antes esta detalleid y facturaid
                descuento = Convert.ToDecimal(producto.Cells[4].Value); //Celda 4 es la cantiddad

                detalle.Articulo = BLL.ArticuloBLL.BuscarB(productoId);
                detalle.Articulo.Existencia += Convert.ToInt32(descuento);
                BLL.ArticuloBLL.Mofidicar(detalle.Articulo);
            }
        }


        private void CalcularDevuelta()
        {
            if (string.IsNullOrWhiteSpace(EfectivomaskedTextBox.Text))
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
                    double resultado = devuelta - Convert.ToDouble(TotalmaskedTextBox.Text);
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
                MessageBox.Show("Cantidad del articulo selecionado es ( " + articulo.Existencia + " )");
                textBoxCantidad.ResetText();
            }
        }

        private void CalcularFactura()
        {

            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {

                if (descuento != 0)
                {
                    decimal descuento = Convert.ToDecimal(descuentoMaskedTextBox.Text) * Convert.ToDecimal(row.Cells[3].Value);
                }
                decimal itbis = Convert.ToDecimal(row.Cells[6].Value) * Convert.ToDecimal(row.Cells[3].Value);

                decimal subtotal = Convert.ToDecimal(row.Cells[3].Value) * Convert.ToDecimal(row.Cells[4].Value);
                facturaG.Total += subtotal + itbis;

                if (descuento != 0)
                {
                    facturaG.Total = facturaG.Total - descuento;
                }
                TotalmaskedTextBox.Text = facturaG.Total.ToString();

            }

        }

        private void LlenarFactura()
        {

            int cantidad = 0;
            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {

                cantidad = dataGridViewVenta.RowCount;
            }

            int id = 0;
            if (facturaG != null)
            {
                id = facturaG.IdFactura;
            }

            facturaG = new Facturas(id, UsuarioLabel.Text, DateTime.Now, clienteComboBox.Text, tipoVentaComboBox.Text, cantidad, Convert.ToDecimal(TotalmaskedTextBox.Text));

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

            if(!bandera)
            {
                if (string.IsNullOrWhiteSpace(textBoxDevuelta.Text))
                {
                    errorProviderTodo.SetError(textBoxDevuelta, "Primero Calcule Devuelta");
                    retorno = false;
                }
                if (string.IsNullOrWhiteSpace(EfectivomaskedTextBox.Text))
                {
                    errorProviderTodo.SetError(EfectivomaskedTextBox, "Campo Obligatorio");
                    retorno = false;
                }

            }


          

            if (string.IsNullOrWhiteSpace(tipoVentaComboBox.Text))
            {
                errorProviderTodo.SetError(tipoVentaComboBox, "Campo Obligatorio");
                retorno = false;
            }


            return retorno;
        }

        private void Limpiar()
        {
            errorProviderTodo.Clear();
            ITBIS_Modifica.Clear();
            NombreM_textBox.Clear();
            CantidadD_masked.Clear();
            NombreM_textBox.Clear();
            TipoVenta_textBox.Clear();
            lista = new List<Clientes>();
            textBoxDevuelta.Clear();
            BusquedamaskedTextBoxId.Clear();
            Cliente_textBox.Clear();
            RealizoVentatextBox.Clear();
            FechaVentatextBox.Clear();
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
            articulo = null;

            textBoxCantidad.Value = 0;
            articulo = new Articulos();
            textBoxCantidad.Enabled = false;
            EfectivomaskedTextBox.Clear();

        }
        public void LlenarComboClientes()
        {
            lista = BLL.ClientesBLL.GetListodo();
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

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {


            listaRelaciones = new List<FacturaDetalles>();
            listadoArticulos = new List<Articulos>();
            LlenarLabel();
            LlenarComboClientes();
            LlenarComboArticulo();
            Limpiar();
            Estado(false);
            descuentoMaskedTextBox.Enabled = true;
            Edicion_groupBox.Enabled = false;
            idArticuloComboBox.Enabled = true;
            clienteComboBox.Enabled = true;
            tipoVentaComboBox.Enabled = true;

        }
        private void AsiganarDatosArticulos()
        {
            Entidades.Articulos Entidada = new Articulos();
            int id = Utilidades.TOINT(idArticuloComboBox.Text);
            Entidada = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == id);
            decimal descuentod = Convert.ToDecimal(Utilidades.TOINT(descuentoMaskedTextBox.Text));
            decimal itbs = Entidada.PrecioVenta * Entidada.ITBIS;
            decimal total1 = (Entidada.PrecioVenta * textBoxCantidad.Value) + itbs;

            textBoxTotalArticlo.Text = total1.ToString();

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
            if(bandera)
            {
                textBoxDevuelta.Enabled = false;
                textBoxDevuelta.Clear();
                bandera = true;
                textBoxDevuelta.Clear();

                EfectivomaskedTextBox.Enabled = false;
            }
            Entidades.Articulos articuloc = new Articulos();
            textBoxCantidad.Value = 0;
            int id = Utilidades.TOINT(idArticuloComboBox.Text);
            articuloc = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == id);
            if (articuloc != null)
            {
                if (articuloc.Existencia == 0)
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
                    PreciotextBox.Text = articuloc.PrecioVenta.ToString();
                    ItbsArticultextBox.Text = articuloc.ITBIS.ToString();
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
                errorProviderTodo.Clear();
                CalcularDevuelta();

            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewVenta.DataSource!=null )
            {
                dataGridViewVenta.Refresh();
                identificador = 0;
                decimal descuento = 0;
                Moodifica = false;
                EfectivomaskedTextBox.Enabled = true;
                foreach (DataGridViewRow producto in dataGridViewVenta.Rows)
                {
                    identificador = Convert.ToInt32(dataGridViewVenta[2, p].Value);

                }

                if (identificador != 0)
                {

                    if (listaRelaciones != null)
                    {
                        var itemToRemove = listaRelaciones.SingleOrDefault(r => r.IdArticulo == identificador);
                        int productoId = Convert.ToInt32(dataGridViewVenta[2, p].Value);  ///Celda 2 es el idArticulo antes esta detalleid y facturaid
                        descuento = Convert.ToInt32(dataGridViewVenta[4, p].Value); //Celda 4 es la cantiddad
                        detalle.Articulo = BLL.ArticuloBLL.BuscarB(productoId);
                        detalle.Articulo.Existencia += Convert.ToInt32(descuento);
                        BLL.ArticuloBLL.Mofidicar(detalle.Articulo);
                        listaRelaciones.Remove(itemToRemove);
                        MessageBox.Show("Articulo Eliminado de factura y enviado a inventario");



                        if (BLL.FacturaDetallesBLL.Eliminar(itemToRemove))
                        {
                            Moodifica = true;

                        }
                        else
                        {
                            Moodifica = false;

                        }

                    }

                }
                else
                {
                    MessageBox.Show("ID a eliminar esta null");
                }
                if (facturaG != null)
                {
                    facturaG.Total = 0;
                }

                RefreshListaRelciones();
                dataGridViewVenta.Refresh();
                CalcularFactura();
            }
            else
            {
                MessageBox.Show("-Opciones \n -Primero Registre Factura \n -Primero Busque factura");
            }
           
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var guardar = new Entidades.Deudasclientes();
            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos");

                Limpiar();
            }
            else
            {

                LlenarFactura();
                if (BLL.FacturaBLL.Guardar(facturaG, listaRelaciones, identificador, Moodifica))
                {

                    MessageBox.Show("Factura registrada con exito");
                  
                    if(bandera)
                    {
                        guardar.Cliente = clienteComboBox.Text;
                        guardar.Deuda = Convert.ToDecimal(TotalmaskedTextBox.Text);                                              
                        BLL.DeudasclientesBLL.Guardar(guardar);
                        MessageBox.Show("Nueva deuda agregada al clinete! "+ clienteComboBox.Text );  
                    }
                    EliminarExitencia();
                    imrpimir();
                    facturaG = new Facturas();
                    identificador = 0;
                    Moodifica = false;

                }
                else
                {
                    MessageBox.Show("Error al rgistrar factura");
                    Moodifica = false;
                }
                Limpiar();
                clienteComboBox.Focus();
                buttonImprimir.Enabled = false;
                buttonGuardar.Enabled = false;
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
                    textBoxCantidad.Value = 0;
                    textBoxCantidad.Enabled = false;
                    idArticuloComboBox.Focus();
                }
                else
                {
                    bool agregado = false;
                    foreach (DataGridViewRow producto in dataGridViewVenta.Rows)
                    {

                        if (articulo.IdArticulo == Utilidades.TOINT(producto.Cells[2].Value.ToString()))
                        {
                            agregado = true;
                            break;

                        }
                    }
                    if (agregado)
                    {
                        errorProviderTodo.SetError(idArticuloComboBox, "Articulo ya esta en factura");
                        MessageBox.Show("Articulo ya esta en factura \n  -Selecione otro");
                    }
                    else
                    {
                        if (textBoxCantidad.Value > 0)
                        {
                            errorProviderTodo.Clear();
                            if (articulo != null)
                            {
                                bool estaEnLista = false;
                                foreach (var lista in listadoArticulos)
                                {
                                    if (lista.IdArticulo == articulo.IdArticulo)
                                    {
                                        estaEnLista = true;
                                        break;
                                    }
                                }

                                if (!estaEnLista)
                                {
                                    listadoArticulos.Add(articulo);
                                    listaRelaciones.Add(new FacturaDetalles(articulo.IdArticulo, 0, 0, articulo.PrecioVenta, Utilidades.TOINT(textBoxCantidad.Text), articulo.NombreArticulo, Convert.ToDecimal(articulo.ITBIS)));
                                    RefreshListaRelciones();

                                    CalcularFactura();
                                }
                            }
                        }
                        else
                        {
                            errorProviderTodo.SetError(textBoxCantidad, "Campo esta en 0");
                        }

                    }

                }
            }


        }

        private void Estado(bool condicion)
        {
            if (condicion == false)
            {
                idArticuloComboBox.Enabled = false;
                buttonAgregar.Enabled = false;
                EfectivomaskedTextBox.Enabled = false;
                textBoxDevuelta.Enabled = false;
                buttonGuardar.Enabled = false;
                Edicion_groupBox.Enabled = false;
                clienteComboBox.Enabled = false;
                tipoVentaComboBox.Enabled = false;
                comboBoxNombreAr.Enabled = false;
                textBoxCantidad.Enabled = false;
                descuentoMaskedTextBox.Enabled = false;
                buttonImprimir.Enabled = false;
            }
            else if (condicion == true)
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

            }

        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Estado(true);
            Moodifica = false;
            Edicion_groupBox.Enabled = false;

        }

        private void Nuevo_Cliente_Click(object sender, EventArgs e)
        {
            Ui.Registros.RegistroClientes.Funcion().Show();
            RegistroClientes.Funcion().Activate();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BusquedamaskedTextBoxId.Text))
            {
                errorProviderTodo.SetError(BusquedamaskedTextBoxId, "Campo vacio");


            }
            else
            {
                int id = Utilidades.TOINT(BusquedamaskedTextBoxId.Text);
                Moodifica = true;
                Edicion_groupBox.Enabled = true;
                facturaG = BLL.FacturaBLL.Buscar(C => C.IdFactura == id);
                errorProviderTodo.Clear();
                if (facturaG != null)
                {
                    TipoVenta_textBox.Text = facturaG.TipoVenta;

                    RealizoVentatextBox.Text = facturaG.NombreUsuario;
                    FechaVentatextBox.Text = facturaG.FechaVenta.ToString();
                    Cliente_textBox.Text = facturaG.Cliente;

                    //Factura
                    clienteComboBox.Text = facturaG.Cliente;
                    tipoVentaComboBox.Text = facturaG.TipoVenta;

                    if (tipoVentaComboBox.Text=="Credito")
                    {
                        EfectivomaskedTextBox.Enabled = false;
                        textBoxDevuelta.Enabled = false;

                    }
                    else
                    {
                        EfectivomaskedTextBox.Enabled = true;
                        textBoxDevuelta.Enabled = true;
                    }
                    
                    TotalmaskedTextBox.Text = facturaG.Total.ToString();
                    RefreshListaRelciones();

                    listaRelaciones = BLL.FacturaDetallesBLL.GetList(A => A.IdFactura == facturaG.IdFactura);
                    foreach (var relacion in listaRelaciones)
                    {
                        listadoArticulos.Add(BLL.ArticuloBLL.Buscar(A => A.IdArticulo == relacion.IdArticulo));
                    }

                    foreach (var articulo in listadoArticulos)
                    {
                        articulo.IdArticulo = BLL.ArticuloBLL.Buscar(A => A.IdArticulo == articulo.IdArticulo).IdArticulo;
                    }


                    RefreshListaRelciones();


                    dataGridViewVenta.Refresh();
                    Edicion_groupBox.Enabled = false;
                    buttonImprimir.Enabled = true;
                    Edicion_groupBox.Enabled = true;
                    errorProviderTodo.Clear();

                    PreciotextBox.Enabled = true;
                    ItbsArticultextBox.Enabled = true;
                    textBoxTotalArticlo.Enabled = true;
                    buttonGuardar.Enabled = true;


                    CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[listadoArticulos];
                    myCurrencyManager.Refresh();
                }
                else
                {
                    errorProviderTodo.SetError(BusquedamaskedTextBoxId, "Factura no registrada");
                }
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

        private void button_CambiarUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ui.Incio.Login.Funcion().Show();
            Ui.Incio.Login.Funcion().Activate();
            this.Hide();
        }

        private void button_Apagado_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BusquedamaskedTextBoxId.Text))
            {
                errorProviderTodo.SetError(BusquedamaskedTextBoxId, "ID Vacio");

            }
            else
            {
                if (dataGridViewVenta.DataSource != null)
                {
                    if (facturaG != null)
                    {
                        errorProviderTodo.Clear();
                        DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar la factura?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            if (BLL.FacturaBLL.EliminarRelacion(facturaG))
                            {
                                SumarExistencia();
                                Limpiar();
                                MessageBox.Show("Eliminado Con exito");
                                facturaG = new Facturas();
                                Estado(false);
                                Edicion_groupBox.Enabled = false;
                                buttonGuardar.Enabled = false;
                                buttonImprimir.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Problemas al eliminar");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay facturas Registradas");
                    }
                }
                else
                {
                    MessageBox.Show("No ha realizado busqeuda");
                }

            }
        }
        private void comboBoxNombreAr_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCantidad.Value = 0;
        }

        private void dataGridViewVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewVenta.Refresh();
            if (listaRelaciones.Count != 0)
            {

                p = dataGridViewVenta.CurrentRow.Index;
                MessageBox.Show("Seleciono  " + dataGridViewVenta[5, p].Value.ToString());
                NombreM_textBox.Text = dataGridViewVenta[5, p].Value.ToString();
                CantidadD_masked.Text = dataGridViewVenta[4, p].Value.ToString();
                ITBIS_Modifica.Text = dataGridViewVenta[6, p].Value.ToString();
            }
            else
            {
                MessageBox.Show("Lista Vacia");
            }

        }

        private void ModificarD_Button_Click(object sender, EventArgs e)
        {

           if(dataGridViewVenta.DataSource!=null)
            {
                EfectivomaskedTextBox.Enabled = true;
                textBoxDevuelta.Enabled = true;
                dataGridViewVenta[4, p].Value = CantidadD_masked.Text;
                dataGridViewVenta[6, p].Value = ITBIS_Modifica.Text;
                CalcularFactura();
            }
           else
            {
                MessageBox.Show("-Opciones \n -Primero Registre Factura \n -Primero Busque factura");
            }

        }

        private void buttonAñdir_Click(object sender, EventArgs e)
        {

        }


        private void dataGridViewVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clienteComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void clienteComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            LlenarComboClientes();
        }
        private void imrpimir()
        {
            int id = Utilidades.TOINT(BusquedamaskedTextBoxId.Text);
            Lista = BLL.FacturaBLL.GetList(p => p.IdFactura == id);

            foreach (var relacion in Lista)
            {
                listaRelaciones = BLL.FacturaDetallesBLL.GetList(A => A.IdFactura == relacion.IdFactura);
            }

            Lista = BLL.FacturaBLL.GetList(p => p.IdFactura == facturaG.IdFactura);

            new Ui.Reportes.Ventanas_Reportes.CReporteDetalleF(listaRelaciones, Lista).Show();
            new Ui.Reportes.Ventanas_Reportes.CReporteDetalleF(listaRelaciones, Lista).Activate();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if(dataGridViewVenta.DataSource!=null)
            {
                imrpimir();
            }
            else
            {
                MessageBox.Show("-Opciones \n -Primero Registre Factura \n -Primero Busque factura");
            }
           
        }

        private void EfectivomaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                CalcularDevuelta();
            }
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CantidadD_masked_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tipoVentaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoVentaComboBox.Text == "Credito")
            {
                textBoxDevuelta.Enabled = false;
                textBoxDevuelta.Clear();
                bandera = true;
                textBoxDevuelta.Clear();
                
                EfectivomaskedTextBox.Enabled = false;
            }
            if (tipoVentaComboBox.Text == "Contado")
            {
                bandera = false;
                EfectivomaskedTextBox.Enabled = true;
                textBoxDevuelta.Enabled = true;
            }
        }
    }
}
