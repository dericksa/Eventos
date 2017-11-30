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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage Reunioes;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.box_mReunioes = new System.Windows.Forms.GroupBox();
            this.btn_NovoEvento = new MaterialSkin.Controls.MaterialRaisedButton();
            this.data_MeusEventos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canceladoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosDBDataSet1 = new Desktop.EventosDBDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tab_Inicial = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_Eventos = new System.Windows.Forms.TabPage();
            this.reuniaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosDBDataSet = new Desktop.EventosDBDataSet();
            this.SeletorTab = new MaterialSkin.Controls.MaterialTabSelector();
            this.reuniaoTableAdapter = new Desktop.EventosDBDataSetTableAdapters.ReuniaoTableAdapter();
            this.eventoTableAdapter = new Desktop.EventosDBDataSet1TableAdapters.EventoTableAdapter();
            this.btn_Admin = new MaterialSkin.Controls.MaterialFlatButton();
            Reunioes = new System.Windows.Forms.TabPage();
            Reunioes.SuspendLayout();
            this.box_mReunioes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_MeusEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet1)).BeginInit();
            this.tab_Inicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reuniaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Reunioes
            // 
            Reunioes.Controls.Add(this.box_mReunioes);
            Reunioes.Controls.Add(this.groupBox2);
            Reunioes.Location = new System.Drawing.Point(4, 22);
            Reunioes.Name = "Reunioes";
            Reunioes.Padding = new System.Windows.Forms.Padding(3);
            Reunioes.Size = new System.Drawing.Size(794, 548);
            Reunioes.TabIndex = 1;
            Reunioes.Text = "Reuniões";
            Reunioes.UseVisualStyleBackColor = true;
            Reunioes.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // box_mReunioes
            // 
            this.box_mReunioes.Controls.Add(this.btn_NovoEvento);
            this.box_mReunioes.Controls.Add(this.data_MeusEventos);
            this.box_mReunioes.Location = new System.Drawing.Point(3, 28);
            this.box_mReunioes.Name = "box_mReunioes";
            this.box_mReunioes.Size = new System.Drawing.Size(788, 249);
            this.box_mReunioes.TabIndex = 2;
            this.box_mReunioes.TabStop = false;
            this.box_mReunioes.Text = "Minhas Reuniões";
            // 
            // btn_NovoEvento
            // 
            this.btn_NovoEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_NovoEvento.Depth = 0;
            this.btn_NovoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoEvento.Location = new System.Drawing.Point(6, 19);
            this.btn_NovoEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_NovoEvento.Name = "btn_NovoEvento";
            this.btn_NovoEvento.Primary = true;
            this.btn_NovoEvento.Size = new System.Drawing.Size(108, 15);
            this.btn_NovoEvento.TabIndex = 1;
            this.btn_NovoEvento.Text = "Nova Reunião";
            this.btn_NovoEvento.UseVisualStyleBackColor = true;
            this.btn_NovoEvento.Click += new System.EventHandler(this.btn_NovoEvento_Click);
            // 
            // data_MeusEventos
            // 
            this.data_MeusEventos.AllowUserToOrderColumns = true;
            this.data_MeusEventos.AutoGenerateColumns = false;
            this.data_MeusEventos.BackgroundColor = System.Drawing.Color.White;
            this.data_MeusEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_MeusEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_MeusEventos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_MeusEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_MeusEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_MeusEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.criadorDataGridViewTextBoxColumn,
            this.canceladoDataGridViewCheckBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.Descricao,
            this.dataDataGridViewTextBoxColumn,
            this.Cancelar});
            this.data_MeusEventos.DataSource = this.eventoBindingSource;
            this.data_MeusEventos.EnableHeadersVisualStyles = false;
            this.data_MeusEventos.Location = new System.Drawing.Point(37, 50);
            this.data_MeusEventos.Name = "data_MeusEventos";
            this.data_MeusEventos.ReadOnly = true;
            this.data_MeusEventos.Size = new System.Drawing.Size(744, 193);
            this.data_MeusEventos.TabIndex = 0;
            this.data_MeusEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // criadorDataGridViewTextBoxColumn
            // 
            this.criadorDataGridViewTextBoxColumn.DataPropertyName = "Criador";
            this.criadorDataGridViewTextBoxColumn.HeaderText = "Criador";
            this.criadorDataGridViewTextBoxColumn.Name = "criadorDataGridViewTextBoxColumn";
            this.criadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // canceladoDataGridViewCheckBoxColumn
            // 
            this.canceladoDataGridViewCheckBoxColumn.DataPropertyName = "Cancelado";
            this.canceladoDataGridViewCheckBoxColumn.HeaderText = "Cancelado";
            this.canceladoDataGridViewCheckBoxColumn.Name = "canceladoDataGridViewCheckBoxColumn";
            this.canceladoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cancelar
            // 
            this.Cancelar.HeaderText = "Cancelar";
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.ReadOnly = true;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseColumnTextForButtonValue = true;
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataMember = "Evento";
            this.eventoBindingSource.DataSource = this.eventosDBDataSet1;
            // 
            // eventosDBDataSet1
            // 
            this.eventosDBDataSet1.DataSetName = "EventosDBDataSet1";
            this.eventosDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-4, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reuniões ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tab_Inicial
            // 
            this.tab_Inicial.Controls.Add(this.tab_Eventos);
            this.tab_Inicial.Controls.Add(Reunioes);
            this.tab_Inicial.Depth = 0;
            this.tab_Inicial.Location = new System.Drawing.Point(0, 103);
            this.tab_Inicial.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_Inicial.Name = "tab_Inicial";
            this.tab_Inicial.SelectedIndex = 0;
            this.tab_Inicial.Size = new System.Drawing.Size(802, 574);
            this.tab_Inicial.TabIndex = 0;
            // 
            // tab_Eventos
            // 
            this.tab_Eventos.Location = new System.Drawing.Point(4, 22);
            this.tab_Eventos.Name = "tab_Eventos";
            this.tab_Eventos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Eventos.Size = new System.Drawing.Size(794, 548);
            this.tab_Eventos.TabIndex = 0;
            this.tab_Eventos.Text = "Eventos";
            this.tab_Eventos.UseVisualStyleBackColor = true;
            this.tab_Eventos.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // reuniaoBindingSource
            // 
            this.reuniaoBindingSource.DataMember = "Reuniao";
            this.reuniaoBindingSource.DataSource = this.eventosDBDataSet;
            // 
            // eventosDBDataSet
            // 
            this.eventosDBDataSet.DataSetName = "EventosDBDataSet";
            this.eventosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reuniaoTableAdapter
            // 
            this.reuniaoTableAdapter.ClearBeforeFill = true;
            // 
            // eventoTableAdapter
            // 
            this.eventoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Admin
            // 
            this.btn_Admin.AutoSize = true;
            this.btn_Admin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Admin.Depth = 0;
            this.btn_Admin.Location = new System.Drawing.Point(731, 36);
            this.btn_Admin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Admin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Primary = false;
            this.btn_Admin.Size = new System.Drawing.Size(56, 36);
            this.btn_Admin.TabIndex = 2;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Visible = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.SeletorTab);
            this.Controls.Add(this.tab_Inicial);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            Reunioes.ResumeLayout(false);
            this.box_mReunioes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_MeusEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet1)).EndInit();
            this.tab_Inicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reuniaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tab_Inicial;
        private System.Windows.Forms.TabPage tab_Eventos;
        private MaterialSkin.Controls.MaterialTabSelector SeletorTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private EventosDBDataSet eventosDBDataSet;
        private System.Windows.Forms.BindingSource reuniaoBindingSource;
        private EventosDBDataSetTableAdapters.ReuniaoTableAdapter reuniaoTableAdapter;
        private System.Windows.Forms.GroupBox box_mReunioes;
        private System.Windows.Forms.DataGridView data_MeusEventos;
        private MaterialSkin.Controls.MaterialRaisedButton btn_NovoEvento;
        private EventosDBDataSet1 eventosDBDataSet1;
        private System.Windows.Forms.BindingSource eventoBindingSource;
        private EventosDBDataSet1TableAdapters.EventoTableAdapter eventoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canceladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Cancelar;
        private MaterialSkin.Controls.MaterialFlatButton btn_Admin;
    }
}