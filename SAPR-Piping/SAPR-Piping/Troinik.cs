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
    public partial class Troinik : Form
    {
        public Troinik()
        {
            InitializeComponent();
        }

        public void ConcatinateAll()
        {
            string typeOfTroinik = "";
            if (PodnadzornostCheckBox.Checked)
            {
                typeOfTroinik = "П";
            }
            ResultatTextBox.Text = "Тройник " +
                typeOfTroinik+
                TroinikDataGridView.CurrentRow.Cells[1].Value.ToString() +
                "x" +
                TroinikDataGridView.CurrentRow.Cells[2].Value.ToString() +
                "-" + TroinikDataGridView.CurrentRow.Cells[3].Value.ToString() +
                "x" + TroinikDataGridView.CurrentRow.Cells[4].Value.ToString() +
                " " + "ГОСТ 17376-2001";
        }

        private void Troinik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainENGDataSet.Trothnik". При необходимости она может быть перемещена или удалена.
            this.trothnikTableAdapter.Fill(this.mainENGDataSet.Trothnik);

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            ((Form1)this.Tag).vTBindingSource.Add(new VT()
            {
                VtElementID = Counter(),
                VtNaim = ResultatTextBox.Text,
                VtMater = MaterialComboBox.Text,
                VtEdIzm = "шт.",
                VtKolvo = KolichestvoNumericUpDown.Value,
                VtPrim = PrimechanieTextBox.Text,
                VtOtbr=OtbrakTolshNumericUpDown1.Value.ToString()+"/"+OtbrakTolshNumericUpDown2.Value.ToString()
            });

            Close();
        }

        private void TroinikDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConcatinateAll();
        }

        private void PrimechanieTextBox_TextChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void KolichestvoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void PodnadzornostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void OtbrakTolshNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void OtbrakTolshNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void TroinikDataGridView_Click(object sender, EventArgs e)
        {
            ConcatinateAll();
        }
    }
}
