namespace Desktop.fPrograma
{
    partial class TelaInicial
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
            this.tab_Inicial = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SeletorTab = new MaterialSkin.Controls.MaterialTabSelector();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tab_Inicial.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Inicial
            // 
            this.tab_Inicial.Controls.Add(this.tabPage1);
            this.tab_Inicial.Controls.Add(this.tabPage2);
            this.tab_Inicial.Depth = 0;
            this.tab_Inicial.Location = new System.Drawing.Point(0, 103);
            this.tab_Inicial.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_Inicial.Name = "tab_Inicial";
            this.tab_Inicial.SelectedIndex = 0;
            this.tab_Inicial.Size = new System.Drawing.Size(802, 498);
            this.tab_Inicial.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Eventos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reuniões";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SeletorTab
            // 
            this.SeletorTab.BaseTabControl = this.tab_Inicial;
            this.SeletorTab.Depth = 0;
            this.SeletorTab.Location = new System.Drawing.Point(-11, 62);
            this.SeletorTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.SeletorTab.Name = "SeletorTab";
            this.SeletorTab.Size = new System.Drawing.Size(813, 35);
            this.SeletorTab.TabIndex = 1;
            this.SeletorTab.Click += new System.EventHandler(this.SeletorTab_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minhas Reuniões";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(414, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reuniões ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.SeletorTab);
            this.Controls.Add(this.tab_Inicial);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.tab_Inicial.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tab_Inicial;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector SeletorTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}