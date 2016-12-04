namespace ProyectoFinal_Aplicada1.Consultar
{
    partial class ConsultaVendedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVendedores));
            this.TblConsudataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarConsultabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EliminarVenConsbutton = new System.Windows.Forms.Button();
            this.Editarbutton = new System.Windows.Forms.Button();
            this.FiltrarVendedortextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TblConsudataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblConsudataGridView
            // 
            this.TblConsudataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblConsudataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TblConsudataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TblConsudataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.TblConsudataGridView.Location = new System.Drawing.Point(16, 211);
            this.TblConsudataGridView.Name = "TblConsudataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblConsudataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TblConsudataGridView.RowTemplate.Height = 24;
            this.TblConsudataGridView.Size = new System.Drawing.Size(1084, 316);
            this.TblConsudataGridView.TabIndex = 0;
            this.TblConsudataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblConsudataGridView_CellContentClick);
            // 
            // BuscarConsultabutton
            // 
            this.BuscarConsultabutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarConsultabutton.ForeColor = System.Drawing.Color.SandyBrown;
            this.BuscarConsultabutton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarConsultabutton.Image")));
            this.BuscarConsultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarConsultabutton.Location = new System.Drawing.Point(860, 47);
            this.BuscarConsultabutton.Name = "BuscarConsultabutton";
            this.BuscarConsultabutton.Size = new System.Drawing.Size(170, 60);
            this.BuscarConsultabutton.TabIndex = 1;
            this.BuscarConsultabutton.Text = "Buscar";
            this.BuscarConsultabutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarConsultabutton.UseVisualStyleBackColor = true;
            this.BuscarConsultabutton.Click += new System.EventHandler(this.BuscarConsultabutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde ";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdedateTimePicker.Location = new System.Drawing.Point(47, 171);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(425, 34);
            this.DesdedateTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(629, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta ";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.Location = new System.Drawing.Point(620, 171);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(425, 34);
            this.HastadateTimePicker.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.EliminarVenConsbutton);
            this.panel2.Controls.Add(this.Editarbutton);
            this.panel2.Location = new System.Drawing.Point(182, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 108);
            this.panel2.TabIndex = 13;
            // 
            // EliminarVenConsbutton
            // 
            this.EliminarVenConsbutton.BackColor = System.Drawing.Color.Transparent;
            this.EliminarVenConsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarVenConsbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarVenConsbutton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarVenConsbutton.Image")));
            this.EliminarVenConsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarVenConsbutton.Location = new System.Drawing.Point(484, 16);
            this.EliminarVenConsbutton.Name = "EliminarVenConsbutton";
            this.EliminarVenConsbutton.Size = new System.Drawing.Size(186, 72);
            this.EliminarVenConsbutton.TabIndex = 16;
            this.EliminarVenConsbutton.Text = "Eliminar";
            this.EliminarVenConsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarVenConsbutton.UseVisualStyleBackColor = false;
            this.EliminarVenConsbutton.Click += new System.EventHandler(this.EliminarVenConsbutton_Click);
            // 
            // Editarbutton
            // 
            this.Editarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Editarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editarbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Editarbutton.Image")));
            this.Editarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editarbutton.Location = new System.Drawing.Point(36, 16);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(172, 72);
            this.Editarbutton.TabIndex = 15;
            this.Editarbutton.Text = "Nuevo";
            this.Editarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Editarbutton.UseVisualStyleBackColor = false;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // FiltrarVendedortextBox
            // 
            this.FiltrarVendedortextBox.Location = new System.Drawing.Point(47, 56);
            this.FiltrarVendedortextBox.Multiline = true;
            this.FiltrarVendedortextBox.Name = "FiltrarVendedortextBox";
            this.FiltrarVendedortextBox.Size = new System.Drawing.Size(807, 39);
            this.FiltrarVendedortextBox.TabIndex = 14;
            // 
            // ConsultaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1107, 703);
            this.Controls.Add(this.FiltrarVendedortextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarConsultabutton);
            this.Controls.Add(this.TblConsudataGridView);
            this.Name = "ConsultaVendedores";
            this.Text = "ConsultaVendedores";
            this.Load += new System.EventHandler(this.ConsultaVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblConsudataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TblConsudataGridView;
        private System.Windows.Forms.Button BuscarConsultabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EliminarVenConsbutton;
        private System.Windows.Forms.Button Editarbutton;
        private System.Windows.Forms.TextBox FiltrarVendedortextBox;
    }
}