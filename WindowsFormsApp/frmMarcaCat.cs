using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp
{
    public partial class frmMarcaCat : Form

    {
        private Marca marca = null;
        private Categoria categoria = null;

        public frmMarcaCat()
        {
            InitializeComponent();
        }

        private void btnAceptarCat_Click(object sender, EventArgs e)
        {
            MarcaNegocio Mnegocio = new MarcaNegocio();
            CategoriaNegocio Cnegocio = new CategoriaNegocio();

            try
            {
                string checkMarca = txtMarcaAdd.Text;
                string checkCategoria = txtCategoriaAdd.Text;

                if (checkMarca != null && checkMarca != "")
                    if (Mnegocio.validarMarca(checkMarca))
                    {
                        MessageBox.Show("La marca ya se encuentra ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMarcaAdd.Focus();
                        return;
                    }
                    else
                    {
                        marca = new Marca();
                        marca.Descripcion = txtMarcaAdd.Text;
                        Mnegocio.agregarMarca(marca);
                        MessageBox.Show("Marca ingresada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                if (checkCategoria != null && checkCategoria != "")
                    if (Cnegocio.validarCategoria(checkCategoria))
                    {
                        MessageBox.Show("La categoría ya se encuentra ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCategoriaAdd.Focus();
                        return;
                    }
                    else
                    {
                        categoria = new Categoria();
                        categoria.Descripcion = txtCategoriaAdd.Text;
                        Cnegocio.agregarCategoria(categoria);
                        MessageBox.Show("Categoría ingresada correctamente", "Éxito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
