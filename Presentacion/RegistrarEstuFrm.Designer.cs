namespace Presentacion
{
    partial class RegistrarEstuFrm
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
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtBoxNombrs = new System.Windows.Forms.TextBox();
            this.txtBoxApellids = new System.Windows.Forms.TextBox();
            this.txtBoxCarnet = new System.Windows.Forms.TextBox();
            this.cmbBoxMunicipio = new System.Windows.Forms.ComboBox();
            this.cmbBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnRegresaralMenu = new System.Windows.Forms.Button();
            this.groupBoxRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(86, 24);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(86, 61);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(86, 99);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(41, 13);
            this.lblCarnet.TabIndex = 3;
            this.lblCarnet.Text = "Carnet:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(86, 172);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio.TabIndex = 4;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(86, 210);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 5;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtBoxNombrs
            // 
            this.txtBoxNombrs.Location = new System.Drawing.Point(171, 24);
            this.txtBoxNombrs.Name = "txtBoxNombrs";
            this.txtBoxNombrs.Size = new System.Drawing.Size(151, 20);
            this.txtBoxNombrs.TabIndex = 6;
            // 
            // txtBoxApellids
            // 
            this.txtBoxApellids.Location = new System.Drawing.Point(171, 61);
            this.txtBoxApellids.Name = "txtBoxApellids";
            this.txtBoxApellids.Size = new System.Drawing.Size(151, 20);
            this.txtBoxApellids.TabIndex = 7;
            // 
            // txtBoxCarnet
            // 
            this.txtBoxCarnet.Location = new System.Drawing.Point(171, 99);
            this.txtBoxCarnet.Name = "txtBoxCarnet";
            this.txtBoxCarnet.Size = new System.Drawing.Size(151, 20);
            this.txtBoxCarnet.TabIndex = 8;
            // 
            // cmbBoxMunicipio
            // 
            this.cmbBoxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMunicipio.FormattingEnabled = true;
            this.cmbBoxMunicipio.Items.AddRange(new object[] {
            "Managua",
            "Masaya",
            "Diriamba",
            "Jinotepe",
            "Bluefields",
            "Ciudad Sandino"});
            this.cmbBoxMunicipio.Location = new System.Drawing.Point(171, 172);
            this.cmbBoxMunicipio.Name = "cmbBoxMunicipio";
            this.cmbBoxMunicipio.Size = new System.Drawing.Size(151, 21);
            this.cmbBoxMunicipio.TabIndex = 9;
            // 
            // cmbBoxDepartamento
            // 
            this.cmbBoxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDepartamento.FormattingEnabled = true;
            this.cmbBoxDepartamento.Items.AddRange(new object[] {
            "Managua",
            "Costa Caribe Sur",
            "Masaya",
            "Carazo"});
            this.cmbBoxDepartamento.Location = new System.Drawing.Point(171, 210);
            this.cmbBoxDepartamento.Name = "cmbBoxDepartamento";
            this.cmbBoxDepartamento.Size = new System.Drawing.Size(151, 21);
            this.cmbBoxDepartamento.TabIndex = 10;
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.Controls.Add(this.lblNombres);
            this.groupBoxRegistro.Controls.Add(this.cmbBoxDepartamento);
            this.groupBoxRegistro.Controls.Add(this.txtBoxNombrs);
            this.groupBoxRegistro.Controls.Add(this.lblDepartamento);
            this.groupBoxRegistro.Controls.Add(this.cmbBoxMunicipio);
            this.groupBoxRegistro.Controls.Add(this.lblApellidos);
            this.groupBoxRegistro.Controls.Add(this.txtBoxCarnet);
            this.groupBoxRegistro.Controls.Add(this.lblMunicipio);
            this.groupBoxRegistro.Controls.Add(this.txtBoxApellids);
            this.groupBoxRegistro.Controls.Add(this.lblCarnet);
            this.groupBoxRegistro.Location = new System.Drawing.Point(22, 22);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Size = new System.Drawing.Size(482, 278);
            this.groupBoxRegistro.TabIndex = 11;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Registro";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(74, 354);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 37);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnRegresaralMenu
            // 
            this.btnRegresaralMenu.Location = new System.Drawing.Point(385, 354);
            this.btnRegresaralMenu.Name = "btnRegresaralMenu";
            this.btnRegresaralMenu.Size = new System.Drawing.Size(75, 37);
            this.btnRegresaralMenu.TabIndex = 13;
            this.btnRegresaralMenu.Text = "Regresar al Menu";
            this.btnRegresaralMenu.UseVisualStyleBackColor = true;
            this.btnRegresaralMenu.Click += new System.EventHandler(this.BtnRegresaralMenu_Click);
            // 
            // RegistrarEstuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresaralMenu);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBoxRegistro);
            this.Name = "RegistrarEstuFrm";
            this.Text = "RegistrarEstuFrm";
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtBoxNombrs;
        private System.Windows.Forms.TextBox txtBoxApellids;
        private System.Windows.Forms.TextBox txtBoxCarnet;
        private System.Windows.Forms.ComboBox cmbBoxMunicipio;
        private System.Windows.Forms.ComboBox cmbBoxDepartamento;
        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRegresaralMenu;
    }
}