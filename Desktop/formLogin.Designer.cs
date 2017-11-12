namespace Login
{
    partial class Login
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
            this.txt_Login = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Senha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnConectar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCadastro = new System.Windows.Forms.LinkLabel();
            this.err_Code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Login
            // 
            this.txt_Login.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Login.Depth = 0;
            this.txt_Login.Hint = "Identificacao";
            this.txt_Login.Location = new System.Drawing.Point(12, 107);
            this.txt_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.PasswordChar = '\0';
            this.txt_Login.SelectedText = "";
            this.txt_Login.SelectionLength = 0;
            this.txt_Login.SelectionStart = 0;
            this.txt_Login.Size = new System.Drawing.Size(271, 23);
            this.txt_Login.TabIndex = 0;
            this.txt_Login.UseSystemPasswordChar = false;
            this.txt_Login.Click += new System.EventHandler(this.txt_Login_Click);
            // 
            // txt_Senha
            // 
            this.txt_Senha.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Senha.Depth = 0;
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Hint = "Senha";
            this.txt_Senha.Location = new System.Drawing.Point(12, 145);
            this.txt_Senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.SelectedText = "";
            this.txt_Senha.SelectionLength = 0;
            this.txt_Senha.SelectionStart = 0;
            this.txt_Senha.Size = new System.Drawing.Size(271, 23);
            this.txt_Senha.TabIndex = 1;
            this.txt_Senha.TabStop = false;
            this.txt_Senha.UseSystemPasswordChar = false;
            // 
            // btnConectar
            // 
            this.btnConectar.Depth = 0;
            this.btnConectar.Location = new System.Drawing.Point(12, 207);
            this.btnConectar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Primary = true;
            this.btnConectar.Size = new System.Drawing.Size(271, 32);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Login";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click_1);
            // 
            // btnCadastro
            // 
            this.btnCadastro.AutoSize = true;
            this.btnCadastro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.LinkColor = System.Drawing.Color.Gray;
            this.btnCadastro.Location = new System.Drawing.Point(9, 254);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(160, 14);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.TabStop = true;
            this.btnCadastro.Text = "Não tem conta? Cadastre-se";
            this.btnCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // err_Code
            // 
            this.err_Code.AutoSize = true;
            this.err_Code.BackColor = System.Drawing.SystemColors.Window;
            this.err_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_Code.ForeColor = System.Drawing.Color.Red;
            this.err_Code.Location = new System.Drawing.Point(12, 89);
            this.err_Code.Name = "err_Code";
            this.err_Code.Size = new System.Drawing.Size(58, 15);
            this.err_Code.TabIndex = 4;
            this.err_Code.Text = "err_Code";
            this.err_Code.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(295, 294);
            this.Controls.Add(this.err_Code);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Login);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Login;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Senha;
        private MaterialSkin.Controls.MaterialRaisedButton btnConectar;
        private System.Windows.Forms.LinkLabel btnCadastro;
        private System.Windows.Forms.Label err_Code;
    }
}