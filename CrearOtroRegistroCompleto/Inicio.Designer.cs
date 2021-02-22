
namespace CrearOtroRegistroCompleto
{
    partial class Inicio
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
            this.rUsuariosButton = new System.Windows.Forms.Button();
            this.rRolesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rUsuariosButton
            // 
            this.rUsuariosButton.Location = new System.Drawing.Point(27, 58);
            this.rUsuariosButton.Name = "rUsuariosButton";
            this.rUsuariosButton.Size = new System.Drawing.Size(140, 36);
            this.rUsuariosButton.TabIndex = 0;
            this.rUsuariosButton.Text = "Registrar usuario";
            this.rUsuariosButton.UseVisualStyleBackColor = true;
            this.rUsuariosButton.Click += new System.EventHandler(this.rUsuariosButton_Click);
            // 
            // rRolesButton
            // 
            this.rRolesButton.Location = new System.Drawing.Point(185, 58);
            this.rRolesButton.Name = "rRolesButton";
            this.rRolesButton.Size = new System.Drawing.Size(140, 36);
            this.rRolesButton.TabIndex = 1;
            this.rRolesButton.Text = "Registrar roles";
            this.rRolesButton.UseVisualStyleBackColor = true;
            this.rRolesButton.Click += new System.EventHandler(this.rRolesButton_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 206);
            this.Controls.Add(this.rRolesButton);
            this.Controls.Add(this.rUsuariosButton);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rUsuariosButton;
        private System.Windows.Forms.Button rRolesButton;
    }
}