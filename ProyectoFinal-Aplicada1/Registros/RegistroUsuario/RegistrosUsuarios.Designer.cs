﻿namespace ProyectoFinal_Aplicada1.Registros.RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.CancelarUsbutton);
            this.groupBox1.Controls.Add(this.CrearUsbutton);
            this.groupBox1.Controls.Add(this.RepContratextBox);
            this.groupBox1.Controls.Add(this.ContrasenatextBox);
            this.groupBox1.Controls.Add(this.NombreUsuariotextBox);
            this.groupBox1.Controls.Add(this.UsuarioIdtextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 620);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserRegister";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(156, 573);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 41);
            this.progressBar1.TabIndex = 11;
            // 
            // CancelarUsbutton
            // 
            this.CancelarUsbutton.BackColor = System.Drawing.Color.Transparent;
            this.CancelarUsbutton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarUsbutton.Image")));
            this.CancelarUsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarUsbutton.Location = new System.Drawing.Point(373, 490);
            this.CancelarUsbutton.Name = "CancelarUsbutton";
            this.CancelarUsbutton.Size = new System.Drawing.Size(186, 55);
            this.CancelarUsbutton.TabIndex = 10;
            this.CancelarUsbutton.Text = "Cancelar";
            this.CancelarUsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarUsbutton.UseVisualStyleBackColor = false;
            // 
            // CrearUsbutton
            // 
            this.CrearUsbutton.BackColor = System.Drawing.Color.Transparent;
            this.CrearUsbutton.Image = ((System.Drawing.Image)(resources.GetObject("CrearUsbutton.Image")));
            this.CrearUsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrearUsbutton.Location = new System.Drawing.Point(16, 490);
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
            // 
            // UsuarioIdtextBox
            // 
            this.UsuarioIdtextBox.Location = new System.Drawing.Point(165, 83);
            this.UsuarioIdtextBox.Name = "UsuarioIdtextBox";
            this.UsuarioIdtextBox.Size = new System.Drawing.Size(275, 30);
            this.UsuarioIdtextBox.TabIndex = 5;
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
            // RegistrosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 667);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrosUsuarios";
            this.Text = "RegistrosUsuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
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
    }
}