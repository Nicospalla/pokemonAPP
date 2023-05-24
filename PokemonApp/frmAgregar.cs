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
using System.Configuration;
using System.IO;

namespace PokemonApp
{
    public partial class frmAgregar : Form
    {
        private Pokemon pokemon = null;
        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Pokemon pokemon)
        {
            InitializeComponent();
            Text = "Modificar Pokemon";
            this.pokemon = pokemon;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            frmPrincipal frmPrincipal = new frmPrincipal();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();
                if (txtNumero.Text == "" || !frmPrincipal.validaNumero(txtNumero.Text) || pokemon.Nombre == "" || cboTipo.SelectedIndex < 0 || cboDebilidad.SelectedIndex < 0)
                {
                    if (!frmPrincipal.validaNumero(txtNumero.Text))
                    {
                        MessageBox.Show("Recuerda que el número, SOLO puede ser de carácter NUMERICO.");
                        return;
                    }
                    MessageBox.Show("No puedes guardar un Pokemon sin, al menos, Número, Nombre, Tipo y Debilidad.");
                    return;
                }

                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                if (!(txtUrlImagen.Text == null))
                    pokemon.UrlImagen = txtUrlImagen.Text;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;
                if (pokemon.ID != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
                }

                if (archivo != null && !(txtUrlImagen.Text.ToLower().Contains("http")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["poke-app"] + archivo.SafeFileName, true);

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboTipo.SelectedIndex = -1;
                cboDebilidad.DataSource = elementoNegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";
                cboDebilidad.SelectedIndex = -1;

                if (pokemon != null)
                {
                
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(txtUrlImagen.Text);
                    cboTipo.SelectedValue = pokemon.Tipo.id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception)
            {
                pbxPokemon.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/non_2x/icon-image-not-found-free-vector.jpg");
            }
        }
        private OpenFileDialog archivo = null;
        private void btnSubirImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "Jpg |*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
            

        }
    }
}
