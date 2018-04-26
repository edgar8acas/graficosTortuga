namespace graficosTortuga
{
    partial class Form1
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
            this.btnPlumaArriba = new System.Windows.Forms.Button();
            this.btnPlumaAbajo = new System.Windows.Forms.Button();
            this.btnGirarDerecha = new System.Windows.Forms.Button();
            this.btnGirarIzquierda = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.txtEspacios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlumaArriba
            // 
            this.btnPlumaArriba.Location = new System.Drawing.Point(105, 94);
            this.btnPlumaArriba.Name = "btnPlumaArriba";
            this.btnPlumaArriba.Size = new System.Drawing.Size(92, 23);
            this.btnPlumaArriba.TabIndex = 0;
            this.btnPlumaArriba.Text = "Pluma arriba";
            this.btnPlumaArriba.UseVisualStyleBackColor = true;
            this.btnPlumaArriba.Click += new System.EventHandler(this.btnPlumaArriba_Click);
            // 
            // btnPlumaAbajo
            // 
            this.btnPlumaAbajo.Location = new System.Drawing.Point(105, 123);
            this.btnPlumaAbajo.Name = "btnPlumaAbajo";
            this.btnPlumaAbajo.Size = new System.Drawing.Size(92, 23);
            this.btnPlumaAbajo.TabIndex = 1;
            this.btnPlumaAbajo.Text = "Pluma abajo";
            this.btnPlumaAbajo.UseVisualStyleBackColor = true;
            this.btnPlumaAbajo.Click += new System.EventHandler(this.btnPlumaAbajo_Click);
            // 
            // btnGirarDerecha
            // 
            this.btnGirarDerecha.Location = new System.Drawing.Point(105, 152);
            this.btnGirarDerecha.Name = "btnGirarDerecha";
            this.btnGirarDerecha.Size = new System.Drawing.Size(92, 23);
            this.btnGirarDerecha.TabIndex = 2;
            this.btnGirarDerecha.Text = "Girar derecha";
            this.btnGirarDerecha.UseVisualStyleBackColor = true;
            this.btnGirarDerecha.Click += new System.EventHandler(this.btnGirarDerecha_Click);
            // 
            // btnGirarIzquierda
            // 
            this.btnGirarIzquierda.Location = new System.Drawing.Point(105, 181);
            this.btnGirarIzquierda.Name = "btnGirarIzquierda";
            this.btnGirarIzquierda.Size = new System.Drawing.Size(92, 23);
            this.btnGirarIzquierda.TabIndex = 3;
            this.btnGirarIzquierda.Text = "Girar izquierda";
            this.btnGirarIzquierda.UseVisualStyleBackColor = true;
            this.btnGirarIzquierda.Click += new System.EventHandler(this.btnGirarIzquierda_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(105, 210);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(92, 23);
            this.btnAvanzar.TabIndex = 4;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // txtEspacios
            // 
            this.txtEspacios.Location = new System.Drawing.Point(42, 213);
            this.txtEspacios.Name = "txtEspacios";
            this.txtEspacios.Size = new System.Drawing.Size(57, 20);
            this.txtEspacios.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Espacios";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(105, 239);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(92, 23);
            this.btnGraficar.TabIndex = 8;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(105, 268);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(92, 23);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Fin de datos";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtMatriz
            // 
            this.txtMatriz.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriz.Location = new System.Drawing.Point(270, 21);
            this.txtMatriz.Multiline = true;
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(414, 404);
            this.txtMatriz.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMatriz);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEspacios);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnGirarIzquierda);
            this.Controls.Add(this.btnGirarDerecha);
            this.Controls.Add(this.btnPlumaAbajo);
            this.Controls.Add(this.btnPlumaArriba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlumaArriba;
        private System.Windows.Forms.Button btnPlumaAbajo;
        private System.Windows.Forms.Button btnGirarDerecha;
        private System.Windows.Forms.Button btnGirarIzquierda;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.TextBox txtEspacios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtMatriz;
    }
}

