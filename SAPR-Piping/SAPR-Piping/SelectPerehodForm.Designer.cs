namespace SAPR_Piping
{
    partial class SelectPerehodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.переходыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new SAPR_Piping.MainDataSet();
            this.переходыTableAdapter = new SAPR_Piping.MainDataSetTableAdapters.ПереходыTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxMater = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEdIzm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownKolvo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownOtbr = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrim = new System.Windows.Forms.TextBox();
            this.textBoxPerex = new System.Windows.Forms.TextBox();
            this.comboBoxPerexTip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.переходыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOtbr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dnDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn,
            this.d1DataGridViewTextBoxColumn,
            this.t1DataGridViewTextBoxColumn,
            this.lDataGridViewTextBoxColumn,
            this.mDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.переходыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(967, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MultiSelectChanged += new System.EventHandler(this.button2_Click);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // dnDataGridViewTextBoxColumn
            // 
            this.dnDataGridViewTextBoxColumn.DataPropertyName = "dn";
            this.dnDataGridViewTextBoxColumn.HeaderText = "dn";
            this.dnDataGridViewTextBoxColumn.Name = "dnDataGridViewTextBoxColumn";
            this.dnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "d";
            this.dDataGridViewTextBoxColumn.HeaderText = "d";
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "t";
            this.tDataGridViewTextBoxColumn.HeaderText = "t";
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            this.tDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // d1DataGridViewTextBoxColumn
            // 
            this.d1DataGridViewTextBoxColumn.DataPropertyName = "d1";
            this.d1DataGridViewTextBoxColumn.HeaderText = "d1";
            this.d1DataGridViewTextBoxColumn.Name = "d1DataGridViewTextBoxColumn";
            this.d1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t1DataGridViewTextBoxColumn
            // 
            this.t1DataGridViewTextBoxColumn.DataPropertyName = "t1";
            this.t1DataGridViewTextBoxColumn.HeaderText = "t1";
            this.t1DataGridViewTextBoxColumn.Name = "t1DataGridViewTextBoxColumn";
            this.t1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lDataGridViewTextBoxColumn
            // 
            this.lDataGridViewTextBoxColumn.DataPropertyName = "L";
            this.lDataGridViewTextBoxColumn.HeaderText = "L";
            this.lDataGridViewTextBoxColumn.Name = "lDataGridViewTextBoxColumn";
            this.lDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // переходыBindingSource
            // 
            this.переходыBindingSource.DataMember = "Переходы";
            this.переходыBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // переходыTableAdapter
            // 
            this.переходыTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(123, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 35);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 584);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxMater
            // 
            this.comboBoxMater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMater.FormattingEnabled = true;
            this.comboBoxMater.Items.AddRange(new object[] {
            "сталь 20",
            "09Г2С",
            "10Г2",
            "10Г2ФБЮ",
            "08Х18Н10Т",
            "20Л",
            "сборн.",
            "ВСт3пс"});
            this.comboBoxMater.Location = new System.Drawing.Point(194, 374);
            this.comboBoxMater.Name = "comboBoxMater";
            this.comboBoxMater.Size = new System.Drawing.Size(237, 37);
            this.comboBoxMater.TabIndex = 8;
            this.comboBoxMater.Text = "сталь 20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "МАТЕРИАЛ";
            // 
            // comboBoxEdIzm
            // 
            this.comboBoxEdIzm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEdIzm.FormattingEnabled = true;
            this.comboBoxEdIzm.Items.AddRange(new object[] {
            "шт",
            "м"});
            this.comboBoxEdIzm.Location = new System.Drawing.Point(450, 374);
            this.comboBoxEdIzm.Name = "comboBoxEdIzm";
            this.comboBoxEdIzm.Size = new System.Drawing.Size(155, 37);
            this.comboBoxEdIzm.TabIndex = 8;
            this.comboBoxEdIzm.Text = "шт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ЕД. ИЗМ.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "КОЛ-ВО";
            // 
            // numericUpDownKolvo
            // 
            this.numericUpDownKolvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownKolvo.Location = new System.Drawing.Point(611, 376);
            this.numericUpDownKolvo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownKolvo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKolvo.Name = "numericUpDownKolvo";
            this.numericUpDownKolvo.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownKolvo.TabIndex = 10;
            this.numericUpDownKolvo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "ОТБР., ММ";
            // 
            // numericUpDownOtbr
            // 
            this.numericUpDownOtbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownOtbr.Location = new System.Drawing.Point(751, 374);
            this.numericUpDownOtbr.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownOtbr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownOtbr.Name = "numericUpDownOtbr";
            this.numericUpDownOtbr.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownOtbr.TabIndex = 10;
            this.numericUpDownOtbr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "ПРИМЕЧАНИЕ";
            // 
            // textBoxPrim
            // 
            this.textBoxPrim.Location = new System.Drawing.Point(20, 495);
            this.textBoxPrim.Multiline = true;
            this.textBoxPrim.Name = "textBoxPrim";
            this.textBoxPrim.Size = new System.Drawing.Size(962, 69);
            this.textBoxPrim.TabIndex = 11;
            // 
            // textBoxPerex
            // 
            this.textBoxPerex.Enabled = false;
            this.textBoxPerex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPerex.Location = new System.Drawing.Point(20, 417);
            this.textBoxPerex.Name = "textBoxPerex";
            this.textBoxPerex.Size = new System.Drawing.Size(962, 35);
            this.textBoxPerex.TabIndex = 12;
            this.textBoxPerex.Text = "Переход";
            // 
            // comboBoxPerexTip
            // 
            this.comboBoxPerexTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPerexTip.FormattingEnabled = true;
            this.comboBoxPerexTip.Items.AddRange(new object[] {
            "ПК",
            "ПЭ"});
            this.comboBoxPerexTip.Location = new System.Drawing.Point(20, 374);
            this.comboBoxPerexTip.Name = "comboBoxPerexTip";
            this.comboBoxPerexTip.Size = new System.Drawing.Size(150, 37);
            this.comboBoxPerexTip.TabIndex = 8;
            this.comboBoxPerexTip.Text = "ПК";
            this.comboBoxPerexTip.SelectedIndexChanged += new System.EventHandler(this.SelectPerehodForm_Load);
            this.comboBoxPerexTip.SelectedValueChanged += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "ТИП";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "ПОИСК";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(538, 584);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(694, 584);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 40);
            this.button4.TabIndex = 15;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SelectPerehodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 873);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxPerex);
            this.Controls.Add(this.textBoxPrim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownOtbr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownKolvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEdIzm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxPerexTip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMater);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPerehodForm";
            this.Text = "ГОСТ 17378-2001";
            this.Load += new System.EventHandler(this.SelectPerehodForm_Load);
            this.Shown += new System.EventHandler(this.SelectPerehodForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.переходыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOtbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource переходыBindingSource;
        private MainDataSetTableAdapters.ПереходыTableAdapter переходыTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.ComboBox comboBoxPerexTip;
        protected internal System.Windows.Forms.TextBox textBoxPerex;
        protected internal System.Windows.Forms.TextBox textBoxPrim;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownOtbr;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownKolvo;
        protected internal System.Windows.Forms.ComboBox comboBoxEdIzm;
        protected internal System.Windows.Forms.ComboBox comboBoxMater;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}