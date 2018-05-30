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
            this.components = new System.ComponentModel.Container();
            this.Contrato = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.codcargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDeDatodp = new Bravosoftbll.BaseDeDatodp();
            this.empleadoTableAdapter = new Bravosoftbll.BaseDeDatodpTableAdapters.empleadoTableAdapter();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatodp)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(310, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Empleado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.fechanacDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.codcargoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 227);
            this.dataGridView1.TabIndex = 6;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // fechanacDataGridViewTextBoxColumn
            // 
            this.fechanacDataGridViewTextBoxColumn.DataPropertyName = "fecha_nac";
            this.fechanacDataGridViewTextBoxColumn.HeaderText = "fecha_nac";
            this.fechanacDataGridViewTextBoxColumn.Name = "fechanacDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "foto";
            this.fotoDataGridViewImageColumn.HeaderText = "foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // codcargoDataGridViewTextBoxColumn
            // 
            this.codcargoDataGridViewTextBoxColumn.DataPropertyName = "cod_cargo";
            this.codcargoDataGridViewTextBoxColumn.HeaderText = "cod_cargo";
            this.codcargoDataGridViewTextBoxColumn.Name = "codcargoDataGridViewTextBoxColumn";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.baseDeDatodp;
            // 
            // baseDeDatodp
            // 
            this.baseDeDatodp.DataSetName = "BaseDeDatodp";
            this.baseDeDatodp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(129, 62);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(129, 20);
            this.txt_Cedula.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cedula";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Contrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatodp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Contrato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BaseDeDatodp baseDeDatodp;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private BaseDeDatodpTableAdapters.empleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.Label label1;
    }
}