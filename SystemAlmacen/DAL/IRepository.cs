using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {

        TEntity Guardar(TEntity laEntidad);

        bool Modificar(TEntity laEntidad);

        bool Eliminar(TEntity laEntidad);

        /// La expession sera un delegado que es una funcion que permitira buscar por la condicion que definamos
        TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda);

        List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda);

    }
}
