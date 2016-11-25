namespace ProyectoFinal_Aplicada1.Registros.RegistroUsuario
{
    partial class RegistrosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.NombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.UsuarioIdtextBox = new System.Windows.Forms.TextBox();
            this.CancelarUsbutton = new System.Windows.Forms.Button();
            this.CrearUsbutton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarUsbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RepContratextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.RepContratextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BuscarUsbutton);
            this.groupBox1.Controls.Add(this.ContrasenatextBox);
            this.groupBox1.Controls.Add(this.NombreUsuariotextBox);
            this.groupBox1.Controls.Add(this.UsuarioIdtextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Location = new System.Drawing.Point(-4, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserRegister";
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContrasenatextBox.Location = new System.Drawing.Point(165, 264);
            this.ContrasenatextBox.Multiline = true;
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.PasswordChar = '*';
            this.ContrasenatextBox.Size = new System.Drawing.Size(286, 49);
            this.ContrasenatextBox.TabIndex = 7;
            // 
            // NombreUsuariotextBox
            // 
            this.NombreUsuariotextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreUsuariotextBox.Location = new System.Drawing.Point(165, 165);
            this.NombreUsuariotextBox.Multiline = true;
            this.NombreUsuariotextBox.Name = "NombreUsuariotextBox";
            this.NombreUsuariotextBox.Size = new System.Drawing.Size(286, 47);
            this.NombreUsuariotextBox.TabIndex = 6;
            this.NombreUsuariotextBox.TextChanged += new System.EventHandler(this.NombreUsuariotextBox_TextChanged);
            this.NombreUsuariotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreUsuariotextBox_KeyPress);
            // 
            // UsuarioIdtextBox
            // 
            this.UsuarioIdtextBox.Enabled = false;
            this.UsuarioIdtextBox.ForeColor = System.Drawing.Color.Gray;
            this.UsuarioIdtextBox.Location = new System.Drawing.Point(165, 83);
            this.UsuarioIdtextBox.Multiline = true;
            this.UsuarioIdtextBox.Name = "UsuarioIdtextBox";
            this.UsuarioIdtextBox.Size = new System.Drawing.Size(275, 30);
            this.UsuarioIdtextBox.TabIndex = 5;
            this.UsuarioIdtextBox.Text = "UsuarioId";
            this.UsuarioIdtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsuarioIdtextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsuarioIdtextBox_MouseClick);
            this.UsuarioIdtextBox.TextChanged += new System.EventHandler(this.UsuarioIdtextBox_TextChanged);
            // 
            // CancelarUsbutton
            // 
            this.CancelarUsbutton.BackColor = System.Drawing.Color.Transparent;
            this.CancelarUsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarUsbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarUsbutton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CancelarUsbutton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarUsbutton.Image")));
            this.CancelarUsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarUsbutton.Location = new System.Drawing.Point(458, 514);
            this.CancelarUsbutton.Name = "CancelarUsbutton";
            this.CancelarUsbutton.Size = new System.Drawing.Size(188, 55);
            this.CancelarUsbutton.TabIndex = 10;
            this.CancelarUsbutton.Text = "Nuevo";
            this.CancelarUsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarUsbutton.UseVisualStyleBackColor = false;
            this.CancelarUsbutton.Click += new System.EventHandler(this.CancelarUsbutton_Click);
            // 
            // CrearUsbutton
            // 
            this.CrearUsbutton.BackColor = System.Drawing.Color.Transparent;
            this.CrearUsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearUsbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearUsbutton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CrearUsbutton.Image = ((System.Drawing.Image)(resources.GetObject("CrearUsbutton.Image")));
            this.CrearUsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrearUsbutton.Location = new System.Drawing.Point(43, 514);
            this.CrearUsbutton.Name = "CrearUsbutton";
            this.CrearUsbutton.Size = new System.Drawing.Size(206, 55);
            this.CrearUsbutton.TabIndex = 9;
            this.CrearUsbutton.Text = "Crear Usuario";
            this.CrearUsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CrearUsbutton.UseVisualStyleBackColor = false;
            this.CrearUsbutton.Click += new System.EventHandler(this.CrearUsbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // BuscarUsbutton
            // 
            this.BuscarUsbutton.ForeColor = System.Drawing.Color.Goldenrod;
            this.BuscarUsbutton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarUsbutton.Image")));
            this.BuscarUsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarUsbutton.Location = new System.Drawing.Point(456, 69);
            this.BuscarUsbutton.Name = "BuscarUsbutton";
            this.BuscarUsbutton.Size = new System.Drawing.Size(141, 49);
            this.BuscarUsbutton.TabIndex = 9;
            this.BuscarUsbutton.Text = "Buscar";
            this.BuscarUsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarUsbutton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(404, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 44);
            this.label3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(404, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 36);
            this.label5.TabIndex = 11;
            // 
            // RepContratextBox
            // 
            this.RepContratextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepContratextBox.Location = new System.Drawing.Point(165, 364);
            this.RepContratextBox.Multiline = true;
            this.RepContratextBox.Name = "RepContratextBox";
            this.RepContratextBox.PasswordChar = '*';
            this.RepContratextBox.Size = new System.Drawing.Size(286, 46);
            this.RepContratextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(399, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 46);
            this.label7.TabIndex = 14;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(43, 588);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(577, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // RegistrosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 623);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CancelarUsbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CrearUsbutton);
            this.Name = "RegistrosUsuarios";
            this.Text = "RegistrosUsuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarUsbutton;
        private System.Windows.Forms.Button CrearUsbutton;
        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.TextBox NombreUsuariotextBox;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuscarUsbutton;
        private System.Windows.Forms.TextBox RepContratextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox UsuarioIdtextBox;
    }
}