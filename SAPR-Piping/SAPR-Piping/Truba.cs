using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPR_Piping
{
    public partial class Truba : Form
    {
        public Truba()
        {
            InitializeComponent();
            
        }

        private void Truba_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainENGDataSet._GOST_8732_78". При необходимости она может быть перемещена или удалена.
            this.gOST_8732_78TableAdapter.Fill(this.mainENGDataSet._GOST_8732_78);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainENGDataSet._GOST_8734_75". При необходимости она может быть перемещена или удалена.
            this.gOST_8734_75TableAdapter.Fill(this.mainENGDataSet._GOST_8734_75);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainENGDataSet.S_hd". При необходимости она может быть перемещена или удалена.
            this.s_hdTableAdapter.Fill(this.mainENGDataSet.S_hd);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainENGDataSet.S_gd". При необходимости она может быть перемещена или удалена.
            this.s_gdTableAdapter.Fill(this.mainENGDataSet.S_gd);
            DocComboBox.SelectedIndex = 0;
            MaterialComboBox.SelectedIndex = 0;
            Massa();

        }

        public void ConcatinateAll()
        {
            ResultatTextBox.Text = "Труба " +
               DuComboBox.Text +
                "x" +
                TolshComboBox.Text +
                " " +
                DocComboBox.Text;
        }

        public void Massa()
        {
            MassaNumericUpDown.Value = (decimal)0.02466 * Convert.ToDecimal(TolshComboBox.Text) *(Convert.ToDecimal(DuComboBox.Text) - Convert.ToDecimal(TolshComboBox.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HotRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HotRadioButton.Checked)
            {
               
                TolshComboBox.DataSource = sgdBindingSource;
                DuComboBox.DataSource = gOST873278BindingSource;
                DocComboBox.SelectedIndex = 0;
                ConcatinateAll();
            }
        }

        private void ColdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ColdRadioButton.Checked)
            {
                // TolshComboBox.DataSource = толщинаХДBindingSource;
                TolshComboBox.DataSource = shdBindingSource;
                DuComboBox.DataSource = gOST873475BindingSource;
                DocComboBox.SelectedIndex = 1;
                ConcatinateAll();
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
            Massa();
        }

        private void TolshComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
            Massa();
        }

        private void DlinaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void MassaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
        }

        private void DocComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConcatinateAll();
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
            //ConcatinateAll();
           
            ((Form1)this.Tag).vTBindingSource.Add(new VT()
            {
                VtElementID = Counter(),
                VtNaim = ResultatTextBox.Text,
                VtMater = MaterialComboBox.Text,
                VtEdIzm = "м",
                VtOtbr=OtbrakTolshNumericUpDown.Value.ToString(),
                VtKolvo = DlinaNumericUpDown.Value,
                VtPrim = PrimechanieTextBox.Text
            });

            Close();
        }
    }
}
