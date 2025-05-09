namespace excepciones1
{
    partial class frmCalculadora
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbxN1 = new System.Windows.Forms.TextBox();
            this.tbxN2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(120, 225);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 31);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbxN1
            // 
            this.tbxN1.Location = new System.Drawing.Point(120, 78);
            this.tbxN1.Name = "tbxN1";
            this.tbxN1.Size = new System.Drawing.Size(92, 20);
            this.tbxN1.TabIndex = 1;
            // 
            // tbxN2
            // 
            this.tbxN2.Location = new System.Drawing.Point(119, 162);
            this.tbxN2.Name = "tbxN2";
            this.tbxN2.Size = new System.Drawing.Size(92, 20);
            this.tbxN2.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(218, 234);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 18);
            this.lblResultado.TabIndex = 3;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 344);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.tbxN2);
            this.Controls.Add(this.tbxN1);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbxN1;
        private System.Windows.Forms.TextBox tbxN2;
        private System.Windows.Forms.Label lblResultado;
    }
}

