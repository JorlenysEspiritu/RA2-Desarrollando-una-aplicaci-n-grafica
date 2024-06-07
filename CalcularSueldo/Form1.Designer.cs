namespace CalcularSueldo
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
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblHijos = new System.Windows.Forms.Label();
            this.lblIncentivos = new System.Windows.Forms.Label();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.lblSueldoBrutoIncentivos = new System.Windows.Forms.Label();
            this.lblDescuentoAFP = new System.Windows.Forms.Label();
            this.lblDescuentoSFS = new System.Windows.Forms.Label();
            this.txtSueldoBrutoIncentivos = new System.Windows.Forms.TextBox();
            this.txtDescuentoAFP = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtTotalDescuentos = new System.Windows.Forms.TextBox();
            this.txtIncentivos = new System.Windows.Forms.TextBox();
            this.txtHijos = new System.Windows.Forms.TextBox();
            this.txtDescuentoSFS = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSueldoNeto = new System.Windows.Forms.TextBox();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblSueldo.Location = new System.Drawing.Point(12, 31);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(94, 29);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblHijos.Location = new System.Drawing.Point(12, 84);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(210, 29);
            this.lblHijos.TabIndex = 1;
            this.lblHijos.Text = "Número de hijos";
            // 
            // lblIncentivos
            // 
            this.lblIncentivos.AutoSize = true;
            this.lblIncentivos.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblIncentivos.Location = new System.Drawing.Point(12, 130);
            this.lblIncentivos.Name = "lblIncentivos";
            this.lblIncentivos.Size = new System.Drawing.Size(137, 29);
            this.lblIncentivos.TabIndex = 2;
            this.lblIncentivos.Text = "Incentivos";
            // 
            // lblTotalDescuentos
            // 
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDescuentos.Location = new System.Drawing.Point(485, 186);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.Size = new System.Drawing.Size(217, 29);
            this.lblTotalDescuentos.TabIndex = 3;
            this.lblTotalDescuentos.Text = "Total Descuentos";
            // 
            // lblSueldoBrutoIncentivos
            // 
            this.lblSueldoBrutoIncentivos.AutoSize = true;
            this.lblSueldoBrutoIncentivos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoBrutoIncentivos.Location = new System.Drawing.Point(485, 31);
            this.lblSueldoBrutoIncentivos.Name = "lblSueldoBrutoIncentivos";
            this.lblSueldoBrutoIncentivos.Size = new System.Drawing.Size(327, 29);
            this.lblSueldoBrutoIncentivos.TabIndex = 4;
            this.lblSueldoBrutoIncentivos.Text = "Sueldo Bruto + Incentivos";
            // 
            // lblDescuentoAFP
            // 
            this.lblDescuentoAFP.AutoSize = true;
            this.lblDescuentoAFP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoAFP.Location = new System.Drawing.Point(494, 81);
            this.lblDescuentoAFP.Name = "lblDescuentoAFP";
            this.lblDescuentoAFP.Size = new System.Drawing.Size(184, 29);
            this.lblDescuentoAFP.TabIndex = 5;
            this.lblDescuentoAFP.Text = "DescuentoAFP";
            // 
            // lblDescuentoSFS
            // 
            this.lblDescuentoSFS.AutoSize = true;
            this.lblDescuentoSFS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoSFS.Location = new System.Drawing.Point(494, 133);
            this.lblDescuentoSFS.Name = "lblDescuentoSFS";
            this.lblDescuentoSFS.Size = new System.Drawing.Size(186, 29);
            this.lblDescuentoSFS.TabIndex = 6;
            this.lblDescuentoSFS.Text = "DescuentoSFS";
            // 
            // txtSueldoBrutoIncentivos
            // 
            this.txtSueldoBrutoIncentivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoBrutoIncentivos.Location = new System.Drawing.Point(828, 31);
            this.txtSueldoBrutoIncentivos.Name = "txtSueldoBrutoIncentivos";
            this.txtSueldoBrutoIncentivos.Size = new System.Drawing.Size(158, 30);
            this.txtSueldoBrutoIncentivos.TabIndex = 7;
            // 
            // txtDescuentoAFP
            // 
            this.txtDescuentoAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoAFP.Location = new System.Drawing.Point(828, 81);
            this.txtDescuentoAFP.Name = "txtDescuentoAFP";
            this.txtDescuentoAFP.Size = new System.Drawing.Size(158, 30);
            this.txtDescuentoAFP.TabIndex = 8;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(261, 31);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(175, 30);
            this.txtSueldo.TabIndex = 9;
            // 
            // txtTotalDescuentos
            // 
            this.txtTotalDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDescuentos.Location = new System.Drawing.Point(828, 192);
            this.txtTotalDescuentos.Name = "txtTotalDescuentos";
            this.txtTotalDescuentos.Size = new System.Drawing.Size(158, 30);
            this.txtTotalDescuentos.TabIndex = 10;
            // 
            // txtIncentivos
            // 
            this.txtIncentivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncentivos.Location = new System.Drawing.Point(261, 136);
            this.txtIncentivos.Name = "txtIncentivos";
            this.txtIncentivos.Size = new System.Drawing.Size(175, 30);
            this.txtIncentivos.TabIndex = 11;
            // 
            // txtHijos
            // 
            this.txtHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHijos.Location = new System.Drawing.Point(261, 86);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(175, 30);
            this.txtHijos.TabIndex = 12;
            // 
            // txtDescuentoSFS
            // 
            this.txtDescuentoSFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoSFS.Location = new System.Drawing.Point(828, 133);
            this.txtDescuentoSFS.Name = "txtDescuentoSFS";
            this.txtDescuentoSFS.Size = new System.Drawing.Size(158, 30);
            this.txtDescuentoSFS.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(349, 258);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(135, 46);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoNeto.Location = new System.Drawing.Point(261, 189);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.Size = new System.Drawing.Size(175, 30);
            this.txtSueldoNeto.TabIndex = 16;
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblSueldoNeto.Location = new System.Drawing.Point(12, 189);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(158, 29);
            this.lblSueldoNeto.TabIndex = 15;
            this.lblSueldoNeto.Text = "Sueldo Neto";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(543, 258);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 46);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1123, 327);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtSueldoNeto);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDescuentoSFS);
            this.Controls.Add(this.txtHijos);
            this.Controls.Add(this.txtIncentivos);
            this.Controls.Add(this.txtTotalDescuentos);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtDescuentoAFP);
            this.Controls.Add(this.txtSueldoBrutoIncentivos);
            this.Controls.Add(this.lblDescuentoSFS);
            this.Controls.Add(this.lblDescuentoAFP);
            this.Controls.Add(this.lblSueldoBrutoIncentivos);
            this.Controls.Add(this.lblTotalDescuentos);
            this.Controls.Add(this.lblIncentivos);
            this.Controls.Add(this.lblHijos);
            this.Controls.Add(this.lblSueldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblHijos;
        private System.Windows.Forms.Label lblIncentivos;
        private System.Windows.Forms.Label lblTotalDescuentos;
        private System.Windows.Forms.Label lblSueldoBrutoIncentivos;
        private System.Windows.Forms.Label lblDescuentoAFP;
        private System.Windows.Forms.Label lblDescuentoSFS;
        private System.Windows.Forms.TextBox txtSueldoBrutoIncentivos;
        private System.Windows.Forms.TextBox txtDescuentoAFP;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtTotalDescuentos;
        private System.Windows.Forms.TextBox txtIncentivos;
        private System.Windows.Forms.TextBox txtHijos;
        private System.Windows.Forms.TextBox txtDescuentoSFS;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSueldoNeto;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

