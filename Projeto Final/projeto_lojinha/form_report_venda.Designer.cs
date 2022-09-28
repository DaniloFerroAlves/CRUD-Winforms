
namespace projeto_lojinha
{
    partial class form_report_venda
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_report_venda));
            this.report_periodo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.bt_gerar_relatorio = new System.Windows.Forms.Button();
            this.cmb_tipo_relatorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_periodo_venda = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_funcionario = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.report_funcionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.gb_cliente = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_meses_cliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gb_produto = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_meses_produto = new System.Windows.Forms.ComboBox();
            this.report_cliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.report_produto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.class_relatorio_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb_periodo_venda.SuspendLayout();
            this.gb_funcionario.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gb_cliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_relatorio_vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // report_periodo
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.class_relatorio_vendaBindingSource;
            this.report_periodo.LocalReport.DataSources.Add(reportDataSource1);
            this.report_periodo.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_venda.rdlc";
            this.report_periodo.Location = new System.Drawing.Point(336, 106);
            this.report_periodo.Name = "report_periodo";
            this.report_periodo.ServerReport.BearerToken = null;
            this.report_periodo.Size = new System.Drawing.Size(648, 325);
            this.report_periodo.TabIndex = 0;
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio.Location = new System.Drawing.Point(44, 28);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(110, 27);
            this.dtp_inicio.TabIndex = 1;
            // 
            // dtp_final
            // 
            this.dtp_final.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(201, 28);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(110, 27);
            this.dtp_final.TabIndex = 2;
            // 
            // bt_gerar_relatorio
            // 
            this.bt_gerar_relatorio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_gerar_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_gerar_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_gerar_relatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_gerar_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gerar_relatorio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gerar_relatorio.ForeColor = System.Drawing.Color.White;
            this.bt_gerar_relatorio.Location = new System.Drawing.Point(805, 19);
            this.bt_gerar_relatorio.Name = "bt_gerar_relatorio";
            this.bt_gerar_relatorio.Size = new System.Drawing.Size(150, 33);
            this.bt_gerar_relatorio.TabIndex = 3;
            this.bt_gerar_relatorio.Text = "Gerar";
            this.bt_gerar_relatorio.UseVisualStyleBackColor = false;
            this.bt_gerar_relatorio.Click += new System.EventHandler(this.bt_gerar_relatorio_Click);
            // 
            // cmb_tipo_relatorio
            // 
            this.cmb_tipo_relatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_relatorio.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_relatorio.FormattingEnabled = true;
            this.cmb_tipo_relatorio.Location = new System.Drawing.Point(184, 46);
            this.cmb_tipo_relatorio.Name = "cmb_tipo_relatorio";
            this.cmb_tipo_relatorio.Size = new System.Drawing.Size(233, 28);
            this.cmb_tipo_relatorio.TabIndex = 4;
            this.cmb_tipo_relatorio.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_relatorio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Relatório:";
            // 
            // gb_periodo_venda
            // 
            this.gb_periodo_venda.Controls.Add(this.label3);
            this.gb_periodo_venda.Controls.Add(this.label2);
            this.gb_periodo_venda.Controls.Add(this.dtp_inicio);
            this.gb_periodo_venda.Controls.Add(this.dtp_final);
            this.gb_periodo_venda.Enabled = false;
            this.gb_periodo_venda.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_periodo_venda.Location = new System.Drawing.Point(12, 97);
            this.gb_periodo_venda.Name = "gb_periodo_venda";
            this.gb_periodo_venda.Size = new System.Drawing.Size(318, 66);
            this.gb_periodo_venda.TabIndex = 6;
            this.gb_periodo_venda.TabStop = false;
            this.gb_periodo_venda.Text = "Periodo Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Até:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "De:";
            // 
            // gb_funcionario
            // 
            this.gb_funcionario.Controls.Add(this.label4);
            this.gb_funcionario.Controls.Add(this.cmb_mes);
            this.gb_funcionario.Enabled = false;
            this.gb_funcionario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_funcionario.Location = new System.Drawing.Point(12, 366);
            this.gb_funcionario.Name = "gb_funcionario";
            this.gb_funcionario.Size = new System.Drawing.Size(318, 65);
            this.gb_funcionario.TabIndex = 7;
            this.gb_funcionario.TabStop = false;
            this.gb_funcionario.Text = "Funcionário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Meses:";
            // 
            // cmb_mes
            // 
            this.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Location = new System.Drawing.Point(74, 28);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(213, 28);
            this.cmb_mes.TabIndex = 8;
            // 
            // report_funcionario
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.class_relatorio_vendaBindingSource;
            this.report_funcionario.LocalReport.DataSources.Add(reportDataSource2);
            this.report_funcionario.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_venda_funcionario.rdlc";
            this.report_funcionario.Location = new System.Drawing.Point(336, 106);
            this.report_funcionario.Name = "report_funcionario";
            this.report_funcionario.ServerReport.BearerToken = null;
            this.report_funcionario.Size = new System.Drawing.Size(648, 325);
            this.report_funcionario.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 20);
            this.panel2.TabIndex = 231;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.bt_fechar);
            this.panel8.Location = new System.Drawing.Point(939, -4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(60, 26);
            this.panel8.TabIndex = 49;
            // 
            // bt_fechar
            // 
            this.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fechar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_fechar.Location = new System.Drawing.Point(-4, -10);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(74, 47);
            this.bt_fechar.TabIndex = 40;
            this.bt_fechar.Text = "X";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // gb_cliente
            // 
            this.gb_cliente.Controls.Add(this.label5);
            this.gb_cliente.Controls.Add(this.cmb_meses_cliente);
            this.gb_cliente.Enabled = false;
            this.gb_cliente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cliente.Location = new System.Drawing.Point(12, 280);
            this.gb_cliente.Name = "gb_cliente";
            this.gb_cliente.Size = new System.Drawing.Size(318, 65);
            this.gb_cliente.TabIndex = 12;
            this.gb_cliente.TabStop = false;
            this.gb_cliente.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Meses:";
            // 
            // cmb_meses_cliente
            // 
            this.cmb_meses_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_meses_cliente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_meses_cliente.FormattingEnabled = true;
            this.cmb_meses_cliente.Location = new System.Drawing.Point(74, 28);
            this.cmb_meses_cliente.Name = "cmb_meses_cliente";
            this.cmb_meses_cliente.Size = new System.Drawing.Size(213, 28);
            this.cmb_meses_cliente.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.bt_gerar_relatorio);
            this.groupBox2.Location = new System.Drawing.Point(11, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 65);
            this.groupBox2.TabIndex = 232;
            this.groupBox2.TabStop = false;
            // 
            // gb_produto
            // 
            this.gb_produto.Controls.Add(this.label6);
            this.gb_produto.Controls.Add(this.cmb_meses_produto);
            this.gb_produto.Enabled = false;
            this.gb_produto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_produto.Location = new System.Drawing.Point(12, 189);
            this.gb_produto.Name = "gb_produto";
            this.gb_produto.Size = new System.Drawing.Size(318, 70);
            this.gb_produto.TabIndex = 13;
            this.gb_produto.TabStop = false;
            this.gb_produto.Text = "Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Meses:";
            // 
            // cmb_meses_produto
            // 
            this.cmb_meses_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_meses_produto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_meses_produto.FormattingEnabled = true;
            this.cmb_meses_produto.Location = new System.Drawing.Point(74, 28);
            this.cmb_meses_produto.Name = "cmb_meses_produto";
            this.cmb_meses_produto.Size = new System.Drawing.Size(213, 28);
            this.cmb_meses_produto.TabIndex = 8;
            // 
            // report_cliente
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.class_relatorio_vendaBindingSource;
            this.report_cliente.LocalReport.DataSources.Add(reportDataSource3);
            this.report_cliente.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_venda_cliente.rdlc";
            this.report_cliente.Location = new System.Drawing.Point(336, 104);
            this.report_cliente.Name = "report_cliente";
            this.report_cliente.ServerReport.BearerToken = null;
            this.report_cliente.Size = new System.Drawing.Size(648, 327);
            this.report_cliente.TabIndex = 233;
            // 
            // report_produto
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.class_relatorio_vendaBindingSource;
            this.report_produto.LocalReport.DataSources.Add(reportDataSource4);
            this.report_produto.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_produto_mais_vendido_venda.rdlc";
            this.report_produto.Location = new System.Drawing.Point(336, 104);
            this.report_produto.Name = "report_produto";
            this.report_produto.ServerReport.BearerToken = null;
            this.report_produto.Size = new System.Drawing.Size(648, 327);
            this.report_produto.TabIndex = 234;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LightGray;
            this.toolTip1.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Os campos vão ser habilitados dependendo do tipo de relatório escolhido");
            // 
            // class_relatorio_vendaBindingSource
            // 
            this.class_relatorio_vendaBindingSource.DataSource = typeof(projeto_lojinha.class_relatorio_venda);
            // 
            // form_report_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(999, 449);
            this.Controls.Add(this.report_produto);
            this.Controls.Add(this.report_cliente);
            this.Controls.Add(this.gb_produto);
            this.Controls.Add(this.gb_cliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.report_funcionario);
            this.Controls.Add(this.gb_funcionario);
            this.Controls.Add(this.gb_periodo_venda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tipo_relatorio);
            this.Controls.Add(this.report_periodo);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_report_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_report_venda";
            this.Load += new System.EventHandler(this.form_report_venda_Load);
            this.gb_periodo_venda.ResumeLayout(false);
            this.gb_periodo_venda.PerformLayout();
            this.gb_funcionario.ResumeLayout(false);
            this.gb_funcionario.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.gb_cliente.ResumeLayout(false);
            this.gb_cliente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gb_produto.ResumeLayout(false);
            this.gb_produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_relatorio_vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_periodo;
        private System.Windows.Forms.BindingSource class_relatorio_vendaBindingSource;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Button bt_gerar_relatorio;
        private System.Windows.Forms.ComboBox cmb_tipo_relatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_periodo_venda;
        private System.Windows.Forms.GroupBox gb_funcionario;
        private System.Windows.Forms.ComboBox cmb_mes;
        private Microsoft.Reporting.WinForms.ReportViewer report_funcionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.GroupBox gb_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_meses_cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb_produto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_meses_produto;
        private Microsoft.Reporting.WinForms.ReportViewer report_cliente;
        private Microsoft.Reporting.WinForms.ReportViewer report_produto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}