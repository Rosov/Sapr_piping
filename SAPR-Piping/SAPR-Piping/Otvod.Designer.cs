namespace SAPR_Piping
{
    partial class Otvod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otvod));
            this.OtvodDataGridView = new System.Windows.Forms.DataGridView();
            this.dnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainENGDataSet = new SAPR_Piping.MainENGDataSet();
            this.otvodTableAdapter = new SAPR_Piping.MainENGDataSetTableAdapters.OtvodTableAdapter();
            this.AddButton = new System.Windows.Forms.Button();
            this.ResultatTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.PrimechanieTextBox = new System.Windows.Forms.TextBox();
            this.KolichestvoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UgolComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OtbrakTolshNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.PodnadzornostCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.OtvodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainENGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolichestvoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // OtvodDataGridView
            // 
            this.OtvodDataGridView.AutoGenerateColumns = false;
            this.OtvodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtvodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dnDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn,
            this.frDataGridViewTextBoxColumn,
            this.wDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.mDataGridViewTextBoxColumn});
            this.OtvodDataGridView.DataSource = this.otvodBindingSource;
            this.OtvodDataGridView.Location = new System.Drawing.Point(4, 13);
            this.OtvodDataGridView.Name = "OtvodDataGridView";
            this.OtvodDataGridView.ReadOnly = true;
            this.OtvodDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OtvodDataGridView.Size = new System.Drawing.Size(517, 405);
            this.OtvodDataGridView.TabIndex = 0;
            this.OtvodDataGridView.Click += new System.EventHandler(this.OtvodDataGridView_Click);
            // 
            // dnDataGridViewTextBoxColumn
            // 
            this.dnDataGridViewTextBoxColumn.DataPropertyName = "dn";
            this.dnDataGridViewTextBoxColumn.HeaderText = "dn";
            this.dnDataGridViewTextBoxColumn.Name = "dnDataGridViewTextBoxColumn";
            this.dnDataGridViewTextBoxColumn.ReadOnly = true;
            this.dnDataGridViewTextBoxColumn.Width = 50;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "d";
            this.dDataGridViewTextBoxColumn.HeaderText = "d";
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.ReadOnly = true;
            this.dDataGridViewTextBoxColumn.Width = 50;
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "t";
            this.tDataGridViewTextBoxColumn.HeaderText = "t";
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            this.tDataGridViewTextBoxColumn.ReadOnly = true;
            this.tDataGridViewTextBoxColumn.Width = 50;
            // 
            // frDataGridViewTextBoxColumn
            // 
            this.frDataGridViewTextBoxColumn.DataPropertyName = "f=r";
            this.frDataGridViewTextBoxColumn.HeaderText = "f=r";
            this.frDataGridViewTextBoxColumn.Name = "frDataGridViewTextBoxColumn";
            this.frDataGridViewTextBoxColumn.ReadOnly = true;
            this.frDataGridViewTextBoxColumn.Width = 50;
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "w";
            this.wDataGridViewTextBoxColumn.HeaderText = "w";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            this.wDataGridViewTextBoxColumn.ReadOnly = true;
            this.wDataGridViewTextBoxColumn.Width = 50;
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "h";
            this.hDataGridViewTextBoxColumn.HeaderText = "h";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            this.hDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDataGridViewTextBoxColumn.Width = 50;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "c";
            this.cDataGridViewTextBoxColumn.HeaderText = "c";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 50;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "b";
            this.bDataGridViewTextBoxColumn.HeaderText = "b";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            this.bDataGridViewTextBoxColumn.Width = 50;
            // 
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.ReadOnly = true;
            this.mDataGridViewTextBoxColumn.Width = 50;
            // 
            // otvodBindingSource
            // 
            this.otvodBindingSource.DataMember = "Otvod";
            this.otvodBindingSource.DataSource = this.mainENGDataSet;
            // 
            // mainENGDataSet
            // 
            this.mainENGDataSet.DataSetName = "MainENGDataSet";
            this.mainENGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otvodTableAdapter
            // 
            this.otvodTableAdapter.ClearBeforeFill = true;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(658, 386);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 32);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ResultatTextBox
            // 
            this.ResultatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ResultatTextBox.Location = new System.Drawing.Point(542, 283);
            this.ResultatTextBox.Multiline = true;
            this.ResultatTextBox.Name = "ResultatTextBox";
            this.ResultatTextBox.Size = new System.Drawing.Size(226, 95);
            this.ResultatTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(565, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Материал:";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.DisplayMember = "S";
            this.MaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "09Г2С",
            "10Г2",
            "Сталь 20"});
            this.MaterialComboBox.Location = new System.Drawing.Point(649, 47);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(103, 25);
            this.MaterialComboBox.TabIndex = 3;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // PrimechanieTextBox
            // 
            this.PrimechanieTextBox.Location = new System.Drawing.Point(542, 225);
            this.PrimechanieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrimechanieTextBox.Multiline = true;
            this.PrimechanieTextBox.Name = "PrimechanieTextBox";
            this.PrimechanieTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrimechanieTextBox.Size = new System.Drawing.Size(226, 35);
            this.PrimechanieTextBox.TabIndex = 8;
            this.PrimechanieTextBox.TextChanged += new System.EventHandler(this.PrimechanieTextBox_TextChanged);
            // 
            // KolichestvoNumericUpDown
            // 
            this.KolichestvoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.KolichestvoNumericUpDown.Location = new System.Drawing.Point(692, 19);
            this.KolichestvoNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.KolichestvoNumericUpDown.Name = "KolichestvoNumericUpDown";
            this.KolichestvoNumericUpDown.Size = new System.Drawing.Size(60, 23);
            this.KolichestvoNumericUpDown.TabIndex = 7;
            this.KolichestvoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KolichestvoNumericUpDown.ValueChanged += new System.EventHandler(this.KolichestvoNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(539, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Примечание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(589, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество:";
            // 
            // UgolComboBox
            // 
            this.UgolComboBox.DisplayMember = "S";
            this.UgolComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.UgolComboBox.FormattingEnabled = true;
            this.UgolComboBox.Items.AddRange(new object[] {
            "90",
            "60",
            "45"});
            this.UgolComboBox.Location = new System.Drawing.Point(649, 78);
            this.UgolComboBox.Name = "UgolComboBox";
            this.UgolComboBox.Size = new System.Drawing.Size(103, 25);
            this.UgolComboBox.TabIndex = 3;
            this.UgolComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(535, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Угол поворота:";
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
            this.OtbrakTolshNumericUpDown1.Location = new System.Drawing.Point(676, 158);
            this.OtbrakTolshNumericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OtbrakTolshNumericUpDown1.Name = "OtbrakTolshNumericUpDown1";
            this.OtbrakTolshNumericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.OtbrakTolshNumericUpDown1.TabIndex = 11;
            this.OtbrakTolshNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OtbrakTolshNumericUpDown1.ValueChanged += new System.EventHandler(this.OtbrakTolshNumericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(555, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отбраковочная толщина (мм):";
            // 
            // PodnadzornostCheckBox
            // 
            this.PodnadzornostCheckBox.AutoSize = true;
            this.PodnadzornostCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PodnadzornostCheckBox.Location = new System.Drawing.Point(548, 118);
            this.PodnadzornostCheckBox.Name = "PodnadzornostCheckBox";
            this.PodnadzornostCheckBox.Size = new System.Drawing.Size(204, 17);
            this.PodnadzornostCheckBox.TabIndex = 9;
            this.PodnadzornostCheckBox.Text = "Подконтрольность Ростехнадзору:";
            this.PodnadzornostCheckBox.UseVisualStyleBackColor = true;
            this.PodnadzornostCheckBox.CheckedChanged += new System.EventHandler(this.PodnadzornostCheckBox_CheckedChanged);
            // 
            // Otvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 431);
            this.Controls.Add(this.OtbrakTolshNumericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PodnadzornostCheckBox);
            this.Controls.Add(this.PrimechanieTextBox);
            this.Controls.Add(this.KolichestvoNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UgolComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.ResultatTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OtvodDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Otvod";
            this.Text = "Otvod";
            this.Load += new System.EventHandler(this.Otvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OtvodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainENGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolichestvoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OtvodDataGridView;
        private MainENGDataSet mainENGDataSet;
        private System.Windows.Forms.BindingSource otvodBindingSource;
        private MainENGDataSetTableAdapters.OtvodTableAdapter otvodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ResultatTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrimechanieTextBox;
        private System.Windows.Forms.NumericUpDown KolichestvoNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox UgolComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.NumericUpDown OtbrakTolshNumericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox PodnadzornostCheckBox;
    }
}