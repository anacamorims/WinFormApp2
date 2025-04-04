namespace AppAlerts
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlerta = new System.Windows.Forms.Button();
            this.btnExAlert = new System.Windows.Forms.Button();
            this.btnExAltRot = new System.Windows.Forms.Button();
            this.btnExCombobox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU DE OPÇÕES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAlerta
            // 
            this.btnAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlerta.Location = new System.Drawing.Point(194, 101);
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Size = new System.Drawing.Size(403, 33);
            this.btnAlerta.TabIndex = 1;
            this.btnAlerta.Text = "ALERTAS";
            this.btnAlerta.UseVisualStyleBackColor = true;
            this.btnAlerta.Click += new System.EventHandler(this.btnAlerta_Click);
            // 
            // btnExAlert
            // 
            this.btnExAlert.BackColor = System.Drawing.Color.Salmon;
            this.btnExAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExAlert.Location = new System.Drawing.Point(194, 174);
            this.btnExAlert.Name = "btnExAlert";
            this.btnExAlert.Size = new System.Drawing.Size(403, 33);
            this.btnExAlert.TabIndex = 2;
            this.btnExAlert.Text = "EXEMPLO COM ALERTA";
            this.btnExAlert.UseVisualStyleBackColor = false;
            this.btnExAlert.Click += new System.EventHandler(this.btnExAlert_Click);
            // 
            // btnExAltRot
            // 
            this.btnExAltRot.BackColor = System.Drawing.Color.YellowGreen;
            this.btnExAltRot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExAltRot.Location = new System.Drawing.Point(194, 252);
            this.btnExAltRot.Name = "btnExAltRot";
            this.btnExAltRot.Size = new System.Drawing.Size(403, 33);
            this.btnExAltRot.TabIndex = 3;
            this.btnExAltRot.Text = "EXEMPLO ALTERAÇÃO DE RÓTULO";
            this.btnExAltRot.UseVisualStyleBackColor = false;
            this.btnExAltRot.Click += new System.EventHandler(this.btnExAltRot_Click);
            // 
            // btnExCombobox
            // 
            this.btnExCombobox.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExCombobox.Location = new System.Drawing.Point(194, 332);
            this.btnExCombobox.Name = "btnExCombobox";
            this.btnExCombobox.Size = new System.Drawing.Size(403, 33);
            this.btnExCombobox.TabIndex = 4;
            this.btnExCombobox.Text = "EXEMPLO COM COMBOBOX";
            this.btnExCombobox.UseVisualStyleBackColor = false;
            this.btnExCombobox.Click += new System.EventHandler(this.btnExCombobox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExCombobox);
            this.Controls.Add(this.btnExAltRot);
            this.Controls.Add(this.btnExAlert);
            this.Controls.Add(this.btnAlerta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlerta;
        private System.Windows.Forms.Button btnExAlert;
        private System.Windows.Forms.Button btnExAltRot;
        private System.Windows.Forms.Button btnExCombobox;
    }
}

