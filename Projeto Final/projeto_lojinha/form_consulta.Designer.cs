namespace projeto_lojinha
{
    partial class form_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_consulta));
            this.label1 = new System.Windows.Forms.Label();
            this.rb_plataforma = new System.Windows.Forms.RadioButton();
            this.rb_genero = new System.Windows.Forms.RadioButton();
            this.rb_categoria = new System.Windows.Forms.RadioButton();
            this.rb_marca = new System.Windows.Forms.RadioButton();
            this.gb_nome = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rb_contem = new System.Windows.Forms.RadioButton();
            this.rb_inicio = new System.Windows.Forms.RadioButton();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.rb_inativo = new System.Windows.Forms.RadioButton();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_sair = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gb_nome.SuspendLayout();
            this.gb_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTA SUBCATEGORIAS";
            // 
            // rb_plataforma
            // 
            this.rb_plataforma.AutoSize = true;
            this.rb_plataforma.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_plataforma.Location = new System.Drawing.Point(262, 88);
            this.rb_plataforma.Name = "rb_plataforma";
            this.rb_plataforma.Size = new System.Drawing.Size(96, 20);
            this.rb_plataforma.TabIndex = 3;
            this.rb_plataforma.Text = "Plataforma";
            this.rb_plataforma.UseVisualStyleBackColor = true;
            // 
            // rb_genero
            // 
            this.rb_genero.AutoSize = true;
            this.rb_genero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_genero.Location = new System.Drawing.Point(89, 88);
            this.rb_genero.Name = "rb_genero";
            this.rb_genero.Size = new System.Drawing.Size(72, 20);
            this.rb_genero.TabIndex = 1;
            this.rb_genero.Text = "Gênero";
            this.rb_genero.UseVisualStyleBackColor = true;
            // 
            // rb_categoria
            // 
            this.rb_categoria.AutoSize = true;
            this.rb_categoria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_categoria.Location = new System.Drawing.Point(166, 88);
            this.rb_categoria.Name = "rb_categoria";
            this.rb_categoria.Size = new System.Drawing.Size(89, 20);
            this.rb_categoria.TabIndex = 0;
            this.rb_categoria.Text = "Categoria";
            this.rb_categoria.UseVisualStyleBackColor = true;
            // 
            // rb_marca
            // 
            this.rb_marca.AutoSize = true;
            this.rb_marca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_marca.Location = new System.Drawing.Point(20, 87);
            this.rb_marca.Name = "rb_marca";
            this.rb_marca.Size = new System.Drawing.Size(66, 20);
            this.rb_marca.TabIndex = 2;
            this.rb_marca.Text = "Marca";
            this.rb_marca.UseVisualStyleBackColor = true;
            // 
            // gb_nome
            // 
            this.gb_nome.Controls.Add(this.panel4);
            this.gb_nome.Controls.Add(this.rb_contem);
            this.gb_nome.Controls.Add(this.rb_inicio);
            this.gb_nome.Controls.Add(this.txt_nome);
            this.gb_nome.Controls.Add(this.label2);
            this.gb_nome.Enabled = false;
            this.gb_nome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_nome.Location = new System.Drawing.Point(11, 182);
            this.gb_nome.Name = "gb_nome";
            this.gb_nome.Size = new System.Drawing.Size(346, 82);
            this.gb_nome.TabIndex = 4;
            this.gb_nome.TabStop = false;
            this.gb_nome.Text = "Nome:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(116, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 2);
            this.panel4.TabIndex = 68;
            // 
            // rb_contem
            // 
            this.rb_contem.AutoSize = true;
            this.rb_contem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_contem.Location = new System.Drawing.Point(78, 54);
            this.rb_contem.Name = "rb_contem";
            this.rb_contem.Size = new System.Drawing.Size(76, 20);
            this.rb_contem.TabIndex = 8;
            this.rb_contem.TabStop = true;
            this.rb_contem.Text = "Contêm";
            this.rb_contem.UseVisualStyleBackColor = true;
            // 
            // rb_inicio
            // 
            this.rb_inicio.AutoSize = true;
            this.rb_inicio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inicio.Location = new System.Drawing.Point(11, 54);
            this.rb_inicio.Name = "rb_inicio";
            this.rb_inicio.Size = new System.Drawing.Size(61, 20);
            this.rb_inicio.TabIndex = 7;
            this.rb_inicio.TabStop = true;
            this.rb_inicio.Text = "Início";
            this.rb_inicio.UseVisualStyleBackColor = true;
            // 
            // txt_nome
            // 
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(116, 21);
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(224, 27);
            this.txt_nome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Insira o Nome:";
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rb_inativo);
            this.gb_status.Controls.Add(this.rb_ativo);
            this.gb_status.Enabled = false;
            this.gb_status.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_status.Location = new System.Drawing.Point(11, 270);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(346, 47);
            this.gb_status.TabIndex = 5;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status:";
            // 
            // rb_inativo
            // 
            this.rb_inativo.AutoSize = true;
            this.rb_inativo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inativo.Location = new System.Drawing.Point(80, 22);
            this.rb_inativo.Name = "rb_inativo";
            this.rb_inativo.Size = new System.Drawing.Size(72, 20);
            this.rb_inativo.TabIndex = 1;
            this.rb_inativo.TabStop = true;
            this.rb_inativo.Text = "Inativo";
            this.rb_inativo.UseVisualStyleBackColor = true;
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ativo.Location = new System.Drawing.Point(11, 22);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(60, 20);
            this.rb_ativo.TabIndex = 0;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "Ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pesquisar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar.ForeColor = System.Drawing.Color.White;
            this.bt_pesquisar.Location = new System.Drawing.Point(236, 325);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(122, 37);
            this.bt_pesquisar.TabIndex = 6;
            this.bt_pesquisar.Text = "Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = false;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_editar.Enabled = false;
            this.bt_editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(11, 325);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(122, 37);
            this.bt_editar.TabIndex = 7;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToResizeColumns = false;
            this.dt.AllowUserToResizeRows = false;
            this.dt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(371, 88);
            this.dt.MultiSelect = false;
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.Size = new System.Drawing.Size(248, 274);
            this.dt.TabIndex = 13;
            this.dt.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmb_tipo);
            this.groupBox4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 60);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pesquisar por:";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(125, 24);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipo.TabIndex = 0;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 20);
            this.panel2.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_sair);
            this.panel1.Location = new System.Drawing.Point(570, -3);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(22, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 2);
            this.panel3.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(592, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Primeiramente escolher um tipo de subcategoria para realizar a consulta");
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LightGray;
            this.toolTip1.IsBalloon = true;
            // 
            // form_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(631, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_plataforma);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rb_genero);
            this.Controls.Add(this.rb_categoria);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.rb_marca);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_pesquisar);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.gb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_consulta";
            this.Text = " ";
            this.Load += new System.EventHandler(this.form_consulta_Load);
            this.gb_nome.ResumeLayout(false);
            this.gb_nome.PerformLayout();
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_contem;
        private System.Windows.Forms.RadioButton rb_inicio;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.RadioButton rb_inativo;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.ComboBox cmb_tipo;
        public System.Windows.Forms.RadioButton rb_plataforma;
        public System.Windows.Forms.RadioButton rb_marca;
        public System.Windows.Forms.RadioButton rb_genero;
        public System.Windows.Forms.RadioButton rb_categoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}