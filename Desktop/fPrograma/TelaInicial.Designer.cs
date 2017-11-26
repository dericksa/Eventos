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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_Inicial = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.box_mReunioes = new System.Windows.Forms.GroupBox();
            this.btn_NovoEvento = new MaterialSkin.Controls.MaterialRaisedButton();
            this.data_MeusEventos = new System.Windows.Forms.DataGridView();
            this.reuniaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosDBDataSet = new Desktop.EventosDBDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SeletorTab = new MaterialSkin.Controls.MaterialTabSelector();
            this.reuniaoTableAdapter = new Desktop.EventosDBDataSetTableAdapters.ReuniaoTableAdapter();
            this.eventosDBDataSet1 = new Desktop.EventosDBDataSet1();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventoTableAdapter = new Desktop.EventosDBDataSet1TableAdapters.EventoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canceladoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tab_Inicial.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.box_mReunioes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_MeusEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reuniaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
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
            this.tab_Inicial.Size = new System.Drawing.Size(802, 574);
            this.tab_Inicial.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Eventos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.box_mReunioes);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reuniões";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_MeusEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // eventosDBDataSet1
            // 
            this.eventosDBDataSet1.DataSetName = "EventosDBDataSet1";
            this.eventosDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataMember = "Evento";
            this.eventoBindingSource.DataSource = this.eventosDBDataSet1;
            // 
            // eventoTableAdapter
            // 
            this.eventoTableAdapter.ClearBeforeFill = true;
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
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.SeletorTab);
            this.Controls.Add(this.tab_Inicial);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.tab_Inicial.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.box_mReunioes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_MeusEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reuniaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tab_Inicial;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}