namespace ProyectoFinal_Aplicada1.Consultas
{
    partial class ConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TblUsuariodataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BuscarUsuabutton = new System.Windows.Forms.Button();
            this.FiltrarUsuariotextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblUsuariodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FiltrarUsuariotextBox);
            this.groupBox1.Controls.Add(this.BuscarUsuabutton);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TblUsuariodataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas";
            // 
            // TblUsuariodataGridView
            // 
            this.TblUsuariodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblUsuariodataGridView.Location = new System.Drawing.Point(0, 210);
            this.TblUsuariodataGridView.Name = "TblUsuariodataGridView";
            this.TblUsuariodataGridView.RowTemplate.Height = 24;
            this.TblUsuariodataGridView.Size = new System.Drawing.Size(1038, 287);
            this.TblUsuariodataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(384, 30);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(586, 121);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(447, 30);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // BuscarUsuabutton
            // 
            this.BuscarUsuabutton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarUsuabutton.Image")));
            this.BuscarUsuabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarUsuabutton.Location = new System.Drawing.Point(838, 29);
            this.BuscarUsuabutton.Name = "BuscarUsuabutton";
            this.BuscarUsuabutton.Size = new System.Drawing.Size(195, 61);
            this.BuscarUsuabutton.TabIndex = 5;
            this.BuscarUsuabutton.Text = "Buscar";
            this.BuscarUsuabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarUsuabutton.UseVisualStyleBackColor = true;
            this.BuscarUsuabutton.Click += new System.EventHandler(this.BuscarUsuabutton_Click);
            // 
            // FiltrarUsuariotextBox
            // 
            this.FiltrarUsuariotextBox.Location = new System.Drawing.Point(33, 29);
            this.FiltrarUsuariotextBox.Multiline = true;
            this.FiltrarUsuariotextBox.Name = "FiltrarUsuariotextBox";
            this.FiltrarUsuariotextBox.Size = new System.Drawing.Size(748, 61);
            this.FiltrarUsuariotextBox.TabIndex = 6;
            // 
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 559);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaUsuarios";
            this.Text = "ConsultaUsuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblUsuariodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FiltrarUsuariotextBox;
        private System.Windows.Forms.Button BuscarUsuabutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TblUsuariodataGridView;
    }
}