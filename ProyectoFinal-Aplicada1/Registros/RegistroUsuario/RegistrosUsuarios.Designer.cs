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
            this.CancelarUsbutton = new System.Windows.Forms.Button();
            this.CrearUsbutton = new System.Windows.Forms.Button();
            this.RepContratextBox = new System.Windows.Forms.TextBox();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.NombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.UsuarioIdtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.groupBox1.Controls.Add(this.RepContratextBox);
            this.groupBox1.Controls.Add(this.ContrasenatextBox);
            this.groupBox1.Controls.Add(this.NombreUsuariotextBox);
            this.groupBox1.Controls.Add(this.UsuarioIdtextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserRegister";
            // 
            // CancelarUsbutton
            // 
            this.CancelarUsbutton.BackColor = System.Drawing.Color.Transparent;
            this.CancelarUsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarUsbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarUsbutton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CancelarUsbutton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarUsbutton.Image")));
            this.CancelarUsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarUsbutton.Location = new System.Drawing.Point(421, 600);
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
            this.CrearUsbutton.Location = new System.Drawing.Point(25, 600);
            this.CrearUsbutton.Name = "CrearUsbutton";
            this.CrearUsbutton.Size = new System.Drawing.Size(206, 55);
            this.CrearUsbutton.TabIndex = 9;
            this.CrearUsbutton.Text = "Crear Usuario";
            this.CrearUsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CrearUsbutton.UseVisualStyleBackColor = false;
            this.CrearUsbutton.Click += new System.EventHandler(this.CrearUsbutton_Click);
            // 
            // RepContratextBox
            // 
            this.RepContratextBox.Location = new System.Drawing.Point(165, 427);
            this.RepContratextBox.Name = "RepContratextBox";
            this.RepContratextBox.PasswordChar = '*';
            this.RepContratextBox.Size = new System.Drawing.Size(275, 30);
            this.RepContratextBox.TabIndex = 8;
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(165, 320);
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.PasswordChar = '*';
            this.ContrasenatextBox.Size = new System.Drawing.Size(275, 30);
            this.ContrasenatextBox.TabIndex = 7;
            // 
            // NombreUsuariotextBox
            // 
            this.NombreUsuariotextBox.Location = new System.Drawing.Point(165, 196);
            this.NombreUsuariotextBox.Name = "NombreUsuariotextBox";
            this.NombreUsuariotextBox.Size = new System.Drawing.Size(275, 30);
            this.NombreUsuariotextBox.TabIndex = 6;
            this.NombreUsuariotextBox.TextChanged += new System.EventHandler(this.NombreUsuariotextBox_TextChanged);
            this.NombreUsuariotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreUsuariotextBox_KeyPress);
            // 
            // UsuarioIdtextBox
            // 
            this.UsuarioIdtextBox.Location = new System.Drawing.Point(165, 83);
            this.UsuarioIdtextBox.Name = "UsuarioIdtextBox";
            this.UsuarioIdtextBox.Size = new System.Drawing.Size(275, 30);
            this.UsuarioIdtextBox.TabIndex = 5;
            this.UsuarioIdtextBox.TextChanged += new System.EventHandler(this.UsuarioIdtextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(211, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Repetir Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(243, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(258, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(258, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "UsuarioId";
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
            // RegistrosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 667);
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
        private System.Windows.Forms.TextBox RepContratextBox;
        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.TextBox NombreUsuariotextBox;
        private System.Windows.Forms.TextBox UsuarioIdtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}