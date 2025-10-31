using MySql.Data.MySqlClient;
using capaEntidad;
using System.Data;
using Mysqlx.Sql;

namespace capaDatos
{
    public class CDCliente
    {

        /*Aquí establecemos la ruya y credenciales de la Base de Datos, previamente configurados en HeidiSQL*/
        string CadenaConexion = "Server=localhost;User=root;Password=12345678;Port=3306;database=curso_cs";

    /*Se realiza la prueba de conexión con la base de datos.*/

        public void PruebaConexion()
        {
            MySqlConnection mySqlConnection = new(CadenaConexion);

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Conectarse" + ex.Message);
                return;
            }
            mySqlConnection.Close();
            MessageBox.Show("Conectado!");

        }


        /*Aquí creamos el método de Crear un Registro*/

        public void Crear(CECliente cE)
        {
            MySqlConnection mySqlConnection = new(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `clientes` (`nombre`, `apellido`, `foto`) VALUES ('" + cE.Nombre + "', '" + cE.Apellido + "', '" + MySqlHelper.EscapeString(cE.Foto) + "');";

            MySqlCommand mySqlCommand = new(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Creado!");
            
        }

        /*Aquí creamos el método de Editar un Registro*/
        public void Editar(CECliente cE)
        {
            MySqlConnection mySqlConnection = new(CadenaConexion);
            mySqlConnection.Open();
            string Query = "UPDATE `clientes` SET `nombre`='" + cE.Nombre + "', `apellido`='"+ cE.Apellido +"', `foto`='"+ MySqlHelper.EscapeString(cE.Foto) + "' WHERE  `id`="+ cE.Id +";";

            MySqlCommand mySqlCommand = new(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Actualizado!");

        }

        /*Aquí creamos el método de Eliminar un Registro*/
        public void Eliminar(CECliente cE)
        {
            MySqlConnection mySqlConnection = new(CadenaConexion);
            mySqlConnection.Open();
            string Query = "DELETE FROM `clientes` WHERE  `id`=" + cE.Id + ";";

            MySqlCommand mySqlCommand = new(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Eliminado!");

        }

        /*Aquí creamos el Método Listar todos los Registros*/
        public DataSet Listar()
        {
            MySqlConnection mySqlConnection = new(CadenaConexion);
            mySqlConnection.Open();
            string Query = "SELECT * FROM `clientes` LIMIT 1000;";
            MySqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();

            Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            Adaptador.Fill(dataSet, "tbl");

            return dataSet;
        }
    }
}
