namespace projeto_lojinha
{
    partial class form_consulta_cargo
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
            this.dgv_consulta_cargo = new System.Windows.Forms.DataGridView();
            this.cb_consulta_por_cargo = new System.Windows.Forms.ComboBox();
            this.gp_nome = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_contem_cargo = new System.Windows.Forms.RadioButton();
            this.txt_nome_cargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_inicio_cargo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gp_status = new System.Windows.Forms.GroupBox();
            this.rb_inativo_cargo = new System.Windows.Forms.RadioButton();
            this.rb_ativo_cargo = new System.Windows.Forms.RadioButton();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_pesquisar_cargo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta_cargo)).BeginInit();
            this.gp_nome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gp_status.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_consulta_cargo
            // 
            this.dgv_consulta_cargo.AllowUserToAddRows = false;
            this.dgv_consulta_cargo.AllowUserToDeleteRows = false;
            this.dgv_consulta_cargo.AllowUserToResizeColumns = false;
            this.dgv_consulta_cargo.AllowUserToResizeRows = false;
            this.dgv_consulta_cargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_consulta_cargo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_consulta_cargo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_consulta_cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta_cargo.Location = new System.Drawing.Point(309, 80);
            this.dgv_consulta_cargo.MultiSelect = false;
            this.dgv_consulta_cargo.Name = "dgv_consulta_cargo";
            this.dgv_consulta_cargo.ReadOnly = true;
            this.dgv_consulta_cargo.RowHeadersVisible = false;
            this.dgv_consulta_cargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_consulta_cargo.Size = new System.Drawing.Size(208, 237);
            this.dgv_consulta_cargo.TabIndex = 0;
            // 
            // cb_consulta_por_cargo
            // 
            this.cb_consulta_por_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.cb_consulta_por_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_consulta_por_cargo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_consulta_por_cargo.FormattingEnabled = true;
            this.cb_consulta_por_cargo.Location = new System.Drawing.Point(118, 19);
            this.cb_consulta_por_cargo.Name = "cb_consulta_por_cargo";
            this.cb_consulta_por_cargo.Size = new System.Drawing.Size(121, 28);
            this.cb_consulta_por_cargo.TabIndex = 17;
            this.cb_consulta_por_cargo.SelectedIndexChanged += new System.EventHandler(this.cb_consulta_por_SelectedIndexChanged);
            // 
            // gp_nome
            // 
            this.gp_nome.Controls.Add(this.panel3);
            this.gp_nome.Controls.Add(this.rb_contem_cargo);
            this.gp_nome.Controls.Add(this.txt_nome_cargo);
            this.gp_nome.Controls.Add(this.label3);
            this.gp_nome.Controls.Add(this.rb_inicio_cargo);
            this.gp_nome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_nome.Location = new System.Drawing.Point(13, 128);
            this.gp_nome.Name = "gp_nome";
            this.gp_nome.Size = new System.Drawing.Size(278, 81);
            this.gp_nome.TabIndex = 18;
            this.gp_nome.TabStop = false;
            this.gp_nome.Text = "Nome:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(117, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 2);
            this.panel3.TabIndex = 56;
            // 
            // rb_contem_cargo
            // 
            this.rb_contem_cargo.AutoSize = true;
            this.rb_contem_cargo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_contem_cargo.Location = new System.Drawing.Point(79, 55);
            this.rb_contem_cargo.Name = "rb_contem_cargo";
            this.rb_contem_cargo.Size = new System.Drawing.Size(76, 20);
            this.rb_contem_cargo.TabIndex = 30;
            this.rb_contem_cargo.TabStop = true;
            this.rb_contem_cargo.Text = "Contém";
            this.rb_contem_cargo.UseVisualStyleBackColor = true;
            // 
            // txt_nome_cargo
            // 
            this.txt_nome_cargo.BackColor = System.Drawing.Color.White;
            this.txt_nome_cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome_cargo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_cargo.Location = new System.Drawing.Point(118, 22);
            this.txt_nome_cargo.Multiline = true;
            this.txt_nome_cargo.Name = "txt_nome_cargo";
            this.txt_nome_cargo.Size = new System.Drawing.Size(145, 26);
            this.txt_nome_cargo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Insira o nome:";
            // 
            // rb_inicio_cargo
            // 
            this.rb_inicio_cargo.AutoSize = true;
            this.rb_inicio_cargo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inicio_cargo.Location = new System.Drawing.Point(15, 55);
            this.rb_inicio_cargo.Name = "rb_inicio_cargo";
            this.rb_inicio_cargo.Size = new System.Drawing.Size(61, 20);
            this.rb_inicio_cargo.TabIndex = 29;
            this.rb_inicio_cargo.TabStop = true;
            this.rb_inicio_cargo.Text = "Ínicio";
            this.rb_inicio_cargo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "CONSULTA CARGO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_consulta_por_cargo);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 54);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pesquisar por:";
            // 
            // gp_status
            // 
            this.gp_status.Controls.Add(this.rb_inativo_cargo);
            this.gp_status.Controls.Add(this.rb_ativo_cargo);
            this.gp_status.Enabled = false;
            this.gp_status.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_status.Location = new System.Drawing.Point(13, 216);
            this.gp_status.Name = "gp_status";
            this.gp_status.Size = new System.Drawing.Size(278, 56);
            this.gp_status.TabIndex = 29;
            this.gp_status.TabStop = false;
            this.gp_status.Text = "Status:";
            // 
            // rb_inativo_cargo
            // 
            this.rb_inativo_cargo.AutoSize = true;
            this.rb_inativo_cargo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inativo_cargo.Location = new System.Drawing.Point(81, 28);
            this.rb_inativo_cargo.Name = "rb_inativo_cargo";
            this.rb_inativo_cargo.Size = new System.Drawing.Size(72, 20);
            this.rb_inativo_cargo.TabIndex = 27;
            this.rb_inativo_cargo.TabStop = true;
            this.rb_inativo_cargo.Text = "Inativo";
            this.rb_inativo_cargo.UseVisualStyleBackColor = true;
            // 
            // rb_ativo_cargo
            // 
            this.rb_ativo_cargo.AutoSize = true;
            this.rb_ativo_cargo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ativo_cargo.Location = new System.Drawing.Point(15, 28);
            this.rb_ativo_cargo.Name = "rb_ativo_cargo";
            this.rb_ativo_cargo.Size = new System.Drawing.Size(60, 20);
            this.rb_ativo_cargo.TabIndex = 28;
            this.rb_ativo_cargo.TabStop = true;
            this.rb_ativo_cargo.Text = "Ativo";
            this.rb_ativo_cargo.UseVisualStyleBackColor = true;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_editar.Location = new System.Drawing.Point(13, 285);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(133, 32);
            this.bt_editar.TabIndex = 41;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_pesquisar_cargo
            // 
            this.bt_pesquisar_cargo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_pesquisar_cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesquisar_cargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_pesquisar_cargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_pesquisar_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pesquisar_cargo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar_cargo.ForeColor = System.Drawing.Color.White;
            this.bt_pesquisar_cargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar_cargo.Location = new System.Drawing.Point(158, 285);
            this.bt_pesquisar_cargo.Name = "bt_pesquisar_cargo";
            this.bt_pesquisar_cargo.Size = new System.Drawing.Size(133, 32);
            this.bt_pesquisar_cargo.TabIndex = 40;
            this.bt_pesquisar_cargo.Text = "Pesquisar";
            this.bt_pesquisar_cargo.UseVisualStyleBackColor = false;
            this.bt_pesquisar_cargo.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 20);
            this.panel2.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_sair);
            this.panel1.Location = new System.Drawing.Point(468, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 26);
            this.panel1.TabIndex = 50;
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
            // form_consulta_cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(530, 329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_pesquisar_cargo);
            this.Controls.Add(this.gp_status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gp_nome);
            this.Controls.Add(this.dgv_consulta_cargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_consulta_cargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_consulta_cargo";
            this.Load += new System.EventHandler(this.form_consulta_cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta_cargo)).EndInit();
            this.gp_nome.ResumeLayout(false);
            this.gp_nome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gp_status.ResumeLayout(false);
            this.gp_status.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_consulta_cargo;
        private System.Windows.Forms.ComboBox cb_consulta_por_cargo;
        private System.Windows.Forms.GroupBox gp_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gp_status;
        private System.Windows.Forms.RadioButton rb_inativo_cargo;
        private System.Windows.Forms.RadioButton rb_ativo_cargo;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_pesquisar_cargo;
        private System.Windows.Forms.TextBox txt_nome_cargo;
        private System.Windows.Forms.RadioButton rb_contem_cargo;
        private System.Windows.Forms.RadioButton rb_inicio_cargo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_sair;
    }
}