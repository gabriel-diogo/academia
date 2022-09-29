using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class login : Form
    {

        Form1 form1;

        DataTable dt;
        public login(Form1 f)
        {
            InitializeComponent();

            form1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usern =tb_name.Text;

            string senha =tb_senha.Text;

            if (usern == "" | senha == "")
            {
                MessageBox.Show("texto fazio");

                tb_name.Focus();
                return;
            }

            string sql = "Select *From tb_user Where  t_usename='"+usern+ "'And t_senha ='" + senha+"'";

            dt=banco.consulta(sql);

            //dt = banco.dql(sql);

            if(dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_usuario.Text = dt.Rows[0].Field<string>("t_usename");
                form1.pictureBox1.Image = Properties.Resources.s;
                global.nivel = int.Parse(dt.Rows[0].Field<Int64>("n_nivel").ToString());
                global.logado = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("nao encontrado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
