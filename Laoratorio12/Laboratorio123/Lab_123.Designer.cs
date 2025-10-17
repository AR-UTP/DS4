namespace Laboratorio123
{
    partial class lab123
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
            this.lbl_LadoA = new System.Windows.Forms.Label();
            this.lbl_LadoC = new System.Windows.Forms.Label();
            this.lbl_LadoB = new System.Windows.Forms.Label();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.lbl_SemiP = new System.Windows.Forms.Label();
            this.txt_ladoA = new System.Windows.Forms.TextBox();
            this.txt_ladoC = new System.Windows.Forms.TextBox();
            this.txt_ladoB = new System.Windows.Forms.TextBox();
            this.btn_semiP = new System.Windows.Forms.Button();
            this.btn_area = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_semiP = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_LadoA
            // 
            this.lbl_LadoA.AutoSize = true;
            this.lbl_LadoA.Location = new System.Drawing.Point(111, 54);
            this.lbl_LadoA.Name = "lbl_LadoA";
            this.lbl_LadoA.Size = new System.Drawing.Size(44, 13);
            this.lbl_LadoA.TabIndex = 0;
            this.lbl_LadoA.Text = "Lado A:";
            // 
            // lbl_LadoC
            // 
            this.lbl_LadoC.AutoSize = true;
            this.lbl_LadoC.Location = new System.Drawing.Point(111, 145);
            this.lbl_LadoC.Name = "lbl_LadoC";
            this.lbl_LadoC.Size = new System.Drawing.Size(44, 13);
            this.lbl_LadoC.TabIndex = 1;
            this.lbl_LadoC.Text = "Lado C:";
            // 
            // lbl_LadoB
            // 
            this.lbl_LadoB.AutoSize = true;
            this.lbl_LadoB.Location = new System.Drawing.Point(111, 97);
            this.lbl_LadoB.Name = "lbl_LadoB";
            this.lbl_LadoB.Size = new System.Drawing.Size(44, 13);
            this.lbl_LadoB.TabIndex = 2;
            this.lbl_LadoB.Text = "Lado B:";
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(225, 250);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(32, 13);
            this.lbl_Area.TabIndex = 3;
            this.lbl_Area.Text = "Área:";
            this.lbl_Area.Click += new System.EventHandler(this.lbl_Area_Click);
            // 
            // lbl_SemiP
            // 
            this.lbl_SemiP.AutoSize = true;
            this.lbl_SemiP.Location = new System.Drawing.Point(216, 219);
            this.lbl_SemiP.Name = "lbl_SemiP";
            this.lbl_SemiP.Size = new System.Drawing.Size(78, 13);
            this.lbl_SemiP.TabIndex = 4;
            this.lbl_SemiP.Text = "Semiperímetro:";
            // 
            // txt_ladoA
            // 
            this.txt_ladoA.Location = new System.Drawing.Point(248, 54);
            this.txt_ladoA.Name = "txt_ladoA";
            this.txt_ladoA.Size = new System.Drawing.Size(100, 20);
            this.txt_ladoA.TabIndex = 5;
            // 
            // txt_ladoC
            // 
            this.txt_ladoC.Location = new System.Drawing.Point(248, 145);
            this.txt_ladoC.Name = "txt_ladoC";
            this.txt_ladoC.Size = new System.Drawing.Size(100, 20);
            this.txt_ladoC.TabIndex = 6;
            // 
            // txt_ladoB
            // 
            this.txt_ladoB.Location = new System.Drawing.Point(248, 97);
            this.txt_ladoB.Name = "txt_ladoB";
            this.txt_ladoB.Size = new System.Drawing.Size(100, 20);
            this.txt_ladoB.TabIndex = 7;
            // 
            // btn_semiP
            // 
            this.btn_semiP.Location = new System.Drawing.Point(174, 189);
            this.btn_semiP.Name = "btn_semiP";
            this.btn_semiP.Size = new System.Drawing.Size(83, 23);
            this.btn_semiP.TabIndex = 8;
            this.btn_semiP.Text = "Semiperímetro";
            this.btn_semiP.UseVisualStyleBackColor = true;
            this.btn_semiP.Click += new System.EventHandler(this.btn_semiP_Click);
            // 
            // btn_area
            // 
            this.btn_area.Location = new System.Drawing.Point(263, 189);
            this.btn_area.Name = "btn_area";
            this.btn_area.Size = new System.Drawing.Size(75, 23);
            this.btn_area.TabIndex = 9;
            this.btn_area.Text = "Área";
            this.btn_area.UseVisualStyleBackColor = true;
            this.btn_area.Click += new System.EventHandler(this.btn_area_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(425, 189);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(344, 189);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_semiP
            // 
            this.txt_semiP.Location = new System.Drawing.Point(312, 219);
            this.txt_semiP.Name = "txt_semiP";
            this.txt_semiP.Size = new System.Drawing.Size(100, 20);
            this.txt_semiP.TabIndex = 12;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(312, 250);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(100, 20);
            this.txt_area.TabIndex = 13;
            // 
            // lab123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.txt_semiP);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_area);
            this.Controls.Add(this.btn_semiP);
            this.Controls.Add(this.txt_ladoB);
            this.Controls.Add(this.txt_ladoC);
            this.Controls.Add(this.txt_ladoA);
            this.Controls.Add(this.lbl_SemiP);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.lbl_LadoB);
            this.Controls.Add(this.lbl_LadoC);
            this.Controls.Add(this.lbl_LadoA);
            this.Name = "lab123";
            this.Text = "Calcular Triángulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LadoA;
        private System.Windows.Forms.Label lbl_LadoC;
        private System.Windows.Forms.Label lbl_LadoB;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.Label lbl_SemiP;
        private System.Windows.Forms.TextBox txt_ladoA;
        private System.Windows.Forms.TextBox txt_ladoC;
        private System.Windows.Forms.TextBox txt_ladoB;
        private System.Windows.Forms.Button btn_semiP;
        private System.Windows.Forms.Button btn_area;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_semiP;
        private System.Windows.Forms.TextBox txt_area;
    }
}

