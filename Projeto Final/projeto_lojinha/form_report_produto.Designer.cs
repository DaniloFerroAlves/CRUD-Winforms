
namespace projeto_lojinha
{
    partial class form_report_produto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_report_produto));
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.cmb_report = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_categoria = new System.Windows.Forms.GroupBox();
            this.gb_genero = new System.Windows.Forms.GroupBox();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.gb_plataforma = new System.Windows.Forms.GroupBox();
            this.cmb_plataforma = new System.Windows.Forms.ComboBox();
            this.gb_data = new System.Windows.Forms.GroupBox();
            this.msk_data_i = new System.Windows.Forms.MaskedTextBox();
            this.msk_data_f = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_marca = new System.Windows.Forms.GroupBox();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.rb_statusinatv = new System.Windows.Forms.RadioButton();
            this.rb_statusatv = new System.Windows.Forms.RadioButton();
            this.bt_report = new System.Windows.Forms.Button();
            this.gb_report = new System.Windows.Forms.GroupBox();
            this.report_venda = new Microsoft.Reporting.WinForms.ReportViewer();
            this.report_locacao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.class_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.gb_categoria.SuspendLayout();
            this.gb_genero.SuspendLayout();
            this.gb_plataforma.SuspendLayout();
            this.gb_data.SuspendLayout();
            this.gb_marca.SuspendLayout();
            this.gb_status.SuspendLayout();
            this.gb_report.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classprodutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(7, 27);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(152, 28);
            this.cmb_categoria.TabIndex = 4;
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            this.cmb_categoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_categoria_MouseClick);
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(6, 27);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(152, 28);
            this.cmb_tipo.TabIndex = 2;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // cmb_report
            // 
            this.cmb_report.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_report.Enabled = false;
            this.cmb_report.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_report.FormattingEnabled = true;
            this.cmb_report.Location = new System.Drawing.Point(11, 26);
            this.cmb_report.Name = "cmb_report";
            this.cmb_report.Size = new System.Drawing.Size(152, 28);
            this.cmb_report.TabIndex = 0;
            this.cmb_report.SelectedIndexChanged += new System.EventHandler(this.cmb_report_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_tipo);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo:";
            // 
            // gb_categoria
            // 
            this.gb_categoria.Controls.Add(this.cmb_categoria);
            this.gb_categoria.Enabled = false;
            this.gb_categoria.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_categoria.Location = new System.Drawing.Point(186, 38);
            this.gb_categoria.Name = "gb_categoria";
            this.gb_categoria.Size = new System.Drawing.Size(164, 65);
            this.gb_categoria.TabIndex = 6;
            this.gb_categoria.TabStop = false;
            this.gb_categoria.Text = "Categoria:";
            // 
            // gb_genero
            // 
            this.gb_genero.Controls.Add(this.cmb_genero);
            this.gb_genero.Enabled = false;
            this.gb_genero.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_genero.ForeColor = System.Drawing.Color.Black;
            this.gb_genero.Location = new System.Drawing.Point(6, 112);
            this.gb_genero.Name = "gb_genero";
            this.gb_genero.Size = new System.Drawing.Size(164, 69);
            this.gb_genero.TabIndex = 7;
            this.gb_genero.TabStop = false;
            this.gb_genero.Text = "Gênero:";
            // 
            // cmb_genero
            // 
            this.cmb_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_genero.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Location = new System.Drawing.Point(6, 27);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(152, 28);
            this.cmb_genero.TabIndex = 4;
            this.cmb_genero.DropDown += new System.EventHandler(this.cmb_genero_DropDown);
            // 
            // gb_plataforma
            // 
            this.gb_plataforma.Controls.Add(this.cmb_plataforma);
            this.gb_plataforma.Enabled = false;
            this.gb_plataforma.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_plataforma.ForeColor = System.Drawing.Color.Black;
            this.gb_plataforma.Location = new System.Drawing.Point(6, 185);
            this.gb_plataforma.Name = "gb_plataforma";
            this.gb_plataforma.Size = new System.Drawing.Size(164, 69);
            this.gb_plataforma.TabIndex = 8;
            this.gb_plataforma.TabStop = false;
            this.gb_plataforma.Text = "Plataforma:";
            // 
            // cmb_plataforma
            // 
            this.cmb_plataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_plataforma.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_plataforma.FormattingEnabled = true;
            this.cmb_plataforma.Location = new System.Drawing.Point(6, 28);
            this.cmb_plataforma.Name = "cmb_plataforma";
            this.cmb_plataforma.Size = new System.Drawing.Size(152, 28);
            this.cmb_plataforma.TabIndex = 4;
            this.cmb_plataforma.DropDown += new System.EventHandler(this.cmb_plataforma_DropDown);
            // 
            // gb_data
            // 
            this.gb_data.Controls.Add(this.msk_data_i);
            this.gb_data.Controls.Add(this.msk_data_f);
            this.gb_data.Controls.Add(this.label3);
            this.gb_data.Controls.Add(this.label2);
            this.gb_data.Enabled = false;
            this.gb_data.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_data.ForeColor = System.Drawing.Color.Black;
            this.gb_data.Location = new System.Drawing.Point(6, 331);
            this.gb_data.Name = "gb_data";
            this.gb_data.Size = new System.Drawing.Size(164, 93);
            this.gb_data.TabIndex = 9;
            this.gb_data.TabStop = false;
            this.gb_data.Text = "Ano Lançamento:";
            // 
            // msk_data_i
            // 
            this.msk_data_i.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msk_data_i.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_data_i.Location = new System.Drawing.Point(54, 27);
            this.msk_data_i.Margin = new System.Windows.Forms.Padding(2);
            this.msk_data_i.Mask = "0000";
            this.msk_data_i.Name = "msk_data_i";
            this.msk_data_i.Size = new System.Drawing.Size(53, 22);
            this.msk_data_i.TabIndex = 10;
            this.msk_data_i.ValidatingType = typeof(System.DateTime);
            // 
            // msk_data_f
            // 
            this.msk_data_f.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msk_data_f.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_data_f.Location = new System.Drawing.Point(54, 60);
            this.msk_data_f.Margin = new System.Windows.Forms.Padding(2);
            this.msk_data_f.Mask = "0000";
            this.msk_data_f.Name = "msk_data_f";
            this.msk_data_f.Size = new System.Drawing.Size(53, 22);
            this.msk_data_f.TabIndex = 11;
            this.msk_data_f.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Até:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "De:";
            // 
            // gb_marca
            // 
            this.gb_marca.Controls.Add(this.cmb_marca);
            this.gb_marca.Enabled = false;
            this.gb_marca.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_marca.ForeColor = System.Drawing.Color.Black;
            this.gb_marca.Location = new System.Drawing.Point(6, 258);
            this.gb_marca.Name = "gb_marca";
            this.gb_marca.Size = new System.Drawing.Size(164, 69);
            this.gb_marca.TabIndex = 10;
            this.gb_marca.TabStop = false;
            this.gb_marca.Text = "Marca:";
            // 
            // cmb_marca
            // 
            this.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marca.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(6, 29);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(152, 28);
            this.cmb_marca.TabIndex = 4;
            this.cmb_marca.DropDown += new System.EventHandler(this.cmb_marca_DropDown);
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rb_statusinatv);
            this.gb_status.Controls.Add(this.rb_statusatv);
            this.gb_status.Enabled = false;
            this.gb_status.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_status.ForeColor = System.Drawing.Color.Black;
            this.gb_status.Location = new System.Drawing.Point(6, 428);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(164, 56);
            this.gb_status.TabIndex = 11;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status:";
            // 
            // rb_statusinatv
            // 
            this.rb_statusinatv.AutoSize = true;
            this.rb_statusinatv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_statusinatv.Location = new System.Drawing.Point(69, 27);
            this.rb_statusinatv.Name = "rb_statusinatv";
            this.rb_statusinatv.Size = new System.Drawing.Size(72, 20);
            this.rb_statusinatv.TabIndex = 1;
            this.rb_statusinatv.TabStop = true;
            this.rb_statusinatv.Text = "Inativo";
            this.rb_statusinatv.UseVisualStyleBackColor = true;
            // 
            // rb_statusatv
            // 
            this.rb_statusatv.AutoSize = true;
            this.rb_statusatv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_statusatv.Location = new System.Drawing.Point(7, 27);
            this.rb_statusatv.Name = "rb_statusatv";
            this.rb_statusatv.Size = new System.Drawing.Size(60, 20);
            this.rb_statusatv.TabIndex = 0;
            this.rb_statusatv.TabStop = true;
            this.rb_statusatv.Text = "Ativo";
            this.rb_statusatv.UseVisualStyleBackColor = true;
            // 
            // bt_report
            // 
            this.bt_report.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_report.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_report.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_report.ForeColor = System.Drawing.Color.White;
            this.bt_report.Location = new System.Drawing.Point(299, 22);
            this.bt_report.Name = "bt_report";
            this.bt_report.Size = new System.Drawing.Size(150, 33);
            this.bt_report.TabIndex = 25;
            this.bt_report.Text = "Gerar Relatório";
            this.bt_report.UseVisualStyleBackColor = false;
            this.bt_report.Click += new System.EventHandler(this.bt_report_Click);
            // 
            // gb_report
            // 
            this.gb_report.Controls.Add(this.pictureBox1);
            this.gb_report.Controls.Add(this.bt_report);
            this.gb_report.Controls.Add(this.cmb_report);
            this.gb_report.Enabled = false;
            this.gb_report.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_report.Location = new System.Drawing.Point(370, 38);
            this.gb_report.Name = "gb_report";
            this.gb_report.Size = new System.Drawing.Size(464, 65);
            this.gb_report.TabIndex = 26;
            this.gb_report.TabStop = false;
            this.gb_report.Text = "Tipo de Relatório:";
            // 
            // report_venda
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.class_produtoBindingSource;
            this.report_venda.LocalReport.DataSources.Add(reportDataSource1);
            this.report_venda.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_produto_venda.rdlc";
            this.report_venda.Location = new System.Drawing.Point(186, 109);
            this.report_venda.Name = "report_venda";
            this.report_venda.ServerReport.BearerToken = null;
            this.report_venda.Size = new System.Drawing.Size(629, 375);
            this.report_venda.TabIndex = 27;
            this.report_venda.Visible = false;
            // 
            // report_locacao
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.class_produtoBindingSource;
            this.report_locacao.LocalReport.DataSources.Add(reportDataSource2);
            this.report_locacao.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_produto_locacao.rdlc";
            this.report_locacao.Location = new System.Drawing.Point(186, 109);
            this.report_locacao.Name = "report_locacao";
            this.report_locacao.ServerReport.BearerToken = null;
            this.report_locacao.Size = new System.Drawing.Size(648, 375);
            this.report_locacao.TabIndex = 28;
            this.report_locacao.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 20);
            this.panel2.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_sair);
            this.panel3.Location = new System.Drawing.Point(793, -3);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Primeiramente escolher um tipo, categoria e um tipo de relatório ");
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LightGray;
            this.toolTip1.IsBalloon = true;
            // 
            // class_produtoBindingSource
            // 
            this.class_produtoBindingSource.DataSource = typeof(projeto_lojinha.class_produto);
            // 
            // classprodutoBindingSource
            // 
            this.classprodutoBindingSource.DataSource = typeof(projeto_lojinha.class_produto);
            // 
            // form_report_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.report_locacao);
            this.Controls.Add(this.report_venda);
            this.Controls.Add(this.gb_report);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.gb_marca);
            this.Controls.Add(this.gb_data);
            this.Controls.Add(this.gb_plataforma);
            this.Controls.Add(this.gb_genero);
            this.Controls.Add(this.gb_categoria);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_report_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_report_produto";
            this.Load += new System.EventHandler(this.form_report_produto_Load);
            this.groupBox1.ResumeLayout(false);
            this.gb_categoria.ResumeLayout(false);
            this.gb_genero.ResumeLayout(false);
            this.gb_plataforma.ResumeLayout(false);
            this.gb_data.ResumeLayout(false);
            this.gb_data.PerformLayout();
            this.gb_marca.ResumeLayout(false);
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.gb_report.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classprodutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_report;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_categoria;
        private System.Windows.Forms.GroupBox gb_genero;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.GroupBox gb_plataforma;
        private System.Windows.Forms.ComboBox cmb_plataforma;
        private System.Windows.Forms.GroupBox gb_data;
        private System.Windows.Forms.MaskedTextBox msk_data_i;
        private System.Windows.Forms.MaskedTextBox msk_data_f;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_marca;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.RadioButton rb_statusinatv;
        private System.Windows.Forms.RadioButton rb_statusatv;
        private System.Windows.Forms.Button bt_report;
        private System.Windows.Forms.GroupBox gb_report;
        private System.Windows.Forms.BindingSource classprodutoBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer report_venda;
        private System.Windows.Forms.BindingSource class_produtoBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer report_locacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}