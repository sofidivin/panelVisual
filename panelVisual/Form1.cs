using panelVisual.Properties;

namespace panelVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProductoRepositorio.IniciarRepositorio();
            VisualizarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            DialogResult dialogResult = productForm.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                // Agrego el producto
                ProductoRepositorio.AgregarProducto(productForm.produtoNuevo);
                VisualizarProductos();
            }
            
        }

        private void VisualizarProductos()
        {
            foreach(Producto prod in ProductoRepositorio.Productos)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = prod.Color.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = prod.Precio.ToString();
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
    }
}