namespace Banco.View {
    partial class TelaPlano {
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPremiun = new System.Windows.Forms.RadioButton();
            this.radioEssencial = new System.Windows.Forms.RadioButton();
            this.radioBasico = new System.Windows.Forms.RadioButton();
            this.txtPlanoInformation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha seu Plano";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPremiun);
            this.groupBox1.Controls.Add(this.radioEssencial);
            this.groupBox1.Controls.Add(this.radioBasico);
            this.groupBox1.Location = new System.Drawing.Point(60, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioPremiun
            // 
            this.radioPremiun.AutoSize = true;
            this.radioPremiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPremiun.Location = new System.Drawing.Point(582, 19);
            this.radioPremiun.Name = "radioPremiun";
            this.radioPremiun.Size = new System.Drawing.Size(116, 29);
            this.radioPremiun.TabIndex = 3;
            this.radioPremiun.TabStop = true;
            this.radioPremiun.Text = "Premiun";
            this.radioPremiun.UseVisualStyleBackColor = true;
            this.radioPremiun.CheckedChanged += new System.EventHandler(this.radioPremiun_CheckedChanged);
            // 
            // radioEssencial
            // 
            this.radioEssencial.AutoSize = true;
            this.radioEssencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEssencial.Location = new System.Drawing.Point(279, 19);
            this.radioEssencial.Name = "radioEssencial";
            this.radioEssencial.Size = new System.Drawing.Size(132, 29);
            this.radioEssencial.TabIndex = 3;
            this.radioEssencial.TabStop = true;
            this.radioEssencial.Text = "Essencial";
            this.radioEssencial.UseVisualStyleBackColor = true;
            this.radioEssencial.CheckedChanged += new System.EventHandler(this.radioEssencial_CheckedChanged);
            // 
            // radioBasico
            // 
            this.radioBasico.AutoSize = true;
            this.radioBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBasico.Location = new System.Drawing.Point(6, 19);
            this.radioBasico.Name = "radioBasico";
            this.radioBasico.Size = new System.Drawing.Size(101, 29);
            this.radioBasico.TabIndex = 0;
            this.radioBasico.TabStop = true;
            this.radioBasico.Text = "Basico";
            this.radioBasico.UseVisualStyleBackColor = true;
            this.radioBasico.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtPlanoInformation
            // 
            this.txtPlanoInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanoInformation.Location = new System.Drawing.Point(60, 168);
            this.txtPlanoInformation.Multiline = true;
            this.txtPlanoInformation.Name = "txtPlanoInformation";
            this.txtPlanoInformation.Size = new System.Drawing.Size(698, 267);
            this.txtPlanoInformation.TabIndex = 3;
            this.txtPlanoInformation.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(359, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaPlano
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPlanoInformation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPlano";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBasico;
        private System.Windows.Forms.RadioButton radioPremiun;
        private System.Windows.Forms.RadioButton radioEssencial;
        private System.Windows.Forms.TextBox txtPlanoInformation;
        private System.Windows.Forms.Button button1;
    }
}