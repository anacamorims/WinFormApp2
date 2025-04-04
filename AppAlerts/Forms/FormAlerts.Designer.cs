namespace AppAlerts.Forms
{
    partial class FormAlerts
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAtencao = new System.Windows.Forms.Button();
            this.btnErro = new System.Windows.Forms.Button();
            this.btnPergunta = new System.Windows.Forms.Button();
            this.btnExemplo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALERTAS DE INTERAÇÃO COM USUÁRIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(222, 103);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(325, 35);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "INFORMAÇÃO";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAtencao
            // 
            this.btnAtencao.BackColor = System.Drawing.Color.Orange;
            this.btnAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtencao.Location = new System.Drawing.Point(222, 164);
            this.btnAtencao.Name = "btnAtencao";
            this.btnAtencao.Size = new System.Drawing.Size(325, 35);
            this.btnAtencao.TabIndex = 2;
            this.btnAtencao.Text = "ATENÇÃO";
            this.btnAtencao.UseVisualStyleBackColor = false;
            this.btnAtencao.Click += new System.EventHandler(this.btnAtencao_Click);
            // 
            // btnErro
            // 
            this.btnErro.BackColor = System.Drawing.Color.Tomato;
            this.btnErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErro.Location = new System.Drawing.Point(222, 228);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(325, 35);
            this.btnErro.TabIndex = 3;
            this.btnErro.Text = "ERRO";
            this.btnErro.UseVisualStyleBackColor = false;
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // btnPergunta
            // 
            this.btnPergunta.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPergunta.Location = new System.Drawing.Point(222, 296);
            this.btnPergunta.Name = "btnPergunta";
            this.btnPergunta.Size = new System.Drawing.Size(325, 35);
            this.btnPergunta.TabIndex = 4;
            this.btnPergunta.Text = "PERGUNTA";
            this.btnPergunta.UseVisualStyleBackColor = false;
            this.btnPergunta.Click += new System.EventHandler(this.btnPergunta_Click);
            // 
            // btnExemplo
            // 
            this.btnExemplo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemplo.Location = new System.Drawing.Point(222, 359);
            this.btnExemplo.Name = "btnExemplo";
            this.btnExemplo.Size = new System.Drawing.Size(325, 35);
            this.btnExemplo.TabIndex = 5;
            this.btnExemplo.Text = "EXEMPLO";
            this.btnExemplo.UseVisualStyleBackColor = false;
            this.btnExemplo.Click += new System.EventHandler(this.btnExemplo_Click);
            // 
            // FormAlerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExemplo);
            this.Controls.Add(this.btnPergunta);
            this.Controls.Add(this.btnErro);
            this.Controls.Add(this.btnAtencao);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.label1);
            this.Name = "FormAlerts";
            this.Text = "FormAlerts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAtencao;
        private System.Windows.Forms.Button btnErro;
        private System.Windows.Forms.Button btnPergunta;
        private System.Windows.Forms.Button btnExemplo;
    }
}