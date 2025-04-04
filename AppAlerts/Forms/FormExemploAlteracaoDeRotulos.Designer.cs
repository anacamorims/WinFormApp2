namespace AppAlerts.Forms
{
    partial class FormExemploAlteracaoDeRotulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSalarioAtual = new System.Windows.Forms.TextBox();
            this.textPerceReajuste = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textSalReajustado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "REAJUSTE SALARIAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SALÁRIO ATUAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PERC(%) REAJUSTE:";
            // 
            // textSalarioAtual
            // 
            this.textSalarioAtual.Location = new System.Drawing.Point(240, 115);
            this.textSalarioAtual.Name = "textSalarioAtual";
            this.textSalarioAtual.Size = new System.Drawing.Size(229, 20);
            this.textSalarioAtual.TabIndex = 3;
            // 
            // textPerceReajuste
            // 
            this.textPerceReajuste.Location = new System.Drawing.Point(240, 202);
            this.textPerceReajuste.Name = "textPerceReajuste";
            this.textPerceReajuste.Size = new System.Drawing.Size(229, 20);
            this.textPerceReajuste.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(240, 258);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 32);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(384, 258);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 32);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "SALÁRIO REAJUSTADO:";
            // 
            // textSalReajustado
            // 
            this.textSalReajustado.Location = new System.Drawing.Point(240, 375);
            this.textSalReajustado.Name = "textSalReajustado";
            this.textSalReajustado.Size = new System.Drawing.Size(229, 20);
            this.textSalReajustado.TabIndex = 8;
            // 
            // FormExemploAlteracaoDeRotulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textSalReajustado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textPerceReajuste);
            this.Controls.Add(this.textSalarioAtual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormExemploAlteracaoDeRotulos";
            this.Text = "FormExemploAlteracaoDeRotulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSalarioAtual;
        private System.Windows.Forms.TextBox textPerceReajuste;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSalReajustado;
    }
}