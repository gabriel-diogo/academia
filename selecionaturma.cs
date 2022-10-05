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
    public partial class selecionaturma : Form
    {
        aluno ss;
        public selecionaturma(aluno s)
        {
            InitializeComponent();
            ss = s;
        }

        private void selecionaturma_Load(object sender, EventArgs e)
        {
            string queryturma = string.Format(@"

            SELECT tbt.n_idturma as 'id',
            tbt.t_descturma as 'turma',
            tbh.t_deschora as 'hora',
            tbp.t_nomeprooff as 'proff',
            tbt.n_maxaluno as 'max',
    
            (SELECT count(n_idalino)FROM tb_aluno as tba WHERE tba.n_idturma = tbt.n_idturma and t_status = 'A')
            as 'qdte. alunos' FROM tb_turma as tbt

            INNER JOIN tb_proff as tbp on tbp.n_idproff = tbt.n_idproff
            INNER JOIN tb_horario as tbh on tbh.n_idhora =tbt.n_hora


                    ");
            dataGridView1.DataSource=banco.dql(queryturma);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridView d = (DataGridView)sender;
            int maxa = 0;
            int qtdea=0;
            maxa = Int32.Parse(d.SelectedRows[0].Cells[4].Value.ToString());
            qtdea=Int32.Parse(d.SelectedRows[0].Cells[5].Value.ToString());
            if (qtdea >= maxa)
            {
                MessageBox.Show("nao a vagas");
            }
            else
            {
                

                ss.tb_turma.Text = d.Rows[d.SelectedRows[0].Index].Cells[1].Value.ToString();
                ss.tb_turma.Tag = d.Rows[d.SelectedRows[0].Index].Cells[0].Value.ToString();
                
                Close();
            }
        }
    }
}
