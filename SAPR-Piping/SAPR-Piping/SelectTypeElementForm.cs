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
    public partial class SelectTypeElementForm : Form
    {
        public SelectTypeElementForm()
        {
            InitializeComponent();
        }

        private void SelectTypeElementForm_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
           SelectPerehodForm f = new SelectPerehodForm();
            f.ShowDialog();
            //Form2 f = new Form2();
            //f.ShowDialog();
            ////this.Hide();
        }
          
    }
}

