namespace Windows
{
    partial class frmIngresoDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.epValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTrazo = new System.Windows.Forms.GroupBox();
            this.rbPuntos = new System.Windows.Forms.RadioButton();
            this.rbRayas = new System.Windows.Forms.RadioButton();
            this.rbContinuo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).BeginInit();
            this.gbTrazo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Amarillo"});
            this.cbColor.Location = new System.Drawing.Point(158, 93);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 24);
            this.cbColor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ELIJA UN COLOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE EL RADIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "ELIJA UN TRAZO";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(158, 30);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(171, 22);
            this.txtRadio.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(15, 273);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(159, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(279, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(198, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epValidacion
            // 
            this.epValidacion.ContainerControl = this;
            // 
            // gbTrazo
            // 
            this.gbTrazo.Controls.Add(this.rbPuntos);
            this.gbTrazo.Controls.Add(this.rbRayas);
            this.gbTrazo.Controls.Add(this.rbContinuo);
            this.gbTrazo.Location = new System.Drawing.Point(158, 141);
            this.gbTrazo.Name = "gbTrazo";
            this.gbTrazo.Size = new System.Drawing.Size(384, 71);
            this.gbTrazo.TabIndex = 7;
            this.gbTrazo.TabStop = false;
            // 
            // rbPuntos
            // 
            this.rbPuntos.AutoSize = true;
            this.rbPuntos.Location = new System.Drawing.Point(284, 28);
            this.rbPuntos.Name = "rbPuntos";
            this.rbPuntos.Size = new System.Drawing.Size(69, 20);
            this.rbPuntos.TabIndex = 4;
            this.rbPuntos.Text = "Puntos";
            this.rbPuntos.UseVisualStyleBackColor = true;
            // 
            // rbRayas
            // 
            this.rbRayas.AutoSize = true;
            this.rbRayas.Location = new System.Drawing.Point(151, 28);
            this.rbRayas.Name = "rbRayas";
            this.rbRayas.Size = new System.Drawing.Size(68, 20);
            this.rbRayas.TabIndex = 5;
            this.rbRayas.Text = "Rayas";
            this.rbRayas.UseVisualStyleBackColor = true;
            // 
            // rbContinuo
            // 
            this.rbContinuo.AutoSize = true;
            this.rbContinuo.Checked = true;
            this.rbContinuo.Location = new System.Drawing.Point(30, 28);
            this.rbContinuo.Name = "rbContinuo";
            this.rbContinuo.Size = new System.Drawing.Size(80, 20);
            this.rbContinuo.TabIndex = 6;
            this.rbContinuo.TabStop = true;
            this.rbContinuo.Text = "Continuo";
            this.rbContinuo.UseVisualStyleBackColor = true;
            // 
            // frmIngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 341);
            this.Controls.Add(this.gbTrazo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbColor);
            this.Name = "frmIngresoDatos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).EndInit();
            this.gbTrazo.ResumeLayout(false);
            this.gbTrazo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider epValidacion;
        private System.Windows.Forms.GroupBox gbTrazo;
        private System.Windows.Forms.RadioButton rbPuntos;
        private System.Windows.Forms.RadioButton rbRayas;
        private System.Windows.Forms.RadioButton rbContinuo;
    }
}

