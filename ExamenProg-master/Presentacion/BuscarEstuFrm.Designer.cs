namespace Presentacion
{
    partial class BuscarEstuFrm
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
            this.lblNombredelEstudiante = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBoxNEstu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscarporPromedio = new System.Windows.Forms.Button();
            this.btnRegresaralMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombredelEstudiante
            // 
            this.lblNombredelEstudiante.AutoSize = true;
            this.lblNombredelEstudiante.Location = new System.Drawing.Point(12, 80);
            this.lblNombredelEstudiante.Name = "lblNombredelEstudiante";
            this.lblNombredelEstudiante.Size = new System.Drawing.Size(117, 13);
            this.lblNombredelEstudiante.TabIndex = 0;
            this.lblNombredelEstudiante.Text = "Nombre del Estudiante:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(437, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBoxNEstu
            // 
            this.txtBoxNEstu.Location = new System.Drawing.Point(135, 80);
            this.txtBoxNEstu.Name = "txtBoxNEstu";
            this.txtBoxNEstu.Size = new System.Drawing.Size(240, 20);
            this.txtBoxNEstu.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 165);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnBuscarporPromedio
            // 
            this.btnBuscarporPromedio.Location = new System.Drawing.Point(12, 341);
            this.btnBuscarporPromedio.Name = "btnBuscarporPromedio";
            this.btnBuscarporPromedio.Size = new System.Drawing.Size(75, 37);
            this.btnBuscarporPromedio.TabIndex = 5;
            this.btnBuscarporPromedio.Text = "Buscar por Promedio";
            this.btnBuscarporPromedio.UseVisualStyleBackColor = true;
            // 
            // btnRegresaralMenu
            // 
            this.btnRegresaralMenu.Location = new System.Drawing.Point(125, 341);
            this.btnRegresaralMenu.Name = "btnRegresaralMenu";
            this.btnRegresaralMenu.Size = new System.Drawing.Size(75, 37);
            this.btnRegresaralMenu.TabIndex = 6;
            this.btnRegresaralMenu.Text = "Regresar al Menu";
            this.btnRegresaralMenu.UseVisualStyleBackColor = true;
            this.btnRegresaralMenu.Click += new System.EventHandler(this.BtnRegresaralMenu_Click);
            // 
            // BuscarEstuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 459);
            this.Controls.Add(this.btnRegresaralMenu);
            this.Controls.Add(this.btnBuscarporPromedio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxNEstu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombredelEstudiante);
            this.Name = "BuscarEstuFrm";
            this.Text = "BuscarEstuFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombredelEstudiante;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBoxNEstu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscarporPromedio;
        private System.Windows.Forms.Button btnRegresaralMenu;
    }
}