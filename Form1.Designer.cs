namespace academia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nomeu = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manutecaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestaoDeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logooffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lb_nomeu);
            this.panel1.Controls.Add(this.lb_usuario);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 76);
            this.panel1.TabIndex = 0;
            // 
            // lb_nomeu
            // 
            this.lb_nomeu.AutoSize = true;
            this.lb_nomeu.Location = new System.Drawing.Point(359, 50);
            this.lb_nomeu.Name = "lb_nomeu";
            this.lb_nomeu.Size = new System.Drawing.Size(27, 13);
            this.lb_nomeu.TabIndex = 4;
            this.lb_nomeu.Text = "*****";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(281, 50);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(41, 13);
            this.lb_usuario.TabIndex = 3;
            this.lb_usuario.Text = "usuario";
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(238, 50);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(13, 13);
            this.lb_acesso.TabIndex = 2;
            this.lb_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "acesso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::academia.Properties.Resources.f;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutecaoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.logarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manutecaoToolStripMenuItem
            // 
            this.manutecaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem});
            this.manutecaoToolStripMenuItem.Name = "manutecaoToolStripMenuItem";
            this.manutecaoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.manutecaoToolStripMenuItem.Text = "manutecao";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "banco de dados";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUserToolStripMenuItem,
            this.gestaoDeUserToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.usuariosToolStripMenuItem.Text = "usuarios";
            // 
            // novoUserToolStripMenuItem
            // 
            this.novoUserToolStripMenuItem.Name = "novoUserToolStripMenuItem";
            this.novoUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoUserToolStripMenuItem.Text = "novo user";
            this.novoUserToolStripMenuItem.Click += new System.EventHandler(this.novoUserToolStripMenuItem_Click);
            // 
            // gestaoDeUserToolStripMenuItem
            // 
            this.gestaoDeUserToolStripMenuItem.Name = "gestaoDeUserToolStripMenuItem";
            this.gestaoDeUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestaoDeUserToolStripMenuItem.Text = "gestao de user";
            this.gestaoDeUserToolStripMenuItem.Click += new System.EventHandler(this.gestaoDeUserToolStripMenuItem_Click);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem});
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.alunoToolStripMenuItem.Text = "aluno";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.novoAlunoToolStripMenuItem.Text = "novo aluno";
            // 
            // logarToolStripMenuItem
            // 
            this.logarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logarToolStripMenuItem1,
            this.logooffToolStripMenuItem});
            this.logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            this.logarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.logarToolStripMenuItem.Text = "logar";
            // 
            // logarToolStripMenuItem1
            // 
            this.logarToolStripMenuItem1.Name = "logarToolStripMenuItem1";
            this.logarToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.logarToolStripMenuItem1.Text = "logon";
            this.logarToolStripMenuItem1.Click += new System.EventHandler(this.logarToolStripMenuItem1_Click);
            // 
            // logooffToolStripMenuItem
            // 
            this.logooffToolStripMenuItem.Name = "logooffToolStripMenuItem";
            this.logooffToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.logooffToolStripMenuItem.Text = "logoff";
            this.logooffToolStripMenuItem.Click += new System.EventHandler(this.logooffToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "academia v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lb_nomeu;
        public System.Windows.Forms.Label lb_usuario;
        public System.Windows.Forms.Label lb_acesso;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logooffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutecaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestaoDeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAlunoToolStripMenuItem;
    }
}

