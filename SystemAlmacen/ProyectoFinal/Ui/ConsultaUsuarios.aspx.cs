using Entidades;
using ProyectoTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Ui.Consultas
{
    public partial class ConsultaUsuarios : System.Web.UI.Page
    {
        public static List<Entidades.Usuarios> Lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            UsuarioGrid.DataSource = BLL.UserBLL.GetListodo();
            UsuarioGrid.DataBind();
            Lista = BLL.UserBLL.GetListodo();

        }

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

                if (desdeFecha.Text == "" && desdeFecha.Text == null)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fecha invalida ');</script>");

                    hastaFecha.Text = "";
                    desdeFecha.Text = "";
                    desdeFecha.Focus();
                }
                else
                {

                    DateTime desde = DateTime.Now;
                    DateTime hasta = DateTime.Now;
                    if (desdeFecha.Text == "")
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fecha invalida ');</script>");
                        hastaFecha.Text = "";
                        desdeFecha.Text = "";
                        desdeFecha.Focus();
                    }
                    else
                    {
                        desde = Convert.ToDateTime(desdeFecha.Text);
                        hasta = Convert.ToDateTime(hastaFecha.Text);
                    }


                    if (desdeFecha.Text != "" && hastaFecha.Text != "")
                    {
                        if (desde <= hasta)
                        {


                            Lista = BLL.UserBLL.GetList(p => p.FechaIngreso >= desde.Date && p.FechaIngreso <= hasta.Date);
                            UsuarioGrid.DataSource = Lista;
                            UsuarioGrid.DataBind();


                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fecha invalida debe ser menor');</script>");
                            desdeFecha.Text = "";
                            hastaFecha.Text = "";
                            desdeFecha.Focus();
                        }
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Ingrese Fecha');</script>");
                        desdeFecha.Focus();
                    }

                }



            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Selecionar(Utilidades.TOINT(buscaText.Text));
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Selecionar(Utilidades.TOINT(buscaText.Text));
        }
    }
}