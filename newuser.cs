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
    public partial class newuser : Form
    {
        public newuser()
        {
            InitializeComponent();
        }

        private void bt_salve_Click(object sender, EventArgs e)
        {
            novouser nu=new novouser();

            nu.name=tb_nome.Text;
            nu.username=tb_username.Text;
            nu.password=tb_senha.Text;
            nu.status = cb_status.Text;

            nu.nivel = Convert.ToInt32(Math.Round(nd_nivel.Value, 0));

            banco.n_user(nu);
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            nd_nivel.Value = 0;
            tb_nome.Focus();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            nd_nivel.Value = 0;
            tb_nome.Focus();
        }
    }
}
