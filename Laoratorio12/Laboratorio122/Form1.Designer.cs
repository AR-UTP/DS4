namespace Laboratorio122
{
    partial class lab122
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
            this.cal1 = new System.Windows.Forms.Label();
            this.cal2 = new System.Windows.Forms.Label();
            this.cal3 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.tittle = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cal1
            // 
            this.cal1.AutoSize = true;
            this.cal1.Location = new System.Drawing.Point(139, 62);
            this.cal1.Name = "cal1";
            this.cal1.Size = new System.Drawing.Size(80, 13);
            this.cal1.TabIndex = 0;
            this.cal1.Text = "Calificación #1:";
            // 
            // cal2
            // 
            this.cal2.AutoSize = true;
            this.cal2.Location = new System.Drawing.Point(142, 103);
            this.cal2.Name = "cal2";
            this.cal2.Size = new System.Drawing.Size(80, 13);
            this.cal2.TabIndex = 1;
            this.cal2.Text = "Calificación #2:";
            // 
            // cal3
            // 
            this.cal3.AutoSize = true;
            this.cal3.Location = new System.Drawing.Point(142, 148);
            this.cal3.Name = "cal3";
            this.cal3.Size = new System.Drawing.Size(80, 13);
            this.cal3.TabIndex = 2;
            this.cal3.Text = "Calificación #3:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(251, 62);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 3;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(251, 103);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 4;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(251, 148);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 5;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(142, 207);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(251, 207);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(362, 207);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 8;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Location = new System.Drawing.Point(325, 20);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(91, 13);
            this.tittle.TabIndex = 9;
            this.tittle.Text = "Calcular promedio";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(409, 109);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(58, 13);
            this.lblres.TabIndex = 10;
            this.lblres.Text = "Resultado:";
            this.lblres.Click += new System.EventHandler(this.res_Click);
            // 
            // lab122
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.cal3);
            this.Controls.Add(this.cal2);
            this.Controls.Add(this.cal1);
            this.Name = "lab122";
            this.Text = "Calcular Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cal1;
        private System.Windows.Forms.Label cal2;
        private System.Windows.Forms.Label cal3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label lblres;
    }
}

