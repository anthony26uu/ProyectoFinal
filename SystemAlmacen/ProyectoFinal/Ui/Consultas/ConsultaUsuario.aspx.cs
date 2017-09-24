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
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado Usuarios');</script>");

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

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Campo ID Vaccio');</script>");

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
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado Usuarios con este Id');</script>");


                    }

                }
            }

            else if (DropFiltro.SelectedIndex == 2)
            {

                DateTime desde = Convert.ToDateTime(desdeFecha.Text);
                DateTime hasta = Convert.ToDateTime(desdeFecha.Text);

                if (desdeFecha.Text != "" && hastaFecha.Text != "")
                {
                    if (desde <= hasta)
                    {
                        Lista = BLL.UserBLL.GetList(p => p.FechaIngreso >= desde && p.FechaIngreso <= hasta);
                        UsuarioGrid.DataSource = Lista;
                        UsuarioGrid.DataBind();
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fecha invalida debe ser menor');</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Ingrese Fecha');</script>");
                }


            }
            else if (DropFiltro.SelectedIndex == 3)
            {
                if (buscaText.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe escribir el Nombre a buscar');</script>");
                }
                else
                {
                    Lista = BLL.UserBLL.GetList(p => p.NombreUsuario == buscaText.Text);
                    UsuarioGrid.DataSource = Lista;
                    UsuarioGrid.DataBind();
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

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UsuarioReport.aspx");
        }
    }
}