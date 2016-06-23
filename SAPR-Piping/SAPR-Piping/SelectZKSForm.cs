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
    public partial class SelectZKSForm : Form
    {
        public SelectZKSForm()
        {
            InitializeComponent();
        }

        private void SelectZKSForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.ЗКС". При необходимости она может быть перемещена или удалена.
            this.зКСTableAdapter.Fill(this.mainDataSet.ЗКС);

        }
    }
}
