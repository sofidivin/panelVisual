using panelVisual.Modelos;
using panelVisual.Properties;
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
    public partial class CategoryForm : Form
    {
        public Categoria categoriaNuevo;

        public CategoryForm()
        {
            InitializeComponent();
            lblIdCat.Text = (CategoriaRepositorio.lastId + 1).ToString();
        }

        public CategoryForm(Categoria cat)
        {
            InitializeComponent();
            lblIdCat.Text = cat.Id.ToString();
            txtNombreCat.Text = cat.Nombre;
        }

        private void btnAceptarCat_Click(object sender, EventArgs e)
        {
            bool categoriaValidado = ValidarCategoria(out string errorMsg);

            if (categoriaValidado)
            {
                categoriaNuevo = new Categoria()
                {
                    Id = int.Parse(lblIdCat.Text),
                    Nombre = txtNombreCat.Text
                };

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private bool ValidarCategoria(out string errorMsg)
        {
            errorMsg = String.Empty;

            if (string.IsNullOrEmpty(lblIdCat.Text))
            {
                errorMsg += "Debe indicar el ID de la categoria " + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtNombreCat.Text))
            {
                errorMsg += "Debe indicar el Nombre de la categoria " + Environment.NewLine;
            }

            return errorMsg == String.Empty;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
