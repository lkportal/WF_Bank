namespace Banco.View {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelPlano = new System.Windows.Forms.Label();
            this.txtDeposita = new System.Windows.Forms.TextBox();
            this.labeD = new System.Windows.Forms.Label();
            this.btnDeposita = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaca = new System.Windows.Forms.Button();
            this.txtSacar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(62, 24);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelSaldo
            // 
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(299, 27);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(198, 104);
            this.labelSaldo.TabIndex = 1;
            this.labelSaldo.Text = "Saldo";
            this.labelSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlano
            // 
            this.labelPlano.AutoSize = true;
            this.labelPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlano.Location = new System.Drawing.Point(12, 59);
            this.labelPlano.Name = "labelPlano";
            this.labelPlano.Size = new System.Drawing.Size(58, 24);
            this.labelPlano.TabIndex = 2;
            this.labelPlano.Text = "Plano";
            // 
            // txtDeposita
            // 
            this.txtDeposita.Location = new System.Drawing.Point(619, 59);
            this.txtDeposita.Name = "txtDeposita";
            this.txtDeposita.Size = new System.Drawing.Size(169, 20);
            this.txtDeposita.TabIndex = 3;
            // 
            // labeD
            // 
            this.labeD.AutoSize = true;
            this.labeD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeD.Location = new System.Drawing.Point(614, 31);
            this.labeD.Name = "labeD";
            this.labeD.Size = new System.Drawing.Size(113, 25);
            this.labeD.TabIndex = 4;
            this.labeD.Text = "Depositar";
            // 
            // btnDeposita
            // 
            this.btnDeposita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposita.Location = new System.Drawing.Point(619, 86);
            this.btnDeposita.Name = "btnDeposita";
            this.btnDeposita.Size = new System.Drawing.Size(83, 23);
            this.btnDeposita.TabIndex = 5;
            this.btnDeposita.Text = "Depositar";
            this.btnDeposita.UseVisualStyleBackColor = true;
            this.btnDeposita.Click += new System.EventHandler(this.btnDeposita_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(614, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sacar";
            // 
            // btnSaca
            // 
            this.btnSaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaca.Location = new System.Drawing.Point(619, 188);
            this.btnSaca.Name = "btnSaca";
            this.btnSaca.Size = new System.Drawing.Size(83, 23);
            this.btnSaca.TabIndex = 8;
            this.btnSaca.Text = "Sacar";
            this.btnSaca.UseVisualStyleBackColor = true;
            this.btnSaca.Click += new System.EventHandler(this.btnSaca_Click);
            // 
            // txtSacar
            // 
            this.txtSacar.Location = new System.Drawing.Point(619, 161);
            this.txtSacar.Name = "txtSacar";
            this.txtSacar.Size = new System.Drawing.Size(169, 20);
            this.txtSacar.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaca);
            this.Controls.Add(this.txtSacar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeposita);
            this.Controls.Add(this.labeD);
            this.Controls.Add(this.txtDeposita);
            this.Controls.Add(this.labelPlano);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelNome);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelPlano;
        private System.Windows.Forms.TextBox txtDeposita;
        private System.Windows.Forms.Label labeD;
        private System.Windows.Forms.Button btnDeposita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaca;
        private System.Windows.Forms.TextBox txtSacar;
    }
}