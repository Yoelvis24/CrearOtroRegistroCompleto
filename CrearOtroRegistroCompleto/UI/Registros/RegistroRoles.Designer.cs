
namespace CrearOtroRegistroCompleto.UI.Registros
{
    partial class RegistroRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroRoles));
            this.rolIdLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.fechaCreacionLabel = new System.Windows.Forms.Label();
            this.rolIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechaCreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.rolErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rolIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // rolIdLabel
            // 
            this.rolIdLabel.AutoSize = true;
            this.rolIdLabel.Location = new System.Drawing.Point(79, 46);
            this.rolIdLabel.Name = "rolIdLabel";
            this.rolIdLabel.Size = new System.Drawing.Size(40, 15);
            this.rolIdLabel.TabIndex = 0;
            this.rolIdLabel.Text = "Rol Id:";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(47, 136);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(72, 15);
            this.descripcionLabel.TabIndex = 1;
            this.descripcionLabel.Text = "Descripción:";
            // 
            // fechaCreacionLabel
            // 
            this.fechaCreacionLabel.AutoSize = true;
            this.fechaCreacionLabel.Location = new System.Drawing.Point(12, 95);
            this.fechaCreacionLabel.Name = "fechaCreacionLabel";
            this.fechaCreacionLabel.Size = new System.Drawing.Size(107, 15);
            this.fechaCreacionLabel.TabIndex = 2;
            this.fechaCreacionLabel.Text = "Fecha de Creación:";
            // 
            // rolIdNumericUpDown
            // 
            this.rolIdNumericUpDown.Location = new System.Drawing.Point(125, 44);
            this.rolIdNumericUpDown.Name = "rolIdNumericUpDown";
            this.rolIdNumericUpDown.Size = new System.Drawing.Size(150, 23);
            this.rolIdNumericUpDown.TabIndex = 3;
            // 
            // fechaCreacionDateTimePicker
            // 
            this.fechaCreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCreacionDateTimePicker.Location = new System.Drawing.Point(125, 89);
            this.fechaCreacionDateTimePicker.Name = "fechaCreacionDateTimePicker";
            this.fechaCreacionDateTimePicker.Size = new System.Drawing.Size(150, 23);
            this.fechaCreacionDateTimePicker.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(125, 133);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(150, 23);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(134, 179);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 58);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(25, 179);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 58);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(242, 179);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 58);
            this.EliminarButton.TabIndex = 8;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(279, 36);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(38, 34);
            this.BuscarButton.TabIndex = 9;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // rolErrorProvider
            // 
            this.rolErrorProvider.ContainerControl = this;
            // 
            // RegistroRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 257);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.fechaCreacionDateTimePicker);
            this.Controls.Add(this.rolIdNumericUpDown);
            this.Controls.Add(this.fechaCreacionLabel);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.rolIdLabel);
            this.Name = "RegistroRoles";
            this.Text = "Registro de Roles";
            ((System.ComponentModel.ISupportInitialize)(this.rolIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rolIdLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label fechaCreacionLabel;
        private System.Windows.Forms.NumericUpDown rolIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker fechaCreacionDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider rolErrorProvider;
    }
}