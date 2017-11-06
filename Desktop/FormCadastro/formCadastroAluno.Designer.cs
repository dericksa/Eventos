namespace FormCadastro
{
    partial class formCadastroAluno
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
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textRA = new System.Windows.Forms.TextBox();
            this.textCurso = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.labelWarn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(24, 85);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(79, 82);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(216, 20);
            this.textNome.TabIndex = 4;
            // 
            // textRA
            // 
            this.textRA.Location = new System.Drawing.Point(79, 115);
            this.textRA.Name = "textRA";
            this.textRA.Size = new System.Drawing.Size(130, 20);
            this.textRA.TabIndex = 5;
            // 
            // textCurso
            // 
            this.textCurso.Location = new System.Drawing.Point(79, 151);
            this.textCurso.Name = "textCurso";
            this.textCurso.Size = new System.Drawing.Size(216, 20);
            this.textCurso.TabIndex = 6;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(79, 181);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(173, 20);
            this.textSenha.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(202, 247);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // labelWarn
            // 
            this.labelWarn.AutoSize = true;
            this.labelWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarn.ForeColor = System.Drawing.Color.Red;
            this.labelWarn.Location = new System.Drawing.Point(114, 31);
            this.labelWarn.Name = "labelWarn";
            this.labelWarn.Size = new System.Drawing.Size(60, 24);
            this.labelWarn.TabIndex = 9;
            this.labelWarn.Text = "label4";
            this.labelWarn.Visible = false;
            this.labelWarn.Click += new System.EventHandler(this.labelWarn_Click);
            // 
            // formCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 300);
            this.Controls.Add(this.labelWarn);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textCurso);
            this.Controls.Add(this.textRA);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNome);
            this.Name = "formCadastroAluno";
            this.Text = "formCadastroAluno";
            this.Load += new System.EventHandler(this.formCadastroAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textRA;
        private System.Windows.Forms.TextBox textCurso;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label labelWarn;
    }
}