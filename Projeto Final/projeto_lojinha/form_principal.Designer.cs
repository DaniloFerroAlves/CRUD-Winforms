
namespace projeto_lojinha
{
    partial class form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_principal));
            this.painel_fechar = new System.Windows.Forms.Panel();
            this.bt_fechar_sistema = new System.Windows.Forms.Button();
            this.barra_topo = new System.Windows.Forms.Panel();
            this.painel_lateral = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_menu = new System.Windows.Forms.Button();
            this.bt_cliente = new System.Windows.Forms.Button();
            this.painel_cliente = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_cadastro_cliente = new System.Windows.Forms.Button();
            this.bt_consulta_cliente = new System.Windows.Forms.Button();
            this.bt_relatorio_cliente = new System.Windows.Forms.Button();
            this.bt_funcionario = new System.Windows.Forms.Button();
            this.painel_funcionario = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_cadastro_funcionario = new System.Windows.Forms.Button();
            this.bt_consulta_funcionario = new System.Windows.Forms.Button();
            this.bt_relatorio_funcionario = new System.Windows.Forms.Button();
            this.bt_cargo = new System.Windows.Forms.Button();
            this.painel_cargo = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_cadastro_cargo = new System.Windows.Forms.Button();
            this.bt_consulta_cargo = new System.Windows.Forms.Button();
            this.bt_report_cargo = new System.Windows.Forms.Button();
            this.bt_produto = new System.Windows.Forms.Button();
            this.painel_produto = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_cadastro_prod = new System.Windows.Forms.Button();
            this.bt_consulta_prod = new System.Windows.Forms.Button();
            this.bt_relatorio_prod = new System.Windows.Forms.Button();
            this.bt_subcategorias = new System.Windows.Forms.Button();
            this.painel_subcategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_cadastro_subcate = new System.Windows.Forms.Button();
            this.bt_consulta_subcate = new System.Windows.Forms.Button();
            this.bt_report_subcate = new System.Windows.Forms.Button();
            this.bt_venda = new System.Windows.Forms.Button();
            this.bt_locacao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer_produto = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.timer_horario = new System.Windows.Forms.Timer(this.components);
            this.timer_funcionario = new System.Windows.Forms.Timer(this.components);
            this.timer_cargo = new System.Windows.Forms.Timer(this.components);
            this.timer_cliente = new System.Windows.Forms.Timer(this.components);
            this.timer_subcategorias = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painel_fechar.SuspendLayout();
            this.barra_topo.SuspendLayout();
            this.painel_lateral.SuspendLayout();
            this.painel_cliente.SuspendLayout();
            this.painel_funcionario.SuspendLayout();
            this.painel_cargo.SuspendLayout();
            this.painel_produto.SuspendLayout();
            this.painel_subcategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // painel_fechar
            // 
            this.painel_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.painel_fechar.BackColor = System.Drawing.Color.Transparent;
            this.painel_fechar.Controls.Add(this.bt_fechar_sistema);
            this.painel_fechar.Location = new System.Drawing.Point(850, 0);
            this.painel_fechar.Name = "painel_fechar";
            this.painel_fechar.Size = new System.Drawing.Size(51, 27);
            this.painel_fechar.TabIndex = 28;
            // 
            // bt_fechar_sistema
            // 
            this.bt_fechar_sistema.FlatAppearance.BorderSize = 0;
            this.bt_fechar_sistema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bt_fechar_sistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_fechar_sistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar_sistema.Image = ((System.Drawing.Image)(resources.GetObject("bt_fechar_sistema.Image")));
            this.bt_fechar_sistema.Location = new System.Drawing.Point(0, 0);
            this.bt_fechar_sistema.Name = "bt_fechar_sistema";
            this.bt_fechar_sistema.Size = new System.Drawing.Size(51, 27);
            this.bt_fechar_sistema.TabIndex = 25;
            this.bt_fechar_sistema.UseVisualStyleBackColor = true;
            this.bt_fechar_sistema.Click += new System.EventHandler(this.button5_Click);
            // 
            // barra_topo
            // 
            this.barra_topo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.barra_topo.Controls.Add(this.painel_fechar);
            this.barra_topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_topo.Location = new System.Drawing.Point(0, 0);
            this.barra_topo.Name = "barra_topo";
            this.barra_topo.Size = new System.Drawing.Size(901, 26);
            this.barra_topo.TabIndex = 29;
            // 
            // painel_lateral
            // 
            this.painel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.painel_lateral.Controls.Add(this.bt_menu);
            this.painel_lateral.Controls.Add(this.bt_cliente);
            this.painel_lateral.Controls.Add(this.painel_cliente);
            this.painel_lateral.Controls.Add(this.bt_funcionario);
            this.painel_lateral.Controls.Add(this.painel_funcionario);
            this.painel_lateral.Controls.Add(this.bt_cargo);
            this.painel_lateral.Controls.Add(this.painel_cargo);
            this.painel_lateral.Controls.Add(this.bt_produto);
            this.painel_lateral.Controls.Add(this.painel_produto);
            this.painel_lateral.Controls.Add(this.bt_subcategorias);
            this.painel_lateral.Controls.Add(this.painel_subcategorias);
            this.painel_lateral.Controls.Add(this.bt_venda);
            this.painel_lateral.Controls.Add(this.bt_locacao);
            this.painel_lateral.Controls.Add(this.button1);
            this.painel_lateral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painel_lateral.Location = new System.Drawing.Point(0, 500);
            this.painel_lateral.MaximumSize = new System.Drawing.Size(130, 411);
            this.painel_lateral.MinimumSize = new System.Drawing.Size(130, 50);
            this.painel_lateral.Name = "painel_lateral";
            this.painel_lateral.Size = new System.Drawing.Size(130, 50);
            this.painel_lateral.TabIndex = 30;
            // 
            // bt_menu
            // 
            this.bt_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bt_menu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_menu.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_menu.ForeColor = System.Drawing.Color.White;
            this.bt_menu.Image = ((System.Drawing.Image)(resources.GetObject("bt_menu.Image")));
            this.bt_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_menu.Location = new System.Drawing.Point(3, 3);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(124, 45);
            this.bt_menu.TabIndex = 0;
            this.bt_menu.Text = "   Menu";
            this.bt_menu.UseVisualStyleBackColor = false;
            this.bt_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_cliente
            // 
            this.bt_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.bt_cliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cliente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cliente.ForeColor = System.Drawing.Color.Azure;
            this.bt_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cliente.Location = new System.Drawing.Point(3, 54);
            this.bt_cliente.Name = "bt_cliente";
            this.bt_cliente.Size = new System.Drawing.Size(124, 31);
            this.bt_cliente.TabIndex = 32;
            this.bt_cliente.Text = "Cliente";
            this.bt_cliente.UseVisualStyleBackColor = false;
            this.bt_cliente.Click += new System.EventHandler(this.bt_cliente_Click);
            // 
            // painel_cliente
            // 
            this.painel_cliente.Controls.Add(this.bt_cadastro_cliente);
            this.painel_cliente.Controls.Add(this.bt_consulta_cliente);
            this.painel_cliente.Controls.Add(this.bt_relatorio_cliente);
            this.painel_cliente.Location = new System.Drawing.Point(3, 91);
            this.painel_cliente.MaximumSize = new System.Drawing.Size(124, 100);
            this.painel_cliente.MinimumSize = new System.Drawing.Size(124, 0);
            this.painel_cliente.Name = "painel_cliente";
            this.painel_cliente.Size = new System.Drawing.Size(124, 0);
            this.painel_cliente.TabIndex = 35;
            // 
            // bt_cadastro_cliente
            // 
            this.bt_cadastro_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_cadastro_cliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cadastro_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_cadastro_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastro_cliente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro_cliente.ForeColor = System.Drawing.Color.Silver;
            this.bt_cadastro_cliente.Location = new System.Drawing.Point(3, 3);
            this.bt_cadastro_cliente.Name = "bt_cadastro_cliente";
            this.bt_cadastro_cliente.Size = new System.Drawing.Size(120, 27);
            this.bt_cadastro_cliente.TabIndex = 35;
            this.bt_cadastro_cliente.Text = "Cadastro";
            this.bt_cadastro_cliente.UseVisualStyleBackColor = false;
            this.bt_cadastro_cliente.Click += new System.EventHandler(this.bt_cadastro_cliente_Click);
            // 
            // bt_consulta_cliente
            // 
            this.bt_consulta_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_consulta_cliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_consulta_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_consulta_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_consulta_cliente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consulta_cliente.ForeColor = System.Drawing.Color.Silver;
            this.bt_consulta_cliente.Location = new System.Drawing.Point(3, 36);
            this.bt_consulta_cliente.Name = "bt_consulta_cliente";
            this.bt_consulta_cliente.Size = new System.Drawing.Size(120, 27);
            this.bt_consulta_cliente.TabIndex = 37;
            this.bt_consulta_cliente.Text = "Consulta";
            this.bt_consulta_cliente.UseVisualStyleBackColor = false;
            this.bt_consulta_cliente.Click += new System.EventHandler(this.bt_consulta_cliente_Click);
            // 
            // bt_relatorio_cliente
            // 
            this.bt_relatorio_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_relatorio_cliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_relatorio_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_relatorio_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_relatorio_cliente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_relatorio_cliente.ForeColor = System.Drawing.Color.Silver;
            this.bt_relatorio_cliente.Location = new System.Drawing.Point(3, 69);
            this.bt_relatorio_cliente.Name = "bt_relatorio_cliente";
            this.bt_relatorio_cliente.Size = new System.Drawing.Size(120, 27);
            this.bt_relatorio_cliente.TabIndex = 39;
            this.bt_relatorio_cliente.Text = "Relatório ";
            this.bt_relatorio_cliente.UseVisualStyleBackColor = false;
            this.bt_relatorio_cliente.Click += new System.EventHandler(this.bt_relatorio_cliente_Click);
            // 
            // bt_funcionario
            // 
            this.bt_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.bt_funcionario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_funcionario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_funcionario.ForeColor = System.Drawing.Color.Azure;
            this.bt_funcionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_funcionario.Location = new System.Drawing.Point(3, 97);
            this.bt_funcionario.Name = "bt_funcionario";
            this.bt_funcionario.Size = new System.Drawing.Size(124, 31);
            this.bt_funcionario.TabIndex = 33;
            this.bt_funcionario.Text = "Funcionário";
            this.bt_funcionario.UseVisualStyleBackColor = false;
            this.bt_funcionario.Click += new System.EventHandler(this.bt_funcionario_Click);
            // 
            // painel_funcionario
            // 
            this.painel_funcionario.Controls.Add(this.bt_cadastro_funcionario);
            this.painel_funcionario.Controls.Add(this.bt_consulta_funcionario);
            this.painel_funcionario.Controls.Add(this.bt_relatorio_funcionario);
            this.painel_funcionario.Location = new System.Drawing.Point(3, 134);
            this.painel_funcionario.MaximumSize = new System.Drawing.Size(126, 100);
            this.painel_funcionario.MinimumSize = new System.Drawing.Size(126, 0);
            this.painel_funcionario.Name = "painel_funcionario";
            this.painel_funcionario.Size = new System.Drawing.Size(126, 0);
            this.painel_funcionario.TabIndex = 40;
            // 
            // bt_cadastro_funcionario
            // 
            this.bt_cadastro_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_cadastro_funcionario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cadastro_funcionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_cadastro_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastro_funcionario.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro_funcionario.ForeColor = System.Drawing.Color.Silver;
            this.bt_cadastro_funcionario.Location = new System.Drawing.Point(3, 3);
            this.bt_cadastro_funcionario.Name = "bt_cadastro_funcionario";
            this.bt_cadastro_funcionario.Size = new System.Drawing.Size(120, 27);
            this.bt_cadastro_funcionario.TabIndex = 35;
            this.bt_cadastro_funcionario.Text = "Cadastro";
            this.bt_cadastro_funcionario.UseVisualStyleBackColor = false;
            this.bt_cadastro_funcionario.Click += new System.EventHandler(this.bt_cadastro_funcionario_Click);
            // 
            // bt_consulta_funcionario
            // 
            this.bt_consulta_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_consulta_funcionario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_consulta_funcionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_consulta_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_consulta_funcionario.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consulta_funcionario.ForeColor = System.Drawing.Color.Silver;
            this.bt_consulta_funcionario.Location = new System.Drawing.Point(3, 36);
            this.bt_consulta_funcionario.Name = "bt_consulta_funcionario";
            this.bt_consulta_funcionario.Size = new System.Drawing.Size(120, 27);
            this.bt_consulta_funcionario.TabIndex = 37;
            this.bt_consulta_funcionario.Text = "Consulta";
            this.bt_consulta_funcionario.UseVisualStyleBackColor = false;
            this.bt_consulta_funcionario.Click += new System.EventHandler(this.bt_consulta_funcionario_Click);
            // 
            // bt_relatorio_funcionario
            // 
            this.bt_relatorio_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_relatorio_funcionario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_relatorio_funcionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_relatorio_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_relatorio_funcionario.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_relatorio_funcionario.ForeColor = System.Drawing.Color.Silver;
            this.bt_relatorio_funcionario.Location = new System.Drawing.Point(3, 69);
            this.bt_relatorio_funcionario.Name = "bt_relatorio_funcionario";
            this.bt_relatorio_funcionario.Size = new System.Drawing.Size(120, 27);
            this.bt_relatorio_funcionario.TabIndex = 39;
            this.bt_relatorio_funcionario.Text = "Relatório ";
            this.bt_relatorio_funcionario.UseVisualStyleBackColor = false;
            this.bt_relatorio_funcionario.Click += new System.EventHandler(this.bt_relatorio_funcionario_Click);
            // 
            // bt_cargo
            // 
            this.bt_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.bt_cargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cargo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cargo.ForeColor = System.Drawing.Color.Azure;
            this.bt_cargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cargo.Location = new System.Drawing.Point(3, 140);
            this.bt_cargo.Name = "bt_cargo";
            this.bt_cargo.Size = new System.Drawing.Size(124, 31);
            this.bt_cargo.TabIndex = 34;
            this.bt_cargo.Text = "Cargo";
            this.bt_cargo.UseVisualStyleBackColor = false;
            this.bt_cargo.Click += new System.EventHandler(this.bt_cargo_Click);
            // 
            // painel_cargo
            // 
            this.painel_cargo.Controls.Add(this.bt_cadastro_cargo);
            this.painel_cargo.Controls.Add(this.bt_consulta_cargo);
            this.painel_cargo.Controls.Add(this.bt_report_cargo);
            this.painel_cargo.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.painel_cargo.Location = new System.Drawing.Point(3, 177);
            this.painel_cargo.MaximumSize = new System.Drawing.Size(124, 100);
            this.painel_cargo.MinimumSize = new System.Drawing.Size(124, 0);
            this.painel_cargo.Name = "painel_cargo";
            this.painel_cargo.Size = new System.Drawing.Size(124, 0);
            this.painel_cargo.TabIndex = 40;
            // 
            // bt_cadastro_cargo
            // 
            this.bt_cadastro_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_cadastro_cargo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cadastro_cargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_cadastro_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastro_cargo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro_cargo.ForeColor = System.Drawing.Color.Silver;
            this.bt_cadastro_cargo.Location = new System.Drawing.Point(1, 3);
            this.bt_cadastro_cargo.Name = "bt_cadastro_cargo";
            this.bt_cadastro_cargo.Size = new System.Drawing.Size(120, 27);
            this.bt_cadastro_cargo.TabIndex = 35;
            this.bt_cadastro_cargo.Text = "Cadastro";
            this.bt_cadastro_cargo.UseVisualStyleBackColor = false;
            this.bt_cadastro_cargo.Click += new System.EventHandler(this.bt_cadastro_cargo_Click);
            // 
            // bt_consulta_cargo
            // 
            this.bt_consulta_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_consulta_cargo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_consulta_cargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_consulta_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_consulta_cargo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consulta_cargo.ForeColor = System.Drawing.Color.Silver;
            this.bt_consulta_cargo.Location = new System.Drawing.Point(1, 36);
            this.bt_consulta_cargo.Name = "bt_consulta_cargo";
            this.bt_consulta_cargo.Size = new System.Drawing.Size(120, 27);
            this.bt_consulta_cargo.TabIndex = 37;
            this.bt_consulta_cargo.Text = "Consulta";
            this.bt_consulta_cargo.UseVisualStyleBackColor = false;
            this.bt_consulta_cargo.Click += new System.EventHandler(this.bt_consulta_cargo_Click);
            // 
            // bt_report_cargo
            // 
            this.bt_report_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_report_cargo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_report_cargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_report_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_report_cargo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_report_cargo.ForeColor = System.Drawing.Color.Silver;
            this.bt_report_cargo.Location = new System.Drawing.Point(1, 69);
            this.bt_report_cargo.Name = "bt_report_cargo";
            this.bt_report_cargo.Size = new System.Drawing.Size(120, 27);
            this.bt_report_cargo.TabIndex = 39;
            this.bt_report_cargo.Text = "Relatório ";
            this.bt_report_cargo.UseVisualStyleBackColor = false;
            this.bt_report_cargo.Click += new System.EventHandler(this.bt_report_cargo_Click);
            // 
            // bt_produto
            // 
            this.bt_produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.bt_produto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_produto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_produto.ForeColor = System.Drawing.Color.Azure;
            this.bt_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_produto.Location = new System.Drawing.Point(3, 183);
            this.bt_produto.Name = "bt_produto";
            this.bt_produto.Size = new System.Drawing.Size(124, 31);
            this.bt_produto.TabIndex = 1;
            this.bt_produto.Text = "Produto";
            this.bt_produto.UseVisualStyleBackColor = false;
            this.bt_produto.Click += new System.EventHandler(this.bt_produto_Click);
            // 
            // painel_produto
            // 
            this.painel_produto.Controls.Add(this.bt_cadastro_prod);
            this.painel_produto.Controls.Add(this.bt_consulta_prod);
            this.painel_produto.Controls.Add(this.bt_relatorio_prod);
            this.painel_produto.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.painel_produto.Location = new System.Drawing.Point(3, 220);
            this.painel_produto.MaximumSize = new System.Drawing.Size(124, 100);
            this.painel_produto.Name = "painel_produto";
            this.painel_produto.Size = new System.Drawing.Size(124, 0);
            this.painel_produto.TabIndex = 31;
            // 
            // bt_cadastro_prod
            // 
            this.bt_cadastro_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_cadastro_prod.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cadastro_prod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_cadastro_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastro_prod.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro_prod.ForeColor = System.Drawing.Color.Silver;
            this.bt_cadastro_prod.Location = new System.Drawing.Point(1, 3);
            this.bt_cadastro_prod.Name = "bt_cadastro_prod";
            this.bt_cadastro_prod.Size = new System.Drawing.Size(120, 27);
            this.bt_cadastro_prod.TabIndex = 0;
            this.bt_cadastro_prod.Text = "Cadastro";
            this.bt_cadastro_prod.UseVisualStyleBackColor = false;
            this.bt_cadastro_prod.Click += new System.EventHandler(this.bt_cadastro_produto_Click);
            // 
            // bt_consulta_prod
            // 
            this.bt_consulta_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_consulta_prod.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_consulta_prod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_consulta_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_consulta_prod.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consulta_prod.ForeColor = System.Drawing.Color.Silver;
            this.bt_consulta_prod.Location = new System.Drawing.Point(1, 36);
            this.bt_consulta_prod.Name = "bt_consulta_prod";
            this.bt_consulta_prod.Size = new System.Drawing.Size(120, 27);
            this.bt_consulta_prod.TabIndex = 1;
            this.bt_consulta_prod.Text = "Consulta";
            this.bt_consulta_prod.UseVisualStyleBackColor = false;
            this.bt_consulta_prod.Click += new System.EventHandler(this.bt_consulta_prod_Click);
            // 
            // bt_relatorio_prod
            // 
            this.bt_relatorio_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_relatorio_prod.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_relatorio_prod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_relatorio_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_relatorio_prod.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_relatorio_prod.ForeColor = System.Drawing.Color.Silver;
            this.bt_relatorio_prod.Location = new System.Drawing.Point(1, 69);
            this.bt_relatorio_prod.Name = "bt_relatorio_prod";
            this.bt_relatorio_prod.Size = new System.Drawing.Size(120, 27);
            this.bt_relatorio_prod.TabIndex = 2;
            this.bt_relatorio_prod.Text = "Relatório";
            this.bt_relatorio_prod.UseVisualStyleBackColor = false;
            this.bt_relatorio_prod.Click += new System.EventHandler(this.bt_relatorio_prod_Click);
            // 
            // bt_subcategorias
            // 
            this.bt_subcategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.bt_subcategorias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_subcategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_subcategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_subcategorias.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_subcategorias.ForeColor = System.Drawing.Color.Azure;
            this.bt_subcategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_subcategorias.Location = new System.Drawing.Point(3, 226);
            this.bt_subcategorias.Name = "bt_subcategorias";
            this.bt_subcategorias.Size = new System.Drawing.Size(124, 31);
            this.bt_subcategorias.TabIndex = 41;
            this.bt_subcategorias.Text = "Subcategorias";
            this.bt_subcategorias.UseVisualStyleBackColor = false;
            this.bt_subcategorias.Click += new System.EventHandler(this.bt_subcategorias_Click);
            // 
            // painel_subcategorias
            // 
            this.painel_subcategorias.Controls.Add(this.bt_cadastro_subcate);
            this.painel_subcategorias.Controls.Add(this.bt_consulta_subcate);
            this.painel_subcategorias.Controls.Add(this.bt_report_subcate);
            this.painel_subcategorias.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.painel_subcategorias.Location = new System.Drawing.Point(3, 263);
            this.painel_subcategorias.MaximumSize = new System.Drawing.Size(124, 100);
            this.painel_subcategorias.Name = "painel_subcategorias";
            this.painel_subcategorias.Size = new System.Drawing.Size(124, 0);
            this.painel_subcategorias.TabIndex = 32;
            // 
            // bt_cadastro_subcate
            // 
            this.bt_cadastro_subcate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_cadastro_subcate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cadastro_subcate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_cadastro_subcate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastro_subcate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro_subcate.ForeColor = System.Drawing.Color.Silver;
            this.bt_cadastro_subcate.Location = new System.Drawing.Point(1, 3);
            this.bt_cadastro_subcate.Name = "bt_cadastro_subcate";
            this.bt_cadastro_subcate.Size = new System.Drawing.Size(120, 27);
            this.bt_cadastro_subcate.TabIndex = 0;
            this.bt_cadastro_subcate.Text = "Cadastro";
            this.bt_cadastro_subcate.UseVisualStyleBackColor = false;
            this.bt_cadastro_subcate.Click += new System.EventHandler(this.bt_cadastro_subcate_Click);
            // 
            // bt_consulta_subcate
            // 
            this.bt_consulta_subcate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_consulta_subcate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_consulta_subcate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_consulta_subcate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_consulta_subcate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consulta_subcate.ForeColor = System.Drawing.Color.Silver;
            this.bt_consulta_subcate.Location = new System.Drawing.Point(1, 36);
            this.bt_consulta_subcate.Name = "bt_consulta_subcate";
            this.bt_consulta_subcate.Size = new System.Drawing.Size(120, 27);
            this.bt_consulta_subcate.TabIndex = 1;
            this.bt_consulta_subcate.Text = "Consulta";
            this.bt_consulta_subcate.UseVisualStyleBackColor = false;
            this.bt_consulta_subcate.Click += new System.EventHandler(this.bt_consulta_subcate_Click);
            // 
            // bt_report_subcate
            // 
            this.bt_report_subcate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bt_report_subcate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_report_subcate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bt_report_subcate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_report_subcate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_report_subcate.ForeColor = System.Drawing.Color.Silver;
            this.bt_report_subcate.Location = new System.Drawing.Point(1, 69);
            this.bt_report_subcate.Name = "bt_report_subcate";
            this.bt_report_subcate.Size = new System.Drawing.Size(120, 27);
            this.bt_report_subcate.TabIndex = 2;
            this.bt_report_subcate.Text = "Relatório";
            this.bt_report_subcate.UseVisualStyleBackColor = false;
            this.bt_report_subcate.Click += new System.EventHandler(this.bt_report_subcate_Click);
            // 
            // bt_venda
            // 
            this.bt_venda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.bt_venda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_venda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_venda.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_venda.ForeColor = System.Drawing.Color.White;
            this.bt_venda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_venda.Location = new System.Drawing.Point(3, 269);
            this.bt_venda.Name = "bt_venda";
            this.bt_venda.Size = new System.Drawing.Size(124, 31);
            this.bt_venda.TabIndex = 34;
            this.bt_venda.Text = "Venda";
            this.bt_venda.UseVisualStyleBackColor = false;
            this.bt_venda.Click += new System.EventHandler(this.bt_venda_Click);
            // 
            // bt_locacao
            // 
            this.bt_locacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.bt_locacao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_locacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_locacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_locacao.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_locacao.ForeColor = System.Drawing.Color.White;
            this.bt_locacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_locacao.Location = new System.Drawing.Point(3, 306);
            this.bt_locacao.Name = "bt_locacao";
            this.bt_locacao.Size = new System.Drawing.Size(124, 31);
            this.bt_locacao.TabIndex = 42;
            this.bt_locacao.Text = "Locação";
            this.bt_locacao.UseVisualStyleBackColor = false;
            this.bt_locacao.Click += new System.EventHandler(this.bt_locacao_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 31);
            this.button1.TabIndex = 43;
            this.button1.Text = "Relatório Venda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer_produto
            // 
            this.timer_produto.Tick += new System.EventHandler(this.timer_produto_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_time.Location = new System.Drawing.Point(54, 70);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(95, 45);
            this.lb_time.TabIndex = 31;
            this.lb_time.Text = "Hora";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_data.Location = new System.Drawing.Point(55, 112);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(64, 32);
            this.lb_data.TabIndex = 32;
            this.lb_data.Text = "Data";
            // 
            // timer_horario
            // 
            this.timer_horario.Tick += new System.EventHandler(this.timer_horario_Tick);
            // 
            // timer_funcionario
            // 
            this.timer_funcionario.Tick += new System.EventHandler(this.timer_funcionario_Tick);
            // 
            // timer_cargo
            // 
            this.timer_cargo.Tick += new System.EventHandler(this.timer_cargo_Tick);
            // 
            // timer_cliente
            // 
            this.timer_cliente.Tick += new System.EventHandler(this.timer_cliente_Tick);
            // 
            // timer_subcategorias
            // 
            this.timer_subcategorias.Tick += new System.EventHandler(this.timer_subcategorias_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 695);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(901, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.painel_lateral);
            this.Controls.Add(this.barra_topo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_principal";
            this.ShowIcon = false;
            this.Text = "Formulário Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_principal_Load);
            this.painel_fechar.ResumeLayout(false);
            this.barra_topo.ResumeLayout(false);
            this.painel_lateral.ResumeLayout(false);
            this.painel_cliente.ResumeLayout(false);
            this.painel_funcionario.ResumeLayout(false);
            this.painel_cargo.ResumeLayout(false);
            this.painel_produto.ResumeLayout(false);
            this.painel_subcategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel painel_fechar;
        private System.Windows.Forms.Button bt_fechar_sistema;
        private System.Windows.Forms.Panel barra_topo;
        private System.Windows.Forms.FlowLayoutPanel painel_lateral;
        private System.Windows.Forms.Button bt_menu;
        private System.Windows.Forms.Button bt_produto;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button bt_consulta_prod;
        private System.Windows.Forms.Button bt_cadastro_prod;
        private System.Windows.Forms.Timer timer_produto;
        private System.Windows.Forms.Button bt_cliente;
        private System.Windows.Forms.Button bt_funcionario;
        private System.Windows.Forms.Button bt_cargo;
        private System.Windows.Forms.FlowLayoutPanel painel_produto;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Timer timer_horario;
        private System.Windows.Forms.Button bt_cadastro_cliente;
        private System.Windows.Forms.Button bt_consulta_cliente;
        private System.Windows.Forms.Button bt_relatorio_cliente;
        private System.Windows.Forms.FlowLayoutPanel painel_cliente;
        private System.Windows.Forms.FlowLayoutPanel painel_funcionario;
        private System.Windows.Forms.Button bt_cadastro_funcionario;
        private System.Windows.Forms.Button bt_consulta_funcionario;
        private System.Windows.Forms.Button bt_relatorio_funcionario;
        private System.Windows.Forms.FlowLayoutPanel painel_cargo;
        private System.Windows.Forms.Button bt_cadastro_cargo;
        private System.Windows.Forms.Button bt_consulta_cargo;
        private System.Windows.Forms.Button bt_report_cargo;
        private System.Windows.Forms.Timer timer_funcionario;
        private System.Windows.Forms.Timer timer_cargo;
        private System.Windows.Forms.Timer timer_cliente;
        private System.Windows.Forms.Button bt_relatorio_prod;
        private System.Windows.Forms.Button bt_subcategorias;
        private System.Windows.Forms.FlowLayoutPanel painel_subcategorias;
        private System.Windows.Forms.Button bt_cadastro_subcate;
        private System.Windows.Forms.Button bt_consulta_subcate;
        private System.Windows.Forms.Button bt_report_subcate;
        private System.Windows.Forms.Timer timer_subcategorias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_venda;
        private System.Windows.Forms.Button bt_locacao;
        private System.Windows.Forms.Button button1;
    }
}

