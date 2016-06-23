using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace SAPR_Piping
{
    public partial class Form1 : Form
    {

        public SelectPerehodForm spf;
        public SelectZKSForm zksf;
        public SelectKZForm kzf;
        public RedactorForm rfForm;
        public TestPerehod testPerehod;
        public Truba truba;
        public Otvod otvod;
        public Troinik troinik;

        Vedomost vedomost;
        BindingList<Section> sections;
       // BindingSource bs;

        Category category;
        BindingSource cs;

        Group group;
        BindingSource gs;
         
        public Form1()
        {
            InitializeComponent();
            ConstructionComboBox.SelectedIndex = 0;
            category = new Category();
            vedomost = new Vedomost(PRabNumericUpDown.Value, PRaschNumericUpDown.Value, GroupOfProductComboBox.SelectedIndex, TMaxNumericUpDown.Value);
            
            //bs = new BindingSource();
            sections = new BindingList<Section>();
            //bs.DataSource = sections;
            comboBox1.DataSource = sections;
            comboBox1.DisplayMember = "NameOfSection";
            comboBox1.ValueMember = "sections.ID";

            cs = new BindingSource();
            cs.DataSource = category.RIM;
            CategoryOfProductComboBox.DataSource = cs;

            group = new Group();
            gs = new BindingSource();
            gs.DataSource = group.GroupOfProduct;
            GroupOfProductComboBox.DataSource = gs;

            PProchMethodComboBox.SelectedIndex = 0;
            PPlotMethodComboBox.SelectedIndex = 0;
            PGermMethodComboBox.SelectedIndex = 0;


            DisplayVedomost();
        }

        private void DisplayVedomost()
        {
            decimal pProch = vedomost.PProch;
            int indexOfCategory = vedomost.IndexOfCategory;
            
            PProchNumericUpDown.Value = pProch;
            PPlotNumericUpDown.Value = PRaschNumericUpDown.Value;
            PGermNumericUpDown.Value = PRabNumericUpDown.Value;

            //PUslComboBox.SelectedIndex = (int)vedomost.PUsl;
            if (vedomost.PUsl == 16) { PUslComboBox.SelectedIndex = 0;}
            if (vedomost.PUsl == 25) { PUslComboBox.SelectedIndex = 1; }
            if (vedomost.PUsl == 40) { PUslComboBox.SelectedIndex = 2; }
            if (vedomost.PUsl == 63) { PUslComboBox.SelectedIndex = 3; }
            if (vedomost.PUsl == 100) { PUslComboBox.SelectedIndex = 4; }
            if (vedomost.PUsl == 160) { PUslComboBox.SelectedIndex = 5; }
            CategoryOfProductComboBox.SelectedIndex =indexOfCategory;
            VControlOfWeldSeamNumericUpDown.Value = vedomost.VControlOfWeldSeam;
            dPNumericUpDown.Value = vedomost.DP;
            GroupOfProductTextBox2.Text = (string)GroupOfProductComboBox.SelectedItem + (string) CategoryOfProductComboBox.SelectedItem;
        }

        private void DisplaySection()
        {
            try
            {
            SectionNameTextBox.Text = sections[comboBox1.SelectedIndex].NameOfSection;
            FromTextBox.Text = sections[comboBox1.SelectedIndex].FromSection;
            ToTextBox.Text = sections[comboBox1.SelectedIndex].ToSection;
            NameOfProductTextBox.Text = sections[comboBox1.SelectedIndex].NameOfProduct;
            GroupOfProductTextBox2.Text = sections[comboBox1.SelectedIndex].GroupAndCategoryOfProduct;
            PUslComboBox.Text = Convert.ToString(sections[comboBox1.SelectedIndex].PUsl);
            PRabNumericUpDown.Value = sections[comboBox1.SelectedIndex].Prab;
            PRaschNumericUpDown.Value = sections[comboBox1.SelectedIndex].PRasch;
            PProchNumericUpDown.Value = sections[comboBox1.SelectedIndex].Pproch;
            PPlotNumericUpDown.Value = sections[comboBox1.SelectedIndex].Pplot;
            PGermNumericUpDown.Value = sections[comboBox1.SelectedIndex].PGerm;
            tChNumericUpDown.Value= sections[comboBox1.SelectedIndex].tCh;
            TFromNumericUpDown.Value = sections[comboBox1.SelectedIndex].TFrom;
            TToNumericUpDown.Value = sections[comboBox1.SelectedIndex].TTo;
            TMaxNumericUpDown.Value = sections[comboBox1.SelectedIndex].TMax;
            VControlOfWeldSeamNumericUpDown.Value= sections[comboBox1.SelectedIndex].VControlOfWeldSeam;
            GroupOfProductComboBox.SelectedIndex= sections[comboBox1.SelectedIndex].Group;
            CategoryOfProductComboBox.SelectedIndex = sections[comboBox1.SelectedIndex].IndexOfCategory;
            PProchMethodComboBox.SelectedIndex = sections[comboBox1.SelectedIndex].PProchMethod;
            PPlotMethodComboBox.SelectedIndex = sections[comboBox1.SelectedIndex].PPlotMethod;
            PGermMethodComboBox.SelectedIndex = sections[comboBox1.SelectedIndex].PGermMethod;
            dPNumericUpDown.Value = sections[comboBox1.SelectedIndex].dP;
            HeatTreatmentCheckBox.Checked = sections[comboBox1.SelectedIndex].HeatTreatment;
            InsulationComboBox.SelectedIndex = sections[comboBox1.SelectedIndex].Insulation;
            LifeTimeNumericUpDown.Value = sections[comboBox1.SelectedIndex].LifeTime;
            SpeedOfCorrosionNumericUpDown.Value = sections[comboBox1.SelectedIndex].SpeedOfCorrosion;
            ConstructionComboBox.SelectedIndex = sections[comboBox1.SelectedIndex].Construction;
                vTBindingSource.Clear();
            foreach (VT item in sections[comboBox1.SelectedIndex].DGV1)
                {
                    vTBindingSource.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Список участков пуст!");
                //throw;
            }
        }
        //Окончание процедуры отображения содерижмого участков (секций)
        private void RenameLine_Click_1(object sender, EventArgs e)
        {
            if (Sverka())
            {
                List<VT> tempList=new List<VT>();
                foreach (VT item in vTBindingSource)
                {
                    tempList.Add(item);
                }
            sections.Add(new Section
            {
                NameOfSection = SectionNameTextBox.Text,
                ID = sections.Count,
                FromSection = FromTextBox.Text,
                ToSection = ToTextBox.Text,
                NameOfProduct = NameOfProductTextBox.Text,
                GroupAndCategoryOfProduct = GroupOfProductTextBox2.Text,
                Prab = PRabNumericUpDown.Value,
                PRasch = PRaschNumericUpDown.Value,
                Pproch = PProchNumericUpDown.Value,
                Pplot = PPlotNumericUpDown.Value,
                PGerm = PGermNumericUpDown.Value,
                DGV1=tempList,
                PUsl = Convert.ToDecimal(PUslComboBox.Text),
                tCh=tChNumericUpDown.Value,
                TFrom=TFromNumericUpDown.Value,
                TTo=TToNumericUpDown.Value,
                TMax=TMaxNumericUpDown.Value,
                VControlOfWeldSeam=VControlOfWeldSeamNumericUpDown.Value,
                Group=GroupOfProductComboBox.SelectedIndex,
                IndexOfCategory=CategoryOfProductComboBox.SelectedIndex,
                PProchMethod=PProchMethodComboBox.SelectedIndex,
                PPlotMethod=PPlotMethodComboBox.SelectedIndex,
                PGermMethod=PGermMethodComboBox.SelectedIndex,
                dP=dPNumericUpDown.Value,
                HeatTreatment=HeatTreatmentCheckBox.Checked,
                Insulation=InsulationComboBox.SelectedIndex,
                LifeTime=LifeTimeNumericUpDown.Value,
                SpeedOfCorrosion=SpeedOfCorrosionNumericUpDown.Value,
                Construction=ConstructionComboBox.SelectedIndex,
            });
            comboBox1.SelectedIndex = sections.Count - 1;
            }
            else
            {
                MessageBox.Show("Название участка пустое или не уникальное");
            }
        }

        public bool Sverka()
        {
            if (SectionNameTextBox.Text.Trim()=="")
            {
                return false;
            }
            for (int i = 0; i < sections.Count; i++)
            {
                if (SectionNameTextBox.Text == sections[i].NameOfSection)
                {
                    return false;
                }

            }
                return true;
        }

        private void SaveSection_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения на данном участке?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                try
                {
                    int position = comboBox1.SelectedIndex;
                    List<VT> tempList = new List<VT>();
                    foreach (VT item in vTBindingSource)
                    {
                        tempList.Add(item);
                    }
                    sections.Insert(comboBox1.SelectedIndex, new Section
                    {
                        NameOfSection = SectionNameTextBox.Text,
                        ID = sections.Count,
                        FromSection = FromTextBox.Text,
                        ToSection = ToTextBox.Text,
                        NameOfProduct = NameOfProductTextBox.Text,
                        GroupAndCategoryOfProduct = GroupOfProductTextBox2.Text,
                        Prab = PRabNumericUpDown.Value,
                        PRasch = PRaschNumericUpDown.Value,
                        Pproch = PProchNumericUpDown.Value,
                        Pplot = PPlotNumericUpDown.Value,
                        PGerm = PGermNumericUpDown.Value,
                        PUsl = Convert.ToDecimal(PUslComboBox.Text),
                        tCh = tChNumericUpDown.Value,
                        TFrom = TFromNumericUpDown.Value,
                        TTo = TToNumericUpDown.Value,
                        TMax = TMaxNumericUpDown.Value,
                        VControlOfWeldSeam = VControlOfWeldSeamNumericUpDown.Value,
                        Group = GroupOfProductComboBox.SelectedIndex,
                        IndexOfCategory = CategoryOfProductComboBox.SelectedIndex,
                        PProchMethod = PProchMethodComboBox.SelectedIndex,
                        PPlotMethod = PPlotMethodComboBox.SelectedIndex,
                        PGermMethod = PGermMethodComboBox.SelectedIndex,
                        dP = dPNumericUpDown.Value,
                        HeatTreatment = HeatTreatmentCheckBox.Checked,
                        Insulation = InsulationComboBox.SelectedIndex,
                        LifeTime = LifeTimeNumericUpDown.Value,
                        SpeedOfCorrosion = SpeedOfCorrosionNumericUpDown.Value,
                        Construction = ConstructionComboBox.SelectedIndex,
                        DGV1=tempList
                    });
                    sections.RemoveAt(comboBox1.SelectedIndex);
                    comboBox1.SelectedIndex = position;
                    DisplaySection();
                }
                catch (Exception) { MessageBox.Show("Введите данные!"); }
            }
        }

        private void DeleteSection_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить этот участок?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    sections.RemoveAt(comboBox1.SelectedIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Список участков пуст: " + ex.Message, "Список участков пуст!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Список участков пуст!");
                }
            }    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addElementBtn_Click(object sender, EventArgs e)
        {
            spf = new SelectPerehodForm();
            spf.Tag = this;
            spf.ShowDialog();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
             // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.ЗКС". При необходимости она может быть перемещена или удалена.
            //this.зКСTableAdapter.Fill(this.mainDataSet.ЗКС);
            this.Location = new Point(0, 0);
            //this.Width = SystemInformation.PrimaryMonitorSize.Width;
            //this.Height = SystemInformation.PrimaryMonitorSize.Height;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spf = new SelectPerehodForm();
            spf.Tag = this;
            spf.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        //

        private Boolean ExecuteReplace(Microsoft.Office.Interop.Word.Find find)
        {
            return ExecuteReplace(find, Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
        }
        private Boolean ExecuteReplace(Microsoft.Office.Interop.Word.Find find,  object replaceOption)
        {
            object findText = Type.Missing;
            object matchCase = Type.Missing;
            object matchWholeWord = Type.Missing;
            object matchWildcards = Type.Missing;
            object matchSoundsLike = Type.Missing;
            object matchAllWordForms = Type.Missing;
            object forward = Type.Missing;
            object wrap = Type.Missing;
            object format = Type.Missing;
            object replaceWith = Type.Missing;
            object replace=replaceOption;
            object matchKashida = Type.Missing;
            object matchDiacritics = Type.Missing;
            object matchAlefHamza = Type.Missing;
            object matchControl = Type.Missing;
            return find.Execute(ref findText,ref matchCase, ref matchWholeWord, ref matchWildcards,
                ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format,
                ref replaceWith, ref replace, ref matchKashida, ref matchDiacritics, ref matchAlefHamza,
               ref matchControl);
        }
        //

        static string Describe(decimal number)
        {
            if (number == 0) return "-";
            string sign= number < 0 ? "минус "+ Math.Abs(number) : "плюс " + number;
            return sign;
        }

        static string Pusto(decimal number)
        {        
            string tire = number == 0 ? "-" : number.ToString();
            return tire;
        }
        static string PustoString(string word)
        {
            string tire = word == "" ? "-" : word;
            return tire;
        }

        private void ведомостьТрубопроводовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Word.Application app;
            Word.Document doc;
            Object missingObj = System.Reflection.Missing.Value;
            Object trueObj = true;
            Object falseObj = false;
            app = new Word.Application();
            Object templatePathObj = Application.StartupPath + "\\vt.docx";
            try
            {
                doc = app.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
                doc.Activate();
                doc = app.ActiveDocument;
                //Колонтитул (шифр проекта)
                /* foreach (Word.Section wordSection in doc.Sections)
                 {
                     Word.Range footerRange = wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                     //footerRange.Font.Size = 20;
                     //footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;
                     footerRange.Text = PustoString(ShifrTextBox.Text);
                 }*/


                Microsoft.Office.Interop.Word.Find fnd = app.Selection.Find;

                //Колонтитул (шифр проекта)
                foreach (Word.Section wordSection in doc.Sections)
                 {
                     Word.Range footerRange = wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    //footerRange.Font.Size = 20;
                    //footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;

                    //footerRange.Text = PustoString(ShifrTextBox.Text);
                    Microsoft.Office.Interop.Word.Find fndС =footerRange.Find;

                    fndС.ClearFormatting();
                    fndС.Text = "{cltl}";
                    fndС.Replacement.ClearFormatting();
                    fndС.Replacement.Text = PustoString(ShifrTextBox.Text);
                    ExecuteReplace(fndС);
                }

                


                // Температура рабочая / max, C (от минус <> до плюс <>)
              
                fnd.ClearFormatting();
                fnd.Text = "{T}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text= "от " + Describe(TFromNumericUpDown.Value) + " до " + Describe(TToNumericUpDown.Value) + " / " + Pusto(TMaxNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Название секции
                fnd.ClearFormatting();
                fnd.Text = "{Name}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = SectionNameTextBox.Text;
                ExecuteReplace(fnd);
                //Давление: Р(усл) кгс/см2
                fnd.ClearFormatting();
                fnd.Text = "{P_usl}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = PustoString(PUslComboBox.SelectedItem.ToString());
                ExecuteReplace(fnd);
                //Давление: Р(раб) кгс/см2
                fnd.ClearFormatting();
                fnd.Text = "{P_rab}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = Pusto(PRabNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Давление: Р(расч) кгс/см2
                fnd.ClearFormatting();
                fnd.Text = "{P_ras}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = Pusto(PRaschNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Давление: Р(проч) кгс/см2
                fnd.ClearFormatting();
                fnd.Text = "{P_pro}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text =Pusto(PProchNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Давление: Р(плот) кгс/см2
                fnd.ClearFormatting();
                fnd.Text = "{P_plo}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = Pusto(PPlotNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Давление: Р(герм) кгс/см2
                fnd.ClearFormatting();
                fnd.Text = "{P_ger}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = Pusto(PGermNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Способ испытания: Р(проч)-"Г" или "П"
                fnd.ClearFormatting();
                fnd.Text = "{M_pro}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = PustoString(PProchMethodComboBox.SelectedItem.ToString());
                ExecuteReplace(fnd);
                //Способ испытания: Р(плот)-"Г" или "П"
                fnd.ClearFormatting();
                fnd.Text = "{M_plo}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = PustoString(PPlotMethodComboBox.SelectedItem.ToString());
                ExecuteReplace(fnd);
                //Способ испытания: Р(герм)-"Г" или "П"
                fnd.ClearFormatting();
                fnd.Text = "{M_ger}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = PustoString(PGermMethodComboBox.SelectedItem.ToString());
                ExecuteReplace(fnd);
                //
                fnd.ClearFormatting();
                fnd.Text = "{dP}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = Pusto(dPNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Время (ч)
                fnd.ClearFormatting();
                fnd.Text = "{th}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = Pusto(tChNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Категория и группа трубопровода
                fnd.ClearFormatting();
                fnd.Text = "{category}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = PustoString(CategoryOfProductComboBox.SelectedItem.ToString());
                ExecuteReplace(fnd);
                //Наименование транспортируемого продукта
                fnd.ClearFormatting();
                fnd.Text = "{product}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = PustoString(GroupOfProductComboBox.SelectedItem.ToString());
                ExecuteReplace(fnd);
                //Граница участка "ОТ"
                fnd.ClearFormatting();
                fnd.Text = "{from}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = PustoString(FromTextBox.Text);
                ExecuteReplace(fnd);
                //Граница участка "ДО"
                fnd.ClearFormatting();
                fnd.Text = "{to}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = PustoString(ToTextBox.Text);
                ExecuteReplace(fnd);
                //Объем контроля сварных швов, %
                fnd.ClearFormatting();
                fnd.Text = "{weldCtrl}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = Pusto(VControlOfWeldSeamNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Скорость коррозии, мм/год
                fnd.ClearFormatting();
                fnd.Text = "{corr}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = Pusto(SpeedOfCorrosionNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Расчетный(назначенный) срок службы трубопровода, лет
                fnd.ClearFormatting();
                fnd.Text = "{workPeriod}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text = Pusto(LifeTimeNumericUpDown.Value);
                ExecuteReplace(fnd);
                //Термообработка (да, нет)
                string term="нет";
                if (HeatTreatmentCheckBox.Checked)
                {
                    term = "да";
                } 
                fnd.ClearFormatting();
                fnd.Text = "{therm}";
                fnd.Replacement.ClearFormatting();
                fnd.Replacement.Text =term;
                ExecuteReplace(fnd);
                //


                //


                //
                int row = 2;
                Microsoft.Office.Interop.Word.Table tbl;
                tbl = doc.Content.Tables[3];
                tbl.Rows[row].HeightRule = Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightAuto;
                VT obj;
                int num;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    obj = vTBindingSource[i] as VT;
                    num = obj.VtElementID;
                    for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    {
                        tbl.Cell(i + 3, 1).Range.Text = Convert.ToString(num);
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                        tbl.Cell(i + 3, j+1 ).Range.Text = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                tbl.Range.Font.Size = 10;
                app.Visible = true;
                app.Activate();
                //app.Quit(ref deflt, ref deflt, ref deflt);
                //doc = null;
                //app = null;
                //GC.Collect();
                //GC.WaitForPendingFinalizers();
                //GC.Collect();
                //GC.WaitForPendingFinalizers(); 
            }
            catch (Exception ex)
            {
                app.Quit(ref missingObj, ref missingObj, ref missingObj);
                doc = null;
                app = null;
                MessageBox.Show(ex.Message);
            }

            //doc.Close(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);

            /*  tbl.Rows[n].Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray10; 

              tbl.Rows[n].Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray20; 

      tbl.Range.Font.Name = "Tahoma"; 
      tbl.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed; 
      tbl.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble; 
      tbl.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble; 
      tbl.Borders.InsideColor = Microsoft.Office.Interop.Word.WdColor.wdColorDarkBlue; 
      tbl.Borders.OutsideColor = Microsoft.Office.Interop.Word.WdColor.wdColorDarkBlue; 
      tbl.Rows[1].Range.Cells[1].Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBrown; 
      tbl.Rows[1].Range.Cells[1].Range.Bold = 1; 
      tbl.Rows[1].Range.Cells[1].Range.Borders.Shadow = false; */






        }

        private void спецификацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            /*for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dgv.Rows[i].Cells[j].Value;
                }
            }*/
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;

        }
        private void SaveDocToFileXML(String TR4FileName)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(TR4FileName, System.Text.Encoding.Unicode);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                // запись данных о версии
                writer.WriteStartElement("DocInfo");
                writer.WriteAttributeString("DocType", "TepRast4Doc");
                writer.WriteAttributeString("Version", "tr4d_r1");
                // запись данных
                writer.WriteStartElement("Table");
               /* for (int i = 0; i < dgv.RowCount - 1; i++)
                {
                    writer.WriteStartElement("Row");
                    writer.WriteAttributeString("Naim", dgv.Rows[i].Cells[0].Value.ToString());
                    writer.WriteAttributeString("Mater", dgv.Rows[i].Cells[1].Value.ToString());
                    writer.WriteAttributeString("KEdIzm", dgv.Rows[i].Cells[2].Value.ToString());
                    writer.WriteAttributeString("Kolvo", dgv.Rows[i].Cells[1].Value.ToString());
                    writer.WriteAttributeString("Otbr", dgv.Rows[i].Cells[1].Value.ToString());
                    writer.WriteAttributeString("Prim", dgv.Rows[i].Cells[1].Value.ToString());
                }*/
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                if (writer != null) writer.Close();
            }
    }
        private void OpenDocToFileXML(String TR4FileName)// Открытие файлов
        {
            toolStripStatusLabel1.Text = "";

            /*
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(TR4FileName, System.Text.Encoding.Unicode);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                // запись данных о версии
                writer.WriteStartElement("DocInfo");
                writer.WriteAttributeString("DocType", "TepRast4Doc");
                writer.WriteAttributeString("Version", "tr4d_r1");
                // запись данных
                writer.WriteStartElement("Table");
                for (int i = 0; i < dgv.RowCount - 1; i++)
                {
                    writer.WriteStartElement("Row");
                    writer.WriteAttributeString("Naim", dgv.Rows[i].Cells[0].Value.ToString());
                    writer.WriteAttributeString("Mater", dgv.Rows[i].Cells[1].Value.ToString());
                    writer.WriteAttributeString("KEdIzm", dgv.Rows[i].Cells[2].Value.ToString());
                    writer.WriteAttributeString("Kolvo", dgv.Rows[i].Cells[1].Value.ToString());
                    writer.WriteAttributeString("Otbr", dgv.Rows[i].Cells[1].Value.ToString());
                    writer.WriteAttributeString("Prim", dgv.Rows[i].Cells[1].Value.ToString());
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                if (writer != null) writer.Close();
            }*/
        }

        private void сохранитьВФорматеXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocToFileXML("www");
        }
        private void RenameLine_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            zksf = new SelectZKSForm();
            zksf.Tag = this;
            zksf.ShowDialog();
        }

        private void PRaschNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            vedomost.PRasch = PRaschNumericUpDown.Value;
            DisplayVedomost();
        }

        private void PRabNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            vedomost.PRab = PRabNumericUpDown.Value;
            DisplayVedomost();
        }
        //ДОБАВЛЕНИЕ НОВОГО ЭЛЕМЕНТА
        private void button1_Click(object sender, EventArgs e)
        {
            /*var index = -1; // ничего не выделено
            string naim, mater, edizm, prim;
            decimal kolvo, otbr;
            int mtk;
            naim = "";
            mater = "";
            edizm = "";
            kolvo = 1;
            otbr = 1;
            prim = "";
            mtk = 0;
            if (dgv.CurrentRow != null)
           {
                index = dgv.CurrentRow.Index;
           }
            else
            {
                index =0;
            }
            RedactorForm rfForm = new RedactorForm(naim, mater, edizm, kolvo, otbr, prim, index, mtk);
            rfForm.Owner = this;
            rfForm.Show();*/
        }

        //РЕДАКТИРОВАНИЕ ВЫБРАННОГО ЭЛЕМЕНТА
        private void Redakt()
        {
           // var index = -1; // ничего не выделено
           /* if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                string naim, mater, edizm, prim;
                decimal kolvo, otbr;
                int mtk;
                naim = dataGridView1.Rows[index].Cells[0].Value.ToString();
                mater = dataGridView1.Rows[index].Cells[1].Value.ToString();
                edizm = dataGridView1.Rows[index].Cells[2].Value.ToString();
                kolvo = Convert.ToDecimal(dataGridView1.Rows[index].Cells[3].Value);
                otbr = Convert.ToDecimal(dataGridView1.Rows[index].Cells[4].Value);
                prim = dataGridView1.Rows[index].Cells[5].Value.ToString();
                mtk = 1;
                RedactorForm rfForm = new RedactorForm(naim, mater, edizm, kolvo, otbr, prim, index, mtk);
                rfForm.Owner = this;
                rfForm.Show();
            }*/
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Redakt();
            VT obj = vTBindingSource.Current as VT;
            RedactorForm rfForm = new RedactorForm(obj);
            rfForm.Owner = this;
            rfForm.Show();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                vTBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
                MessageBox.Show("Список элементов пуст");
            }    
        
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redakt();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            kzf = new SelectKZForm();
            kzf.Tag = this;
            kzf.ShowDialog();
           
        }

        

        private void PRaschNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            vedomost.PRasch = PRaschNumericUpDown.Value;
            DisplayVedomost();
        }

        private void PRabNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            vedomost.PRab = PRabNumericUpDown.Value;
            DisplayVedomost();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            saveFileDialog1.Filter= "Файлы проектов (*.pmp)|*.pmp|Все файлы *.*|*.*";
            saveFileDialog1.FileName = "*.pmp";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (Stream output = File.OpenWrite(saveFileDialog1.FileName))
                {
                    formatter.Serialize(output, sections);
                }
            }
        }

        private void загрузитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы проектов (*.pmp)|*.pmp|Все файлы *.*|*.*";
            openFileDialog1.FileName = "*.pmp";
            BinaryFormatter formatter = new BinaryFormatter();
            BindingList<Section>  tempsections = new BindingList<Section>();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                vTBindingSource.Clear();
                using (Stream input = File.OpenRead(openFileDialog1.FileName))
                {
                    tempsections = (BindingList<Section>)formatter.Deserialize(input);
                }
                sections = tempsections;
                //bs = new BindingSource();

                //bs.DataSource = sections;
                comboBox1.DataSource = sections;
                comboBox1.DisplayMember = "NameOfSection";
                comboBox1.ValueMember = "sections.ID";
                DisplayVedomost();

            }
        }

        private void GroupOfProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vedomost.Group = GroupOfProductComboBox.SelectedIndex;
            if (GroupOfProductComboBox.SelectedIndex==6)
            {
                tChNumericUpDown.Value = 0;
            }
            DisplayVedomost();
        }

        private void TMaxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            vedomost.TMax = TMaxNumericUpDown.Value;
            DisplayVedomost();
        }

        private void CategoryOfProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vedomost.IndexOfCategory = CategoryOfProductComboBox.SelectedIndex;
            //DisplayVedomost();
            GroupOfProductTextBox2.Text = (string)GroupOfProductComboBox.SelectedItem + (string)CategoryOfProductComboBox.SelectedItem;
            switch (CategoryOfProductComboBox.SelectedIndex)
            {
                case 1:
                    VControlOfWeldSeamNumericUpDown.Value = 20;
                    break;
                case 2:
                    VControlOfWeldSeamNumericUpDown.Value = 10;
                    break;
                case 3:
                    VControlOfWeldSeamNumericUpDown.Value = 2;
                    break;
                case 4:
                    VControlOfWeldSeamNumericUpDown.Value = 1;
                    break;

                default:
                    VControlOfWeldSeamNumericUpDown.Value = 20;
                    break;
            }
        }

        private void dPNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            vedomost.DP = dPNumericUpDown.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            testPerehod = new TestPerehod();
            testPerehod.Tag = this;
            testPerehod.ShowDialog();

           
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        //Очень сложная процедура. Второй раз её повторить будет сложно!!!
            VT obj = vTBindingSource.Current as VT;
            int CurrentPosition = vTBindingSource.Position;
            switch (CurrentPosition)
            {
                case 0:
                    obj.VtElementID = 1;
                    vTBindingSource[CurrentPosition] = obj;
                     break;
                default:
                    if (obj.VtElementID != 0)
                    {
                        obj.VtElementID = 0;
                        for (int i = vTBindingSource.Position + 1; i < vTBindingSource.Count; i++)
                        {
                            obj = vTBindingSource[i] as VT;
                            if (obj.VtElementID != 0)
                            {
                                obj.VtElementID --;
                                vTBindingSource[i] = obj;
                            }
                        }
                    }
                    else
                    {
                        int j = CurrentPosition;
                        VT tempObj = vTBindingSource[j-1] as VT;
                        while (tempObj.VtElementID==0)
                        {
                            j--;
                            tempObj = vTBindingSource[j] as VT;
                        }
                        obj.VtElementID = tempObj.VtElementID+1;
                        vTBindingSource[CurrentPosition] = obj;
                        for (int i = vTBindingSource.Position + 1; i < vTBindingSource.Count; i++)
                        {
                            obj = vTBindingSource[i] as VT;
                            if (obj.VtElementID != 0)
                            {
                                obj.VtElementID += 1;
                                vTBindingSource[i] = obj;
                            }
                        }
                    }
                    break;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            //Сделать перемещение строк. 1 - создаем временную ячейку. 2- меняем местами.3 В текущую записываем содержимое временной ячейки. 4. меняем Position 5. Пересчитываем индексы
            //Дальше всё выверено не практике. Работает. Можно оптимизировать, но нет времени.
            int position = vTBindingSource.Position;
            if (position>0)
            {

                VT obj = vTBindingSource.Current as VT;
                vTBindingSource.MovePrevious();
                VT obj1 = vTBindingSource.Current as VT;
                vTBindingSource.MoveNext();

                vTBindingSource.Insert(vTBindingSource.Position - 1, obj);
                vTBindingSource.RemoveCurrent();

                if (obj1.VtElementID!=0 && obj.VtElementID!=0)
                {
                    obj.VtElementID --;

                }
                
                if (position < vTBindingSource.Count - 1)
                {
                    vTBindingSource.MovePrevious();
                    VT obj2 = vTBindingSource.Current as VT;
                    if (obj2.VtElementID != 0 && obj.VtElementID != 0)
                    {
                        obj2.VtElementID++;
                    }
                        vTBindingSource.Insert(vTBindingSource.Position, obj2);
                        vTBindingSource.RemoveCurrent();
                        vTBindingSource.MovePrevious();
                    
                    vTBindingSource.MovePrevious();
                }
                else
                {
                    VT obj2 = vTBindingSource.Current as VT;
                    if (obj2.VtElementID != 0 && obj.VtElementID != 0)
                    {
                        obj2.VtElementID++;
                    }
                    vTBindingSource.Insert(vTBindingSource.Position, obj1);
                    vTBindingSource.RemoveCurrent();
                    vTBindingSource.MovePrevious();
                }

                

                

            }

            }

        private void DownButton_Click(object sender, EventArgs e)
        {
            //Перемещение ячейки в датагриде вниз. 1. Меняем местами ячейки. 2.Меняем Position. 3. Реиндескируем.
            if (vTBindingSource.Position<vTBindingSource.Count-1)
            {

           
            VT obj = vTBindingSource.Current as VT;
            vTBindingSource.MoveNext();
            VT obj1 = vTBindingSource.Current as VT;
            vTBindingSource.MovePrevious();
            int position = vTBindingSource.Position;
            if (position!=vTBindingSource.Count-1)
            {
                if (obj1.VtElementID!=0 && obj.VtElementID!=0)
                {
                    obj.VtElementID++;
                    obj1.VtElementID--;
                }
                vTBindingSource.Insert(vTBindingSource.Position + 2, obj);
                vTBindingSource.RemoveCurrent();
                vTBindingSource.Insert(vTBindingSource.Position, obj1);
                vTBindingSource.RemoveCurrent();
                }
            }

        }

        private void TrubaButton_Click(object sender, EventArgs e)
        {
            truba = new Truba();
            truba.Tag = this;
            truba.ShowDialog();
        }

        private void PPlotNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OtvodButton_Click(object sender, EventArgs e)
        {
            otvod = new Otvod();
            otvod.Tag = this;
            otvod.ShowDialog();
        }

        private void TroinikButton_Click(object sender, EventArgs e)
        {
            troinik = new Troinik();
            troinik.Tag = this;
            troinik.ShowDialog();
        }
    }
}
