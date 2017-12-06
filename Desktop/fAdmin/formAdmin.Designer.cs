namespace Desktop.fAdmin
{
    partial class form_Adm
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
            this.grp_Perm = new System.Windows.Forms.GroupBox();
            this.box_Perm = new System.Windows.Forms.ComboBox();
            this.btn_Perm = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_ID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.box_Cert = new System.Windows.Forms.GroupBox();
            this.btn_Cert = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_IdEvCert = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_id_Cert = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_LeituraEv = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_Confirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_LeituraId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grp_Palestra = new System.Windows.Forms.GroupBox();
            this.txt_localeditar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_desceditar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_ideditar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAprovar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grp_Palestras_Add = new System.Windows.Forms.GroupBox();
            this.box_Palestras = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.date_EditarPalestra = new System.Windows.Forms.DateTimePicker();
            this.grp_Perm.SuspendLayout();
            this.box_Cert.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_Palestra.SuspendLayout();
            this.grp_Palestras_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Perm
            // 
            this.grp_Perm.BackColor = System.Drawing.SystemColors.Window;
            this.grp_Perm.Controls.Add(this.box_Perm);
            this.grp_Perm.Controls.Add(this.btn_Perm);
            this.grp_Perm.Controls.Add(this.txt_ID);
            this.grp_Perm.Location = new System.Drawing.Point(12, 124);
            this.grp_Perm.Name = "grp_Perm";
            this.grp_Perm.Size = new System.Drawing.Size(196, 164);
            this.grp_Perm.TabIndex = 0;
            this.grp_Perm.TabStop = false;
            this.grp_Perm.Text = "Permissões";
            // 
            // box_Perm
            // 
            this.box_Perm.FormattingEnabled = true;
            this.box_Perm.Location = new System.Drawing.Point(18, 76);
            this.box_Perm.Name = "box_Perm";
            this.box_Perm.Size = new System.Drawing.Size(166, 21);
            this.box_Perm.TabIndex = 2;
            this.box_Perm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_Perm
            // 
            this.btn_Perm.Depth = 0;
            this.btn_Perm.Location = new System.Drawing.Point(42, 118);
            this.btn_Perm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Perm.Name = "btn_Perm";
            this.btn_Perm.Primary = true;
            this.btn_Perm.Size = new System.Drawing.Size(103, 23);
            this.btn_Perm.TabIndex = 1;
            this.btn_Perm.Text = "Alterar";
            this.btn_Perm.UseVisualStyleBackColor = true;
            this.btn_Perm.Click += new System.EventHandler(this.btn_Perm_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Depth = 0;
            this.txt_ID.Hint = "ID do Usuário";
            this.txt_ID.Location = new System.Drawing.Point(18, 36);
            this.txt_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PasswordChar = '\0';
            this.txt_ID.SelectedText = "";
            this.txt_ID.SelectionLength = 0;
            this.txt_ID.SelectionStart = 0;
            this.txt_ID.Size = new System.Drawing.Size(166, 23);
            this.txt_ID.TabIndex = 0;
            this.txt_ID.UseSystemPasswordChar = false;
            // 
            // box_Cert
            // 
            this.box_Cert.BackColor = System.Drawing.SystemColors.Window;
            this.box_Cert.Controls.Add(this.btn_Cert);
            this.box_Cert.Controls.Add(this.txt_IdEvCert);
            this.box_Cert.Controls.Add(this.txt_id_Cert);
            this.box_Cert.Location = new System.Drawing.Point(12, 294);
            this.box_Cert.Name = "box_Cert";
            this.box_Cert.Size = new System.Drawing.Size(200, 156);
            this.box_Cert.TabIndex = 1;
            this.box_Cert.TabStop = false;
            this.box_Cert.Text = "Certificados";
            // 
            // btn_Cert
            // 
            this.btn_Cert.Depth = 0;
            this.btn_Cert.Location = new System.Drawing.Point(53, 117);
            this.btn_Cert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cert.Name = "btn_Cert";
            this.btn_Cert.Primary = true;
            this.btn_Cert.Size = new System.Drawing.Size(75, 23);
            this.btn_Cert.TabIndex = 5;
            this.btn_Cert.Text = "Gerar ";
            this.btn_Cert.UseVisualStyleBackColor = true;
            this.btn_Cert.Click += new System.EventHandler(this.btn_Cert_Click);
            // 
            // txt_IdEvCert
            // 
            this.txt_IdEvCert.Depth = 0;
            this.txt_IdEvCert.Hint = "ID do Evento";
            this.txt_IdEvCert.Location = new System.Drawing.Point(18, 78);
            this.txt_IdEvCert.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_IdEvCert.Name = "txt_IdEvCert";
            this.txt_IdEvCert.PasswordChar = '\0';
            this.txt_IdEvCert.SelectedText = "";
            this.txt_IdEvCert.SelectionLength = 0;
            this.txt_IdEvCert.SelectionStart = 0;
            this.txt_IdEvCert.Size = new System.Drawing.Size(166, 23);
            this.txt_IdEvCert.TabIndex = 4;
            this.txt_IdEvCert.UseSystemPasswordChar = false;
            // 
            // txt_id_Cert
            // 
            this.txt_id_Cert.Depth = 0;
            this.txt_id_Cert.Hint = "ID do Usuário";
            this.txt_id_Cert.Location = new System.Drawing.Point(18, 40);
            this.txt_id_Cert.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_id_Cert.Name = "txt_id_Cert";
            this.txt_id_Cert.PasswordChar = '\0';
            this.txt_id_Cert.SelectedText = "";
            this.txt_id_Cert.SelectionLength = 0;
            this.txt_id_Cert.SelectionStart = 0;
            this.txt_id_Cert.Size = new System.Drawing.Size(166, 23);
            this.txt_id_Cert.TabIndex = 3;
            this.txt_id_Cert.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txt_LeituraEv);
            this.groupBox1.Controls.Add(this.btn_Confirmar);
            this.groupBox1.Controls.Add(this.txt_LeituraId);
            this.groupBox1.Location = new System.Drawing.Point(12, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presença";
            // 
            // txt_LeituraEv
            // 
            this.txt_LeituraEv.Depth = 0;
            this.txt_LeituraEv.Hint = "ID do Evento";
            this.txt_LeituraEv.Location = new System.Drawing.Point(18, 80);
            this.txt_LeituraEv.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_LeituraEv.Name = "txt_LeituraEv";
            this.txt_LeituraEv.PasswordChar = '\0';
            this.txt_LeituraEv.SelectedText = "";
            this.txt_LeituraEv.SelectionLength = 0;
            this.txt_LeituraEv.SelectionStart = 0;
            this.txt_LeituraEv.Size = new System.Drawing.Size(166, 23);
            this.txt_LeituraEv.TabIndex = 6;
            this.txt_LeituraEv.UseSystemPasswordChar = false;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Depth = 0;
            this.btn_Confirmar.Location = new System.Drawing.Point(42, 125);
            this.btn_Confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Primary = true;
            this.btn_Confirmar.Size = new System.Drawing.Size(92, 23);
            this.btn_Confirmar.TabIndex = 6;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // txt_LeituraId
            // 
            this.txt_LeituraId.Depth = 0;
            this.txt_LeituraId.Hint = "Leitura do ID";
            this.txt_LeituraId.Location = new System.Drawing.Point(18, 38);
            this.txt_LeituraId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_LeituraId.Name = "txt_LeituraId";
            this.txt_LeituraId.PasswordChar = '\0';
            this.txt_LeituraId.SelectedText = "";
            this.txt_LeituraId.SelectionLength = 0;
            this.txt_LeituraId.SelectionStart = 0;
            this.txt_LeituraId.Size = new System.Drawing.Size(154, 23);
            this.txt_LeituraId.TabIndex = 0;
            this.txt_LeituraId.UseSystemPasswordChar = false;
            // 
            // grp_Palestra
            // 
            this.grp_Palestra.BackColor = System.Drawing.SystemColors.Window;
            this.grp_Palestra.Controls.Add(this.date_EditarPalestra);
            this.grp_Palestra.Controls.Add(this.txt_localeditar);
            this.grp_Palestra.Controls.Add(this.materialRaisedButton1);
            this.grp_Palestra.Controls.Add(this.txt_desceditar);
            this.grp_Palestra.Controls.Add(this.txt_ideditar);
            this.grp_Palestra.Location = new System.Drawing.Point(221, 411);
            this.grp_Palestra.Name = "grp_Palestra";
            this.grp_Palestra.Size = new System.Drawing.Size(211, 255);
            this.grp_Palestra.TabIndex = 3;
            this.grp_Palestra.TabStop = false;
            this.grp_Palestra.Text = "Editar Palestra";
            this.grp_Palestra.Enter += new System.EventHandler(this.grp_Palestra_Enter);
            // 
            // txt_localeditar
            // 
            this.txt_localeditar.AllowDrop = true;
            this.txt_localeditar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_localeditar.Depth = 0;
            this.txt_localeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_localeditar.Hint = "Local";
            this.txt_localeditar.Location = new System.Drawing.Point(21, 74);
            this.txt_localeditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_localeditar.Name = "txt_localeditar";
            this.txt_localeditar.PasswordChar = '\0';
            this.txt_localeditar.SelectedText = "";
            this.txt_localeditar.SelectionLength = 0;
            this.txt_localeditar.SelectionStart = 0;
            this.txt_localeditar.Size = new System.Drawing.Size(166, 23);
            this.txt_localeditar.TabIndex = 23;
            this.txt_localeditar.TabStop = false;
            this.txt_localeditar.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(49, 209);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(103, 23);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Alterar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // txt_desceditar
            // 
            this.txt_desceditar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_desceditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_desceditar.Depth = 0;
            this.txt_desceditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_desceditar.Hint = "Descrição";
            this.txt_desceditar.Location = new System.Drawing.Point(21, 114);
            this.txt_desceditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_desceditar.Name = "txt_desceditar";
            this.txt_desceditar.PasswordChar = '\0';
            this.txt_desceditar.SelectedText = "";
            this.txt_desceditar.SelectionLength = 0;
            this.txt_desceditar.SelectionStart = 0;
            this.txt_desceditar.Size = new System.Drawing.Size(166, 23);
            this.txt_desceditar.TabIndex = 24;
            this.txt_desceditar.TabStop = false;
            this.txt_desceditar.UseSystemPasswordChar = false;
            // 
            // txt_ideditar
            // 
            this.txt_ideditar.Depth = 0;
            this.txt_ideditar.Hint = "ID do Evento";
            this.txt_ideditar.Location = new System.Drawing.Point(21, 36);
            this.txt_ideditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ideditar.Name = "txt_ideditar";
            this.txt_ideditar.PasswordChar = '\0';
            this.txt_ideditar.SelectedText = "";
            this.txt_ideditar.SelectionLength = 0;
            this.txt_ideditar.SelectionStart = 0;
            this.txt_ideditar.Size = new System.Drawing.Size(166, 23);
            this.txt_ideditar.TabIndex = 6;
            this.txt_ideditar.UseSystemPasswordChar = false;
            // 
            // btnAprovar
            // 
            this.btnAprovar.Depth = 0;
            this.btnAprovar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAprovar.Location = new System.Drawing.Point(37, 117);
            this.btnAprovar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Primary = true;
            this.btnAprovar.Size = new System.Drawing.Size(115, 25);
            this.btnAprovar.TabIndex = 21;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = true;
            this.btnAprovar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grp_Palestras_Add
            // 
            this.grp_Palestras_Add.BackColor = System.Drawing.SystemColors.Window;
            this.grp_Palestras_Add.Controls.Add(this.box_Palestras);
            this.grp_Palestras_Add.Controls.Add(this.btnAprovar);
            this.grp_Palestras_Add.Location = new System.Drawing.Point(221, 124);
            this.grp_Palestras_Add.Name = "grp_Palestras_Add";
            this.grp_Palestras_Add.Size = new System.Drawing.Size(211, 164);
            this.grp_Palestras_Add.TabIndex = 23;
            this.grp_Palestras_Add.TabStop = false;
            this.grp_Palestras_Add.Text = "Aprovar Palestra";
            // 
            // box_Palestras
            // 
            this.box_Palestras.FormattingEnabled = true;
            this.box_Palestras.Location = new System.Drawing.Point(37, 49);
            this.box_Palestras.Name = "box_Palestras";
            this.box_Palestras.Size = new System.Drawing.Size(121, 21);
            this.box_Palestras.TabIndex = 22;
            this.box_Palestras.SelectedIndexChanged += new System.EventHandler(this.box_Palestras_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(377, 68);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = false;
            this.btnVoltar.Size = new System.Drawing.Size(64, 36);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 103);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(502, 1);
            this.materialDivider1.TabIndex = 24;
            // 
            // date_EditarPalestra
            // 
            this.date_EditarPalestra.Location = new System.Drawing.Point(21, 169);
            this.date_EditarPalestra.Name = "date_EditarPalestra";
            this.date_EditarPalestra.Size = new System.Drawing.Size(166, 20);
            this.date_EditarPalestra.TabIndex = 25;
            // 
            // form_Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 673);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.grp_Palestras_Add);
            this.Controls.Add(this.grp_Palestra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.box_Cert);
            this.Controls.Add(this.grp_Perm);
            this.Name = "form_Adm";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.formAdmin_Load);
            this.grp_Perm.ResumeLayout(false);
            this.box_Cert.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grp_Palestra.ResumeLayout(false);
            this.grp_Palestras_Add.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Perm;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Perm;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ID;
        private System.Windows.Forms.ComboBox box_Perm;
        private System.Windows.Forms.GroupBox box_Cert;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Cert;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_IdEvCert;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_id_Cert;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Confirmar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_LeituraId;
        private System.Windows.Forms.GroupBox grp_Palestra;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ideditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAprovar;
        private System.Windows.Forms.GroupBox grp_Palestras_Add;
        private MaterialSkin.Controls.MaterialFlatButton btnVoltar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_localeditar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_desceditar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_LeituraEv;
        private System.Windows.Forms.ComboBox box_Palestras;
        private System.Windows.Forms.DateTimePicker date_EditarPalestra;
    }
}