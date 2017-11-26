namespace Desktop.fPrograma
{
    partial class CadastroReuniao
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
            this.btnVoltar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txt_Local = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Desc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.evt_Data = new System.Windows.Forms.DateTimePicker();
            this.Label_data = new MaterialSkin.Controls.MaterialLabel();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_Convidado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(221, 66);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = false;
            this.btnVoltar.Size = new System.Drawing.Size(64, 36);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(3, 103);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(282, 1);
            this.materialDivider1.TabIndex = 9;
            // 
            // txt_Local
            // 
            this.txt_Local.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Local.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Local.Depth = 0;
            this.txt_Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Local.Hint = "Local";
            this.txt_Local.Location = new System.Drawing.Point(12, 125);
            this.txt_Local.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Local.Name = "txt_Local";
            this.txt_Local.PasswordChar = '\0';
            this.txt_Local.SelectedText = "";
            this.txt_Local.SelectionLength = 0;
            this.txt_Local.SelectionStart = 0;
            this.txt_Local.Size = new System.Drawing.Size(260, 23);
            this.txt_Local.TabIndex = 11;
            this.txt_Local.TabStop = false;
            this.txt_Local.UseSystemPasswordChar = false;
            // 
            // txt_Desc
            // 
            this.txt_Desc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Desc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Desc.Depth = 0;
            this.txt_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Desc.Hint = "Descrição";
            this.txt_Desc.Location = new System.Drawing.Point(12, 164);
            this.txt_Desc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.PasswordChar = '\0';
            this.txt_Desc.SelectedText = "";
            this.txt_Desc.SelectionLength = 0;
            this.txt_Desc.SelectionStart = 0;
            this.txt_Desc.Size = new System.Drawing.Size(260, 23);
            this.txt_Desc.TabIndex = 12;
            this.txt_Desc.TabStop = false;
            this.txt_Desc.UseSystemPasswordChar = false;
            // 
            // evt_Data
            // 
            this.evt_Data.Location = new System.Drawing.Point(12, 258);
            this.evt_Data.Name = "evt_Data";
            this.evt_Data.Size = new System.Drawing.Size(200, 20);
            this.evt_Data.TabIndex = 13;
            // 
            // Label_data
            // 
            this.Label_data.AutoSize = true;
            this.Label_data.BackColor = System.Drawing.SystemColors.Control;
            this.Label_data.Depth = 0;
            this.Label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Label_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_data.Location = new System.Drawing.Point(12, 242);
            this.Label_data.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_data.Name = "Label_data";
            this.Label_data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_data.Size = new System.Drawing.Size(82, 13);
            this.Label_data.TabIndex = 14;
            this.Label_data.Text = "Data do Evento";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 302);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Primary = true;
            this.btnCadastrar.Size = new System.Drawing.Size(260, 36);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txt_Convidado
            // 
            this.txt_Convidado.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Convidado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Convidado.Depth = 0;
            this.txt_Convidado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Convidado.Hint = "Convidado";
            this.txt_Convidado.Location = new System.Drawing.Point(12, 203);
            this.txt_Convidado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Convidado.Name = "txt_Convidado";
            this.txt_Convidado.PasswordChar = '\0';
            this.txt_Convidado.SelectedText = "";
            this.txt_Convidado.SelectionLength = 0;
            this.txt_Convidado.SelectionStart = 0;
            this.txt_Convidado.Size = new System.Drawing.Size(260, 23);
            this.txt_Convidado.TabIndex = 16;
            this.txt_Convidado.TabStop = false;
            this.txt_Convidado.UseSystemPasswordChar = false;
            // 
            // CadastroReuniao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 368);
            this.Controls.Add(this.txt_Convidado);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.Label_data);
            this.Controls.Add(this.evt_Data);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.txt_Local);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.materialDivider1);
            this.Name = "CadastroReuniao";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.CadastroReuniao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnVoltar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Local;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Desc;
        private System.Windows.Forms.DateTimePicker evt_Data;
        private MaterialSkin.Controls.MaterialLabel Label_data;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Convidado;
    }
}