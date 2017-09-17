using Entidades;
using ProyectoTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoFinal.Ui.Consultas
{
    public partial class ConsultaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            UsuarioGrid.DataSource = BLL.UserBLL.GetListodo();
            UsuarioGrid.DataBind();
          




        }

        public List<Entidades.Usuarios> Lista { get; set; }

        public void Selecionar(int id)
        {
          
          

            if (DropFiltro.SelectedIndex == 0)
            {
                buscaText.Text = "";
                

                if (BLL.UserBLL.GetListodo().Count == 0)
                {
                   
                    MessageBox.Show("No se han registrado Usuarios");
                }
                else
                {
                    Lista = BLL.UserBLL.GetListodo();
                    UsuarioGrid.DataSource = Lista;
                    

                }
            }
            else if (DropFiltro.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(buscaText.Text))
                {
                    MessageBox.Show("Campo ID Vaccio");
                }
                else
                {

                   
                    if (BLL.UserBLL.GetList(p => p.Id == id) != null)
                    {
                        Lista = BLL.UserBLL.GetList(p => p.Id == id);
                        UsuarioGrid.DataSource = Lista;
                        UsuarioGrid.DataBind();





                    }
                    else if (UsuarioGrid.DataSource == null)
                    {
                        MessageBox.Show("Id No Existe");
                       
                    }

                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Selecionar(Utilidades.TOINT(buscaText.Text));
        }

        protected void buscaText_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void DropFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        protected void DropFiltro_TextChanged(object sender, EventArgs e)
        {
        }
    }
}