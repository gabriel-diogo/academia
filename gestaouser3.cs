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
    public partial class gestaouser : Form
    {
        public gestaouser()
        {
            InitializeComponent();
        }

        private void gestaouser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = banco.obid();

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 170;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;

            int linha = dgv.SelectedRows.Count;

            if(linha > 0)
            {
                DataTable dt=new DataTable();

                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                dt = banco.obtdados(vid);

                tb_id.Text = dt.Rows[0].Field<Int64>("n_id").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("t_nome").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("t_usename").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("t_senha").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("t_status").ToString();
                nd_nivel.Value = dt.Rows[0].Field<Int64>("n_nivel");

            }
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            newuser ne =new newuser();

            ne.ShowDialog();

            dataGridView1.DataSource = banco.obid();
        }

        private void b_saveat_Click(object sender, EventArgs e)
        {

            try
            {

                int linha = dataGridView1.SelectedRows[0].Index;
                novouser u = new novouser();

                u.id = Convert.ToInt32(tb_id.Text);
                u.name = tb_nome.Text;
                u.username = tb_username.Text;
                u.password = tb_senha.Text;
                u.status = cb_status.Text;
                u.nivel = Convert.ToInt32(Math.Round(nd_nivel.Value, 0));
                banco.atualizauser(u);
                dataGridView1[1, linha].Value=tb_nome.Text;

            }
            catch (Exception ee)
            {
                MessageBox.Show("ero", ee.ToString());
            }


            //pesado
            //dataGridView1.DataSource = banco.obid();

            //dataGridView1.CurrentCell = dataGridView1[0, linha];

            //leve

            
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("excluir?", "confirma", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                banco.deleteuser(tb_id.Text);

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }
    }
}
