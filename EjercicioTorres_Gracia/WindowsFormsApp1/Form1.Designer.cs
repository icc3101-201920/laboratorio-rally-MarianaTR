namespace VistasRally
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarPilotoButton = new System.Windows.Forms.Button();
            this.PilotNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.CrearEquipo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PilotocomboBox = new System.Windows.Forms.ComboBox();
            this.NavegantecomboBox = new System.Windows.Forms.ComboBox();
            this.PilotoLabel = new System.Windows.Forms.Label();
            this.NavenganteLabel = new System.Windows.Forms.Label();
            this.VehiculoLabel = new System.Windows.Forms.Label();
            this.marcaVehiculo = new System.Windows.Forms.TextBox();
            this.cilindraVehiculo = new System.Windows.Forms.NumericUpDown();
            this.marcaLabel = new System.Windows.Forms.Label();
            this.cilindradaLabel = new System.Windows.Forms.Label();
            this.nameEquipo = new System.Windows.Forms.TextBox();
            this.AgregarEquipoButton = new System.Windows.Forms.Button();
            this.EquipoComboBox = new System.Windows.Forms.ComboBox();
            this.EquiposLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cilindraVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a Rally Manager";
            // 
            // AgregarPilotoButton
            // 
            this.AgregarPilotoButton.Location = new System.Drawing.Point(450, 290);
            this.AgregarPilotoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgregarPilotoButton.Name = "AgregarPilotoButton";
            this.AgregarPilotoButton.Size = new System.Drawing.Size(165, 28);
            this.AgregarPilotoButton.TabIndex = 1;
            this.AgregarPilotoButton.Text = "Agregar Miembro";
            this.AgregarPilotoButton.UseVisualStyleBackColor = true;
            this.AgregarPilotoButton.Click += new System.EventHandler(this.AgregarPilotoButton_Click);
            // 
            // PilotNameComboBox
            // 
            this.PilotNameComboBox.FormattingEnabled = true;
            this.PilotNameComboBox.Location = new System.Drawing.Point(367, 165);
            this.PilotNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PilotNameComboBox.Name = "PilotNameComboBox";
            this.PilotNameComboBox.Size = new System.Drawing.Size(312, 24);
            this.PilotNameComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(417, 208);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(222, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // RolComboBox
            // 
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Location = new System.Drawing.Point(450, 238);
            this.RolComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(160, 24);
            this.RolComboBox.TabIndex = 7;
            // 
            // CrearEquipo
            // 
            this.CrearEquipo.Location = new System.Drawing.Point(475, 335);
            this.CrearEquipo.Name = "CrearEquipo";
            this.CrearEquipo.Size = new System.Drawing.Size(117, 25);
            this.CrearEquipo.TabIndex = 8;
            this.CrearEquipo.Text = "Crear Equipo";
            this.CrearEquipo.UseVisualStyleBackColor = true;
            this.CrearEquipo.Click += new System.EventHandler(this.CrearEquipo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AgregarEquipoButton);
            this.panel1.Controls.Add(this.nameEquipo);
            this.panel1.Controls.Add(this.cilindradaLabel);
            this.panel1.Controls.Add(this.marcaLabel);
            this.panel1.Controls.Add(this.cilindraVehiculo);
            this.panel1.Controls.Add(this.marcaVehiculo);
            this.panel1.Controls.Add(this.VehiculoLabel);
            this.panel1.Controls.Add(this.NavenganteLabel);
            this.panel1.Controls.Add(this.PilotoLabel);
            this.panel1.Controls.Add(this.NavegantecomboBox);
            this.panel1.Controls.Add(this.PilotocomboBox);
            this.panel1.Location = new System.Drawing.Point(721, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 196);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // PilotocomboBox
            // 
            this.PilotocomboBox.FormattingEnabled = true;
            this.PilotocomboBox.Location = new System.Drawing.Point(16, 59);
            this.PilotocomboBox.Name = "PilotocomboBox";
            this.PilotocomboBox.Size = new System.Drawing.Size(121, 24);
            this.PilotocomboBox.TabIndex = 0;
            // 
            // NavegantecomboBox
            // 
            this.NavegantecomboBox.FormattingEnabled = true;
            this.NavegantecomboBox.Location = new System.Drawing.Point(166, 59);
            this.NavegantecomboBox.Name = "NavegantecomboBox";
            this.NavegantecomboBox.Size = new System.Drawing.Size(121, 24);
            this.NavegantecomboBox.TabIndex = 1;
            // 
            // PilotoLabel
            // 
            this.PilotoLabel.AutoSize = true;
            this.PilotoLabel.Location = new System.Drawing.Point(53, 39);
            this.PilotoLabel.Name = "PilotoLabel";
            this.PilotoLabel.Size = new System.Drawing.Size(43, 17);
            this.PilotoLabel.TabIndex = 2;
            this.PilotoLabel.Text = "Piloto";
            // 
            // NavenganteLabel
            // 
            this.NavenganteLabel.AutoSize = true;
            this.NavenganteLabel.Location = new System.Drawing.Point(186, 39);
            this.NavenganteLabel.Name = "NavenganteLabel";
            this.NavenganteLabel.Size = new System.Drawing.Size(77, 17);
            this.NavenganteLabel.TabIndex = 3;
            this.NavenganteLabel.Text = "Navegante";
            // 
            // VehiculoLabel
            // 
            this.VehiculoLabel.AutoSize = true;
            this.VehiculoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VehiculoLabel.Location = new System.Drawing.Point(103, 86);
            this.VehiculoLabel.Name = "VehiculoLabel";
            this.VehiculoLabel.Size = new System.Drawing.Size(106, 29);
            this.VehiculoLabel.TabIndex = 4;
            this.VehiculoLabel.Text = "Vehiculo";
            // 
            // marcaVehiculo
            // 
            this.marcaVehiculo.Location = new System.Drawing.Point(27, 135);
            this.marcaVehiculo.Name = "marcaVehiculo";
            this.marcaVehiculo.Size = new System.Drawing.Size(100, 22);
            this.marcaVehiculo.TabIndex = 5;
            // 
            // cilindraVehiculo
            // 
            this.cilindraVehiculo.Location = new System.Drawing.Point(208, 136);
            this.cilindraVehiculo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cilindraVehiculo.Name = "cilindraVehiculo";
            this.cilindraVehiculo.Size = new System.Drawing.Size(68, 22);
            this.cilindraVehiculo.TabIndex = 6;
            this.cilindraVehiculo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // marcaLabel
            // 
            this.marcaLabel.AutoSize = true;
            this.marcaLabel.Location = new System.Drawing.Point(49, 115);
            this.marcaLabel.Name = "marcaLabel";
            this.marcaLabel.Size = new System.Drawing.Size(47, 17);
            this.marcaLabel.TabIndex = 7;
            this.marcaLabel.Text = "Marca";
            // 
            // cilindradaLabel
            // 
            this.cilindradaLabel.AutoSize = true;
            this.cilindradaLabel.Location = new System.Drawing.Point(205, 122);
            this.cilindradaLabel.Name = "cilindradaLabel";
            this.cilindradaLabel.Size = new System.Drawing.Size(71, 17);
            this.cilindradaLabel.TabIndex = 8;
            this.cilindradaLabel.Text = "Cilindrada";
            // 
            // nameEquipo
            // 
            this.nameEquipo.Location = new System.Drawing.Point(91, 3);
            this.nameEquipo.Name = "nameEquipo";
            this.nameEquipo.Size = new System.Drawing.Size(130, 22);
            this.nameEquipo.TabIndex = 9;
            this.nameEquipo.Text = "Nombre Equipo";
            // 
            // AgregarEquipoButton
            // 
            this.AgregarEquipoButton.Location = new System.Drawing.Point(122, 170);
            this.AgregarEquipoButton.Name = "AgregarEquipoButton";
            this.AgregarEquipoButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarEquipoButton.TabIndex = 10;
            this.AgregarEquipoButton.Text = "Agregar Equipo";
            this.AgregarEquipoButton.UseVisualStyleBackColor = true;
            this.AgregarEquipoButton.Click += new System.EventHandler(this.AgregarEquipoButton_Click);
            // 
            // EquipoComboBox
            // 
            this.EquipoComboBox.FormattingEnabled = true;
            this.EquipoComboBox.Location = new System.Drawing.Point(250, 336);
            this.EquipoComboBox.Name = "EquipoComboBox";
            this.EquipoComboBox.Size = new System.Drawing.Size(121, 24);
            this.EquipoComboBox.TabIndex = 10;
            // 
            // EquiposLabel
            // 
            this.EquiposLabel.AutoSize = true;
            this.EquiposLabel.Location = new System.Drawing.Point(282, 316);
            this.EquiposLabel.Name = "EquiposLabel";
            this.EquiposLabel.Size = new System.Drawing.Size(59, 17);
            this.EquiposLabel.TabIndex = 11;
            this.EquiposLabel.Text = "Equipos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.EquiposLabel);
            this.Controls.Add(this.EquipoComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CrearEquipo);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PilotNameComboBox);
            this.Controls.Add(this.AgregarPilotoButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cilindraVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarPilotoButton;
        private System.Windows.Forms.ComboBox PilotNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.Button CrearEquipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox NavegantecomboBox;
        private System.Windows.Forms.ComboBox PilotocomboBox;
        private System.Windows.Forms.Label NavenganteLabel;
        private System.Windows.Forms.Label PilotoLabel;
        private System.Windows.Forms.Label VehiculoLabel;
        private System.Windows.Forms.Label cilindradaLabel;
        private System.Windows.Forms.Label marcaLabel;
        private System.Windows.Forms.NumericUpDown cilindraVehiculo;
        private System.Windows.Forms.TextBox marcaVehiculo;
        private System.Windows.Forms.Button AgregarEquipoButton;
        private System.Windows.Forms.TextBox nameEquipo;
        private System.Windows.Forms.ComboBox EquipoComboBox;
        private System.Windows.Forms.Label EquiposLabel;
    }
}

