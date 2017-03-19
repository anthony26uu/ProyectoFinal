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
        private static Entidades.Usuarios UsuarioG = null;
     //   Usuarios UsuarioG;
        FacturaDetalles detalle;
        Facturas facturaG;
        List<Articulos> listadoArticulos;
        public RegistrarVenta()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Limpiar();
        }

        private void LlenarLabel()
        {

            label6.Text = Login.InsetarU().NombreUsuario;
            label7.Text = Login.InsetarU().Tipo;


        }

       

        public static Entidades.Usuarios InsetarU()
        {
         //   UsuarioG = BLL.UserBLL.Buscar(p => p.NombreUsuario == nombreTextBox.Text);
            return UsuarioG;
        }


        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
            LlenarLabel();
            LlenarCombo();
            LlenarComboArticulo();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(clienteComboBox.Text))
            {
                errorProviderTodo.SetError(clienteComboBox, "Campo Obligatorio");
                retorno = false;
            }
            /*
            if (string.IsNullOrWhiteSpace(descuentoMaskedTextBox.Text))
            {
                errorProviderTodo.SetError(descuentoMaskedTextBox, "Campo Obligatorio");
                retorno = false;
            }
            */
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

        //Button Agregar
        private void button1_Click_1(object sender, EventArgs e)
        {
  
        
            listadoArticulos.Add(new Articulos(Utilidades.TOINT(idArticuloComboBox.Text),comboBoxNombreAr.Text,Convert.ToDecimal(PreciotextBox.Text)  , Convert.ToDecimal( ItbsArticultextBox.Text)));

            dataGridViewVenta.DataSource = null;
            dataGridViewVenta.DataSource = listadoArticulos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int id = 0;

            try
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {

                    facturaG.IdFactura = Utilidades.TOINT(idFacturaTextBox.Text);
                    facturaG.IdArticulo = Utilidades.TOINT(IDArticulotextBox.Text);
                    facturaG.TipoVenta = tipoVentaComboBox.SelectedIndex.ToString();
                    facturaG.FechaVenta = Convert.ToDateTime(labelFecha.Text);
                    facturaG.Descuento = Utilidades.TOINT(descuentoMaskedTextBox.Text);
                    facturaG.Cliente = clienteComboBox.SelectedIndex.ToString();
                    facturaG.TipoVenta = tipoVentaComboBox.SelectedIndex.ToString();
                    facturaG.CantidadProd = Convert.ToInt32(textBoxCantidad.Value);
                    facturaG.ITBS = Convert.ToInt32(ItbsArticultextBox.Text);

                    //Modifica si es necesario  de lo contrario guarda 
                    if (id != facturaG.IdArticulo)
                    {
                        BLL.FacturaBLL.Mofidicar(facturaG);
                        MessageBox.Show("Articulo fue modificado");
                    }
                    else
                    {

                        BLL.FacturaBLL.Guardar(facturaG);
                        MessageBox.Show("Nuevo Articulo agregado con exito!");
                    }
                }
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }

            /*

            if (BLL.GruposBLL.Guardar(grupo))
            {
                foreach (var item in listado)
                {
                    BLL.EstudiantesBLL.Guardar(item);
                }
                BLL.GruposEstudiantesBLL.Guardar(relaciones);
                MessageBox.Show("Guardo");
            }
            else
            {
                MessageBox.Show("No Guardo");
            }
            */
        }
    }
}
