namespace academia
{
    partial class gestaouser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.nd_nivel = new System.Windows.Forms.NumericUpDown();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.l_nivel = new System.Windows.Forms.Label();
            this.l_status = new System.Windows.Forms.Label();
            this.l_senha = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_saveat = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nd_nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "d=desligado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "b=blockeado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "A=ativo";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "b",
            "d"});
            this.cb_status.Location = new System.Drawing.Point(26, 236);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 27;
            // 
            // nd_nivel
            // 
            this.nd_nivel.Location = new System.Drawing.Point(183, 237);
            this.nd_nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nd_nivel.Name = "nd_nivel";
            this.nd_nivel.Size = new System.Drawing.Size(120, 20);
            this.nd_nivel.TabIndex = 26;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(26, 164);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(128, 20);
            this.tb_username.TabIndex = 25;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(172, 164);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '.';
            this.tb_senha.Size = new System.Drawing.Size(107, 20);
            this.tb_senha.TabIndex = 24;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(29, 96);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(253, 20);
            this.tb_nome.TabIndex = 23;
            // 
            // l_nivel
            // 
            this.l_nivel.AutoSize = true;
            this.l_nivel.Location = new System.Drawing.Point(180, 202);
            this.l_nivel.Name = "l_nivel";
            this.l_nivel.Size = new System.Drawing.Size(29, 13);
            this.l_nivel.TabIndex = 22;
            this.l_nivel.Text = "nivel";
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Location = new System.Drawing.Point(23, 202);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(35, 13);
            this.l_status.TabIndex = 21;
            this.l_status.Text = "status";
            // 
            // l_senha
            // 
            this.l_senha.AutoSize = true;
            this.l_senha.Location = new System.Drawing.Point(169, 148);
            this.l_senha.Name = "l_senha";
            this.l_senha.Size = new System.Drawing.Size(36, 13);
            this.l_senha.TabIndex = 20;
            this.l_senha.Text = "senha";
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.Location = new System.Drawing.Point(23, 148);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(53, 13);
            this.l_username.TabIndex = 19;
            this.l_username.Text = "username";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(32, 80);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(33, 13);
            this.l_name.TabIndex = 18;
            this.l_name.Text = "name";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(26, 40);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(107, 20);
            this.tb_id.TabIndex = 32;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(23, 24);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 31;
            this.id.Text = "id";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(349, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 433);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_saveat);
            this.panel1.Controls.Add(this.b_delete);
            this.panel1.Controls.Add(this.b_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 38);
            this.panel1.TabIndex = 34;
            // 
            // b_saveat
            // 
            this.b_saveat.Location = new System.Drawing.Point(172, 4);
            this.b_saveat.Name = "b_saveat";
            this.b_saveat.Size = new System.Drawing.Size(143, 23);
            this.b_saveat.TabIndex = 2;
            this.b_saveat.Text = "salva";
            this.b_saveat.UseVisualStyleBackColor = true;
            this.b_saveat.Click += new System.EventHandler(this.b_saveat_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(367, 3);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(143, 23);
            this.b_delete.TabIndex = 1;
            this.b_delete.Text = "excluir";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_novo
            // 
            this.b_novo.Location = new System.Drawing.Point(4, 4);
            this.b_novo.Name = "b_novo";
            this.b_novo.Size = new System.Drawing.Size(143, 23);
            this.b_novo.TabIndex = 0;
            this.b_novo.Text = "new";
            this.b_novo.UseVisualStyleBackColor = true;
            this.b_novo.Click += new System.EventHandler(this.b_novo_Click);
            // 
            // gestaouser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.nd_nivel);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.l_nivel);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.l_senha);
            this.Controls.Add(this.l_username);
            this.Controls.Add(this.l_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gestaouser";
            this.Text = "gestaouser3";
            this.Load += new System.EventHandler(this.gestaouser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nd_nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.NumericUpDown nd_nivel;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label l_nivel;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label l_senha;
        private System.Windows.Forms.Label l_username;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_saveat;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_novo;
    }
}