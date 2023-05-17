using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace PokemonApp
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pokemon poke = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                poke.Numero = int.Parse(txtNumero.Text);
                poke.Nombre = txtNombre.Text;
                poke.Descripcion = txtDescripcion.Text;

                negocio.agregar(poke);
                MessageBox.Show("Agregado exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
