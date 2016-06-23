using System;
using System.Windows.Forms;

namespace SAPR_Piping
{
    public partial class RedactorForm : Form
    {
        string naim, mater, edizm, prim, otbr;
        decimal kolvo;
        int mtk;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        int index = 0;
       /* public RedactorForm(string naim, string mater, string edizm, decimal kolvo, decimal otbr, string prim, int index, int mtk)
        {
            InitializeComponent();
            this.naim = naim;
            this.mater = mater;
            this.edizm = edizm;
            this.kolvo = kolvo;
            this.otbr = otbr;
            this.prim = prim;
            this.index = index;
            this.mtk = mtk;
            
        }*/

        public RedactorForm(VT obj)
        {
            InitializeComponent();
            this.naim = obj.VtNaim;
            this.mater = obj.VtMater;
            this.edizm = obj.VtEdIzm;
            this.kolvo = obj.VtKolvo;
            this.otbr = obj.VtOtbr;
            this.prim = obj.VtPrim;
            this.index = obj.VtElementID;
            this.mtk = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;
            this.naim = textBoxNaim.Text;
            this.mater = comboBoxMater.Text;
            this.edizm = comboBoxEdIzm.Text;
            this.kolvo = numericUpDownKolvo.Value;
            this.otbr = numericUpDownOtbr.Value.ToString();
            this.prim = textBoxPrim.Text;
          
        }

        private void RedactorForm_Load(object sender, EventArgs e)
        {
            if (this.mtk==1)
            {
                Form1 form1 = this.Owner as Form1;
                textBoxNaim.Text = this.naim;
                comboBoxMater.Text = this.mater;
                comboBoxEdIzm.Text = this.edizm;
                numericUpDownKolvo.Value = this.kolvo;
                numericUpDownOtbr.Value = Convert.ToDecimal(this.otbr);
                textBoxPrim.Text = this.prim;
                this.Text = "Редактирование...";
            }
            else
            {
                this.Text = "Добавление нового элемента";
            }
        }
    }
}
