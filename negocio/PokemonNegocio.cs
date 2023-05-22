using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {

            try
            {
                List<Pokemon> lista = new List<Pokemon>();
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;

                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT P.Id, Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, P.IdTipo, P.IdDebilidad , D.Descripcion as Debilidad FROM POKEMONS as P, ELEMENTOS as E, ELEMENTOS as D WHERE P.IdTipo = E.Id AND D.Id = P.IdDebilidad And P.Activo = 1";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.ID = (int)lector["Id"];
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Tipo.id = (int)lector["IdTipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    aux.Debilidad.id = (int)lector["IdDebilidad"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values (" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "',1, @IdTipo, @IdDebilidad, @UrlImagen) ");
                datos.setearParametros("@IdTipo", nuevo.Tipo.id);
                datos.setearParametros("@IdDebilidad", nuevo.Debilidad.id);
                datos.setearParametros("UrlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            { 
                datos.cerrarConexion();
            }

        }
        public void modificar(Pokemon poke)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @num, Nombre = @nombre, Descripcion = @descripcion, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDeb where Id = @id");
                datos.setearParametros("@num", poke.Numero);
                datos.setearParametros("@nombre", poke.Nombre);
                datos.setearParametros("@descripcion", poke.Descripcion);
                datos.setearParametros("@img", poke.UrlImagen);
                datos.setearParametros("@idTipo", poke.Tipo.id);
                datos.setearParametros("@idDeb", poke.Debilidad.id);
                datos.setearParametros("@id", poke.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarFisico(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from POKEMONS where id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            { 
                throw;
            } finally 
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarLogico (int id)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Activo = 0 where id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT P.Id, Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, P.IdTipo, P.IdDebilidad , D.Descripcion as Debilidad FROM POKEMONS as P, ELEMENTOS as E, ELEMENTOS as D WHERE P.IdTipo = E.Id AND D.Id = P.IdDebilidad And P.Activo = 1 And ";
                if (campo == "Numero")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Numero > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Numero < " + filtro;
                            break;
                        default:
                            consulta += "Numero = " + filtro;
                            break;
                    }
                } else
                {
                    string elegido;
                    if (campo == "Nombre")
                        elegido = "Nombre ";
                    else
                        elegido = "P.Descripcion ";

                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += elegido + "like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += elegido + "like '%" + filtro + "'";
                            break;
                        default:
                            consulta += elegido + "like '%" + filtro + "%'";
                            break;
                    }
                }
                    datos.setearConsulta(consulta);
                    datos.ejecutarLectura();
                    while (datos.Lector.Read())
                    {
                        Pokemon aux = new Pokemon();
                        aux.ID = (int)datos.Lector["Id"];
                        aux.Numero = (int)datos.Lector["Numero"];
                        aux.Nombre = (string)datos.Lector["Nombre"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                        if (!(datos.Lector["UrlImagen"] is DBNull))
                            aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                        aux.Tipo = new Elemento();
                        aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                        aux.Tipo.id = (int)datos.Lector["IdTipo"];
                        aux.Debilidad = new Elemento();
                        aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                        aux.Debilidad.id = (int)datos.Lector["IdDebilidad"];

                        lista.Add(aux);
                    }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
