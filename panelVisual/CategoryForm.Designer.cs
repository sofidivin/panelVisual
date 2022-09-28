namespace panelVisual
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdCat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.NombreCat = new System.Windows.Forms.Label();
            this.btnAceptarCat = new System.Windows.Forms.Button();
            this.lblIdCat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 60);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIdCat);
            this.panel1.Controls.Add(this.IdCat);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 0;
            // 
            // IdCat
            // 
            this.IdCat.BackColor = System.Drawing.Color.Black;
            this.IdCat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdCat.Location = new System.Drawing.Point(0, 0);
            this.IdCat.Name = "IdCat";
            this.IdCat.Size = new System.Drawing.Size(100, 23);
            this.IdCat.TabIndex = 0;
            this.IdCat.Text = "ID";
            this.IdCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNombreCat);
            this.panel2.Controls.Add(this.NombreCat);
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 23);
            this.panel2.TabIndex = 2;
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Location = new System.Drawing.Point(100, 0);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(100, 23);
            this.txtNombreCat.TabIndex = 1;
            // 
            // NombreCat
            // 
            this.NombreCat.BackColor = System.Drawing.Color.Black;
            this.NombreCat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombreCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NombreCat.Location = new System.Drawing.Point(0, 0);
            this.NombreCat.Name = "NombreCat";
            this.NombreCat.Size = new System.Drawing.Size(100, 23);
            this.NombreCat.TabIndex = 0;
            this.NombreCat.Text = "Nombre";
            this.NombreCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAceptarCat
            // 
            this.btnAceptarCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCat.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAceptarCat.Location = new System.Drawing.Point(103, 135);
            this.btnAceptarCat.Name = "btnAceptarCat";
            this.btnAceptarCat.Size = new System.Drawing.Size(85, 32);
            this.btnAceptarCat.TabIndex = 16;
            this.btnAceptarCat.Text = "Aceptar";
            this.btnAceptarCat.UseVisualStyleBackColor = false;
            this.btnAceptarCat.Click += new System.EventHandler(this.btnAceptarCat_Click);
            // 
            // lblIdCat
            // 
            this.lblIdCat.AutoSize = true;
            this.lblIdCat.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCat.ForeColor = System.Drawing.Color.White;
            this.lblIdCat.Location = new System.Drawing.Point(132, 4);
            this.lblIdCat.Name = "lblIdCat";
            this.lblIdCat.Size = new System.Drawing.Size(38, 15);
            this.lblIdCat.TabIndex = 1;
            this.lblIdCat.Text = "label1";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(290, 180);
            this.Controls.Add(this.btnAceptarCat);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label IdCat;
        private Panel panel2;
        private TextBox txtNombreCat;
        private Label NombreCat;
        private Button btnAceptarCat;
        private Label lblIdCat;
    }
}