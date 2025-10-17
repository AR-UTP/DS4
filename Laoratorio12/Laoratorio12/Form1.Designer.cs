namespace Laoratorio12
{
    partial class Form1
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblShowRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(342, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(95, 13);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Calcular Velocidad";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(277, 84);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(57, 13);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "Velocidad:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(277, 127);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Tiempo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(386, 77);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(148, 20);
            this.txtSpeed.TabIndex = 4;
            this.txtSpeed.TextChanged += new System.EventHandler(this.txtSpeed_TextChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(386, 120);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(148, 20);
            this.txtTime.TabIndex = 5;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(233, 189);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(362, 189);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(498, 189);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(276, 163);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(58, 13);
            this.lblRes.TabIndex = 9;
            this.lblRes.Text = "Resultado:";
            // 
            // lblShowRes
            // 
            this.lblShowRes.AutoSize = true;
            this.lblShowRes.Location = new System.Drawing.Point(430, 163);
            this.lblShowRes.Name = "lblShowRes";
            this.lblShowRes.Size = new System.Drawing.Size(13, 13);
            this.lblShowRes.TabIndex = 10;
            this.lblShowRes.Text = "0";
            this.lblShowRes.Click += new System.EventHandler(this.lblShowRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShowRes);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblTittle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblShowRes;
    }
}

