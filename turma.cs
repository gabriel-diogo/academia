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
    public partial class turma : Form
    {
        public turma()
        {
            InitializeComponent();
        }

        private void turma_Load(object sender, EventArgs e)
        {
            string vquery = @"
            
                SELECT 
                    tbt.n_idturma as 'id',

                    tbt.t_descturma as 'turma',
                        tbh.t_deschora as 'hora'


                        FROM

                 tb_turma as tbt

                inner join 

            tb_horario as tbh on tbh.n_idhora =tbt.n_hora
                

                ";

            dataGridView1.DataSource = banco.dql( vquery);
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 200;



            string vqueryprof = @"
                SELECT
                n_idproff,
                t_nomeprooff

            FROM
                tb_proff
            ORDER BY n_idproff

    
                    ";
            cb_proff.Items.Clear();
            cb_proff.DataSource = banco.dql( vqueryprof);
            cb_proff.DisplayMember = "t_nomeprooff";
            cb_proff.ValueMember = "n_idproff";



            Dictionary<string, string> st = new Dictionary<string, string>();

            st.Add("A", "activa");
            st.Add("p", "parada");
            st.Add("c", "cancel");

            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st,null);
            cb_status.DisplayMember = "VALUE";
            cb_status.ValueMember = "KEY";


            string vqueryhora = @"SELECT *FROM tb_horario ORDER BY t_deschora";

            cb_hora.Items.Clear();
            cb_hora.DataSource=banco.dql( vqueryhora);
            cb_hora.DisplayMember = "t_deschora";
            cb_hora.ValueMember = "n_idhora";

        }
    }
}
