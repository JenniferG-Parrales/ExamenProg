namespace Presentacion
{
    partial class IngresarNotsFrm
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
            this.lblSistematicos = new System.Windows.Forms.Label();
            this.lblIParcial = new System.Windows.Forms.Label();
            this.lblIIParcial = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.nudSistematicos = new System.Windows.Forms.NumericUpDown();
            this.nudIParcial = new System.Windows.Forms.NumericUpDown();
            this.nudIIParcial = new System.Windows.Forms.NumericUpDown();
            this.nudTarea = new System.Windows.Forms.NumericUpDown();
            this.groupBoxIngresar = new System.Windows.Forms.GroupBox();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.btnRegresaralMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSistematicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIIParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTarea)).BeginInit();
            this.groupBoxIngresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSistematicos
            // 
            this.lblSistematicos.AutoSize = true;
            this.lblSistematicos.Location = new System.Drawing.Point(16, 45);
            this.lblSistematicos.Name = "lblSistematicos";
            this.lblSistematicos.Size = new System.Drawing.Size(66, 13);
            this.lblSistematicos.TabIndex = 0;
            this.lblSistematicos.Text = "Sistematicos";
            // 
            // lblIParcial
            // 
            this.lblIParcial.AutoSize = true;
            this.lblIParcial.Location = new System.Drawing.Point(16, 81);
            this.lblIParcial.Name = "lblIParcial";
            this.lblIParcial.Size = new System.Drawing.Size(45, 13);
            this.lblIParcial.TabIndex = 1;
            this.lblIParcial.Text = "I Parcial";
            // 
            // lblIIParcial
            // 
            this.lblIIParcial.AutoSize = true;
            this.lblIIParcial.Location = new System.Drawing.Point(16, 122);
            this.lblIIParcial.Name = "lblIIParcial";
            this.lblIIParcial.Size = new System.Drawing.Size(48, 13);
            this.lblIIParcial.TabIndex = 2;
            this.lblIIParcial.Text = "II Parcial";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(16, 160);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(35, 13);
            this.lblTarea.TabIndex = 3;
            this.lblTarea.Text = "Tarea";
            // 
            // nudSistematicos
            // 
            this.nudSistematicos.Location = new System.Drawing.Point(106, 45);
            this.nudSistematicos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSistematicos.Name = "nudSistematicos";
            this.nudSistematicos.Size = new System.Drawing.Size(74, 20);
            this.nudSistematicos.TabIndex = 5;
            // 
            // nudIParcial
            // 
            this.nudIParcial.Location = new System.Drawing.Point(106, 81);
            this.nudIParcial.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudIParcial.Name = "nudIParcial";
            this.nudIParcial.Size = new System.Drawing.Size(74, 20);
            this.nudIParcial.TabIndex = 6;
            // 
            // nudIIParcial
            // 
            this.nudIIParcial.Location = new System.Drawing.Point(106, 122);
            this.nudIIParcial.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudIIParcial.Name = "nudIIParcial";
            this.nudIIParcial.Size = new System.Drawing.Size(74, 20);
            this.nudIIParcial.TabIndex = 7;
            // 
            // nudTarea
            // 
            this.nudTarea.Location = new System.Drawing.Point(106, 160);
            this.nudTarea.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTarea.Name = "nudTarea";
            this.nudTarea.Size = new System.Drawing.Size(74, 20);
            this.nudTarea.TabIndex = 8;
            // 
            // groupBoxIngresar
            // 
            this.groupBoxIngresar.Controls.Add(this.lblSistematicos);
            this.groupBoxIngresar.Controls.Add(this.nudTarea);
            this.groupBoxIngresar.Controls.Add(this.lblIParcial);
            this.groupBoxIngresar.Controls.Add(this.lblTarea);
            this.groupBoxIngresar.Controls.Add(this.nudIIParcial);
            this.groupBoxIngresar.Controls.Add(this.nudSistematicos);
            this.groupBoxIngresar.Controls.Add(this.nudIParcial);
            this.groupBoxIngresar.Controls.Add(this.lblIIParcial);
            this.groupBoxIngresar.Location = new System.Drawing.Point(27, 22);
            this.groupBoxIngresar.Name = "groupBoxIngresar";
            this.groupBoxIngresar.Size = new System.Drawing.Size(358, 212);
            this.groupBoxIngresar.TabIndex = 9;
            this.groupBoxIngresar.TabStop = false;
            this.groupBoxIngresar.Text = "Ingresar";
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.Location = new System.Drawing.Point(46, 305);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(79, 36);
            this.btnAgregarNota.TabIndex = 10;
            this.btnAgregarNota.Text = "Agregar Nota";
            this.btnAgregarNota.UseVisualStyleBackColor = true;
            // 
            // btnRegresaralMenu
            // 
            this.btnRegresaralMenu.Location = new System.Drawing.Point(201, 305);
            this.btnRegresaralMenu.Name = "btnRegresaralMenu";
            this.btnRegresaralMenu.Size = new System.Drawing.Size(79, 36);
            this.btnRegresaralMenu.TabIndex = 11;
            this.btnRegresaralMenu.Text = "Regresar al Menu";
            this.btnRegresaralMenu.UseVisualStyleBackColor = true;
            this.btnRegresaralMenu.Click += new System.EventHandler(this.BtnRegresaralMenu_Click);
            // 
            // IngresarNotsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresaralMenu);
            this.Controls.Add(this.btnAgregarNota);
            this.Controls.Add(this.groupBoxIngresar);
            this.Name = "IngresarNotsFrm";
            this.Text = "IngresarNotsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.nudSistematicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIIParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTarea)).EndInit();
            this.groupBoxIngresar.ResumeLayout(false);
            this.groupBoxIngresar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSistematicos;
        private System.Windows.Forms.Label lblIParcial;
        private System.Windows.Forms.Label lblIIParcial;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.NumericUpDown nudSistematicos;
        private System.Windows.Forms.NumericUpDown nudIParcial;
        private System.Windows.Forms.NumericUpDown nudIIParcial;
        private System.Windows.Forms.NumericUpDown nudTarea;
        private System.Windows.Forms.GroupBox groupBoxIngresar;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.Button btnRegresaralMenu;
    }
}