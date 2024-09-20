namespace Rango__x_y_
{
   partial class Form1
   {
      /// <summary>
      /// Variable del diseñador necesaria.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpiar los recursos que se están utilizando.
      /// </summary>
      /// <param name="disposing">true si los recursos administrados deben eliminarse; false de lo contrario.</param>
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
      /// Requerido por el Diseñador.
      /// </summary>
      private void InitializeComponent()
      {
         this.txtX = new System.Windows.Forms.TextBox();
         this.txtY = new System.Windows.Forms.TextBox();
         this.btnMostrar = new System.Windows.Forms.Button();
         this.listBoxResultados = new System.Windows.Forms.ListBox();
         this.labelX = new System.Windows.Forms.Label();
         this.labelY = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // txtX
         // 
         this.txtX.Location = new System.Drawing.Point(20, 30);
         this.txtX.Name = "txtX";
         this.txtX.Size = new System.Drawing.Size(100, 20);
         this.txtX.TabIndex = 0;
         // 
         // txtY
         // 
         this.txtY.Location = new System.Drawing.Point(20, 80);
         this.txtY.Name = "txtY";
         this.txtY.Size = new System.Drawing.Size(100, 20);
         this.txtY.TabIndex = 1;
         // 
         // btnMostrar
         // 
         this.btnMostrar.Location = new System.Drawing.Point(20, 120);
         this.btnMostrar.Name = "btnMostrar";
         this.btnMostrar.Size = new System.Drawing.Size(100, 30);
         this.btnMostrar.TabIndex = 2;
         this.btnMostrar.Text = "Mostrar";
         this.btnMostrar.UseVisualStyleBackColor = true;
         this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
         // 
         // listBoxResultados
         // 
         this.listBoxResultados.FormattingEnabled = true;
         this.listBoxResultados.Location = new System.Drawing.Point(150, 30);
         this.listBoxResultados.Name = "listBoxResultados";
         this.listBoxResultados.Size = new System.Drawing.Size(120, 120);
         this.listBoxResultados.TabIndex = 3;
         // 
         // labelX
         // 
         this.labelX.AutoSize = true;
         this.labelX.Location = new System.Drawing.Point(20, 10);
         this.labelX.Name = "labelX";
         this.labelX.Size = new System.Drawing.Size(49, 13);
         this.labelX.TabIndex = 4;
         this.labelX.Text = "Número X";
         // 
         // labelY
         // 
         this.labelY.AutoSize = true;
         this.labelY.Location = new System.Drawing.Point(20, 60);
         this.labelY.Name = "labelY";
         this.labelY.Size = new System.Drawing.Size(49, 13);
         this.labelY.TabIndex = 5;
         this.labelY.Text = "Número Y";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(300, 180);
         this.Controls.Add(this.labelY);
         this.Controls.Add(this.labelX);
         this.Controls.Add(this.listBoxResultados);
         this.Controls.Add(this.btnMostrar);
         this.Controls.Add(this.txtY);
         this.Controls.Add(this.txtX);
         this.Name = "Form1";
         this.Text = "Rango de Números";
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox txtX;
      private System.Windows.Forms.TextBox txtY;
      private System.Windows.Forms.Button btnMostrar;
      private System.Windows.Forms.ListBox listBoxResultados;
      private System.Windows.Forms.Label labelX;
      private System.Windows.Forms.Label labelY;
   }
}
