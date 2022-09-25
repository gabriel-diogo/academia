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
    }
}
