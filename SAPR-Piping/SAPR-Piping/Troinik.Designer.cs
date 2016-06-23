namespace SAPR_Piping
{
    partial class Troinik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Troinik));
            this.TroinikDataGridView = new System.Windows.Forms.DataGridView();
            this.dnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trothnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainENGDataSet = new SAPR_Piping.MainENGDataSet();
            this.trothnikTableAdapter = new SAPR_Piping.MainENGDataSetTableAdapters.TrothnikTableAdapter();
            this.PrimechanieTextBox = new System.Windows.Forms.TextBox();
            this.KolichestvoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.ResultatTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.OtbrakTolshNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.OtbrakTolshNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.PodnadzornostCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TroinikDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trothnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainENGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolichestvoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // TroinikDataGridView
            // 
            this.TroinikDataGridView.AutoGenerateColumns = false;
            this.TroinikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TroinikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dnDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn,
            this.d1DataGridViewTextBoxColumn,
            this.t1DataGridViewTextBoxColumn,
            this.mDataGridViewTextBoxColumn});
            this.TroinikDataGridView.DataSource = this.trothnikBindingSource;
            this.TroinikDataGridView.Location = new System.Drawing.Point(17, 17);
            this.TroinikDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.TroinikDataGridView.MultiSelect = false;
            this.TroinikDataGridView.Name = "TroinikDataGridView";
            this.TroinikDataGridView.ReadOnly = true;
            this.TroinikDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TroinikDataGridView.Size = new System.Drawing.Size(653, 413);
            this.TroinikDataGridView.TabIndex = 0;
            this.TroinikDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TroinikDataGridView_CellContentClick);
            this.TroinikDataGridView.Click += new System.EventHandler(this.TroinikDataGridView_Click);
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
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trothnikBindingSource
            // 
            this.trothnikBindingSource.DataMember = "Trothnik";
            this.trothnikBindingSource.DataSource = this.mainENGDataSet;
            // 
            // mainENGDataSet
            // 
            this.mainENGDataSet.DataSetName = "MainENGDataSet";
            this.mainENGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trothnikTableAdapter
            // 
            this.trothnikTableAdapter.ClearBeforeFill = true;
            // 
            // PrimechanieTextBox
            // 
            this.PrimechanieTextBox.Location = new System.Drawing.Point(677, 282);
            this.PrimechanieTextBox.Multiline = true;
            this.PrimechanieTextBox.Name = "PrimechanieTextBox";
            this.PrimechanieTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrimechanieTextBox.Size = new System.Drawing.Size(281, 45);
            this.PrimechanieTextBox.TabIndex = 16;
            this.PrimechanieTextBox.TextChanged += new System.EventHandler(this.PrimechanieTextBox_TextChanged);
            // 
            // KolichestvoNumericUpDown
            // 
            this.KolichestvoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.KolichestvoNumericUpDown.Location = new System.Drawing.Point(877, 17);
            this.KolichestvoNumericUpDown.Name = "KolichestvoNumericUpDown";
            this.KolichestvoNumericUpDown.Size = new System.Drawing.Size(80, 23);
            this.KolichestvoNumericUpDown.TabIndex = 15;
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
            this.label4.Location = new System.Drawing.Point(683, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Примечание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(768, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(727, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 12;
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
            this.MaterialComboBox.Location = new System.Drawing.Point(821, 49);
            this.MaterialComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(136, 25);
            this.MaterialComboBox.TabIndex = 11;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // ResultatTextBox
            // 
            this.ResultatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ResultatTextBox.Location = new System.Drawing.Point(677, 334);
            this.ResultatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultatTextBox.Multiline = true;
            this.ResultatTextBox.Name = "ResultatTextBox";
            this.ResultatTextBox.Size = new System.Drawing.Size(280, 46);
            this.ResultatTextBox.TabIndex = 10;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(810, 388);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(147, 42);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OtbrakTolshNumericUpDown2
            // 
            this.OtbrakTolshNumericUpDown2.DecimalPlaces = 1;
            this.OtbrakTolshNumericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OtbrakTolshNumericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.OtbrakTolshNumericUpDown2.Location = new System.Drawing.Point(883, 213);
            this.OtbrakTolshNumericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OtbrakTolshNumericUpDown2.Name = "OtbrakTolshNumericUpDown2";
            this.OtbrakTolshNumericUpDown2.Size = new System.Drawing.Size(76, 23);
            this.OtbrakTolshNumericUpDown2.TabIndex = 20;
            this.OtbrakTolshNumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OtbrakTolshNumericUpDown2.ValueChanged += new System.EventHandler(this.OtbrakTolshNumericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(729, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Отбраковочная толщина #2 (мм):";
            // 
            // OtbrakTolshNumericUpDown1
            // 
            this.OtbrakTolshNumericUpDown1.DecimalPlaces = 1;
            this.OtbrakTolshNumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OtbrakTolshNumericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.OtbrakTolshNumericUpDown1.Location = new System.Drawing.Point(882, 156);
            this.OtbrakTolshNumericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OtbrakTolshNumericUpDown1.Name = "OtbrakTolshNumericUpDown1";
            this.OtbrakTolshNumericUpDown1.Size = new System.Drawing.Size(76, 23);
            this.OtbrakTolshNumericUpDown1.TabIndex = 21;
            this.OtbrakTolshNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OtbrakTolshNumericUpDown1.ValueChanged += new System.EventHandler(this.OtbrakTolshNumericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(728, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Отбраковочная толщина #1 (мм):";
            // 
            // PodnadzornostCheckBox
            // 
            this.PodnadzornostCheckBox.AutoSize = true;
            this.PodnadzornostCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PodnadzornostCheckBox.Location = new System.Drawing.Point(699, 85);
            this.PodnadzornostCheckBox.Name = "PodnadzornostCheckBox";
            this.PodnadzornostCheckBox.Size = new System.Drawing.Size(258, 21);
            this.PodnadzornostCheckBox.TabIndex = 17;
            this.PodnadzornostCheckBox.Text = "Подконтрольность Ростехнадзору:";
            this.PodnadzornostCheckBox.UseVisualStyleBackColor = true;
            this.PodnadzornostCheckBox.CheckedChanged += new System.EventHandler(this.PodnadzornostCheckBox_CheckedChanged);
            // 
            // Troinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 438);
            this.Controls.Add(this.OtbrakTolshNumericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtbrakTolshNumericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PodnadzornostCheckBox);
            this.Controls.Add(this.PrimechanieTextBox);
            this.Controls.Add(this.KolichestvoNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.ResultatTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TroinikDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Troinik";
            this.Text = "Troinik";
            this.Load += new System.EventHandler(this.Troinik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TroinikDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trothnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainENGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolichestvoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TroinikDataGridView;
        private MainENGDataSet mainENGDataSet;
        private System.Windows.Forms.BindingSource trothnikBindingSource;
        private MainENGDataSetTableAdapters.TrothnikTableAdapter trothnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox PrimechanieTextBox;
        private System.Windows.Forms.NumericUpDown KolichestvoNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.TextBox ResultatTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown OtbrakTolshNumericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown OtbrakTolshNumericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox PodnadzornostCheckBox;
    }
}