using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace academia
{
    public partial class aluno : Form
    {
        string oringenc = "", foto = "", destinoc = "", pastad = global.caminhofoto;

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
            if (destinoc == "")
            {
                if (MessageBox.Show("sem foto", "ero", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                if (destinoc != "")
                {
                    System.IO.File.Copy(oringenc, destinoc, true);
                    if (File.Exists(destinoc))
                    {
                        pictureBox1.ImageLocation = destinoc;
                    }
                    else
                    {
                        if (MessageBox.Show("sem foto", "ero", MessageBoxButtons.YesNo) == DialogResult.No)
                        { return; }
                    }
                }
            }


            string query = string.Format(@"INSERT INTO tb_aluno
            
            (t_nomea,t_tel,t_status,n_idturma,t_foto)
            VALUES('{0}','{1}','{2}',{3},'{4}')",

            tb_nome.Text,mk_tel.Text,cb_status.SelectedValue,tb_turma.Tag.ToString(),destinoc);

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
            pictureBox1.ImageLocation=destinoc;
        }

        private void btn_turma_Click(object sender, EventArgs e)
        {
            selecionaturma s=new selecionaturma(this);
            s.ShowDialog();
        }
        
        
        private void btn_foto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                oringenc = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoc=pastad+foto;
            }
            if (File.Exists(destinoc))
            {
                if(MessageBox.Show("ja existe","substituir",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            
            
            
          
                pictureBox1.ImageLocation= oringenc;
          

        }
    }
}
