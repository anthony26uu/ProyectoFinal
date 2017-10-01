using Entidades;
using ProyectoTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal.Ui.Registros
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        Usuarios usuario = new Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        {


            this.TextFecha.Text = string.Format("{0:G}", DateTime.Now);



            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);

        }

        private void Limpiar()
        {
            TextBoxID.Text = "";
            TextBoxConfirm.Text = "";
            TextBoxNombre.Text = "";
            TextBoxPass.Text = "";
            RequiredFieldValidator1.Text = "";
            RequiredFieldValidator2.Text = "";
            RequiredFieldValidator3.Text = "";
            RequiredFieldValidator3.Text = "";
            RequiredFieldValidator5.Text = "";
            DropTipo.Text = null;

        }

        private Usuarios LlenarCampos()
        {

            usuario.Id = (Utilidades.TOINT(TextBoxID.Text));
            usuario.NombreUsuario = TextBoxNombre.Text;
            usuario.PassUsuario = TextBoxPass.Text;
            usuario.Tipo = DropTipo.Text;
            usuario.FechaIngreso = Convert.ToDateTime(TextFecha.Text);
            return usuario;
        }

        private bool validarUser()
        {
            bool retorno = true;
            Entidades.Usuarios us = new Usuarios();
            us = BLL.UserBLL.Buscar(p => p.NombreUsuario == TextBoxNombre.Text);
            if (us != null)
            {
                if (us.NombreUsuario == TextBoxNombre.Text)
                {
                   
                    retorno = false;
                }
            }

            return retorno;
        }


        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

       
        protected void Guardar_Click(object sender, EventArgs e)
        {

            var guardar = new Entidades.Usuarios();
            int id = 0;
            try
            {
                if (IsValid)
                {
                   
                    if (!validarUser())
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Nombre de usuario ya existe');</script>");


                        }
                        else
                        {
                            guardar.Id = (Utilidades.TOINT(TextBoxID.Text));
                            guardar.NombreUsuario = TextBoxNombre.Text;
                            guardar.PassUsuario = TextBoxPass.Text;
                            guardar.Tipo = DropTipo.Text;
                            guardar.FechaIngreso = Convert.ToDateTime(TextFecha.Text);



                            if (TextBoxPass.Text == TextBoxConfirm.Text)
                            {
                                if (id != guardar.Id)
                                {
                                    BLL.UserBLL.Mofidicar(guardar);

                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Usuario modificado con exito');</script>");


                                }
                                else
                                {
                                    BLL.UserBLL.Guardar(guardar);
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Nuevo usuario agregado!');</script>");


                                }
                            }
                            else
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Campos Contraseña no coninciden');</script>");



                            }
                        

                    }
                }
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void BotonBuscar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(TextBoxID.Text))
            {


                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe Usuario con este ido');</script>");


                Limpiar();
            }
            else

            {
               
                int id = int.Parse(TextBoxID.Text);
                var user = BLL.UserBLL.Buscar(p => p.Id == id);
                if (user != null)
                {
                    TextBoxID.Text = Convert.ToString(user.Id);
                    TextBoxNombre.Text = user.NombreUsuario;
                    DropTipo.Text = user.Tipo;
                    TextBoxPass.Text = user.PassUsuario;
                    TextBoxConfirm.Text = user.PassUsuario;
                    TextFecha.Text = Convert.ToString(user.FechaIngreso);


                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Contraseña omitida por Seguridad');</script>");

                    
                }
                else
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe Usuario con este ido');</script>");
                
                    
                }
            }

        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxID.Text))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe Usuario con este id');</script>");


             
                Limpiar();


            }
            else
            {
                int id = int.Parse(TextBoxID.Text);
                var bll = new BLL.UserBLL();
                var user = BLL.UserBLL.Buscar(p => p.Id == id);
                if (BLL.UserBLL.Eliminar(user))
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('El Usuario se ha Eliminado  con exito');</script>");

                    Limpiar();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se pudo eliminar El usuario');</script>");

                 
                }
            }
        }

        protected void TextFecha_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}