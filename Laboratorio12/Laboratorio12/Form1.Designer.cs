namespace Laboratorio12
{
    partial class calcular
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtAuto2 = new System.Windows.Forms.TextBox();
            this.txtAuto1 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Distancia = new System.Windows.Forms.Label();
            this.horaAuto = new System.Windows.Forms.Label();
            this.velocidad = new System.Windows.Forms.Label();
            this.nombreInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(9, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(90, 131);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar ";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(171, 131);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtAuto2
            // 
            this.txtAuto2.Location = new System.Drawing.Point(146, 84);
            this.txtAuto2.Name = "txtAuto2";
            this.txtAuto2.Size = new System.Drawing.Size(100, 20);
            this.txtAuto2.TabIndex = 3;
            // 
            // txtAuto1
            // 
            this.txtAuto1.Location = new System.Drawing.Point(146, 36);
            this.txtAuto1.Name = "txtAuto1";
            this.txtAuto1.Size = new System.Drawing.Size(100, 20);
            this.txtAuto1.TabIndex = 4;
            this.txtAuto1.TextChanged += new System.EventHandler(this.txtAuto1_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(146, 190);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // Distancia
            // 
            this.Distancia.AutoSize = true;
            this.Distancia.Location = new System.Drawing.Point(84, 190);
            this.Distancia.Name = "Distancia";
            this.Distancia.Size = new System.Drawing.Size(51, 13);
            this.Distancia.TabIndex = 7;
            this.Distancia.Text = "Distancia";
            this.Distancia.Click += new System.EventHandler(this.label2_Click);
            // 
            // horaAuto
            // 
            this.horaAuto.AutoSize = true;
            this.horaAuto.Location = new System.Drawing.Point(12, 84);
            this.horaAuto.Name = "horaAuto";
            this.horaAuto.Size = new System.Drawing.Size(100, 13);
            this.horaAuto.TabIndex = 8;
            this.horaAuto.Text = "Horas de Uso Auto ";
            this.horaAuto.Click += new System.EventHandler(this.label3_Click);
            // 
            // velocidad
            // 
            this.velocidad.AutoSize = true;
            this.velocidad.Location = new System.Drawing.Point(12, 36);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(82, 13);
            this.velocidad.TabIndex = 9;
            this.velocidad.Text = "Velocidad Auto ";
            // 
            // nombreInicial
            // 
            this.nombreInicial.AutoSize = true;
            this.nombreInicial.Location = new System.Drawing.Point(97, 9);
            this.nombreInicial.Name = "nombreInicial";
            this.nombreInicial.Size = new System.Drawing.Size(123, 13);
            this.nombreInicial.TabIndex = 10;
            this.nombreInicial.Text = "Calculadora de distancia";
            // 
            // calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 261);
            this.Controls.Add(this.nombreInicial);
            this.Controls.Add(this.velocidad);
            this.Controls.Add(this.horaAuto);
            this.Controls.Add(this.Distancia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtAuto1);
            this.Controls.Add(this.txtAuto2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "calcular";
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtAuto2;
        private System.Windows.Forms.TextBox txtAuto1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Distancia;
        private System.Windows.Forms.Label horaAuto;
        private System.Windows.Forms.Label velocidad;
        private System.Windows.Forms.Label nombreInicial;
    }
}

