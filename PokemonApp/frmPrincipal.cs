using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace PokemonApp
{
    public partial class frmPrincipal : Form
    {
        private List<Pokemon> listaPokemon;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Numero");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
        }

        private void cargar ()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvPokemon.DataSource = listaPokemon;
                ocultarColumnas();
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            dgvPokemon.Columns["ID"].Visible = false;
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }
        private void cargarImagen(string imagen) {
            try
            {
                picboxPokemon.Load(imagen);
            }
            catch (Exception)
            {
                picboxPokemon.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/non_2x/icon-image-not-found-free-vector.jpg");
            }
        }

        private void btnAgregarPpal_Click(object sender, EventArgs e)
        {
            frmAgregar alta = new frmAgregar();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

            frmAgregar modificar = new frmAgregar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFis_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLog_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar (bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult result = MessageBox.Show("Seguro quieres eliminarlo?", "Eliminando Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminarLogico(seleccionado.ID);
                    else
                        negocio.eliminarFisico(seleccionado.ID);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltroAv_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAv.Text;
                dgvPokemon.DataSource = negocio.filtrar(campo, criterio, filtro);
                if (dgvPokemon.Rows.Count == 0)
                {
                    bloquearBtn();
                }
                else
                    activarBtn();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void bloquearBtn()
        {
            btnEliminarFis.Enabled = false;
            btnEliminarLog.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void activarBtn() { 
                btnEliminarFis.Enabled = true;
                btnEliminarLog.Enabled = true;
                btnModificar.Enabled = true;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = (txtFiltro.Text).ToUpper();

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro) || x.Tipo.Descripcion.ToUpper().Contains(filtro) || x.Debilidad.Descripcion.ToUpper().Contains(filtro));
                if(listaFiltrada.Count == 0)
                    bloquearBtn();
                else
                    activarBtn();
            }
            else
            {
                listaFiltrada = listaPokemon;
                activarBtn();
            }

            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            cboCriterio.Items.Clear();
            if (opcion == "Numero")
            {
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
            
        }

 
    }
}
