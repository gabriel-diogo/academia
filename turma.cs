using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace academia
{
    public partial class turma : Form
    {
        int modo = 0;

        string idcel;

        public void salvar()
        {
            string queryTurma = "";

            if (tb_nomet.Text == "" | cb_proff.Text == "" | cb_hora.Text == ""  )
            {
                MessageBox.Show("FALTA DADOS A SER INSERIDO");
                return;
            }
            else
            {
                if (tb_nomet.Text == "")
                {
                    queryTurma = string.Format(@"
                     INSERT INTO tb_turma (t_descturma,n_idproff,n_hora,n_maxaluno,t_status)VALUES ('{0}',{1},{2},{3},'{4}')", tb_nomet.Text, cb_proff.SelectedValue, cb_hora.SelectedValue,
                            Int32.Parse(Math.Round(nd_max.Value, 0).ToString()),
                            cb_status.SelectedValue, idcel);
                }
               
                int linha = dataGridView1.SelectedRows[0].Index;
                banco.dml(queryTurma);
                dataGridView1.DataSource = banco.dql(queryTurma);
                MessageBox.Show("DADOS GRAVADOS");
            }
        }


        public void atualiza()
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

            dataGridView1.DataSource = banco.dql(vquery);
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
            cb_proff.DataSource = banco.dql(vqueryprof);
            cb_proff.DisplayMember = "t_nomeprooff";
            cb_proff.ValueMember = "n_idproff";



            Dictionary<string, string> st = new Dictionary<string, string>();

            st.Add("A", "activa");
            st.Add("p", "parada");
            st.Add("c", "cancel");

            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "VALUE";
            cb_status.ValueMember = "KEY";


            string vqueryhora = @"SELECT * FROM tb_horario ORDER BY t_deschora";

            cb_hora.Items.Clear();
            cb_hora.DataSource = banco.dql(vqueryhora);
            cb_hora.DisplayMember = "t_deschora";
            cb_hora.ValueMember = "n_idhora";
        }
        public turma()
        {
            InitializeComponent();
        }

        private void turma_Load(object sender, EventArgs e)
        {
            atualiza();


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int linha = dgv.SelectedRows.Count;
            if (linha > 0)
            {
                modo = 0;
                idcel = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();




                string vqueryc = @"
            SELECT
                t_descturma,
                n_idproff,
            n_hora,
                n_maxaluno,
                t_status
               
                
                
                    
                          
            FROM tb_turma 
            WHERE n_idturma = " + idcel;

                DataTable dt = banco.dql(vqueryc);


                tb_nomet.Text = dt.Rows[0].Field<string>("t_descturma");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("t_status");
                cb_proff.SelectedValue = dt.Rows[0].Field<Int64>("n_idproff").ToString();
                nd_max.Value = dt.Rows[0].Field<Int64>("n_maxaluno");

                cb_hora.SelectedValue = dt.Rows[0].Field<Int64>("n_hora");


                //calculo vagas

                string query = string.Format(@"SELECT count(n_idalino) as 'cont'
                        
                    FROM tb_aluno WHERE t_status= 'A' and n_idturma={0} ",idcel);

                dt=banco.dql(query);

                int vagas=Int32.Parse(Math.Round(nd_max.Value,0).ToString());
                vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("cont").ToString());

                tb_vagas.Text = vagas.ToString();






            }


        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            tb_nomet.Clear();
            cb_proff.SelectedIndex = -1;
            nd_max.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_hora.SelectedIndex = -1;

            tb_nomet.Focus();
            modo = 2;
        }
        public void sava()
        {
            string vquery = "";


            if (tb_nomet.Text == "" | cb_proff.Text == "" | cb_hora.Text == "")
            {
                MessageBox.Show("FALTA DADOS A SER INSERIDO");
                return;
            }
            else
            {



                vquery = string.Format(@"
                    INSERT INTO tb_turma (t_descturma,n_idproff,n_hora,n_maxaluno,t_status)VALUES ('{0}',{1},{2},{3},'{4}')", tb_nomet.Text, cb_proff.SelectedValue, cb_hora.SelectedValue,
                        Int32.Parse(Math.Round(nd_max.Value, 0).ToString()),
                        cb_status.SelectedValue, idcel);



                int linha = dataGridView1.SelectedRows[0].Index;
                banco.dql(vquery);

                dataGridView1[1, linha].Value = tb_nomet.Text;
                dataGridView1[2, linha].Value = cb_hora.Text;

                MessageBox.Show("gravado");




            }

            try
            {
                atualiza();

            }
            catch (Exception es)
            {



            }
        }
        private void bt_save_Click(object sender, EventArgs e)
        {

            if (modo != 0)
            {
                string vquery = "";

                if(modo == 1)
                {
                    try { 
                    
                    vquery = string.Format(@"UPDATE tb_turma

                SET 
                    t_descturma= '{0}',n_idproff={1},n_hora={2},n_maxaluno={3},t_status='{4}'

                    WHERE
                        n_idturma={5}", tb_nomet.Text, cb_proff.SelectedValue, cb_hora.SelectedValue,
                                    Int32.Parse(Math.Round(nd_max.Value, 0).ToString()),
                                    cb_status.SelectedValue, idcel);

                }catch (Exception ef)
                {
                    MessageBox.Show(ef.ToString());
                }


            }
                else { 
                    
                    try {
                    
                    vquery = string.Format(@"
                    INSERT INTO tb_turma (t_descturma,n_idproff,n_hora,n_maxaluno,t_status)VALUES ('{0}',{1},{2},{3},'{4}')",
                    tb_nomet.Text, cb_proff.SelectedValue, cb_hora.SelectedValue,
                        Int32.Parse(Math.Round(nd_max.Value, 0).ToString()),
                        cb_status.SelectedValue);
                        }catch (Exception ef)
                    {
                        MessageBox.Show(ef.ToString());
                    }
                   



                }


            int linha = dataGridView1.SelectedRows[0].Index;
            banco.dql(vquery);
                if(modo == 1) { 
            dataGridView1[1, linha].Value = tb_nomet.Text;
            dataGridView1[2, linha].Value = cb_hora.Text;
                }
                else
                {

                    //atualiza

                    string vqueryy = @"
            
                SELECT 
                    tbt.n_idturma as 'id',

                    tbt.t_descturma as 'turma',
                        tbh.t_deschora as 'hora'


                        FROM

                 tb_turma as tbt

                inner join 

            tb_horario as tbh on tbh.n_idhora =tbt.n_hora
                

                ";

                    dataGridView1.DataSource = banco.dql(vqueryy);

                }
            MessageBox.Show("gravado");

            }

          





        }

        private void bt_ex_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("excluir?", "ex", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {


               


                string query = string.Format("DELETE FROM tb_turma WHERE n_idturma={0}",idcel);



                banco.dml(query);

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        public void up()
        {
            try
            {
                string vquery = string.Format(@"UPDATE tb_turma

                SET 
                    t_descturma= '{0}',n_idproff={1},n_hora={2},n_maxaluno={3},t_status='{4}'

                    WHERE
                        n_idturma={5}", tb_nomet.Text, cb_proff.SelectedValue, cb_hora.SelectedValue,
                                 Int32.Parse(Math.Round(nd_max.Value, 0).ToString()),
                                 cb_status.SelectedValue, idcel);
                int linha = dataGridView1.SelectedRows[0].Index;




                string queryTurma = string.Format(@"
                    UPDATE
                        tb_turmas
                    SET
                         t_descturma= '{0}',n_idproff={1},n_hora={2},n_maxaluno={3},t_status='{4}'
                    WHERE
                        N_idTurma = {5}", tb_nomet.Text, cb_proff.SelectedValue, cb_hora.SelectedValue,
                                                Int32.Parse(Math.Round(nd_max.Value, 0).ToString()),
                                                cb_status.SelectedValue, idcel);





                banco.dql(vquery);



                dataGridView1[1, linha].Value = tb_nomet.Text;
                dataGridView1[2, linha].Value = cb_hora.Text;

                MessageBox.Show("gravado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("dados invalidos");
            }


            try
            {
                atualiza();

            }
            catch (Exception es)
            {



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //atualiza

            string vqueryy = @"
            
                SELECT 
                    tbt.n_idturma as 'id',

                    tbt.t_descturma as 'turma',
                        tbh.t_deschora as 'hora'


                        FROM

                 tb_turma as tbt

                inner join 

            tb_horario as tbh on tbh.n_idhora =tbt.n_hora
                

                ";

            dataGridView1.DataSource = banco.dql(vqueryy);

        }

        private void tb_nomet_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0) {modo = 1; }
            
        }

        private void cb_proff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0) { modo = 1; }
        }

        private void nd_max_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0) { modo = 1; }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0) { modo = 1; }

        }

        private void cb_hora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0) { modo = 1; }
        }



        public void imprimir()
        {
            try
            {





                //arquivotxt

                string nomearq = global.caminho + @"\ turma.pdf";

                FileStream arquipdf = new FileStream(nomearq, FileMode.Create);

                Document doc = new Document(PageSize.A4);

                PdfWriter rscpdf = PdfWriter.GetInstance(doc, arquipdf);

                //image

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(global.caminho + @"\img.png");

                logo.ScaleToFit(140f, 120f);
                logo.Alignment = Element.ALIGN_LEFT;
                logo.SetAbsolutePosition(100, 700);//x -y






                string dados = "";

                Paragraph pa = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));

                pa.Alignment = Element.ALIGN_CENTER;
                pa.Add("gddddddd \n");

                pa.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 15, (int)System.Drawing.FontStyle.Italic);



                pa.Alignment = Element.ALIGN_CENTER;

                pa.Add("fffffffffff \n");


                pa.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 15, (int)System.Drawing.FontStyle.Italic);

                pa.Alignment = Element.ALIGN_CENTER;

                pa.Add("llllllllllll \n\n\n");


                ///tabelas
                ///

                PdfPTable tab = new PdfPTable(3);

                tab.DefaultCell.FixedHeight = 20;

                PdfPCell cel = new PdfPCell();

                cel.Colspan = 3;

                cel.AddElement(logo);

                tab.AddCell(cel);


                //manual
                tab.AddCell("produto");
                tab.AddCell("codigo");
                tab.AddCell("preco");
                tab.AddCell("tv"); tab.AddCell("01"); tab.AddCell("50.40");

                PdfPCell cel2 = new PdfPCell(new Phrase("tabela preco"));

                cel2.Rotation = 0;
                cel2.Colspan = 3;
                cel2.FixedHeight = 20;
                cel2.HorizontalAlignment = Element.ALIGN_CENTER;
                cel2.VerticalAlignment = Element.ALIGN_MIDDLE;
                tab.AddCell(cel2);

                doc.Open();


                //doc.Add(logo);
                doc.Add(pa);
                doc.Add(tab);

                doc.Close();

            }
            catch (Exception es)
            {

            }
        }

        private void b_imp_Click(object sender, EventArgs e)
        {
            try
            {

           

            string nomearq = global.caminho + @"\ turma2.pdf";

            FileStream arquipdf = new FileStream(nomearq, FileMode.Create);

            Document doc = new Document(PageSize.A4);

            PdfWriter rscpdf = PdfWriter.GetInstance(doc, arquipdf);

            //image

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(global.caminho + @"\img.png");

            logo.ScaleToFit(40f, 50f);
            logo.Alignment = Element.ALIGN_LEFT;
            logo.SetAbsolutePosition(100, 750);//x -y



            string dados = "";

            Paragraph pa = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));

            pa.Alignment = Element.ALIGN_CENTER;
            pa.Add("relatorio tuma \n\n");

            Paragraph pa2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic));

            pa2.Alignment = Element.ALIGN_CENTER;
            pa2.Add("gd\n");

            PdfPTable tab = new PdfPTable(3);

            tab.DefaultCell.FixedHeight = 20;

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

            tab.AddCell("id");

            tab.AddCell("turma");

            tab.AddCell("hora");

            DataTable dtturma=banco.dql(vquery);
            for(int i = 0; i < dtturma.Rows.Count; i++)
            {
                tab.AddCell(dtturma.Rows[i].Field<Int64>("id").ToString());
                tab.AddCell(dtturma.Rows[i].Field<string>("turma"));
                tab.AddCell(dtturma.Rows[i].Field<string>("hora"));

            }

            doc.Open();
            doc.Add(logo);
            doc.Add(pa);
            doc.Add(tab);
            doc.Add(pa2);
            doc.Close();

            DialogResult res=MessageBox.Show("abrir","pdf",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(global.caminho + @"\ turma2.pdf");
            }
            }
            catch (Exception) { }

        }
    }
}
