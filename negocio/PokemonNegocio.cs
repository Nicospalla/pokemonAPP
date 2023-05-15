﻿using System;
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
                comando.CommandText = "SELECT Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad FROM POKEMONS as P, ELEMENTOS as E, ELEMENTOS as D WHERE P.IdTipo = E.Id AND D.Id = P.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemeto();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemeto();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    
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
    }
}