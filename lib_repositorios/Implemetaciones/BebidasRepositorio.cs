using lib_entidades;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class BebidasRepositorio : IBebidasRepositorio
    {
        private Conexion? conexion;

        public BebidasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Bebidas> Listar()
        {
            return conexion!.Listar<Bebidas>();
        }

        public List<Bebidas> Buscar(Expression<Func<Bebidas, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Bebidas Guardar(Bebidas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Bebidas Modificar(Bebidas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Bebidas Borrar(Bebidas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Bebidas, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}