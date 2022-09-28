
namespace projeto_lojinha
{
    partial class form_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_report));
            this.class_generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class_marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class_categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class_plataformaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_gerar_relatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_marca = new System.Windows.Forms.RadioButton();
            this.rb_plataforma = new System.Windows.Forms.RadioButton();
            this.rb_categoria = new System.Windows.Forms.RadioButton();
            this.rb_genero = new System.Windows.Forms.RadioButton();
            this.reportv_genero = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportv_marca = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportv_categoria = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportv_plataforma = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.class_generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_plataformaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.bt_gerar_relatorio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rb_marca);
            this.groupBox2.Controls.Add(this.rb_plataforma);
            this.groupBox2.Controls.Add(this.rb_categoria);
            this.groupBox2.Controls.Add(this.rb_genero);
            this.groupBox2.Location = new System.Drawing.Point(7, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 73);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(17, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 2);
            this.panel2.TabIndex = 57;
            // 
            // bt_gerar_relatorio
            // 
            this.bt_gerar_relatorio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_gerar_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_gerar_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_gerar_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gerar_relatorio.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gerar_relatorio.ForeColor = System.Drawing.Color.White;
            this.bt_gerar_relatorio.Location = new System.Drawing.Point(553, 25);
            this.bt_gerar_relatorio.Name = "bt_gerar_relatorio";
            this.bt_gerar_relatorio.Size = new System.Drawing.Size(150, 33);
            this.bt_gerar_relatorio.TabIndex = 5;
            this.bt_gerar_relatorio.Text = "Gerar Relatório";
            this.bt_gerar_relatorio.UseVisualStyleBackColor = false;
            this.bt_gerar_relatorio.Click += new System.EventHandler(this.bt_gerar_relatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o tipo de Relatório:";
            // 
            // rb_marca
            // 
            this.rb_marca.AutoSize = true;
            this.rb_marca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_marca.Location = new System.Drawing.Point(17, 42);
            this.rb_marca.Name = "rb_marca";
            this.rb_marca.Size = new System.Drawing.Size(66, 20);
            this.rb_marca.TabIndex = 0;
            this.rb_marca.TabStop = true;
            this.rb_marca.Text = "Marca";
            this.rb_marca.UseVisualStyleBackColor = true;
            this.rb_marca.CheckedChanged += new System.EventHandler(this.rb_marca_CheckedChanged);
            // 
            // rb_plataforma
            // 
            this.rb_plataforma.AutoSize = true;
            this.rb_plataforma.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_plataforma.Location = new System.Drawing.Point(267, 42);
            this.rb_plataforma.Name = "rb_plataforma";
            this.rb_plataforma.Size = new System.Drawing.Size(96, 20);
            this.rb_plataforma.TabIndex = 3;
            this.rb_plataforma.TabStop = true;
            this.rb_plataforma.Text = "Plataforma";
            this.rb_plataforma.UseVisualStyleBackColor = true;
            this.rb_plataforma.CheckedChanged += new System.EventHandler(this.rb_plataforma_CheckedChanged);
            // 
            // rb_categoria
            // 
            this.rb_categoria.AutoSize = true;
            this.rb_categoria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_categoria.Location = new System.Drawing.Point(170, 42);
            this.rb_categoria.Name = "rb_categoria";
            this.rb_categoria.Size = new System.Drawing.Size(89, 20);
            this.rb_categoria.TabIndex = 2;
            this.rb_categoria.TabStop = true;
            this.rb_categoria.Text = "Categoria";
            this.rb_categoria.UseVisualStyleBackColor = true;
            this.rb_categoria.CheckedChanged += new System.EventHandler(this.rb_categoria_CheckedChanged);
            // 
            // rb_genero
            // 
            this.rb_genero.AutoSize = true;
            this.rb_genero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_genero.Location = new System.Drawing.Point(89, 42);
            this.rb_genero.Name = "rb_genero";
            this.rb_genero.Size = new System.Drawing.Size(72, 20);
            this.rb_genero.TabIndex = 1;
            this.rb_genero.TabStop = true;
            this.rb_genero.Text = "Gênero";
            this.rb_genero.UseVisualStyleBackColor = true;
            this.rb_genero.CheckedChanged += new System.EventHandler(this.rb_genero_CheckedChanged);
            // 
            // reportv_genero
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.class_generoBindingSource;
            this.reportv_genero.LocalReport.DataSources.Add(reportDataSource1);
            this.reportv_genero.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_genero.rdlc";
            this.reportv_genero.Location = new System.Drawing.Point(16, 115);
            this.reportv_genero.Name = "reportv_genero";
            this.reportv_genero.ServerReport.BearerToken = null;
            this.reportv_genero.Size = new System.Drawing.Size(698, 378);
            this.reportv_genero.TabIndex = 30;
            this.reportv_genero.Visible = false;
            // 
            // reportv_marca
            // 
            reportDataSource2.Name = "dataset_marca";
            reportDataSource2.Value = this.class_marcaBindingSource;
            this.reportv_marca.LocalReport.DataSources.Add(reportDataSource2);
            this.reportv_marca.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_marca.rdlc";
            this.reportv_marca.Location = new System.Drawing.Point(16, 115);
            this.reportv_marca.Name = "reportv_marca";
            this.reportv_marca.ServerReport.BearerToken = null;
            this.reportv_marca.Size = new System.Drawing.Size(698, 378);
            this.reportv_marca.TabIndex = 31;
            this.reportv_marca.Visible = false;
            // 
            // reportv_categoria
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.class_categoriaBindingSource;
            this.reportv_categoria.LocalReport.DataSources.Add(reportDataSource3);
            this.reportv_categoria.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_categoria.rdlc";
            this.reportv_categoria.Location = new System.Drawing.Point(16, 115);
            this.reportv_categoria.Name = "reportv_categoria";
            this.reportv_categoria.ServerReport.BearerToken = null;
            this.reportv_categoria.Size = new System.Drawing.Size(698, 378);
            this.reportv_categoria.TabIndex = 32;
            this.reportv_categoria.Visible = false;
            // 
            // reportv_plataforma
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.class_plataformaBindingSource;
            this.reportv_plataforma.LocalReport.DataSources.Add(reportDataSource4);
            this.reportv_plataforma.LocalReport.ReportEmbeddedResource = "projeto_lojinha.report_plataforma.rdlc";
            this.reportv_plataforma.Location = new System.Drawing.Point(16, 115);
            this.reportv_plataforma.Name = "reportv_plataforma";
            this.reportv_plataforma.ServerReport.BearerToken = null;
            this.reportv_plataforma.Size = new System.Drawing.Size(698, 378);
            this.reportv_plataforma.TabIndex = 33;
            this.reportv_plataforma.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 20);
            this.panel1.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_fechar);
            this.panel3.Location = new System.Drawing.Point(680, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 26);
            this.panel3.TabIndex = 49;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Escolha qual subcategoria você deseja obter um relatório");
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LightGray;
            this.toolTip1.IsBalloon = true;
            // 
            // form_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportv_plataforma);
            this.Controls.Add(this.reportv_categoria);
            this.Controls.Add(this.reportv_marca);
            this.Controls.Add(this.reportv_genero);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_report";
            this.Text = "form_report";
            this.Load += new System.EventHandler(this.form_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.class_generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_plataformaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource class_marcaBindingSource;
        private System.Windows.Forms.BindingSource class_categoriaBindingSource;
        private System.Windows.Forms.BindingSource class_generoBindingSource;
        private System.Windows.Forms.BindingSource class_plataformaBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_gerar_relatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_marca;
        private System.Windows.Forms.RadioButton rb_plataforma;
        private System.Windows.Forms.RadioButton rb_categoria;
        private System.Windows.Forms.RadioButton rb_genero;
        private Microsoft.Reporting.WinForms.ReportViewer reportv_genero;
        private Microsoft.Reporting.WinForms.ReportViewer reportv_marca;
        private Microsoft.Reporting.WinForms.ReportViewer reportv_categoria;
        private Microsoft.Reporting.WinForms.ReportViewer reportv_plataforma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}