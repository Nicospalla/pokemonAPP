﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector { get; }

        public AccesoDatos(string cmd) {
            try
            {
                conexion = new SqlConnection("server = .\\SQLEXPRESS; database = POKEDEX_DB; integrated security");
                comando = new SqlCommand();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void setearConsulta(string consulta) { 
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura() {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion() {
            if(lector != null)
                lector.Close();
            conexion.Close();
        } 
    }
}
