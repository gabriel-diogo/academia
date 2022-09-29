namespace academia
{
    partial class turma
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_imp = new System.Windows.Forms.Button();
            this.b_novo = new System.Windows.Forms.Button();
            this.bt_ex = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.cb_proff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nd_max = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_hora = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_max)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(4, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(410, 359);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_imp);
            this.panel1.Controls.Add(this.b_novo);
            this.panel1.Controls.Add(this.bt_ex);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 35);
            this.panel1.TabIndex = 8;
            // 
            // b_imp
            // 
            this.b_imp.Location = new System.Drawing.Point(517, 3);
            this.b_imp.Name = "b_imp";
            this.b_imp.Size = new System.Drawing.Size(75, 23);
            this.b_imp.TabIndex = 3;
            this.b_imp.Text = "imprimir";
            this.b_imp.UseVisualStyleBackColor = true;
            // 
            // b_novo
            // 
            this.b_novo.Location = new System.Drawing.Point(307, 3);
            this.b_novo.Name = "b_novo";
            this.b_novo.Size = new System.Drawing.Size(75, 23);
            this.b_novo.TabIndex = 2;
            this.b_novo.Text = "novo";
            this.b_novo.UseVisualStyleBackColor = true;
            // 
            // bt_ex
            // 
            this.bt_ex.Location = new System.Drawing.Point(168, 3);
            this.bt_ex.Name = "bt_ex";
            this.bt_ex.Size = new System.Drawing.Size(75, 23);
            this.bt_ex.TabIndex = 1;
            this.bt_ex.Text = "excluir";
            this.bt_ex.UseVisualStyleBackColor = true;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(12, 3);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 0;
            this.bt_save.Text = "salve";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // cb_proff
            // 
            this.cb_proff.FormattingEnabled = true;
            this.cb_proff.Location = new System.Drawing.Point(420, 45);
            this.cb_proff.Name = "cb_proff";
            this.cb_proff.Size = new System.Drawing.Size(177, 21);
            this.cb_proff.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "profesor";
            // 
            // nd_max
            // 
            this.nd_max.Location = new System.Drawing.Point(420, 128);
            this.nd_max.Name = "nd_max";
            this.nd_max.Size = new System.Drawing.Size(98, 20);
            this.nd_max.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "max";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(546, 128);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(84, 21);
            this.cb_status.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "status";
            // 
            // cb_hora
            // 
            this.cb_hora.FormattingEnabled = true;
            this.cb_hora.Location = new System.Drawing.Point(424, 254);
            this.cb_hora.Name = "cb_hora";
            this.cb_hora.Size = new System.Drawing.Size(177, 21);
            this.cb_hora.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "horario";
            // 
            // turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_hora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nd_max);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_proff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "turma";
            this.Text = "turma";
            this.Load += new System.EventHandler(this.turma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nd_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_imp;
        private System.Windows.Forms.Button b_novo;
        private System.Windows.Forms.Button bt_ex;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.ComboBox cb_proff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nd_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_hora;
        private System.Windows.Forms.Label label4;
    }
}