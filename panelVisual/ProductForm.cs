using panelVisual.Properties;
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool productoValidado = ValidarProducto(out string errorMsg);
            
            if(productoValidado)
            {
                produtoNuevo = new Producto()
                {
                    Id = int.Parse(txtId.Text),
                    Nombre = txtNombre.Text,
                    Color = txtColor.Text,
                    Precio = int.Parse(txtPrecio.Text)
                };

                this.DialogResult = DialogResult.OK;
            } 
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private bool ValidarProducto(out string errorMsg)
        {
            errorMsg = String.Empty;

            if(string.IsNullOrEmpty(txtId.Text))
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
    }
}
