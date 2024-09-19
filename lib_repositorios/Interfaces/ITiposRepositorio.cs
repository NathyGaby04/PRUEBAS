using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ITiposRepositorio
    {
        void Configurar(string string_conexion);
        List<Tipos> Listar();
        List<Tipos> Buscar(Expression<Func<Tipos, bool>> condiciones);
        Tipos Guardar(Tipos entidad);
        Tipos Modificar(Tipos entidad);
        Tipos Borrar(Tipos entidad);
        bool Existe(Expression<Func<Tipos, bool>> condiciones);
    }
}