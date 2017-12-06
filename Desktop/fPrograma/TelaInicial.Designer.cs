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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.data_MeusConvites = new System.Windows.Forms.DataGridView();
            this.ideventosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmacaoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Confirmar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Recusar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.participanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosDBDataSet2 = new Desktop.EventosDBDataSet2();
            this.tab_Inicial = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_Eventos = new System.Windows.Forms.TabPage();
            this.grp_Palestra = new System.Windows.Forms.GroupBox();
            this.check_Privado = new System.Windows.Forms.CheckBox();
            this.txt_Convidado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_Local = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Tempo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.evt_Data = new System.Windows.Forms.DateTimePicker();
            this.txt_Desc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grp_Horarios = new System.Windows.Forms.GroupBox();
            this.btn_Horario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.date_Horario = new System.Windows.Forms.DateTimePicker();
            this.reuniaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosDBDataSet = new Desktop.EventosDBDataSet();
            this.reuniaoTableAdapter = new Desktop.EventosDBDataSetTableAdapters.ReuniaoTableAdapter();
            this.eventoTableAdapter = new Desktop.EventosDBDataSet1TableAdapters.EventoTableAdapter();
            this.btn_Admin = new MaterialSkin.Controls.MaterialFlatButton();
            this.participanteTableAdapter = new Desktop.EventosDBDataSet2TableAdapters.ParticipanteTableAdapter();
            this.tab_Geral = new MaterialSkin.Controls.MaterialTabSelector();
            Reunioes = new System.Windows.Forms.TabPage();
            Reunioes.SuspendLayout();
            this.box_mReunioes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_MeusEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_MeusConvites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet2)).BeginInit();
            this.tab_Inicial.SuspendLayout();
            this.tab_Eventos.SuspendLayout();
            this.grp_Palestra.SuspendLayout();
            this.grp_Horarios.SuspendLayout();
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
            this.data_MeusEventos.AllowUserToAddRows = false;
            this.data_MeusEventos.AllowUserToDeleteRows = false;
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
            this.groupBox2.Controls.Add(this.data_MeusConvites);
            this.groupBox2.Location = new System.Drawing.Point(3, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reuniões ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // data_MeusConvites
            // 
            this.data_MeusConvites.AllowUserToAddRows = false;
            this.data_MeusConvites.AllowUserToDeleteRows = false;
            this.data_MeusConvites.AutoGenerateColumns = false;
            this.data_MeusConvites.BackgroundColor = System.Drawing.Color.White;
            this.data_MeusConvites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_MeusConvites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_MeusConvites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_MeusConvites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_MeusConvites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_MeusConvites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ideventosDataGridViewTextBoxColumn,
            this.confirmacaoDataGridViewCheckBoxColumn,
            this.Confirmar,
            this.Recusar});
            this.data_MeusConvites.DataSource = this.participanteBindingSource;
            this.data_MeusConvites.EnableHeadersVisualStyles = false;
            this.data_MeusConvites.Location = new System.Drawing.Point(25, 19);
            this.data_MeusConvites.Name = "data_MeusConvites";
            this.data_MeusConvites.ReadOnly = true;
            this.data_MeusConvites.Size = new System.Drawing.Size(459, 193);
            this.data_MeusConvites.TabIndex = 2;
            this.data_MeusConvites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // ideventosDataGridViewTextBoxColumn
            // 
            this.ideventosDataGridViewTextBoxColumn.DataPropertyName = "Id_eventos";
            this.ideventosDataGridViewTextBoxColumn.HeaderText = "Reunião";
            this.ideventosDataGridViewTextBoxColumn.Name = "ideventosDataGridViewTextBoxColumn";
            this.ideventosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // confirmacaoDataGridViewCheckBoxColumn
            // 
            this.confirmacaoDataGridViewCheckBoxColumn.DataPropertyName = "confirmacao";
            this.confirmacaoDataGridViewCheckBoxColumn.HeaderText = "Confirmado";
            this.confirmacaoDataGridViewCheckBoxColumn.Name = "confirmacaoDataGridViewCheckBoxColumn";
            this.confirmacaoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Confirmar
            // 
            this.Confirmar.HeaderText = "Confirmar";
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.ReadOnly = true;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseColumnTextForButtonValue = true;
            // 
            // Recusar
            // 
            this.Recusar.HeaderText = "Recusar";
            this.Recusar.Name = "Recusar";
            this.Recusar.ReadOnly = true;
            this.Recusar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Recusar.Text = "Recusar";
            this.Recusar.UseColumnTextForButtonValue = true;
            // 
            // participanteBindingSource
            // 
            this.participanteBindingSource.DataMember = "Participante";
            this.participanteBindingSource.DataSource = this.eventosDBDataSet2;
            // 
            // eventosDBDataSet2
            // 
            this.eventosDBDataSet2.DataSetName = "EventosDBDataSet2";
            this.eventosDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tab_Eventos.Controls.Add(this.grp_Palestra);
            this.tab_Eventos.Controls.Add(this.grp_Horarios);
            this.tab_Eventos.Location = new System.Drawing.Point(4, 22);
            this.tab_Eventos.Name = "tab_Eventos";
            this.tab_Eventos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Eventos.Size = new System.Drawing.Size(794, 548);
            this.tab_Eventos.TabIndex = 0;
            this.tab_Eventos.Text = "Geral";
            this.tab_Eventos.UseVisualStyleBackColor = true;
            this.tab_Eventos.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // grp_Palestra
            // 
            this.grp_Palestra.BackColor = System.Drawing.Color.White;
            this.grp_Palestra.Controls.Add(this.check_Privado);
            this.grp_Palestra.Controls.Add(this.txt_Convidado);
            this.grp_Palestra.Controls.Add(this.btnCadastrar);
            this.grp_Palestra.Controls.Add(this.txt_Local);
            this.grp_Palestra.Controls.Add(this.txt_Tempo);
            this.grp_Palestra.Controls.Add(this.evt_Data);
            this.grp_Palestra.Controls.Add(this.txt_Desc);
            this.grp_Palestra.Location = new System.Drawing.Point(280, 22);
            this.grp_Palestra.Name = "grp_Palestra";
            this.grp_Palestra.Size = new System.Drawing.Size(246, 343);
            this.grp_Palestra.TabIndex = 1;
            this.grp_Palestra.TabStop = false;
            this.grp_Palestra.Text = "Cadastrar Palestra";
            this.grp_Palestra.Visible = false;
            // 
            // check_Privado
            // 
            this.check_Privado.AutoSize = true;
            this.check_Privado.Location = new System.Drawing.Point(85, 218);
            this.check_Privado.Name = "check_Privado";
            this.check_Privado.Size = new System.Drawing.Size(62, 17);
            this.check_Privado.TabIndex = 29;
            this.check_Privado.Text = "Privado";
            this.check_Privado.UseVisualStyleBackColor = true;
            this.check_Privado.CheckedChanged += new System.EventHandler(this.check_Privado_CheckedChanged);
            // 
            // txt_Convidado
            // 
            this.txt_Convidado.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Convidado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Convidado.Depth = 0;
            this.txt_Convidado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Convidado.Hint = "Convidado";
            this.txt_Convidado.Location = new System.Drawing.Point(41, 241);
            this.txt_Convidado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Convidado.Name = "txt_Convidado";
            this.txt_Convidado.PasswordChar = '\0';
            this.txt_Convidado.SelectedText = "";
            this.txt_Convidado.SelectionLength = 0;
            this.txt_Convidado.SelectionStart = 0;
            this.txt_Convidado.Size = new System.Drawing.Size(183, 23);
            this.txt_Convidado.TabIndex = 28;
            this.txt_Convidado.TabStop = false;
            this.txt_Convidado.UseSystemPasswordChar = false;
            this.txt_Convidado.Visible = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrar.Location = new System.Drawing.Point(68, 285);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Primary = true;
            this.btnCadastrar.Size = new System.Drawing.Size(115, 25);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txt_Local
            // 
            this.txt_Local.AllowDrop = true;
            this.txt_Local.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Local.Depth = 0;
            this.txt_Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Local.Hint = "Local";
            this.txt_Local.Location = new System.Drawing.Point(41, 39);
            this.txt_Local.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Local.Name = "txt_Local";
            this.txt_Local.PasswordChar = '\0';
            this.txt_Local.SelectedText = "";
            this.txt_Local.SelectionLength = 0;
            this.txt_Local.SelectionStart = 0;
            this.txt_Local.Size = new System.Drawing.Size(183, 23);
            this.txt_Local.TabIndex = 23;
            this.txt_Local.TabStop = false;
            this.txt_Local.UseSystemPasswordChar = false;
            // 
            // txt_Tempo
            // 
            this.txt_Tempo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Tempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Tempo.Depth = 0;
            this.txt_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Tempo.Hint = "Tempo de Palestra";
            this.txt_Tempo.Location = new System.Drawing.Point(41, 121);
            this.txt_Tempo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Tempo.Name = "txt_Tempo";
            this.txt_Tempo.PasswordChar = '\0';
            this.txt_Tempo.SelectedText = "";
            this.txt_Tempo.SelectionLength = 0;
            this.txt_Tempo.SelectionStart = 0;
            this.txt_Tempo.Size = new System.Drawing.Size(183, 23);
            this.txt_Tempo.TabIndex = 26;
            this.txt_Tempo.TabStop = false;
            this.txt_Tempo.UseSystemPasswordChar = false;
            // 
            // evt_Data
            // 
            this.evt_Data.Location = new System.Drawing.Point(56, 172);
            this.evt_Data.Name = "evt_Data";
            this.evt_Data.Size = new System.Drawing.Size(127, 20);
            this.evt_Data.TabIndex = 25;
            // 
            // txt_Desc
            // 
            this.txt_Desc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Desc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Desc.Depth = 0;
            this.txt_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Desc.Hint = "Descrição";
            this.txt_Desc.Location = new System.Drawing.Point(41, 79);
            this.txt_Desc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.PasswordChar = '\0';
            this.txt_Desc.SelectedText = "";
            this.txt_Desc.SelectionLength = 0;
            this.txt_Desc.SelectionStart = 0;
            this.txt_Desc.Size = new System.Drawing.Size(183, 23);
            this.txt_Desc.TabIndex = 24;
            this.txt_Desc.TabStop = false;
            this.txt_Desc.UseSystemPasswordChar = false;
            // 
            // grp_Horarios
            // 
            this.grp_Horarios.Controls.Add(this.btn_Horario);
            this.grp_Horarios.Controls.Add(this.date_Horario);
            this.grp_Horarios.Location = new System.Drawing.Point(8, 22);
            this.grp_Horarios.Name = "grp_Horarios";
            this.grp_Horarios.Size = new System.Drawing.Size(256, 139);
            this.grp_Horarios.TabIndex = 0;
            this.grp_Horarios.TabStop = false;
            this.grp_Horarios.Text = "Horários";
            this.grp_Horarios.Visible = false;
            // 
            // btn_Horario
            // 
            this.btn_Horario.Depth = 0;
            this.btn_Horario.Location = new System.Drawing.Point(72, 91);
            this.btn_Horario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Horario.Name = "btn_Horario";
            this.btn_Horario.Primary = true;
            this.btn_Horario.Size = new System.Drawing.Size(98, 23);
            this.btn_Horario.TabIndex = 1;
            this.btn_Horario.Text = "Cadastrar";
            this.btn_Horario.UseVisualStyleBackColor = true;
            this.btn_Horario.Click += new System.EventHandler(this.btn_Horario_Click);
            // 
            // date_Horario
            // 
            this.date_Horario.Location = new System.Drawing.Point(24, 39);
            this.date_Horario.Name = "date_Horario";
            this.date_Horario.Size = new System.Drawing.Size(200, 20);
            this.date_Horario.TabIndex = 0;
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
            // participanteTableAdapter
            // 
            this.participanteTableAdapter.ClearBeforeFill = true;
            // 
            // tab_Geral
            // 
            this.tab_Geral.BaseTabControl = this.tab_Inicial;
            this.tab_Geral.Depth = 0;
            this.tab_Geral.Location = new System.Drawing.Point(0, 62);
            this.tab_Geral.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_Geral.Name = "tab_Geral";
            this.tab_Geral.Size = new System.Drawing.Size(802, 42);
            this.tab_Geral.TabIndex = 3;
            this.tab_Geral.Text = "materialTabSelector1";
            this.tab_Geral.Click += new System.EventHandler(this.tab_Geral_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.tab_Geral);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.tab_Inicial);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            Reunioes.ResumeLayout(false);
            this.box_mReunioes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_MeusEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_MeusConvites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet2)).EndInit();
            this.tab_Inicial.ResumeLayout(false);
            this.tab_Eventos.ResumeLayout(false);
            this.grp_Palestra.ResumeLayout(false);
            this.grp_Palestra.PerformLayout();
            this.grp_Horarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reuniaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tab_Inicial;
        private System.Windows.Forms.TabPage tab_Eventos;
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
        private System.Windows.Forms.DataGridView data_MeusConvites;
        private EventosDBDataSet2 eventosDBDataSet2;
        private System.Windows.Forms.BindingSource participanteBindingSource;
        private EventosDBDataSet2TableAdapters.ParticipanteTableAdapter participanteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideventosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmacaoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Confirmar;
        private System.Windows.Forms.DataGridViewButtonColumn Recusar;
        private System.Windows.Forms.GroupBox grp_Horarios;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Horario;
        private System.Windows.Forms.DateTimePicker date_Horario;
        private System.Windows.Forms.GroupBox grp_Palestra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Local;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Tempo;
        private System.Windows.Forms.DateTimePicker evt_Data;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Desc;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrar;
        private System.Windows.Forms.CheckBox check_Privado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Convidado;
        private MaterialSkin.Controls.MaterialTabSelector tab_Geral;
    }
}