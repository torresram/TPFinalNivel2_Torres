using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;
using System.Net.Security;
using System.Drawing.Text;
using System.CodeDom.Compiler;

namespace WindowsFormsApp
{
    public partial class frmAltas : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
         
        public frmAltas()
        {
            InitializeComponent();
        }

        public frmAltas(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            //Icon = Properties.Resources.recycle;
            Text = "Modificar artículo";
        }

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                
                string checkCodigo = txtCodigo.Text;

                if(checkCodigo != articulo.Codigo)
                {
                    if (negocio.validarCodigo(txtCodigo.Text))
                    {
                        MessageBox.Show("El código ingresado ya existe, ingrese el correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodigo.Focus();
                        return;
                    }
                }

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;   
                articulo.Descripcion = txtDesc.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.ImagenURL = txtImagen.Text;

                string checkCadena = txtPrecio.Text.Replace('.', ',');
                
                if (soloNumeros(checkCadena))
                    articulo.Precio = decimal.Parse(checkCadena);
                else
                {
                    MessageBox.Show("El valor ingresado debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrecio.Focus();
                    txtPrecio.Clear();
                    return;
                }
                    

                if (articulo.Id != 0) 
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }                
                else 
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }                

                if (archivo != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
                    
                    if (File.Exists(ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName) == false)   
                        {
                            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                        }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }
        private void frmAltas_Load(object sender, EventArgs e)
        {
            cargaCbos();

            try
            {               
                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDesc.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.ImagenURL;
                    cargarImagen(articulo.ImagenURL);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbNuevaImg.Load(imagen);
            }
            catch (Exception)
            {
                pbNuevaImg.Load("http://sigpapelera.com.ar/Fotos/sin.jpg");
            }
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            frmMarcaCat marcaCat = new frmMarcaCat();
            marcaCat.ShowDialog();
            cargaCbos();
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {                
                if (!(char.IsNumber(caracter) || caracter == ','))
                    return false;
            }
            return true;
        }

        private void cargaCbos()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
