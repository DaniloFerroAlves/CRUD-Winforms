
namespace projeto_lojinha
{
    partial class form_report_funcionario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_report_funcionario));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_gerar_relatorio = new System.Windows.Forms.Button();
            this.gp_status = new System.Windows.Forms.GroupBox();
            this.rb_inativo = new System.Windows.Forms.RadioButton();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.gp_cidade = new System.Windows.Forms.GroupBox();
            this.cmb_cidade = new System.Windows.Forms.ComboBox();
            this.gp_bairro = new System.Windows.Forms.GroupBox();
            this.cmb_bairro = new System.Windows.Forms.ComboBox();
            this.gp_cargo = new System.Windows.Forms.GroupBox();
            this.cmb_cargo = new System.Windows.Forms.ComboBox();
            this.gp_mes = new System.Windows.Forms.GroupBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.gp_idade_if = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idade_final = new System.Windows.Forms.TextBox();
            this.txt_idade_inicio = new System.Windows.Forms.TextBox();
            this.gp_maiores = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maioresde = new System.Windows.Forms.TextBox();
            this.cmb_tipo_relatorio = new System.Windows.Forms.ComboBox();
            this.report_viewer_funcionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.class_funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gp_status.SuspendLayout();
            this.gp_cidade.SuspendLayout();
            this.gp_bairro.SuspendLayout();
            this.gp_cargo.SuspendLayout();
            this.gp_mes.SuspendLayout();
            this.gp_idade_if.SuspendLayout();
            this.gp_maiores.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tipo de Relatório:";
            // 
            // bt_gerar_relatorio
            // 
            this.bt_gerar_relatorio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_gerar_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_gerar_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_gerar_relatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_gerar_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gerar_relatorio.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gerar_relatorio.ForeColor = System.Drawing.Color.White;
            this.bt_gerar_relatorio.Location = new System.Drawing.Point(748, 16);
            this.bt_gerar_relatorio.Name = "bt_gerar_relatorio";
            this.bt_gerar_relatorio.Size = new System.Drawing.Size(150, 33);
            this.bt_gerar_relatorio.TabIndex = 46;
            this.bt_gerar_relatorio.Text = "Gerar Relatório";
            this.bt_gerar_relatorio.UseVisualStyleBackColor = false;
            this.bt_gerar_relatorio.Click += new System.EventHandler(this.bt_gerar_relatorio_Click);
            // 
            // gp_status
            // 
            this.gp_status.Controls.Add(this.rb_inativo);
            this.gp_status.Controls.Add(this.rb_ativo);
            this.gp_status.Enabled = false;
            this.gp_status.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_status.Location = new System.Drawing.Point(12, 443);
            this.gp_status.Name = "gp_status";
            this.gp_status.Size = new System.Drawing.Size(187, 57);
            this.gp_status.TabIndex = 46;
            this.gp_status.TabStop = false;
            this.gp_status.Text = "Status:";
            // 
            // rb_inativo
            // 
            this.rb_inativo.AutoSize = true;
            this.rb_inativo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inativo.Location = new System.Drawing.Point(81, 27);
            this.rb_inativo.Name = "rb_inativo";
            this.rb_inativo.Size = new System.Drawing.Size(69, 18);
            this.rb_inativo.TabIndex = 1;
            this.rb_inativo.TabStop = true;
            this.rb_inativo.Text = "Inativo";
            this.rb_inativo.UseVisualStyleBackColor = true;
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ativo.Location = new System.Drawing.Point(19, 27);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(56, 18);
            this.rb_ativo.TabIndex = 0;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "Ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            // 
            // gp_cidade
            // 
            this.gp_cidade.Controls.Add(this.cmb_cidade);
            this.gp_cidade.Enabled = false;
            this.gp_cidade.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_cidade.Location = new System.Drawing.Point(12, 260);
            this.gp_cidade.Name = "gp_cidade";
            this.gp_cidade.Size = new System.Drawing.Size(187, 57);
            this.gp_cidade.TabIndex = 47;
            this.gp_cidade.TabStop = false;
            this.gp_cidade.Text = "Cidade:";
            // 
            // cmb_cidade
            // 
            this.cmb_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cidade.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cidade.FormattingEnabled = true;
            this.cmb_cidade.Location = new System.Drawing.Point(16, 24);
            this.cmb_cidade.Name = "cmb_cidade";
            this.cmb_cidade.Size = new System.Drawing.Size(157, 28);
            this.cmb_cidade.TabIndex = 0;
            // 
            // gp_bairro
            // 
            this.gp_bairro.Controls.Add(this.cmb_bairro);
            this.gp_bairro.Enabled = false;
            this.gp_bairro.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_bairro.Location = new System.Drawing.Point(12, 382);
            this.gp_bairro.Name = "gp_bairro";
            this.gp_bairro.Size = new System.Drawing.Size(187, 57);
            this.gp_bairro.TabIndex = 48;
            this.gp_bairro.TabStop = false;
            this.gp_bairro.Text = "Bairro:";
            // 
            // cmb_bairro
            // 
            this.cmb_bairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bairro.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bairro.FormattingEnabled = true;
            this.cmb_bairro.Location = new System.Drawing.Point(16, 24);
            this.cmb_bairro.Name = "cmb_bairro";
            this.cmb_bairro.Size = new System.Drawing.Size(157, 28);
            this.cmb_bairro.TabIndex = 0;
            // 
            // gp_cargo
            // 
            this.gp_cargo.Controls.Add(this.cmb_cargo);
            this.gp_cargo.Enabled = false;
            this.gp_cargo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_cargo.Location = new System.Drawing.Point(12, 321);
            this.gp_cargo.Name = "gp_cargo";
            this.gp_cargo.Size = new System.Drawing.Size(187, 57);
            this.gp_cargo.TabIndex = 49;
            this.gp_cargo.TabStop = false;
            this.gp_cargo.Text = "Escolha o cargo:";
            // 
            // cmb_cargo
            // 
            this.cmb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cargo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cargo.FormattingEnabled = true;
            this.cmb_cargo.Location = new System.Drawing.Point(16, 24);
            this.cmb_cargo.Name = "cmb_cargo";
            this.cmb_cargo.Size = new System.Drawing.Size(157, 28);
            this.cmb_cargo.TabIndex = 0;
            // 
            // gp_mes
            // 
            this.gp_mes.Controls.Add(this.cmb_mes);
            this.gp_mes.Enabled = false;
            this.gp_mes.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_mes.Location = new System.Drawing.Point(12, 199);
            this.gp_mes.Name = "gp_mes";
            this.gp_mes.Size = new System.Drawing.Size(187, 57);
            this.gp_mes.TabIndex = 50;
            this.gp_mes.TabStop = false;
            this.gp_mes.Text = "Escolha o mês:";
            // 
            // cmb_mes
            // 
            this.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Location = new System.Drawing.Point(16, 23);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(157, 28);
            this.cmb_mes.TabIndex = 0;
            // 
            // gp_idade_if
            // 
            this.gp_idade_if.Controls.Add(this.panel5);
            this.gp_idade_if.Controls.Add(this.panel4);
            this.gp_idade_if.Controls.Add(this.label2);
            this.gp_idade_if.Controls.Add(this.label3);
            this.gp_idade_if.Controls.Add(this.txt_idade_final);
            this.gp_idade_if.Controls.Add(this.txt_idade_inicio);
            this.gp_idade_if.Enabled = false;
            this.gp_idade_if.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_idade_if.Location = new System.Drawing.Point(12, 93);
            this.gp_idade_if.Name = "gp_idade_if";
            this.gp_idade_if.Size = new System.Drawing.Size(187, 49);
            this.gp_idade_if.TabIndex = 46;
            this.gp_idade_if.TabStop = false;
            this.gp_idade_if.Text = "Idade:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(39, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(44, 2);
            this.panel5.TabIndex = 66;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(130, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(44, 2);
            this.panel4.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 47;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 48;
            this.label3.Text = "Até:";
            // 
            // txt_idade_final
            // 
            this.txt_idade_final.BackColor = System.Drawing.Color.White;
            this.txt_idade_final.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idade_final.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idade_final.Location = new System.Drawing.Point(130, 21);
            this.txt_idade_final.Multiline = true;
            this.txt_idade_final.Name = "txt_idade_final";
            this.txt_idade_final.Size = new System.Drawing.Size(44, 22);
            this.txt_idade_final.TabIndex = 44;
            this.txt_idade_final.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idade_final_KeyPress);
            // 
            // txt_idade_inicio
            // 
            this.txt_idade_inicio.BackColor = System.Drawing.Color.White;
            this.txt_idade_inicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idade_inicio.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idade_inicio.Location = new System.Drawing.Point(39, 21);
            this.txt_idade_inicio.Multiline = true;
            this.txt_idade_inicio.Name = "txt_idade_inicio";
            this.txt_idade_inicio.Size = new System.Drawing.Size(44, 20);
            this.txt_idade_inicio.TabIndex = 43;
            this.txt_idade_inicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idade_inicio_KeyPress);
            // 
            // gp_maiores
            // 
            this.gp_maiores.Controls.Add(this.panel6);
            this.gp_maiores.Controls.Add(this.label5);
            this.gp_maiores.Controls.Add(this.txt_maioresde);
            this.gp_maiores.Enabled = false;
            this.gp_maiores.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_maiores.Location = new System.Drawing.Point(12, 146);
            this.gp_maiores.Name = "gp_maiores";
            this.gp_maiores.Size = new System.Drawing.Size(187, 49);
            this.gp_maiores.TabIndex = 45;
            this.gp_maiores.TabStop = false;
            this.gp_maiores.Text = "Maiores de:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(129, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(44, 2);
            this.panel6.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 14);
            this.label5.TabIndex = 52;
            this.label5.Text = " Insira a idade:";
            // 
            // txt_maioresde
            // 
            this.txt_maioresde.BackColor = System.Drawing.Color.White;
            this.txt_maioresde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_maioresde.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maioresde.Location = new System.Drawing.Point(129, 21);
            this.txt_maioresde.Multiline = true;
            this.txt_maioresde.Name = "txt_maioresde";
            this.txt_maioresde.Size = new System.Drawing.Size(44, 20);
            this.txt_maioresde.TabIndex = 43;
            this.txt_maioresde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maioresde_KeyPress);
            // 
            // cmb_tipo_relatorio
            // 
            this.cmb_tipo_relatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_relatorio.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_relatorio.FormattingEnabled = true;
            this.cmb_tipo_relatorio.Location = new System.Drawing.Point(178, 18);
            this.cmb_tipo_relatorio.Name = "cmb_tipo_relatorio";
            this.cmb_tipo_relatorio.Size = new System.Drawing.Size(252, 28);
            this.cmb_tipo_relatorio.TabIndex = 42;
            this.cmb_tipo_relatorio.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_relatorio_SelectedIndexChanged);
            // 
            // report_viewer_funcionario
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.class_funcionarioBindingSource;
            this.report_viewer_funcionario.LocalReport.DataSources.Add(reportDataSource1);
            this.report_viewer_funcionario.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_funcionario.rdlc";
            this.report_viewer_funcionario.Location = new System.Drawing.Point(227, 104);
            this.report_viewer_funcionario.Name = "report_viewer_funcionario";
            this.report_viewer_funcionario.ServerReport.BearerToken = null;
            this.report_viewer_funcionario.Size = new System.Drawing.Size(695, 396);
            this.report_viewer_funcionario.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 20);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_sair);
            this.panel3.Location = new System.Drawing.Point(878, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 26);
            this.panel3.TabIndex = 50;
            // 
            // bt_sair
            // 
            this.bt_sair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_sair.Location = new System.Drawing.Point(-4, -10);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(74, 47);
            this.bt_sair.TabIndex = 40;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Location = new System.Drawing.Point(994, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 26);
            this.panel1.TabIndex = 49;
            // 
            // bt_fechar
            // 
            this.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fechar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_fechar.Location = new System.Drawing.Point(-4, -10);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(74, 47);
            this.bt_fechar.TabIndex = 40;
            this.bt_fechar.Text = "X";
            this.bt_fechar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.bt_gerar_relatorio);
            this.groupBox1.Controls.Add(this.cmb_tipo_relatorio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 57);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Os campos vão ser habilitados dependendo do tipo de relatório escolhido");
            // 
            // class_funcionarioBindingSource
            // 
            this.class_funcionarioBindingSource.DataSource = typeof(projeto_lojinha.class_funcionario);
            // 
            // form_report_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.report_viewer_funcionario);
            this.Controls.Add(this.gp_idade_if);
            this.Controls.Add(this.gp_maiores);
            this.Controls.Add(this.gp_mes);
            this.Controls.Add(this.gp_status);
            this.Controls.Add(this.gp_cargo);
            this.Controls.Add(this.gp_bairro);
            this.Controls.Add(this.gp_cidade);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_report_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_relatorio_funcionario";
            this.Load += new System.EventHandler(this.form_relatorio_funcionario_Load);
            this.gp_status.ResumeLayout(false);
            this.gp_status.PerformLayout();
            this.gp_cidade.ResumeLayout(false);
            this.gp_bairro.ResumeLayout(false);
            this.gp_cargo.ResumeLayout(false);
            this.gp_mes.ResumeLayout(false);
            this.gp_idade_if.ResumeLayout(false);
            this.gp_idade_if.PerformLayout();
            this.gp_maiores.ResumeLayout(false);
            this.gp_maiores.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_gerar_relatorio;
        private System.Windows.Forms.GroupBox gp_status;
        private System.Windows.Forms.RadioButton rb_inativo;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.GroupBox gp_cidade;
        private System.Windows.Forms.ComboBox cmb_cidade;
        private System.Windows.Forms.GroupBox gp_bairro;
        private System.Windows.Forms.ComboBox cmb_bairro;
        private System.Windows.Forms.GroupBox gp_cargo;
        private System.Windows.Forms.ComboBox cmb_cargo;
        private System.Windows.Forms.BindingSource class_funcionarioBindingSource;
        private System.Windows.Forms.GroupBox gp_mes;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.GroupBox gp_idade_if;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idade_final;
        private System.Windows.Forms.TextBox txt_idade_inicio;
        private System.Windows.Forms.GroupBox gp_maiores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maioresde;
        private System.Windows.Forms.ComboBox cmb_tipo_relatorio;
        private Microsoft.Reporting.WinForms.ReportViewer report_viewer_funcionario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}