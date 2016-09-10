namespace calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.btncalcular = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.rbsoma = new System.Windows.Forms.RadioButton();
            this.rbsubtrair = new System.Windows.Forms.RadioButton();
            this.rbdivisao = new System.Windows.Forms.RadioButton();
            this.rbmultiplica = new System.Windows.Forms.RadioButton();
            this.tbresultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(110, 227);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(60, 22);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(60, 20);
            this.tb1.TabIndex = 1;
            this.tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(60, 83);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(60, 20);
            this.tb2.TabIndex = 2;
            // 
            // rbsoma
            // 
            this.rbsoma.AutoSize = true;
            this.rbsoma.Checked = true;
            this.rbsoma.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.rbsoma.Location = new System.Drawing.Point(208, 34);
            this.rbsoma.Name = "rbsoma";
            this.rbsoma.Size = new System.Drawing.Size(73, 21);
            this.rbsoma.TabIndex = 3;
            this.rbsoma.TabStop = true;
            this.rbsoma.Text = "Somar";
            this.rbsoma.UseVisualStyleBackColor = true;
            this.rbsoma.CheckedChanged += new System.EventHandler(this.rbsoma_CheckedChanged);
            // 
            // rbsubtrair
            // 
            this.rbsubtrair.AutoSize = true;
            this.rbsubtrair.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.rbsubtrair.Location = new System.Drawing.Point(208, 63);
            this.rbsubtrair.Name = "rbsubtrair";
            this.rbsubtrair.Size = new System.Drawing.Size(92, 21);
            this.rbsubtrair.TabIndex = 4;
            this.rbsubtrair.Text = "Subtrair";
            this.rbsubtrair.UseVisualStyleBackColor = true;
            this.rbsubtrair.CheckedChanged += new System.EventHandler(this.rbsubtrair_CheckedChanged);
            // 
            // rbdivisao
            // 
            this.rbdivisao.AutoSize = true;
            this.rbdivisao.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.rbdivisao.Location = new System.Drawing.Point(208, 96);
            this.rbdivisao.Name = "rbdivisao";
            this.rbdivisao.Size = new System.Drawing.Size(74, 21);
            this.rbdivisao.TabIndex = 5;
            this.rbdivisao.Text = "Dividir";
            this.rbdivisao.UseVisualStyleBackColor = true;
            this.rbdivisao.CheckedChanged += new System.EventHandler(this.rbdivisao_CheckedChanged);
            // 
            // rbmultiplica
            // 
            this.rbmultiplica.AutoSize = true;
            this.rbmultiplica.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.rbmultiplica.Location = new System.Drawing.Point(208, 130);
            this.rbmultiplica.Name = "rbmultiplica";
            this.rbmultiplica.Size = new System.Drawing.Size(126, 21);
            this.rbmultiplica.TabIndex = 6;
            this.rbmultiplica.Text = "Multiplicaçao";
            this.rbmultiplica.UseVisualStyleBackColor = true;
            this.rbmultiplica.CheckedChanged += new System.EventHandler(this.rbmultiplica_CheckedChanged);
            // 
            // tbresultado
            // 
            this.tbresultado.Location = new System.Drawing.Point(110, 150);
            this.tbresultado.Name = "tbresultado";
            this.tbresultado.Size = new System.Drawing.Size(60, 20);
            this.tbresultado.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label1.Location = new System.Drawing.Point(14, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultado :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Num1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label3.Location = new System.Drawing.Point(1, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Num2:";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbresultado);
            this.Controls.Add(this.rbmultiplica);
            this.Controls.Add(this.rbdivisao);
            this.Controls.Add(this.rbsubtrair);
            this.Controls.Add(this.rbsoma);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btncalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.RadioButton rbsoma;
        private System.Windows.Forms.RadioButton rbsubtrair;
        private System.Windows.Forms.RadioButton rbdivisao;
        private System.Windows.Forms.RadioButton rbmultiplica;
        private System.Windows.Forms.TextBox tbresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

