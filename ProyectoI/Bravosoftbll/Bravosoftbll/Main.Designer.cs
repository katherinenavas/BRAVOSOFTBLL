namespace Bravosoftbll
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.Barra = new System.Windows.Forms.Panel();
            this.Cuerpo = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.Vacantes = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Button();
            this.Contrato = new System.Windows.Forms.Button();
            this.Empleado = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuVertical.Controls.Add(this.Registrar);
            this.MenuVertical.Controls.Add(this.Vacantes);
            this.MenuVertical.Controls.Add(this.Area);
            this.MenuVertical.Controls.Add(this.Contrato);
            this.MenuVertical.Controls.Add(this.Empleado);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.SystemColors.Window;
            this.Barra.Controls.Add(this.Restaurar);
            this.Barra.Controls.Add(this.Minimizar);
            this.Barra.Controls.Add(this.Maximizar);
            this.Barra.Controls.Add(this.Cerrar);
            this.Barra.Controls.Add(this.Menu);
            this.Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra.Location = new System.Drawing.Point(250, 0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(1050, 50);
            this.Barra.TabIndex = 1;
            this.Barra.Paint += new System.Windows.Forms.PaintEventHandler(this.Barra_Paint);
            this.Barra.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Barra_MouseDoubleClick);
            this.Barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_MouseDown);
            // 
            // Cuerpo
            // 
            this.Cuerpo.BackColor = System.Drawing.SystemColors.Window;
            this.Cuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cuerpo.Location = new System.Drawing.Point(250, 50);
            this.Cuerpo.Name = "Cuerpo";
            this.Cuerpo.Size = new System.Drawing.Size(1050, 600);
            this.Cuerpo.TabIndex = 2;
            this.Cuerpo.Paint += new System.Windows.Forms.PaintEventHandler(this.Cuerpo_Paint);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(972, 9);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 3;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(941, 9);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(972, 9);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(25, 25);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 2;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(1003, 9);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 1;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu
            // 
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(6, 9);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(35, 35);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Registrar
            // 
            this.Registrar.FlatAppearance.BorderSize = 0;
            this.Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Image = global::Bravosoftbll.Properties.Resources.iconemplead;
            this.Registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registrar.Location = new System.Drawing.Point(-10, 391);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(244, 56);
            this.Registrar.TabIndex = 5;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Vacantes
            // 
            this.Vacantes.FlatAppearance.BorderSize = 0;
            this.Vacantes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Vacantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vacantes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vacantes.Image = global::Bravosoftbll.Properties.Resources.vacantes1;
            this.Vacantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vacantes.Location = new System.Drawing.Point(12, 329);
            this.Vacantes.Name = "Vacantes";
            this.Vacantes.Size = new System.Drawing.Size(244, 56);
            this.Vacantes.TabIndex = 4;
            this.Vacantes.Text = "Vacantes";
            this.Vacantes.UseVisualStyleBackColor = true;
            this.Vacantes.Click += new System.EventHandler(this.Vacantes_Click);
            // 
            // Area
            // 
            this.Area.FlatAppearance.BorderSize = 0;
            this.Area.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Area.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Image = global::Bravosoftbll.Properties.Resources.iconcargo;
            this.Area.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Area.Location = new System.Drawing.Point(0, 267);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(244, 56);
            this.Area.TabIndex = 3;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // Contrato
            // 
            this.Contrato.FlatAppearance.BorderSize = 0;
            this.Contrato.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Contrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contrato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrato.Image = global::Bravosoftbll.Properties.Resources.iconContrato;
            this.Contrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Contrato.Location = new System.Drawing.Point(0, 205);
            this.Contrato.Name = "Contrato";
            this.Contrato.Size = new System.Drawing.Size(244, 56);
            this.Contrato.TabIndex = 2;
            this.Contrato.Text = "Contrato";
            this.Contrato.UseVisualStyleBackColor = true;
            this.Contrato.Click += new System.EventHandler(this.Contrato_Click);
            // 
            // Empleado
            // 
            this.Empleado.FlatAppearance.BorderSize = 0;
            this.Empleado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.Image = global::Bravosoftbll.Properties.Resources.iconemplead;
            this.Empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empleado.Location = new System.Drawing.Point(-10, 143);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(244, 56);
            this.Empleado.TabIndex = 1;
            this.Empleado.Text = "Empleado";
            this.Empleado.UseVisualStyleBackColor = true;
            this.Empleado.Click += new System.EventHandler(this.Empleado_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-43, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Cuerpo);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.MenuVertical.ResumeLayout(false);
            this.Barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel Barra;
        private System.Windows.Forms.Panel Cuerpo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Button Empleado;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button Vacantes;
        private System.Windows.Forms.Button Area;
        private System.Windows.Forms.Button Contrato;
    }
}

