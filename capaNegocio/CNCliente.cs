using capaEntidad;
using capaDatos;
using System.Data;

namespace capaNegocio
{

    /*Creamos las reglas del Negocio*/
    public class CNCliente
    {
        CDCliente cDCliente = new CDCliente();
        public bool ValidarDatos(CECliente cliente)
        {
        /*Aquí se realizan las validaciones de campos vacíos*/
            bool Resultado = true;
            
            /*Aquí Valido si el campo del Nombre está vacío*/
            if (cliente.Nombre == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Nombre es Obligatorio");
            }

            /*Aquí Valido si el campo del Apellido está vacío*/
            if (cliente.Apellido == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Apellido es Obligatorio");
            }

            /*Aquí Valido si el campo de la Foto está vacío*/
            if (cliente.Foto == null)
            {
                Resultado = false;
                MessageBox.Show("La Foto es Obligatoria");
            }

            return Resultado;
        }


        /*Aquí están los métodos que tiene la clases Cliente*/

        public void PruebaMyssql()
        {
            cDCliente.PruebaConexion();
        }

        public void CrearCliente(CECliente cE)
        {
            cDCliente.Crear(cE);
        }

        public void EditarCliente(CECliente cE)
        {
            cDCliente.Editar(cE);
        }

        public void EliminarCliente(CECliente cE)
        {
            cDCliente.Eliminar(cE);
        }

        public DataSet ObtenerDatos()
        {
            return cDCliente.Listar();
        }

    }
}
