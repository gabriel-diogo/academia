namespace academia
{
    partial class newuser
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
            this.l_name = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.Label();
            this.l_senha = new System.Windows.Forms.Label();
            this.l_status = new System.Windows.Forms.Label();
            this.l_nivel = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.nd_nivel = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fecha = new System.Windows.Forms.Button();
            this.bt_salve = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nd_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(32, 62);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(33, 13);
            this.l_name.TabIndex = 0;
            this.l_name.Text = "name";
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.Location = new System.Drawing.Point(32, 118);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(53, 13);
            this.l_username.TabIndex = 2;
            this.l_username.Text = "username";
            // 
            // l_senha
            // 
            this.l_senha.AutoSize = true;
            this.l_senha.Location = new System.Drawing.Point(178, 118);
            this.l_senha.Name = "l_senha";
            this.l_senha.Size = new System.Drawing.Size(36, 13);
            this.l_senha.TabIndex = 4;
            this.l_senha.Text = "senha";
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Location = new System.Drawing.Point(32, 188);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(35, 13);
            this.l_status.TabIndex = 6;
            this.l_status.Text = "status";
            // 
            // l_nivel
            // 
            this.l_nivel.AutoSize = true;
            this.l_nivel.Location = new System.Drawing.Point(189, 188);
            this.l_nivel.Name = "l_nivel";
            this.l_nivel.Size = new System.Drawing.Size(29, 13);
            this.l_nivel.TabIndex = 8;
            this.l_nivel.Text = "nivel";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(35, 78);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(253, 20);
            this.tb_nome.TabIndex = 9;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(181, 134);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(107, 20);
            this.tb_senha.TabIndex = 10;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(35, 134);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(128, 20);
            this.tb_username.TabIndex = 12;
            // 
            // nd_nivel
            // 
            this.nd_nivel.Location = new System.Drawing.Point(192, 223);
            this.nd_nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nd_nivel.Name = "nd_nivel";
            this.nd_nivel.Size = new System.Drawing.Size(120, 20);
            this.nd_nivel.TabIndex = 13;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "b",
            "d"});
            this.cb_status.Location = new System.Drawing.Point(35, 222);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "A=ativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "b=blockeado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "d=desligado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fecha);
            this.panel1.Controls.Add(this.bt_salve);
            this.panel1.Controls.Add(this.bt_cancel);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 35);
            this.panel1.TabIndex = 18;
            // 
            // bt_fecha
            // 
            this.bt_fecha.Location = new System.Drawing.Point(312, 3);
            this.bt_fecha.Name = "bt_fecha";
            this.bt_fecha.Size = new System.Drawing.Size(75, 23);
            this.bt_fecha.TabIndex = 4;
            this.bt_fecha.Text = "fecha";
            this.bt_fecha.UseVisualStyleBackColor = true;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // bt_salve
            // 
            this.bt_salve.Location = new System.Drawing.Point(88, 3);
            this.bt_salve.Name = "bt_salve";
            this.bt_salve.Size = new System.Drawing.Size(75, 23);
            this.bt_salve.TabIndex = 3;
            this.bt_salve.Text = "salva";
            this.bt_salve.UseVisualStyleBackColor = true;
            this.bt_salve.Click += new System.EventHandler(this.bt_salve_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(181, 3);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 2;
            this.bt_cancel.Text = "cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(0, 3);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 23);
            this.bt_novo.TabIndex = 0;
            this.bt_novo.Text = "novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // newuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.panel1);
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
            this.Name = "newuser";
            this.Text = "newuser";
            ((System.ComponentModel.ISupportInitialize)(this.nd_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_username;
        private System.Windows.Forms.Label l_senha;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label l_nivel;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.NumericUpDown nd_nivel;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_fecha;
        private System.Windows.Forms.Button bt_salve;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_novo;
    }
}