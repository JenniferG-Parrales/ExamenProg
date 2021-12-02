namespace Presentacion
{
    partial class MenuFrm
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
            this.btnRegistrarEstudiante = new System.Windows.Forms.Button();
            this.btnIngresarNotas = new System.Windows.Forms.Button();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarEstudiante
            // 
            this.btnRegistrarEstudiante.Location = new System.Drawing.Point(21, 30);
            this.btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            this.btnRegistrarEstudiante.Size = new System.Drawing.Size(80, 37);
            this.btnRegistrarEstudiante.TabIndex = 0;
            this.btnRegistrarEstudiante.Text = "Registrar Estudiante";
            this.btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            this.btnRegistrarEstudiante.Click += new System.EventHandler(this.BtnRegistrarEstudiante_Click);
            // 
            // btnIngresarNotas
            // 
            this.btnIngresarNotas.Location = new System.Drawing.Point(21, 102);
            this.btnIngresarNotas.Name = "btnIngresarNotas";
            this.btnIngresarNotas.Size = new System.Drawing.Size(80, 37);
            this.btnIngresarNotas.TabIndex = 1;
            this.btnIngresarNotas.Text = "Ingresar Notas";
            this.btnIngresarNotas.UseVisualStyleBackColor = true;
            this.btnIngresarNotas.Click += new System.EventHandler(this.BtnIngresarNotas_Click);
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(21, 170);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(80, 37);
            this.btnBuscarEstudiante.TabIndex = 2;
            this.btnBuscarEstudiante.Text = "Buscar Estudiante";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.BtnBuscarEstudiante_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarEstudiante);
            this.groupBox1.Controls.Add(this.btnBuscarEstudiante);
            this.groupBox1.Controls.Add(this.btnIngresarNotas);
            this.groupBox1.Location = new System.Drawing.Point(33, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 383);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuFrm";
            this.Text = "InterfaceFrm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarEstudiante;
        private System.Windows.Forms.Button btnIngresarNotas;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}