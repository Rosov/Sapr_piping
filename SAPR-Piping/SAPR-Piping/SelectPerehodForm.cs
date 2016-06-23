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
    public partial class SelectPerehodForm : Form
    {
        public SelectPerehodForm()
        {
            InitializeComponent();
        }

        private void SelectPerehodForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.Переходы' table. You can move, or remove it, as needed.
       this.переходыTableAdapter.Fill(this.mainDataSet.Переходы);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int rowNumber = ((Form1)this.Tag).dgv.Rows.Add();
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[0].Value = textBoxPerex.Text;
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[1].Value = comboBoxMater.SelectedItem.ToString();
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[2].Value = comboBoxEdIzm.SelectedItem.ToString();
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[3].Value = numericUpDownKolvo.Value;
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[4].Value = numericUpDownOtbr.Value;
            ((Form1)this.Tag).dgv.Rows[rowNumber].Cells[5].Value = textBoxPrim.Text;*/
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1[1, i].FormattedValue.ToString().Contains(textBox1.Text.Trim()))
                {
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    return;
                }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                object[] items = new object[row.Cells.Count];

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    items[i] = row.Cells[i].Value;
                }
                textBoxPerex.Text = "Переход " + " " + comboBoxPerexTip.Text + " " + items[1] + "x" + items[2] + "-" + items[3] + "x" + items[4] + " " + this.Text;
                //((Form1)this.Tag).dgv.Rows.Add(items);
            }
        }

        private void SelectPerehodForm_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dataGridView1_SelectionChanged()
        {
            MessageBox.Show("ww");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                object[] items = new object[row.Cells.Count];

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    items[i] = row.Cells[i].Value;
                }
                textBoxPerex.Text = "Переход " + " " + comboBoxPerexTip.Text + " " + items[1] + "x" + items[2] + "-" + items[3] + "x" + items[4] + " " + this.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
