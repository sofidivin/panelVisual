using panelVisual.Modelos;
using panelVisual.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panelVisual
{
    public partial class ProductForm : Form
    {
        public Producto produtoNuevo;

        public ProductForm()
        {
            InitializeComponent();
            lblIdProds.Text = (ProductoRepositorio.lastId + 1).ToString();
            LlenarCombo();
        }

        public ProductForm(Producto prod)
        {
            InitializeComponent();
            LlenarCombo();
            lblIdProds.Text = prod.Id.ToString();
            txtNombre.Text = prod.Nombre;
            txtColor.Text = prod.Color;
            txtPrecio.Text = prod.Precio.ToString();
            cmBoxCategoria.SelectedItem = prod.Categoria.Nombre.ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool productoValidado = ValidarProducto(out string errorMsg);
            
            if(productoValidado)
            {
                produtoNuevo = new Producto()
                {
                    Id = int.Parse(lblIdProds.Text),
                    Nombre = txtNombre.Text,
                    Color = txtColor.Text,
                    Precio = double.Parse(txtPrecio.Text),
                    Categoria = CategoriaRepositorio.GetCategoriaByName(cmBoxCategoria.SelectedItem.ToString())
                };

                this.DialogResult = DialogResult.OK;
            } 
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }

        }

        //COMBO DE CATEGORIAS
        private void LlenarCombo()
        {
            foreach (Categoria cat in CategoriaRepositorio.Categorias)
            {
                cmBoxCategoria.Items.Add(cat.Nombre);
            }
        }

        private bool ValidarProducto(out string errorMsg)
        {
            errorMsg = String.Empty;

            if(string.IsNullOrEmpty(lblIdProds.Text))
            {
                errorMsg += "Debe indicar el ID del producto " + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorMsg += "Debe indicar el Nombre del producto " + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtColor.Text))
            {
                errorMsg += "Debe indicar el Color del producto " + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                errorMsg += "Debe indicar el Precio del producto " + Environment.NewLine;
            }

            return errorMsg == String.Empty;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBoxCategoria.SelectedItem != null)
            {
                Categoria seleccionada = CategoriaRepositorio.GetCategoriaByName(cmBoxCategoria.SelectedItem.ToString());
                /*filtroProd.Categoria = seleccionada;
                FiltrarProds();*/
            }
        }
    }
}
