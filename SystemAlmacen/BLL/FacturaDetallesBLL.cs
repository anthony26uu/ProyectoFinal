using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL  
{
  public  class FacturaDetallesBLL
    {


    public static bool Guardar(FacturaDetalles relacion)
    {
        bool resultado = false;
        using (var conexion = new RegistroDb())
        {
            try
            {
                conexion.RelacionDb.Add(relacion);
                conexion.SaveChanges();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        return resultado;
    }

    public static bool Guardar(List<FacturaDetalles >listado)
    {
        bool resultado = false;
        try
        {
            foreach (var relacion in listado)
            {
                resultado = Guardar(relacion);
            }

        }
        catch (Exception)
        {

            throw;
        }
        return resultado;
    }

    public static List<Articulos> Listar(Expression<Func<FacturaDetalles, bool>> criterioBusqueda)
    {
        List<Articulos> listado = new List<Articulos>();
        List<FacturaDetalles> relaciones = null;
        using (var conexion = new RegistroDb())
        {
            try
            {
                relaciones = conexion.RelacionDb.Where(criterioBusqueda).ToList();
                foreach (var item in relaciones)
                {
                    listado.Add(ArticuloBLL.BuscarRelacion(item.IdArticulo));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        return listado;
    }

}
}
