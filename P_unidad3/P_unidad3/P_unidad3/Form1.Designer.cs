namespace P_unidad3
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
            this.BtnCon = new System.Windows.Forms.Button();
            this.txtAlgo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCon
            // 
            this.BtnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCon.Location = new System.Drawing.Point(158, 81);
            this.BtnCon.Name = "BtnCon";
            this.BtnCon.Size = new System.Drawing.Size(129, 31);
            this.BtnCon.TabIndex = 0;
            this.BtnCon.Text = "CONECTAR";
            this.BtnCon.UseVisualStyleBackColor = true;
            this.BtnCon.Click += new System.EventHandler(this.BtnCon_Click);
            // 
            // txtAlgo
            // 
            this.txtAlgo.Location = new System.Drawing.Point(94, 137);
            this.txtAlgo.Name = "txtAlgo";
            this.txtAlgo.Size = new System.Drawing.Size(239, 20);
            this.txtAlgo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRACTICA UNIDAD 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(459, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlgo);
            this.Controls.Add(this.BtnCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCon;
        private System.Windows.Forms.TextBox txtAlgo;
        private System.Windows.Forms.Label label1;
    }
}

