namespace Bravosoftbll
{
    partial class Empleado
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
            this.Contrato = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Contrato
            // 
            this.Contrato.FlatAppearance.BorderSize = 0;
            this.Contrato.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Contrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contrato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrato.Image = global::Bravosoftbll.Properties.Resources.iconemplead;
            this.Contrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Contrato.Location = new System.Drawing.Point(562, 381);
            this.Contrato.Name = "Contrato";
            this.Contrato.Size = new System.Drawing.Size(244, 56);
            this.Contrato.TabIndex = 4;
            this.Contrato.Text = "Contrato";
            this.Contrato.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(191, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Empleado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Contrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Contrato;
        private System.Windows.Forms.Button button1;
    }
}