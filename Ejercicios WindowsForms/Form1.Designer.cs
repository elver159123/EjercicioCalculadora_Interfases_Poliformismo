namespace Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.sumar = new System.Windows.Forms.CheckBox();
            this.restar = new System.Windows.Forms.CheckBox();
            this.modulo = new System.Windows.Forms.CheckBox();
            this.dividir = new System.Windows.Forms.CheckBox();
            this.multiplicar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "numero 2";
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(90, 183);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(135, 26);
            this.tbNum2.TabIndex = 2;
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(90, 111);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(135, 26);
            this.tbNum1.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(106, 310);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operaciones Básicas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(23, 312);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(77, 19);
            this.Result.TabIndex = 6;
            this.Result.Text = "Resultado";
            // 
            // sumar
            // 
            this.sumar.AutoSize = true;
            this.sumar.Location = new System.Drawing.Point(54, 230);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(37, 23);
            this.sumar.TabIndex = 7;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            // 
            // restar
            // 
            this.restar.AutoSize = true;
            this.restar.Location = new System.Drawing.Point(100, 230);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(33, 23);
            this.restar.TabIndex = 8;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            // 
            // modulo
            // 
            this.modulo.AutoSize = true;
            this.modulo.Location = new System.Drawing.Point(139, 230);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(42, 23);
            this.modulo.TabIndex = 9;
            this.modulo.Text = "re";
            this.modulo.UseVisualStyleBackColor = true;
            // 
            // dividir
            // 
            this.dividir.AutoSize = true;
            this.dividir.Location = new System.Drawing.Point(187, 230);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(32, 23);
            this.dividir.TabIndex = 10;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            // 
            // multiplicar
            // 
            this.multiplicar.AutoSize = true;
            this.multiplicar.Location = new System.Drawing.Point(225, 230);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(36, 23);
            this.multiplicar.TabIndex = 11;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ir nueva pantalla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(362, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Controles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.CheckBox sumar;
        private System.Windows.Forms.CheckBox restar;
        private System.Windows.Forms.CheckBox modulo;
        private System.Windows.Forms.CheckBox dividir;
        private System.Windows.Forms.CheckBox multiplicar;
        private System.Windows.Forms.Button button1;
    }
}

