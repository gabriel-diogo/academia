using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class aluno : Form
    {
        public aluno()
        {
            InitializeComponent();
        }

        private void aluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();

            status.Add("A", "ativo");
            status.Add("B", "block");
            status.Add("P", "parado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "VALUE";
            cb_status.ValueMember = "KEY";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            tb_nome.Clear();
            mk_tel.Clear();
            cb_status.SelectedIndex= 0;
            tb_nome.Focus();
            button2.Enabled=true;
            button3.Enabled = true;
            button1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            tb_nome.Enabled = false;
            mk_tel.Enabled = false;
            cb_status.Enabled = false;
            cb_status.Enabled=false;

            tb_nome.Clear();
            mk_tel.Clear();
            cb_status.SelectedIndex = 0;
            
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = string.Format(@"INSERT INTO tb_aluno
            
            (t_nomea,t_tel,t_status,n_idturma)
            VALUES('{0}','{1}','{2}',{3})",

            tb_nome.Text,mk_tel.Text,cb_status.SelectedValue,tb_turma.Tag.ToString());

            banco.dml(query);
            MessageBox.Show("gravado");






            tb_nome.Enabled = false;
            mk_tel.Enabled = false;
            cb_status.Enabled = false;
            cb_status.Enabled = false;

            tb_nome.Clear();
            mk_tel.Clear();
            cb_status.SelectedIndex = 0;

            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
        }

        private void btn_turma_Click(object sender, EventArgs e)
        {
            selecionaturma s=new selecionaturma(this);
            s.ShowDialog();
        }
    }
}
