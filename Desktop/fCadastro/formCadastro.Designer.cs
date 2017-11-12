namespace Desktop.fCadastro
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.txt_Nome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Senha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.txt_CurDep = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnVoltar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txt_Nome, "txt_Nome");
            this.txt_Nome.Depth = 0;
            this.txt_Nome.Hint = "Nome Completo";
            this.txt_Nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.PasswordChar = '\0';
            this.txt_Nome.SelectedText = "";
            this.txt_Nome.SelectionLength = 0;
            this.txt_Nome.SelectionStart = 0;
            this.txt_Nome.TabStop = false;
            this.txt_Nome.UseSystemPasswordChar = false;
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txt_Id, "txt_Id");
            this.txt_Id.Depth = 0;
            this.txt_Id.Hint = "Identificação (RA, Registro, etc)";
            this.txt_Id.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.PasswordChar = '\0';
            this.txt_Id.SelectedText = "";
            this.txt_Id.SelectionLength = 0;
            this.txt_Id.SelectionStart = 0;
            this.txt_Id.TabStop = false;
            this.txt_Id.UseSystemPasswordChar = false;
            // 
            // txt_Senha
            // 
            this.txt_Senha.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txt_Senha, "txt_Senha");
            this.txt_Senha.Depth = 0;
            this.txt_Senha.Hint = "Senha";
            this.txt_Senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.SelectedText = "";
            this.txt_Senha.SelectionLength = 0;
            this.txt_Senha.SelectionStart = 0;
            this.txt_Senha.TabStop = false;
            this.txt_Senha.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            resources.ApplyResources(this.materialDivider1, "materialDivider1");
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxGrupo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.comboBoxGrupo.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxGrupo, "comboBoxGrupo");
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupo_SelectedIndexChanged);
            // 
            // txt_CurDep
            // 
            this.txt_CurDep.Depth = 0;
            this.txt_CurDep.Hint = "";
            resources.ApplyResources(this.txt_CurDep, "txt_CurDep");
            this.txt_CurDep.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_CurDep.Name = "txt_CurDep";
            this.txt_CurDep.PasswordChar = '\0';
            this.txt_CurDep.SelectedText = "";
            this.txt_CurDep.SelectionLength = 0;
            this.txt_CurDep.SelectionStart = 0;
            this.txt_CurDep.UseSystemPasswordChar = false;
            // 
            // btnVoltar
            // 
            resources.ApplyResources(this.btnVoltar, "btnVoltar");
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = false;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Depth = 0;
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Primary = true;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Cadastro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txt_CurDep);
            this.Controls.Add(this.comboBoxGrupo);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_Nome);
            this.Name = "Cadastro";
            this.Load += new System.EventHandler(this.formCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Nome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Id;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Senha;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ComboBox comboBoxGrupo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_CurDep;
        private MaterialSkin.Controls.MaterialFlatButton btnVoltar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrar;
    }
}