
namespace CrearOtroRegistroCompleto
{
    partial class RegistroForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            this.FechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaIngresoLabel = new System.Windows.Forms.Label();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.rolLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.confirmarTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.confirmarLabel = new System.Windows.Forms.Label();
            this.claveLabel = new System.Windows.Forms.Label();
            this.nombresLabel = new System.Windows.Forms.Label();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.UsuarioIdLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.usuarioIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaIngresoDateTimePicker
            // 
            this.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaIngresoDateTimePicker.Location = new System.Drawing.Point(116, 136);
            this.FechaIngresoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker";
            this.FechaIngresoDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.FechaIngresoDateTimePicker.TabIndex = 52;
            // 
            // fechaIngresoLabel
            // 
            this.fechaIngresoLabel.AutoSize = true;
            this.fechaIngresoLabel.Location = new System.Drawing.Point(20, 139);
            this.fechaIngresoLabel.Name = "fechaIngresoLabel";
            this.fechaIngresoLabel.Size = new System.Drawing.Size(80, 15);
            this.fechaIngresoLabel.TabIndex = 51;
            this.fechaIngresoLabel.Text = "Fecha Ingreso";
            // 
            // rolComboBox
            // 
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Location = new System.Drawing.Point(571, 67);
            this.rolComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(133, 23);
            this.rolComboBox.TabIndex = 50;
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Location = new System.Drawing.Point(541, 72);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(24, 15);
            this.rolLabel.TabIndex = 49;
            this.rolLabel.Text = "Rol";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(454, 101);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(250, 23);
            this.emailTextBox.TabIndex = 47;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.AutoSize = true;
            this.activoCheckBox.Location = new System.Drawing.Point(644, 37);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.activoCheckBox.TabIndex = 46;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(412, 104);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 44;
            this.emailLabel.Text = "Email";
            // 
            // confirmarTextBox
            // 
            this.confirmarTextBox.Location = new System.Drawing.Point(594, 139);
            this.confirmarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmarTextBox.Name = "confirmarTextBox";
            this.confirmarTextBox.PasswordChar = '*';
            this.confirmarTextBox.Size = new System.Drawing.Size(110, 23);
            this.confirmarTextBox.TabIndex = 43;
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(116, 170);
            this.claveTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(152, 23);
            this.claveTextBox.TabIndex = 42;
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.Location = new System.Drawing.Point(116, 64);
            this.aliasTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(215, 23);
            this.aliasTextBox.TabIndex = 41;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(116, 98);
            this.nombresTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(290, 23);
            this.nombresTextBox.TabIndex = 40;
            // 
            // confirmarLabel
            // 
            this.confirmarLabel.AutoSize = true;
            this.confirmarLabel.Location = new System.Drawing.Point(495, 142);
            this.confirmarLabel.Name = "confirmarLabel";
            this.confirmarLabel.Size = new System.Drawing.Size(93, 15);
            this.confirmarLabel.TabIndex = 38;
            this.confirmarLabel.Text = "Confirmar Clave";
            // 
            // claveLabel
            // 
            this.claveLabel.AutoSize = true;
            this.claveLabel.Location = new System.Drawing.Point(52, 170);
            this.claveLabel.Name = "claveLabel";
            this.claveLabel.Size = new System.Drawing.Size(36, 15);
            this.claveLabel.TabIndex = 37;
            this.claveLabel.Text = "Clave";
            // 
            // nombresLabel
            // 
            this.nombresLabel.AutoSize = true;
            this.nombresLabel.Location = new System.Drawing.Point(52, 101);
            this.nombresLabel.Name = "nombresLabel";
            this.nombresLabel.Size = new System.Drawing.Size(56, 15);
            this.nombresLabel.TabIndex = 36;
            this.nombresLabel.Text = "Nombres";
            // 
            // aliasLabel
            // 
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Location = new System.Drawing.Point(52, 67);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(32, 15);
            this.aliasLabel.TabIndex = 35;
            this.aliasLabel.Text = "Alias";
            // 
            // UsuarioIdLabel
            // 
            this.UsuarioIdLabel.AutoSize = true;
            this.UsuarioIdLabel.Location = new System.Drawing.Point(52, 32);
            this.UsuarioIdLabel.Name = "UsuarioIdLabel";
            this.UsuarioIdLabel.Size = new System.Drawing.Size(18, 15);
            this.UsuarioIdLabel.TabIndex = 34;
            this.UsuarioIdLabel.Text = "ID";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(242, 22);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(43, 34);
            this.BuscarButton.TabIndex = 55;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(173, 211);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(95, 63);
            this.NuevoButton.TabIndex = 56;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(320, 211);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(95, 63);
            this.GuardarButton.TabIndex = 57;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(454, 211);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(95, 63);
            this.EliminarButton.TabIndex = 58;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // usuarioIdNumericUpDown
            // 
            this.usuarioIdNumericUpDown.Location = new System.Drawing.Point(116, 28);
            this.usuarioIdNumericUpDown.Name = "usuarioIdNumericUpDown";
            this.usuarioIdNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.usuarioIdNumericUpDown.TabIndex = 59;
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 293);
            this.Controls.Add(this.usuarioIdNumericUpDown);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FechaIngresoDateTimePicker);
            this.Controls.Add(this.fechaIngresoLabel);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(this.rolLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.confirmarTextBox);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.confirmarLabel);
            this.Controls.Add(this.claveLabel);
            this.Controls.Add(this.nombresLabel);
            this.Controls.Add(this.aliasLabel);
            this.Controls.Add(this.UsuarioIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroForm";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RegistroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaIngresoDateTimePicker;
        private System.Windows.Forms.Label fechaIngresoLabel;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox confirmarTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.Label confirmarLabel;
        private System.Windows.Forms.Label claveLabel;
        private System.Windows.Forms.Label nombresLabel;
        private System.Windows.Forms.Label aliasLabel;
        private System.Windows.Forms.Label UsuarioIdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown usuarioIdNumericUpDown;
    }
}

