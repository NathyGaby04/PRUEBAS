using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IBebidasRepositorio
    {
        void Configurar(string string_conexion);
        List<Bebidas> Listar();
        List<Bebidas> Buscar(Expression<Func<Bebidas, bool>> condiciones);
        Bebidas Guardar(Bebidas entidad);
        Bebidas Modificar(Bebidas entidad);
        Bebidas Borrar(Bebidas entidad);
        bool Existe(Expression<Func<Bebidas, bool>> condiciones);
    }
}