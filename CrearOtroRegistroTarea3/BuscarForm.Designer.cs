
namespace CrearOtroRegistroTarea3
{
    partial class BuscarForm
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
            this.FechaCreacionResultadodateTime = new System.Windows.Forms.DateTimePicker();
            this.RolIdResultTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionResulTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechaCreacionResultadodateTime
            // 
            this.FechaCreacionResultadodateTime.Location = new System.Drawing.Point(245, 183);
            this.FechaCreacionResultadodateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaCreacionResultadodateTime.Name = "FechaCreacionResultadodateTime";
            this.FechaCreacionResultadodateTime.Size = new System.Drawing.Size(219, 23);
            this.FechaCreacionResultadodateTime.TabIndex = 12;
            // 
            // RolIdResultTextBox
            // 
            this.RolIdResultTextBox.Location = new System.Drawing.Point(245, 93);
            this.RolIdResultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RolIdResultTextBox.Name = "RolIdResultTextBox";
            this.RolIdResultTextBox.Size = new System.Drawing.Size(110, 23);
            this.RolIdResultTextBox.TabIndex = 11;
            // 
            // DescripcionResulTextBox
            // 
            this.DescripcionResulTextBox.Location = new System.Drawing.Point(245, 137);
            this.DescripcionResulTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescripcionResulTextBox.Name = "DescripcionResulTextBox";
            this.DescripcionResulTextBox.Size = new System.Drawing.Size(110, 23);
            this.DescripcionResulTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha Creación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rol ID";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(240, 36);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(40, 15);
            this.tituloLabel.TabIndex = 13;
            this.tituloLabel.Text = "Datos:";
            // 
            // BuscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 282);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.FechaCreacionResultadodateTime);
            this.Controls.Add(this.RolIdResultTextBox);
            this.Controls.Add(this.DescripcionResulTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscarForm";
            this.Text = "BuscarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker FechaCreacionResultadodateTime;
        public System.Windows.Forms.TextBox RolIdResultTextBox;
        public System.Windows.Forms.TextBox DescripcionResulTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tituloLabel;
    }
}