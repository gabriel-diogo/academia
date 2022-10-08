using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class g_aluno : Form
    {

        string querydgv = "";
        string tmatual = "";
        string idcell = "";
        string turm = "";
        int linha = 0;
        public g_aluno()
        {
            InitializeComponent();
        }

        private void g_aluno_Load(object sender, EventArgs e)
        {
            querydgv = @"SELECT n_idalino as 'id' ,t_nomea as 'aluno' FROM tb_aluno";
            dataGridView1.DataSource = banco.dql(querydgv);

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 120;

            tb_nome.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();

            //popula cbturma

            string vqueryturma = @"SELECT n_idturma ,('vagas: '|| (
                (n_maxaluno)-(SELECT count(tba.n_idalino)
                    FROM tb_aluno as tba
                WHERE tba.t_status ='A' and tba.n_idturma=n_idturma))
                 || ' / turma : ' || t_descturma ) as 'turma' FROM 
                    tb_turma
                        ORDER BY n_idturma
                        ";

            cb_turma.Items.Clear();
            cb_turma.DataSource = banco.dql(vqueryturma);

            cb_turma.DisplayMember = "turma";
            cb_turma.ValueMember = "n_idturma";

            //pop status

            Dictionary<string, string> s = new Dictionary<string, string>();
            s.Add("A", "ativo");
            s.Add("B", "block");
            s.Add("C", "cancel");

            cb_status.DataSource = new BindingSource(s, null);
            cb_status.DisplayMember = "VALUE";
            cb_status.ValueMember = "KEY";

            turm = cb_turma.Text;
            tmatual = cb_turma.Text;
            idcell = dataGridView1.Rows[0].Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            turm = cb_turma.Text;
            if (tmatual != turm)
            {
                string[] t =turm.Split(' ');
                int vagas=int.Parse(t[1]);
                if(vagas < 1)
                {Console.Beep(); Console.Beep(); Console.Beep();


                    MessageBox.Show("nao a vagas");

                    

                    cb_turma.Focus();
                    return;
                }
               // linha = dataGridView1.SelectedRows[0].Index;
                string queryupdat = string.Format(@"UPDATE tb_aluno SET 
                t_nomea = '{0}',t_tel= '{1}',t_status = '{2}',n_idturma ='{3}'
                WHERE n_idalino= {4}
                  ",tb_nome.Text,mk_tel.Text,cb_status.SelectedValue,cb_turma.SelectedValue,idcell);
                banco.dml(queryupdat);
                // dataGridView1[1,linha].Value=tb_nome.Text;
                
            }
                Console.Beep();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
           
                
                if (File.Exists(pictureBox1.ImageLocation))
                {
                    File.Delete(pictureBox1.ImageLocation);
                }
                string querydel = string.Format(@"DELETE FROM tb_aluno WHERE  n_idalino ={0}",idcell);

                 banco.dml(querydel);
               // banco.deleteuser(dataGridView1.CurrentRow.ToString());

                
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv=(DataGridView)sender;

            if(dgv.SelectedRows.Count > 0)
            {
                idcell = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                tb_nome.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
                idcell = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                string querycp = string.Format(@"SELECT n_idalino ,t_nomea,t_tel,t_status,n_idturma,t_foto
                   FROM tb_aluno WHERE n_idalino={0}", idcell);
                DataTable dt=banco.dql(querycp);

                tb_nome.Text = dt.Rows[0].Field<string>("t_nomea");
                mk_tel.Text = dt.Rows[0].Field<string>("t_tel");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("t_status");
                cb_turma.SelectedValue = dt.Rows[0].Field<Int64>("n_idturma");
                tmatual = cb_turma.Text;
                pictureBox1.ImageLocation= dt.Rows[0].Field<string>("t_foto");
            }
        }
    }
}
