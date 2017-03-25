using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
   public class FacturaBLL
    {
        public static Facturas Guardar(Entidades.Facturas cliente)
        {
            Entidades.Facturas creado = null;
            using (var repositorio = new Repositorio<Entidades.Facturas>())
            {
                creado = repositorio.Guardar(cliente);
            }

            return creado;
        }

        public static Entidades.Facturas Buscarb(Expression<Func<Facturas, bool>> tipo)
        {
            Facturas Result = null;
            using (var repoitorio = new Repositorio<Facturas>())

            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }

        public static Facturas Buscar(Expression<Func<Facturas, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Facturas>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(Facturas cliente)
        {
            using (var repositorio = new DAL.Repositorio<Facturas>())
            {
                return repositorio.Eliminar(cliente);
            }
        }


        public static List<Entidades.Facturas> GetListodo()
        {
            List<Entidades.Facturas> lista = new List<Entidades.Facturas>();
            using (var db = new DAL.Repositorio<Facturas>())
            {
                try
                {
                    return db.ListaTodo();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public static bool Mofidicar(Facturas existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Facturas>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }



    }
}
