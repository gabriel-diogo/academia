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
    public partial class F_horariocs : Form
    {
        public F_horariocs()
        {
            InitializeComponent();
        }

        private void F_horariocs_Load(object sender, EventArgs e)
        {
            string vquery = @"
        
            SELECT
              n_idhora as 'id',
            
            t_deschora as 'horario'


            FROM  tb_horario 
            
                ORDER BY t_deschora";


            dataGridView1.DataSource = banco.dql( vquery);
            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].Width = 460;
            
        
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           DataGridView dgv = (DataGridView) sender;
            int linhas =dgv.SelectedRows.Count;
            if(linhas > 0)
            {
                DataTable dt=new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                            
                    SELECT 
                    *FROM
                        
                        tb_horario

                WHERE
                        n_idhora
                                =

                        "+vid;


                dt=banco.dql(vquery);
                textBox1.Text=dt.Rows[0].Field<Int64>("n_idhora").ToString();
                maskedTextBox1.Text = dt.Rows[0].Field<string>("t_deschora");
            }
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            maskedTextBox1.Focus();
        }

        private void bt_salve_Click(object sender, EventArgs e)
        {
            string vquery;

            if (textBox1.Text == "") { 
                
                
                vquery = @"INSERT INTO tb_horario (t_deschora) VALUES ('"+maskedTextBox1.Text +"')";
            }
            else
            {
                vquery = @"UPDATE  tb_horario SET t_deschora='" + maskedTextBox1.Text + "' WHERE n_idhora="+textBox1.Text;

            }
            banco.dml(vquery);

            vquery = @"
        
            SELECT
              n_idhora as 'id',
            
            t_deschora as 'horario'


            FROM  tb_horario  ORDER BY t_deschora";

            dataGridView1.DataSource = banco.dql(vquery);

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("confirma", "excluir", MessageBoxButtons.YesNo);
            if(res== DialogResult.Yes)
            {
                string vquery = @"DELETE FROM tb_horario WHERE n_idhora ="+textBox1.Text;

                banco.dml(vquery);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }
    }
}
