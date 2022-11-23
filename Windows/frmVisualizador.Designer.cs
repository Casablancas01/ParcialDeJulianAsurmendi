namespace Windows
{
    partial class frmVisualizador
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
            this.dgvEsferas = new System.Windows.Forms.DataGridView();
            this.ColRadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVolumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEsferas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEsferas
            // 
            this.dgvEsferas.AllowUserToAddRows = false;
            this.dgvEsferas.AllowUserToDeleteRows = false;
            this.dgvEsferas.AllowUserToResizeColumns = false;
            this.dgvEsferas.AllowUserToResizeRows = false;
            this.dgvEsferas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEsferas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRadio,
            this.ColColor,
            this.ColTrazo,
            this.ColArea,
            this.ColVolumen});
            this.dgvEsferas.Location = new System.Drawing.Point(59, 12);
            this.dgvEsferas.MultiSelect = false;
            this.dgvEsferas.Name = "dgvEsferas";
            this.dgvEsferas.ReadOnly = true;
            this.dgvEsferas.RowHeadersVisible = false;
            this.dgvEsferas.RowHeadersWidth = 51;
            this.dgvEsferas.RowTemplate.Height = 24;
            this.dgvEsferas.Size = new System.Drawing.Size(678, 296);
            this.dgvEsferas.TabIndex = 0;
            // 
            // ColRadio
            // 
            this.ColRadio.HeaderText = "Radio";
            this.ColRadio.MinimumWidth = 6;
            this.ColRadio.Name = "ColRadio";
            this.ColRadio.ReadOnly = true;
            this.ColRadio.Width = 125;
            // 
            // ColColor
            // 
            this.ColColor.HeaderText = "Color";
            this.ColColor.MinimumWidth = 6;
            this.ColColor.Name = "ColColor";
            this.ColColor.ReadOnly = true;
            this.ColColor.Width = 125;
            // 
            // ColTrazo
            // 
            this.ColTrazo.HeaderText = "Trazo";
            this.ColTrazo.MinimumWidth = 6;
            this.ColTrazo.Name = "ColTrazo";
            this.ColTrazo.ReadOnly = true;
            this.ColTrazo.Width = 125;
            // 
            // ColArea
            // 
            this.ColArea.HeaderText = "Area";
            this.ColArea.MinimumWidth = 6;
            this.ColArea.Name = "ColArea";
            this.ColArea.ReadOnly = true;
            this.ColArea.Width = 125;
            // 
            // ColVolumen
            // 
            this.ColVolumen.HeaderText = "Vaolumen";
            this.ColVolumen.MinimumWidth = 6;
            this.ColVolumen.Name = "ColVolumen";
            this.ColVolumen.ReadOnly = true;
            this.ColVolumen.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Elementos";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(185, 407);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(0, 16);
            this.lbCantidad.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(59, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR ESFERA";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(700, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmVisualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEsferas);
            this.Name = "frmVisualizador";
            this.ShowIcon = false;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.frmVisualizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEsferas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEsferas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVolumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
    }
}