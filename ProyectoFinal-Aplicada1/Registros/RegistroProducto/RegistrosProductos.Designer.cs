namespace ProyectoFinal_Aplicada1.RegistroProducto
{
    partial class RegistrosProductos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosProductos));
            this.MarcatextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProveedorProductoscomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DescripcionProtextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrecioProdtextBox = new System.Windows.Forms.TextBox();
            this.UnidadTextBox2 = new System.Windows.Forms.TextBox();
            this.PaisProductotextBox = new System.Windows.Forms.TextBox();
            this.DireccionProductotextBox = new System.Windows.Forms.TextBox();
            this.BuscarProductobutton = new System.Windows.Forms.Button();
            this.ProductoIdtextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Editarbutton = new System.Windows.Forms.Button();
            this.Registrarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CampoObligatorioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CampoObligatorioerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // MarcatextBox
            // 
            this.MarcatextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcatextBox.ForeColor = System.Drawing.Color.Gray;
            this.MarcatextBox.Location = new System.Drawing.Point(235, 293);
            this.MarcatextBox.Multiline = true;
            this.MarcatextBox.Name = "MarcatextBox";
            this.MarcatextBox.Size = new System.Drawing.Size(371, 42);
            this.MarcatextBox.TabIndex = 16;
            this.MarcatextBox.Text = "Marca";
            this.MarcatextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MarcatextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MarcatextBox_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(385, 712);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unidad";
            // 
            // ProveedorProductoscomboBox
            // 
            this.ProveedorProductoscomboBox.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ProveedorProductoscomboBox.FormattingEnabled = true;
            this.ProveedorProductoscomboBox.Location = new System.Drawing.Point(235, 217);
            this.ProveedorProductoscomboBox.Name = "ProveedorProductoscomboBox";
            this.ProveedorProductoscomboBox.Size = new System.Drawing.Size(371, 31);
            this.ProveedorProductoscomboBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(374, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(390, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio";
            // 
            // DescripcionProtextBox
            // 
            this.DescripcionProtextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProtextBox.ForeColor = System.Drawing.Color.Gray;
            this.DescripcionProtextBox.Location = new System.Drawing.Point(235, 376);
            this.DescripcionProtextBox.Multiline = true;
            this.DescripcionProtextBox.Name = "DescripcionProtextBox";
            this.DescripcionProtextBox.Size = new System.Drawing.Size(371, 55);
            this.DescripcionProtextBox.TabIndex = 8;
            this.DescripcionProtextBox.Text = "Descripcion";
            this.DescripcionProtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DescripcionProtextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DescripcionProtextBox_MouseClick);
            this.DescripcionProtextBox.TextChanged += new System.EventHandler(this.DescripciontextBox_TextChanged);
            // 
            // NombretextBox
            // 
            this.NombretextBox.ForeColor = System.Drawing.Color.Gray;
            this.NombretextBox.Location = new System.Drawing.Point(235, 117);
            this.NombretextBox.Multiline = true;
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(371, 33);
            this.NombretextBox.TabIndex = 6;
            this.NombretextBox.Text = "Nombre";
            this.NombretextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NombretextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductostextBox_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.PrecioProdtextBox);
            this.panel2.Controls.Add(this.UnidadTextBox2);
            this.panel2.Controls.Add(this.PaisProductotextBox);
            this.panel2.Controls.Add(this.DireccionProductotextBox);
            this.panel2.Controls.Add(this.MarcatextBox);
            this.panel2.Controls.Add(this.BuscarProductobutton);
            this.panel2.Controls.Add(this.ProductoIdtextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ProveedorProductoscomboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.NombretextBox);
            this.panel2.Controls.Add(this.DescripcionProtextBox);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Location = new System.Drawing.Point(10, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 806);
            this.panel2.TabIndex = 12;
            // 
            // PrecioProdtextBox
            // 
            this.PrecioProdtextBox.Location = new System.Drawing.Point(325, 673);
            this.PrecioProdtextBox.Name = "PrecioProdtextBox";
            this.PrecioProdtextBox.Size = new System.Drawing.Size(213, 30);
            this.PrecioProdtextBox.TabIndex = 38;
            // 
            // UnidadTextBox2
            // 
            this.UnidadTextBox2.Location = new System.Drawing.Point(325, 750);
            this.UnidadTextBox2.Name = "UnidadTextBox2";
            this.UnidadTextBox2.Size = new System.Drawing.Size(213, 30);
            this.UnidadTextBox2.TabIndex = 37;
            // 
            // PaisProductotextBox
            // 
            this.PaisProductotextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaisProductotextBox.ForeColor = System.Drawing.Color.Gray;
            this.PaisProductotextBox.Location = new System.Drawing.Point(235, 558);
            this.PaisProductotextBox.Multiline = true;
            this.PaisProductotextBox.Name = "PaisProductotextBox";
            this.PaisProductotextBox.Size = new System.Drawing.Size(371, 55);
            this.PaisProductotextBox.TabIndex = 36;
            this.PaisProductotextBox.Text = "Pais";
            this.PaisProductotextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaisProductotextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaisProductotextBox_MouseClick);
            // 
            // DireccionProductotextBox
            // 
            this.DireccionProductotextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionProductotextBox.ForeColor = System.Drawing.Color.Gray;
            this.DireccionProductotextBox.Location = new System.Drawing.Point(235, 470);
            this.DireccionProductotextBox.Multiline = true;
            this.DireccionProductotextBox.Name = "DireccionProductotextBox";
            this.DireccionProductotextBox.Size = new System.Drawing.Size(371, 55);
            this.DireccionProductotextBox.TabIndex = 35;
            this.DireccionProductotextBox.Text = "Direccion";
            this.DireccionProductotextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DireccionProductotextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DireccionProductotextBox_MouseClick);
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarProductobutton.Image")));
            this.BuscarProductobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarProductobutton.Location = new System.Drawing.Point(527, 25);
            this.BuscarProductobutton.Name = "BuscarProductobutton";
            this.BuscarProductobutton.Size = new System.Drawing.Size(141, 45);
            this.BuscarProductobutton.TabIndex = 34;
            this.BuscarProductobutton.Text = "Buscar";
            this.BuscarProductobutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarProductobutton.UseVisualStyleBackColor = true;
            this.BuscarProductobutton.Click += new System.EventHandler(this.BuscarProductobutton_Click);
            // 
            // ProductoIdtextBox
            // 
            this.ProductoIdtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ProductoIdtextBox.ForeColor = System.Drawing.Color.Gray;
            this.ProductoIdtextBox.Location = new System.Drawing.Point(325, 33);
            this.ProductoIdtextBox.Multiline = true;
            this.ProductoIdtextBox.Name = "ProductoIdtextBox";
            this.ProductoIdtextBox.Size = new System.Drawing.Size(167, 35);
            this.ProductoIdtextBox.TabIndex = 12;
            this.ProductoIdtextBox.Text = "Codigo";
            this.ProductoIdtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductoIdtextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductoIdtextBox_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Editarbutton);
            this.panel1.Controls.Add(this.Registrarbutton);
            this.panel1.Controls.Add(this.Eliminarbutton);
            this.panel1.Location = new System.Drawing.Point(12, 865);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 115);
            this.panel1.TabIndex = 13;
            // 
            // Editarbutton
            // 
            this.Editarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Editarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editarbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editarbutton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Editarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Editarbutton.Image")));
            this.Editarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editarbutton.Location = new System.Drawing.Point(21, 16);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(172, 72);
            this.Editarbutton.TabIndex = 15;
            this.Editarbutton.Text = "Nuevo";
            this.Editarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Editarbutton.UseVisualStyleBackColor = false;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // Registrarbutton
            // 
            this.Registrarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Registrarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrarbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarbutton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Registrarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Registrarbutton.Image")));
            this.Registrarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registrarbutton.Location = new System.Drawing.Point(288, 16);
            this.Registrarbutton.Name = "Registrarbutton";
            this.Registrarbutton.Size = new System.Drawing.Size(186, 72);
            this.Registrarbutton.TabIndex = 12;
            this.Registrarbutton.Text = "Guardar";
            this.Registrarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Registrarbutton.UseVisualStyleBackColor = false;
            this.Registrarbutton.Click += new System.EventHandler(this.Registrarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.Color.White;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(560, 16);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(218, 72);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR BERKLEY", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(346, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 56);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registros";
            // 
            // CampoObligatorioerrorProvider
            // 
            this.CampoObligatorioerrorProvider.ContainerControl = this;
            // 
            // RegistrosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 1005);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RegistrosProductos";
            this.Text = "RegistrosProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegistrosProductos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CampoObligatorioerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MarcatextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ProveedorProductoscomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescripcionProtextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BuscarProductobutton;
        private System.Windows.Forms.TextBox ProductoIdtextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Editarbutton;
        private System.Windows.Forms.Button Registrarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PaisProductotextBox;
        private System.Windows.Forms.TextBox DireccionProductotextBox;
        private System.Windows.Forms.TextBox UnidadTextBox2;
        private System.Windows.Forms.TextBox PrecioProdtextBox;
        private System.Windows.Forms.ErrorProvider CampoObligatorioerrorProvider;
    }
}