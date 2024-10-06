namespace Laboratorio11
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
            this.btnCLickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCLickThis
            // 
            this.btnCLickThis.Location = new System.Drawing.Point(95, 57);
            this.btnCLickThis.Name = "btnCLickThis";
            this.btnCLickThis.Size = new System.Drawing.Size(151, 35);
            this.btnCLickThis.TabIndex = 0;
            this.btnCLickThis.Text = "CLICK THIS ";
            this.btnCLickThis.UseVisualStyleBackColor = true;
            this.btnCLickThis.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(150, 108);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 13);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 165);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnCLickThis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCLickThis;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

