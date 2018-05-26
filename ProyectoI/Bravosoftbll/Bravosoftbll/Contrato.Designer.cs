namespace Bravosoftbll
{
    partial class Contrato
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
            this.tEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tEmpleado
            // 
            this.tEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tEmpleado.FlatAppearance.BorderSize = 0;
            this.tEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tEmpleado.Location = new System.Drawing.Point(0, 0);
            this.tEmpleado.Name = "tEmpleado";
            this.tEmpleado.Size = new System.Drawing.Size(1284, 56);
            this.tEmpleado.TabIndex = 4;
            this.tEmpleado.Text = "Contrato";
            this.tEmpleado.UseVisualStyleBackColor = true;
            this.tEmpleado.Click += new System.EventHandler(this.tEmpleado_Click);
            // 
            // Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.tEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contrato";
            this.Text = "Contrato";
            this.Load += new System.EventHandler(this.Contrato_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tEmpleado;
    }
}