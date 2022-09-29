using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace academia
{
    public partial class profesor : Form
    {
        public profesor()
        {
            InitializeComponent();
        }

        private void profesor_Load(object sender, EventArgs e)
        {
            string vquery = @"
        
            SELECT
              n_idproff as 'id',
            
            t_nomeprooff as 'nome',

            t_telefone as 'telefon'


            FROM  tb_proff
            
                ORDER BY n_idproff";


            dataGridView1.DataSource = banco.dql(vquery);
            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 300;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int linhas = dgv.SelectedRows.Count;
            if (linhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                            
                    SELECT 
                    *FROM
                        
                        tb_proff

                WHERE
                       n_idproff
                                =

                        "
                + vid;


                dt = banco.dql(vquery);
                tb_id.Text = dt.Rows[0].Field<Int64>("n_idproff").ToString();

                tb_nome.Text = dt.Rows[0].Field<string>("t_nomeprooff");

                maskedTextBox1.Text = dt.Rows[0].Field<string>("t_telefone");
            }
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            tb_nome.Clear();
            maskedTextBox1.Clear();
            tb_nome.Focus();
        }

        private void bt_salve_Click(object sender, EventArgs e)
        {
            string vquery;

            if (tb_id.Text == "")
            {


                vquery = @"INSERT INTO tb_proff (t_nomeprooff,t_telefone) VALUES ('" + tb_nome.Text + "','" + maskedTextBox1.Text + "')";
            }
            else
            {
                vquery = @"UPDATE  tb_proff SET t_nomeprooff='" + tb_nome.Text + "',t_telefone='" + maskedTextBox1.Text + "' WHERE n_idproff=" + tb_id.Text;

            }
            banco.dml(vquery);

            vquery = @"
        
            SELECT
              n_idproff as 'id',
                t_nomeprooff as 'nome',
            
            t_telefone as 'telefon'


            FROM  tb_proff  ORDER BY n_idproff";

            dataGridView1.DataSource = banco.dql(vquery);


        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("confirma", "excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = @"DELETE FROM tb_proff WHERE n_idproff =" + tb_id.Text;

                banco.dml(vquery);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            Console.Beep();
        }
    }
}
