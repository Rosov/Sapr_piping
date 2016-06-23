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
    public partial class Otvod : Form
    {
        public Otvod()
        {
            InitializeComponent();
        }


        public void ConcatinateAll()
        {
            string typeOfOtvod="";
            if (PodnadzornostCheckBox.Checked)
            {
                typeOfOtvod = "П";
            }
            ResultatTextBox.Text = "Отвод " +
                typeOfOtvod+
                UgolComboBox.Text+"-"+
                OtvodDataGridView.CurrentRow.Cells[1].Value.ToString() +
                "x" +
                OtvodDataGridView.CurrentRow.Cells[2].Value.ToString() +"-"+
                MaterialComboBox.Text+
                " " + "ГОСТ 17375-2001";
        }

        private void Otvod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainENGDataSet.Otvod". При необходимости она может быть перемещена или удалена.
            this.otvodTableAdapter.Fill(this.mainENGDataSet.Otvod);
            MaterialComboBox.SelectedIndex = 0;
            UgolComboBox.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                VtOtbr=OtbrakTolshNumericUpDown1.Value.ToString()
            });

            Close();
        }

        private void OtvodDataGridView_Click(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void KolichestvoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void PrimechanieTextBox_TextChanged(object sender, EventArgs e)
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
    }
}
