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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           login l = new login(this);

            l.ShowDialog();
        }


        private void abriform(int nivel,Form f)
        {
            if (global.logado)
            {
                if (global.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("nao permitido");
                }
            }
            else
            {
                MessageBox.Show("faca login");
            }
        }

        private void logarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           login f=new login(this);
            f.ShowDialog();
        }

        private void logooffToolStripMenuItem_Click(object sender, EventArgs e)
        { lb_acesso.Text = "0";
            lb_nomeu.Text = "";
            pictureBox1.Image = Properties.Resources.f;

            global.nivel = 0;
            global.logado = false;

        }

        private void novoUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (global.logado)
            {

                if (global.nivel >= 1)
                {
                    newuser n = new newuser();
                    n.ShowDialog();
                }
                else
                {
                    MessageBox.Show("acesso nao permitido");
                }
            }
            else
            {
                MessageBox.Show("facalogin");
            }
        }

        private void gestaoDeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (global.logado)
            {
                if(global.nivel >= 1)
                {
                    gestaouser g =new gestaouser();

                    g.ShowDialog();
                }
                else
                {
                    MessageBox.Show("nao permitodo");
                }
            }
            else
            {
                MessageBox.Show("faca login");
            }
        }

        private void horarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_horariocs f =new F_horariocs();

            abriform(2, f);
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profesor p = new profesor();
            abriform(2, p);
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turma t=new turma();

            abriform(2, t);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aluno a=new aluno();
            abriform(1, a);
        }
    }
}
