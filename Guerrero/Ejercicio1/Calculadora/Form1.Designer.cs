namespace Calculadora
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(35, 41);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(117, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Digite el primer número:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(212, 41);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(130, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Digite el segundo número:";
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(38, 69);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(114, 20);
            this.tbNum1.TabIndex = 2;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(215, 69);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(127, 20);
            this.tbNum2.TabIndex = 3;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(42, 117);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(47, 36);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Sumar";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(194, 117);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(74, 36);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "Multiplicar";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(116, 117);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(47, 36);
            this.btnResta.TabIndex = 6;
            this.btnResta.Text = "Restar";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(295, 117);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(47, 36);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "Dividir";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(27, 183);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 234);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblResult;
    }
}

