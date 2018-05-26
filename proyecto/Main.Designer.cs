namespace proyecto
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
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hojaDeVidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aspirantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Image = global::proyecto.Properties.Resources.registro;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Visible = false;
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::proyecto.Properties.Resources.inicio;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.loginToolStripMenuItem.Text = "Iniciar sesión";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::proyecto.Properties.Resources.salir;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Visible = false;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hojaDeVidaToolStripMenuItem,
            this.contratoToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.vacantesToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // hojaDeVidaToolStripMenuItem
            // 
            this.hojaDeVidaToolStripMenuItem.Name = "hojaDeVidaToolStripMenuItem";
            this.hojaDeVidaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hojaDeVidaToolStripMenuItem.Text = "Hoja de vida";
            // 
            // contratoToolStripMenuItem
            // 
            this.contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            this.contratoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contratoToolStripMenuItem.Text = "Contrato";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // vacantesToolStripMenuItem
            // 
            this.vacantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aspirantesToolStripMenuItem});
            this.vacantesToolStripMenuItem.Name = "vacantesToolStripMenuItem";
            this.vacantesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vacantesToolStripMenuItem.Text = "Vacantes";
            // 
            // aspirantesToolStripMenuItem
            // 
            this.aspirantesToolStripMenuItem.Name = "aspirantesToolStripMenuItem";
            this.aspirantesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aspirantesToolStripMenuItem.Text = "Aspirantes";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 484);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hojaDeVidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aspirantesToolStripMenuItem;

    }
}

