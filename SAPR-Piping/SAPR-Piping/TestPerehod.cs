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
    public partial class TestPerehod : Form
    {
        //Процедура собирает нужные значения ячеек и конкатенирует их в текстовом поле
        public void ConcatinateAll()
        {
            string typeOfPerehod;
            if (PodnadzornostCheckBox.Checked)
            {
                typeOfPerehod = "П" + TypeOfPerehodCmbBox.Text;
            }
            else
            {
                typeOfPerehod = TypeOfPerehodCmbBox.Text;
            }
            ResultatTextBox.Text = "Переход " + 
                typeOfPerehod + 
                TypeOfPerehodDataGridView.CurrentRow.Cells[1].Value.ToString() + 
                "x" + 
                TypeOfPerehodDataGridView.CurrentRow.Cells[2].Value.ToString() + 
                "-" + TypeOfPerehodDataGridView.CurrentRow.Cells[3].Value.ToString() + 
                "x" + TypeOfPerehodDataGridView.CurrentRow.Cells[4].Value.ToString() + 
                " " + "ГОСТ 17378-2001";
        }

        public int Counter()
        {
            BindingSource bs = ((Form1)this.Tag).vTBindingSource;
            int count = 0;
            for (int i = bs.Count; i > 0; i--)
            {
                VT obj = bs[i-1] as VT;
                if (obj.VtElementID > count)
                {
                    count = obj.VtElementID;
                }
            }
            return count+1;
        }

        public TestPerehod()
        {
            InitializeComponent();
           
        }

        private void TestPerehod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainENGDataSet.Perehod". При необходимости она может быть перемещена или удалена.
            this.perehodTableAdapter.Fill(this.mainENGDataSet.Perehod);
            //TypeOfPerehodCmbBox.SelectedIndex = 0;
            //this.переходыTableAdapter.Fill(this.mainDataSet.Переходы);
            TypeOfPerehodCmbBox.SelectedIndex = 0;
            MaterialComboBox.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConcatinateAll();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {

            //ConcatinateAll();
            //Counter();
           
            ((Form1)this.Tag).vTBindingSource.Add(new VT()
            {
                VtElementID = Counter(),
                VtNaim=ResultatTextBox.Text,
                VtMater=MaterialComboBox.Text,
                VtEdIzm="шт.",
                VtKolvo=KolichestvoNumericUpDown.Value,
                VtPrim=PrimechanieTextBox.Text,
                VtOtbr=OtbrakTolshNumericUpDown1.Value.ToString()+"/"+OtbrakTolshNumericUpDown2.Value.ToString()
            });

            Close();
        }

        private void TypeOfPerehodCmbBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeOfPerehodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ConcatinateAll();
        }

        private void TypeOfPerehodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConcatinateAll();
        }

        private void ResultatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PodnadzornostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }
    }
}
