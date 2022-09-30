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

namespace panelVisual.UserControls
{
    public partial class UC_Admin : UserControl
    {
        public UC_Admin()
        {
            InitializeComponent();
            CategoriaRepositorio.IniciarRepositorio();
            ProductoRepositorio.IniciarRepositorio();
            VisualizarCategoria();
            VisualizarProductos();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            DialogResult dialogResult = productForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                // Agrego el producto
                ProductoRepositorio.AgregarProducto(productForm.produtoNuevo);
                VisualizarProductos();
            }

        }

        private void VisualizarProductos()
        {
            dataGridView1.Rows.Clear();
            foreach (Producto prod in ProductoRepositorio.Productos)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = prod.Color.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = prod.Precio.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = prod.Categoria.Nombre.ToString();

            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idCategoriaEliminar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ProductoRepositorio.EliminarProducto(int.Parse(idCategoriaEliminar));
                VisualizarProductos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto para Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idProductoEditar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombreProductoEditar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string colorProductoEditar = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string precioProductoEditar = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string categoriaProductoEditar = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                Producto productoEditar = new Producto()
                {
                    Id = int.Parse(idProductoEditar),
                    Nombre = nombreProductoEditar,
                    Color = colorProductoEditar,
                    Precio = double.Parse(precioProductoEditar),
                    Categoria = CategoriaRepositorio.GetCategoriaByName(categoriaProductoEditar)

                };

                ProductForm productForm = new ProductForm(productoEditar);
                DialogResult dialogResult = productForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    // Edito el producto
                    ProductoRepositorio.EditarProducto(int.Parse(idProductoEditar), productForm.produtoNuevo);
                    VisualizarProductos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto para Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCat_Click_1(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            DialogResult dialogResult = categoryForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                // Agrego la categoria
                CategoriaRepositorio.AgregarCategoria(categoryForm.categoriaNuevo);
                VisualizarCategoria();
            }
        }

        private void btnEliminarCat_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string idCategoriaEliminar = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                CategoriaRepositorio.EliminarCategoria(int.Parse(idCategoriaEliminar));
                VisualizarCategoria();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un categoria para Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VisualizarCategoria()
        {
            dataGridView2.Rows.Clear();
            foreach (Categoria prod in CategoriaRepositorio.Categorias)
            {
                int rowIndex = dataGridView2.Rows.Add();
                dataGridView2.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                dataGridView2.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
            }
        }

        private void btnEditarCat_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string idCategoriaEditar = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string nombreCategoriaEditar = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();

                Categoria categoriaEditar = new Categoria()
                {
                    Id = int.Parse(idCategoriaEditar),
                    Nombre = nombreCategoriaEditar
                };

                CategoryForm categoryForm = new CategoryForm();
                DialogResult dialogResult = categoryForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    // Edito el producto
                    CategoriaRepositorio.EditarCategoria(int.Parse(idCategoriaEditar), categoryForm.categoriaNuevo);
                    VisualizarCategoria();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoria para Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
