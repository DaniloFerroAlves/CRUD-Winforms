namespace projeto_lojinha
{
    partial class form_consulta_cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvg_consulta_cliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.cmb_pesquisar_por = new System.Windows.Forms.ComboBox();
            this.txt_buscar_nome = new System.Windows.Forms.TextBox();
            this.rb_inicio = new System.Windows.Forms.RadioButton();
            this.rb_contem = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gp_nome = new System.Windows.Forms.GroupBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gp_cpf = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.gp_status = new System.Windows.Forms.GroupBox();
            this.rb_inativo = new System.Windows.Forms.RadioButton();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.bt_editar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_consulta_cliente)).BeginInit();
            this.gp_nome.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gp_cpf.SuspendLayout();
            this.gp_status.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvg_consulta_cliente
            // 
            this.dvg_consulta_cliente.AllowUserToAddRows = false;
            this.dvg_consulta_cliente.AllowUserToDeleteRows = false;
            this.dvg_consulta_cliente.AllowUserToResizeColumns = false;
            this.dvg_consulta_cliente.AllowUserToResizeRows = false;
            this.dvg_consulta_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvg_consulta_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_consulta_cliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvg_consulta_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_consulta_cliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_consulta_cliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_consulta_cliente.Location = new System.Drawing.Point(406, 40);
            this.dvg_consulta_cliente.MultiSelect = false;
            this.dvg_consulta_cliente.Name = "dvg_consulta_cliente";
            this.dvg_consulta_cliente.ReadOnly = true;
            this.dvg_consulta_cliente.RowHeadersVisible = false;
            this.dvg_consulta_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_consulta_cliente.Size = new System.Drawing.Size(413, 385);
            this.dvg_consulta_cliente.TabIndex = 17;
            this.dvg_consulta_cliente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_consulta_cliente_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "CONSULTA CLIENTE";
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.BackColor = System.Drawing.Color.DimGray;
            this.bt_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pesquisar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar.ForeColor = System.Drawing.Color.White;
            this.bt_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar.Location = new System.Drawing.Point(238, 393);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(133, 32);
            this.bt_pesquisar.TabIndex = 19;
            this.bt_pesquisar.Text = "Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = false;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // cmb_pesquisar_por
            // 
            this.cmb_pesquisar_por.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.cmb_pesquisar_por.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pesquisar_por.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pesquisar_por.FormattingEnabled = true;
            this.cmb_pesquisar_por.Location = new System.Drawing.Point(117, 19);
            this.cmb_pesquisar_por.Name = "cmb_pesquisar_por";
            this.cmb_pesquisar_por.Size = new System.Drawing.Size(131, 28);
            this.cmb_pesquisar_por.TabIndex = 20;
            this.cmb_pesquisar_por.SelectedIndexChanged += new System.EventHandler(this.cmb_pesquisar_por_SelectedIndexChanged);
            // 
            // txt_buscar_nome
            // 
            this.txt_buscar_nome.BackColor = System.Drawing.Color.White;
            this.txt_buscar_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar_nome.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_nome.Location = new System.Drawing.Point(117, 22);
            this.txt_buscar_nome.Multiline = true;
            this.txt_buscar_nome.Name = "txt_buscar_nome";
            this.txt_buscar_nome.Size = new System.Drawing.Size(226, 26);
            this.txt_buscar_nome.TabIndex = 21;
            // 
            // rb_inicio
            // 
            this.rb_inicio.AutoSize = true;
            this.rb_inicio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inicio.Location = new System.Drawing.Point(12, 55);
            this.rb_inicio.Name = "rb_inicio";
            this.rb_inicio.Size = new System.Drawing.Size(61, 20);
            this.rb_inicio.TabIndex = 22;
            this.rb_inicio.TabStop = true;
            this.rb_inicio.Text = "Ínicio";
            this.rb_inicio.UseVisualStyleBackColor = true;
            // 
            // rb_contem
            // 
            this.rb_contem.AutoSize = true;
            this.rb_contem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_contem.Location = new System.Drawing.Point(79, 55);
            this.rb_contem.Name = "rb_contem";
            this.rb_contem.Size = new System.Drawing.Size(76, 20);
            this.rb_contem.TabIndex = 23;
            this.rb_contem.TabStop = true;
            this.rb_contem.Text = "Contém";
            this.rb_contem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pesquisar por:";
            // 
            // gp_nome
            // 
            this.gp_nome.Controls.Add(this.lb_nome);
            this.gp_nome.Controls.Add(this.txt_buscar_nome);
            this.gp_nome.Controls.Add(this.rb_contem);
            this.gp_nome.Controls.Add(this.rb_inicio);
            this.gp_nome.Enabled = false;
            this.gp_nome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_nome.Location = new System.Drawing.Point(18, 165);
            this.gp_nome.Name = "gp_nome";
            this.gp_nome.Size = new System.Drawing.Size(353, 81);
            this.gp_nome.TabIndex = 25;
            this.gp_nome.TabStop = false;
            this.gp_nome.Text = "Nome:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(12, 28);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(103, 16);
            this.lb_nome.TabIndex = 26;
            this.lb_nome.Text = "Insira o nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_pesquisar_por);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 54);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta:";
            // 
            // gp_cpf
            // 
            this.gp_cpf.Controls.Add(this.label4);
            this.gp_cpf.Controls.Add(this.msk_cpf);
            this.gp_cpf.Enabled = false;
            this.gp_cpf.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_cpf.Location = new System.Drawing.Point(18, 261);
            this.gp_cpf.Name = "gp_cpf";
            this.gp_cpf.Size = new System.Drawing.Size(353, 50);
            this.gp_cpf.TabIndex = 27;
            this.gp_cpf.TabStop = false;
            this.gp_cpf.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Insira o CPF:";
            // 
            // msk_cpf
            // 
            this.msk_cpf.BackColor = System.Drawing.Color.White;
            this.msk_cpf.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cpf.Location = new System.Drawing.Point(113, 18);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(113, 27);
            this.msk_cpf.TabIndex = 27;
            this.msk_cpf.MouseUp += new System.Windows.Forms.MouseEventHandler(this.msk_cpf_MouseUp);
            // 
            // gp_status
            // 
            this.gp_status.Controls.Add(this.rb_inativo);
            this.gp_status.Controls.Add(this.rb_ativo);
            this.gp_status.Enabled = false;
            this.gp_status.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_status.Location = new System.Drawing.Point(18, 326);
            this.gp_status.Name = "gp_status";
            this.gp_status.Size = new System.Drawing.Size(353, 56);
            this.gp_status.TabIndex = 28;
            this.gp_status.TabStop = false;
            this.gp_status.Text = "Status:";
            // 
            // rb_inativo
            // 
            this.rb_inativo.AutoSize = true;
            this.rb_inativo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inativo.Location = new System.Drawing.Point(81, 27);
            this.rb_inativo.Name = "rb_inativo";
            this.rb_inativo.Size = new System.Drawing.Size(72, 20);
            this.rb_inativo.TabIndex = 27;
            this.rb_inativo.TabStop = true;
            this.rb_inativo.Text = "Inativo";
            this.rb_inativo.UseVisualStyleBackColor = true;
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ativo.Location = new System.Drawing.Point(12, 27);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(60, 20);
            this.rb_ativo.TabIndex = 28;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "Ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar.Enabled = false;
            this.bt_editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_editar.Location = new System.Drawing.Point(18, 393);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(133, 32);
            this.bt_editar.TabIndex = 39;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 20);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_sair);
            this.panel3.Location = new System.Drawing.Point(771, -3);
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
            this.bt_sair.Click += new System.EventHandler(this.button1_Click);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(135, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 2);
            this.panel4.TabIndex = 56;
            // 
            // form_consulta_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(831, 438);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.gp_status);
            this.Controls.Add(this.gp_cpf);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gp_nome);
            this.Controls.Add(this.bt_pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg_consulta_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_consulta_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_consulta_cliente";
            this.Load += new System.EventHandler(this.form_consulta_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_consulta_cliente)).EndInit();
            this.gp_nome.ResumeLayout(false);
            this.gp_nome.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gp_cpf.ResumeLayout(false);
            this.gp_cpf.PerformLayout();
            this.gp_status.ResumeLayout(false);
            this.gp_status.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvg_consulta_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.ComboBox cmb_pesquisar_por;
        private System.Windows.Forms.TextBox txt_buscar_nome;
        private System.Windows.Forms.RadioButton rb_inicio;
        private System.Windows.Forms.RadioButton rb_contem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gp_nome;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gp_cpf;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.GroupBox gp_status;
        private System.Windows.Forms.RadioButton rb_inativo;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Panel panel4;
    }
}