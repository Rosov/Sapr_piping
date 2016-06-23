using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPR_Piping
{
    public partial class SelectKZForm : Form
    {
        VT vt;
        public SelectKZForm()
        {
            InitializeComponent();
            vt = new VT((string)textBoxKZ.Text, (string)textBoxKZi.Text, (string)"шт", (decimal)numericUpDownKolvo.Value, Convert.ToString(numericUpDownOtbr.Value), (string)textBoxPrim.Text, (string)"КЗ", (string) "1", (string) "00",(string)"10", (decimal) 7.5);
        }

        public int Counter()
        {
            BindingSource bs = ((Form1)this.Tag).vTBindingSource;
            int count = 0;
            for (int i = bs.Count; i > 0; i--)
            {
                VT obj = bs[i - 1] as VT;
                if (obj.VtElementID > count)
                {
                    count = obj.VtElementID;
                }
            }
            return count + 1;
        }

        private void SelectKZForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainENGDataSet.KZ_i". При необходимости она может быть перемещена или удалена.
            this.kZ_iTableAdapter.Fill(this.mainENGDataSet.KZ_i);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainENGDataSet.KZ". При необходимости она может быть перемещена или удалена.
            this.kZTableAdapter.Fill(this.mainENGDataSet.KZ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.КЗ_исп". При необходимости она может быть перемещена или удалена.
            // this.кЗ_испTableAdapter.Fill(this.mainDataSet.КЗ_исп);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.КЗ". При необходимости она может быть перемещена или удалена.
            // this.кЗTableAdapter.Fill(this.mainDataSet.КЗ);
            comboBoxIspO.SelectedIndex = 0;
            comboBoxIspP.SelectedIndex = 0;
        }
        private void ViborKZ()
        {
            foreach (DataGridViewRow row in dataGridViewKZ.SelectedRows)
            {
                object[] items = new object[row.Cells.Count];

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    items[i] = row.Cells[i].Value;
                }
                textBoxKZ.Text = "Клапан запорный " + vt.VtEP +"." +vt.VtIspO+ "-ВАРК" + "-" + items[1] + "-" + items[0]+"-"+ vt.VtIspM +"-"+vt.VtIspP+ " Ду "+ items[1]+ " мм, Ру "+ items[0] + " кгс/см2 с ответными фланцами и крепежом";
                vt.VtMassa = Convert.ToDecimal(items[14]);
                comboBoxIspO.Text = vt.VtIspO;
                comboBoxIspP.Text = vt.VtIspP;
                //textBoxCKBA.Text = "Клапан ЦКБА " + vt.VtEP + "." + vt.VtIspO + "-ВАРК" + "-" + items[1] + "-" + items[0] + "-" + vt.VtIspM + "-" + vt.VtIspP + " Ду " + items[1] + " мм, Ру " + items[0] + " кгс/см2 с ответными фланцами и крепежом";
                //textBoxKZi.Text = vt.VtIspM;
                // MessageBox.Show(vt.VtMassa.ToString());
            }
        }

        private void dataGridViewKZ_DoubleClick(object sender, EventArgs e)
        {
            ViborKZ();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*int rowNumber = ((Form1)this.Tag).dgv.Rows.Add();
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[0].Value = vt.VtNaim;
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[1].Value = vt.VtMater;
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[2].Value = vt.VtEdIzm;
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[3].Value = vt.VtKolvo;
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[4].Value = vt.VtOtbr;
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[5].Value = vt.VtPrim;*/
            Close();
        }

        private void dataGridViewKZi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex > 1)
                {
                    textBoxKZi.Text = dataGridViewKZi.CurrentCell.Value.ToString();
                    vt.VtIspM = dataGridViewKZi.Columns[e.ColumnIndex].HeaderText.Substring(0,2);
                }
                else
                {
                    textBoxKZi.Text = "";
                }
                ViborKZ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void checkBoxEP_CheckedChanged(object sender, EventArgs e)
        {
        if (checkBoxEP.Checked==true)
            {
                vt.VtEP = "КЗП";
            }
        else
            {
                vt.VtEP = "КЗ";
            }
            ViborKZ();
        }

        private void comboBoxIspO_SelectedValueChanged(object sender, EventArgs e)
        {
            vt.VtIspO = comboBoxIspO.SelectedItem.ToString().Substring(0,1);
            ViborKZ();
        }

        private void comboBoxIspP_SelectedValueChanged(object sender, EventArgs e)
        {
            vt.VtIspP = comboBoxIspP.SelectedItem.ToString().Substring(0, 2);
            ViborKZ();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var fzk = new FormZoomZK();
            fzk.pictureBox1.Image = pictureBox1.Image;
            fzk.Text = this.Text;
            fzk.ShowDialog();
        }

        private void textBoxKZ_TextChanged(object sender, EventArgs e)
        {
            vt.VtNaim = textBoxKZ.Text;
        }

        private void textBoxKZi_TextChanged(object sender, EventArgs e)
        {
            vt.VtMater = textBoxKZi.Text;
        }

        private void numericUpDownKolvo_ValueChanged(object sender, EventArgs e)
        {
            vt.VtKolvo= numericUpDownKolvo.Value;
        }

        private void numericUpDownOtbr_ValueChanged(object sender, EventArgs e)
        {
            vt.VtOtbr= numericUpDownOtbr.Value.ToString();
        }

        private void textBoxPrim_TextChanged(object sender, EventArgs e)
        {
            vt.VtPrim= textBoxPrim.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
