namespace SAPR_Piping
{
    partial class TestPerehod
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
            this.TypeOfPerehodDataGridView = new System.Windows.Forms.DataGridView();
            this.dnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perehodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainENGDataSet = new SAPR_Piping.MainENGDataSet();
            this.TypeOfPerehodCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KolichestvoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResultatTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PrimechanieTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.perehodTableAdapter = new SAPR_Piping.MainENGDataSetTableAdapters.PerehodTableAdapter();
            this.PodnadzornostCheckBox = new System.Windows.Forms.CheckBox();
            this.OtbrakTolshNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OtbrakTolshNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfPerehodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perehodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainENGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolichestvoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeOfPerehodDataGridView
            // 
            this.TypeOfPerehodDataGridView.AllowUserToAddRows = false;
            this.TypeOfPerehodDataGridView.AllowUserToDeleteRows = false;
            this.TypeOfPerehodDataGridView.AutoGenerateColumns = false;
            this.TypeOfPerehodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeOfPerehodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dnDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn,
            this.d1DataGridViewTextBoxColumn,
            this.t1DataGridViewTextBoxColumn,
            this.lDataGridViewTextBoxColumn,
            this.mDataGridViewTextBoxColumn});
            this.TypeOfPerehodDataGridView.DataSource = this.perehodBindingSource;
            this.TypeOfPerehodDataGridView.Location = new System.Drawing.Point(11, 13);
            this.TypeOfPerehodDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.TypeOfPerehodDataGridView.Name = "TypeOfPerehodDataGridView";
            this.TypeOfPerehodDataGridView.ReadOnly = true;
            this.TypeOfPerehodDataGridView.RowTemplate.Height = 33;
            this.TypeOfPerehodDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TypeOfPerehodDataGridView.Size = new System.Drawing.Size(402, 344);
            this.TypeOfPerehodDataGridView.TabIndex = 0;
            this.TypeOfPerehodDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TypeOfPerehodDataGridView_CellClick);
            this.TypeOfPerehodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TypeOfPerehodDataGridView_CellContentClick);
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
            // perehodBindingSource
            // 
            this.perehodBindingSource.DataMember = "Perehod";
            this.perehodBindingSource.DataSource = this.mainENGDataSet;
            // 
            // mainENGDataSet
            // 
            this.mainENGDataSet.DataSetName = "MainENGDataSet";
            this.mainENGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TypeOfPerehodCmbBox
            // 
            this.TypeOfPerehodCmbBox.AllowDrop = true;
            this.TypeOfPerehodCmbBox.FormattingEnabled = true;
            this.TypeOfPerehodCmbBox.Items.AddRange(new object[] {
            "К",
            "Э"});
            this.TypeOfPerehodCmbBox.Location = new System.Drawing.Point(551, 16);
            this.TypeOfPerehodCmbBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeOfPerehodCmbBox.Name = "TypeOfPerehodCmbBox";
            this.TypeOfPerehodCmbBox.Size = new System.Drawing.Size(71, 21);
            this.TypeOfPerehodCmbBox.TabIndex = 1;
            this.TypeOfPerehodCmbBox.SelectedIndexChanged += new System.EventHandler(this.TypeOfPerehodCmbBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип перехода:";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.AllowDrop = true;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "09Г2С",
            "10Г2",
            "Сталь 20"});
            this.MaterialComboBox.Location = new System.Drawing.Point(551, 37);
            this.MaterialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(71, 21);
            this.MaterialComboBox.TabIndex = 1;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Материал:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество:";
            // 
            // KolichestvoNumericUpDown
            // 
            this.KolichestvoNumericUpDown.Location = new System.Drawing.Point(553, 61);
            this.KolichestvoNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.KolichestvoNumericUpDown.Name = "KolichestvoNumericUpDown";
            this.KolichestvoNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.KolichestvoNumericUpDown.TabIndex = 3;
            this.KolichestvoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KolichestvoNumericUpDown.ValueChanged += new System.EventHandler(this.KolichestvoNumericUpDown_ValueChanged);
            // 
            // ResultatTextBox
            // 
            this.ResultatTextBox.Location = new System.Drawing.Point(418, 276);
            this.ResultatTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultatTextBox.Multiline = true;
            this.ResultatTextBox.Name = "ResultatTextBox";
            this.ResultatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultatTextBox.Size = new System.Drawing.Size(226, 46);
            this.ResultatTextBox.TabIndex = 4;
            this.ResultatTextBox.TextChanged += new System.EventHandler(this.ResultatTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(550, 329);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 28);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PrimechanieTextBox
            // 
            this.PrimechanieTextBox.Location = new System.Drawing.Point(417, 221);
            this.PrimechanieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrimechanieTextBox.Multiline = true;
            this.PrimechanieTextBox.Name = "PrimechanieTextBox";
            this.PrimechanieTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrimechanieTextBox.Size = new System.Drawing.Size(226, 35);
            this.PrimechanieTextBox.TabIndex = 4;
            this.PrimechanieTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Примечание:";
            // 
            // perehodTableAdapter
            // 
            this.perehodTableAdapter.ClearBeforeFill = true;
            // 
            // PodnadzornostCheckBox
            // 
            this.PodnadzornostCheckBox.AutoSize = true;
            this.PodnadzornostCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PodnadzornostCheckBox.Location = new System.Drawing.Point(418, 86);
            this.PodnadzornostCheckBox.Name = "PodnadzornostCheckBox";
            this.PodnadzornostCheckBox.Size = new System.Drawing.Size(204, 17);
            this.PodnadzornostCheckBox.TabIndex = 6;
            this.PodnadzornostCheckBox.Text = "Подконтрольность Ростехнадзору:";
            this.PodnadzornostCheckBox.UseVisualStyleBackColor = true;
            this.PodnadzornostCheckBox.CheckedChanged += new System.EventHandler(this.PodnadzornostCheckBox_CheckedChanged);
            // 
            // OtbrakTolshNumericUpDown1
            // 
            this.OtbrakTolshNumericUpDown1.DecimalPlaces = 1;
            this.OtbrakTolshNumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OtbrakTolshNumericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.OtbrakTolshNumericUpDown1.Location = new System.Drawing.Point(546, 125);
            this.OtbrakTolshNumericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OtbrakTolshNumericUpDown1.Name = "OtbrakTolshNumericUpDown1";
            this.OtbrakTolshNumericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.OtbrakTolshNumericUpDown1.TabIndex = 8;
            this.OtbrakTolshNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(453, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Отбраковочная толщина #1 (мм):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(453, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Отбраковочная толщина #2 (мм):";
            // 
            // OtbrakTolshNumericUpDown2
            // 
            this.OtbrakTolshNumericUpDown2.DecimalPlaces = 1;
            this.OtbrakTolshNumericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OtbrakTolshNumericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.OtbrakTolshNumericUpDown2.Location = new System.Drawing.Point(546, 173);
            this.OtbrakTolshNumericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OtbrakTolshNumericUpDown2.Name = "OtbrakTolshNumericUpDown2";
            this.OtbrakTolshNumericUpDown2.Size = new System.Drawing.Size(76, 20);
            this.OtbrakTolshNumericUpDown2.TabIndex = 8;
            this.OtbrakTolshNumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TestPerehod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 368);
            this.Controls.Add(this.OtbrakTolshNumericUpDown2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OtbrakTolshNumericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PodnadzornostCheckBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PrimechanieTextBox);
            this.Controls.Add(this.ResultatTextBox);
            this.Controls.Add(this.KolichestvoNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeOfPerehodCmbBox);
            this.Controls.Add(this.TypeOfPerehodDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestPerehod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestPerehod";
            this.Load += new System.EventHandler(this.TestPerehod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfPerehodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perehodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainENGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolichestvoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TypeOfPerehodDataGridView;
        private System.Windows.Forms.ComboBox TypeOfPerehodCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown KolichestvoNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultatTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PrimechanieTextBox;
        private System.Windows.Forms.Label label4;
        private MainENGDataSet mainENGDataSet;
        private System.Windows.Forms.BindingSource perehodBindingSource;
        private MainENGDataSetTableAdapters.PerehodTableAdapter perehodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox PodnadzornostCheckBox;
        private System.Windows.Forms.NumericUpDown OtbrakTolshNumericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown OtbrakTolshNumericUpDown2;
    }
}