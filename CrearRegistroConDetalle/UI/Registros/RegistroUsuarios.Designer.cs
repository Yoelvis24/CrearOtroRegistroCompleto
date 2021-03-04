
namespace CrearRegistroConDetalle.UI.Registros
{
    partial class RegistroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            this.UsuarioIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.IngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.confirmarTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fechaIngresoLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.RolLabel = new System.Windows.Forms.Label();
            this.ConfirmarLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.Aliaslabel = new System.Windows.Forms.Label();
            this.usuariosIdLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.UsuarioErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioIdNumericUpDown
            // 
            this.UsuarioIdNumericUpDown.Location = new System.Drawing.Point(110, 13);
            this.UsuarioIdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsuarioIdNumericUpDown.Name = "UsuarioIdNumericUpDown";
            this.UsuarioIdNumericUpDown.Size = new System.Drawing.Size(144, 23);
            this.UsuarioIdNumericUpDown.TabIndex = 38;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.AutoSize = true;
            this.activoCheckBox.Location = new System.Drawing.Point(630, 13);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.activoCheckBox.TabIndex = 37;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RolComboBox
            // 
            this.RolComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "administrador"});
            this.RolComboBox.Location = new System.Drawing.Point(570, 47);
            this.RolComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(125, 23);
            this.RolComboBox.TabIndex = 36;
            // 
            // IngresoDateTimePicker
            // 
            this.IngresoDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.IngresoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.IngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IngresoDateTimePicker.Location = new System.Drawing.Point(110, 115);
            this.IngresoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IngresoDateTimePicker.Name = "IngresoDateTimePicker";
            this.IngresoDateTimePicker.Size = new System.Drawing.Size(131, 23);
            this.IngresoDateTimePicker.TabIndex = 35;
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(289, 116);
            this.claveTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(151, 23);
            this.claveTextBox.TabIndex = 34;
            // 
            // confirmarTextBox
            // 
            this.confirmarTextBox.Location = new System.Drawing.Point(544, 118);
            this.confirmarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmarTextBox.Name = "confirmarTextBox";
            this.confirmarTextBox.PasswordChar = '*';
            this.confirmarTextBox.Size = new System.Drawing.Size(151, 23);
            this.confirmarTextBox.TabIndex = 33;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(110, 81);
            this.nombresTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(268, 23);
            this.nombresTextBox.TabIndex = 32;
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.Location = new System.Drawing.Point(110, 47);
            this.aliasTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(197, 23);
            this.aliasTextBox.TabIndex = 31;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(423, 81);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(272, 23);
            this.emailTextBox.TabIndex = 30;
            // 
            // fechaIngresoLabel
            // 
            this.fechaIngresoLabel.AutoSize = true;
            this.fechaIngresoLabel.Location = new System.Drawing.Point(8, 121);
            this.fechaIngresoLabel.Name = "fechaIngresoLabel";
            this.fechaIngresoLabel.Size = new System.Drawing.Size(96, 15);
            this.fechaIngresoLabel.TabIndex = 29;
            this.fechaIngresoLabel.Text = "Fecha de Ingreso";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(381, 83);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 28;
            this.emailLabel.Text = "Email";
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.Location = new System.Drawing.Point(537, 49);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(24, 15);
            this.RolLabel.TabIndex = 27;
            this.RolLabel.Text = "Rol";
            // 
            // ConfirmarLabel
            // 
            this.ConfirmarLabel.AutoSize = true;
            this.ConfirmarLabel.Location = new System.Drawing.Point(446, 119);
            this.ConfirmarLabel.Name = "ConfirmarLabel";
            this.ConfirmarLabel.Size = new System.Drawing.Size(93, 15);
            this.ConfirmarLabel.TabIndex = 26;
            this.ConfirmarLabel.Text = "Confirmar Clave";
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(247, 119);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(36, 15);
            this.ClaveLabel.TabIndex = 25;
            this.ClaveLabel.Text = "Clave";
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Location = new System.Drawing.Point(9, 81);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(56, 15);
            this.NombresLabel.TabIndex = 24;
            this.NombresLabel.Text = "Nombres";
            // 
            // Aliaslabel
            // 
            this.Aliaslabel.AutoSize = true;
            this.Aliaslabel.Location = new System.Drawing.Point(9, 47);
            this.Aliaslabel.Name = "Aliaslabel";
            this.Aliaslabel.Size = new System.Drawing.Size(32, 15);
            this.Aliaslabel.TabIndex = 23;
            this.Aliaslabel.Text = "Alias";
            // 
            // usuariosIdLabel
            // 
            this.usuariosIdLabel.AutoSize = true;
            this.usuariosIdLabel.Location = new System.Drawing.Point(9, 13);
            this.usuariosIdLabel.Name = "usuariosIdLabel";
            this.usuariosIdLabel.Size = new System.Drawing.Size(18, 15);
            this.usuariosIdLabel.TabIndex = 22;
            this.usuariosIdLabel.Text = "ID";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(260, 9);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(47, 33);
            this.BuscarButton.TabIndex = 39;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(147, 161);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(100, 43);
            this.NuevoButton.TabIndex = 40;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(297, 161);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 43);
            this.GuardarButton.TabIndex = 41;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(446, 161);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 43);
            this.EliminarButton.TabIndex = 42;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // UsuarioErrorProvider
            // 
            this.UsuarioErrorProvider.ContainerControl = this;
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 216);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.UsuarioIdNumericUpDown);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.IngresoDateTimePicker);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.confirmarTextBox);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.fechaIngresoLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.ConfirmarLabel);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.Aliaslabel);
            this.Controls.Add(this.usuariosIdLabel);
            this.Name = "RegistroUsuarios";
            this.Text = "RegistroUsuarios";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UsuarioIdNumericUpDown;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.DateTimePicker IngresoDateTimePicker;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox confirmarTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label fechaIngresoLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label RolLabel;
        private System.Windows.Forms.Label ConfirmarLabel;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Label Aliaslabel;
        private System.Windows.Forms.Label usuariosIdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider UsuarioErrorProvider;
    }
}