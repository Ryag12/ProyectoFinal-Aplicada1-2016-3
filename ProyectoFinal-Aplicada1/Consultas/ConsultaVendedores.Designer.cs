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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVendedores));
            this.TblConsudataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarConsultabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltrarVendedorcomboBox = new System.Windows.Forms.ComboBox();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TblConsudataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TblConsudataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblConsudataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TblConsudataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TblConsudataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TblConsudataGridView.Location = new System.Drawing.Point(16, 211);
            this.TblConsudataGridView.Name = "TblConsudataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblConsudataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TblConsudataGridView.RowTemplate.Height = 24;
            this.TblConsudataGridView.Size = new System.Drawing.Size(1100, 316);
            this.TblConsudataGridView.TabIndex = 0;
            this.TblConsudataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblConsudataGridView_CellContentClick);
            // 
            // BuscarConsultabutton
            // 
            this.BuscarConsultabutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarConsultabutton.ForeColor = System.Drawing.Color.SandyBrown;
            this.BuscarConsultabutton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarConsultabutton.Image")));
            this.BuscarConsultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarConsultabutton.Location = new System.Drawing.Point(902, 56);
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
            // FiltrarVendedorcomboBox
            // 
            this.FiltrarVendedorcomboBox.FormattingEnabled = true;
            this.FiltrarVendedorcomboBox.Location = new System.Drawing.Point(47, 75);
            this.FiltrarVendedorcomboBox.Name = "FiltrarVendedorcomboBox";
            this.FiltrarVendedorcomboBox.Size = new System.Drawing.Size(807, 24);
            this.FiltrarVendedorcomboBox.TabIndex = 7;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.Location = new System.Drawing.Point(620, 171);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(425, 34);
            this.HastadateTimePicker.TabIndex = 8;
            // 
            // ConsultaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1128, 541);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.FiltrarVendedorcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarConsultabutton);
            this.Controls.Add(this.TblConsudataGridView);
            this.Name = "ConsultaVendedores";
            this.Text = "ConsultaVendedores";
            this.Load += new System.EventHandler(this.ConsultaVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblConsudataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TblConsudataGridView;
        private System.Windows.Forms.Button BuscarConsultabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltrarVendedorcomboBox;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
    }
}