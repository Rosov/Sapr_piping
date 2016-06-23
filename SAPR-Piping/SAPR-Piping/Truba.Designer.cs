namespace SAPR_Piping
{
    partial class Truba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Truba));
            this.TolshComboBox = new System.Windows.Forms.ComboBox();
            this.sgdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainENGDataSet = new SAPR_Piping.MainENGDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.HotRadioButton = new System.Windows.Forms.RadioButton();
            this.ColdRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DuComboBox = new System.Windows.Forms.ComboBox();
            this.gOST873278BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.DocComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrimechanieTextBox = new System.Windows.Forms.TextBox();
            this.s_gdTableAdapter = new SAPR_Piping.MainENGDataSetTableAdapters.S_gdTableAdapter();
            this.shdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_hdTableAdapter = new SAPR_Piping.MainENGDataSetTableAdapters.S_hdTableAdapter();
            this.gOST873475BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gOST_8734_75TableAdapter = new SAPR_Piping.MainENGDataSetTableAdapters.GOST_8734_75TableAdapter();
            this.gOST_8732_78TableAdapter = new SAPR_Piping.MainENGDataSetTableAdapters.GOST_8732_78TableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DlinaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.MassaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ResultatTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OtbrakTolshNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sgdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainENGDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gOST873278BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOST873475BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlinaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TolshComboBox
            // 
            this.TolshComboBox.DataSource = this.sgdBindingSource;
            this.TolshComboBox.DisplayMember = "S";
            this.TolshComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TolshComboBox.FormattingEnabled = true;
            this.TolshComboBox.Location = new System.Drawing.Point(224, 150);
            this.TolshComboBox.Name = "TolshComboBox";
            this.TolshComboBox.Size = new System.Drawing.Size(103, 25);
            this.TolshComboBox.TabIndex = 0;
            this.TolshComboBox.ValueMember = "S";
            this.TolshComboBox.SelectedIndexChanged += new System.EventHandler(this.TolshComboBox_SelectedIndexChanged);
            // 
            // sgdBindingSource
            // 
            this.sgdBindingSource.DataMember = "S_gd";
            this.sgdBindingSource.DataSource = this.mainENGDataSet;
            // 
            // mainENGDataSet
            // 
            this.mainENGDataSet.DataSetName = "MainENGDataSet";
            this.mainENGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(65, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Толщина стенки (мм):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HotRadioButton
            // 
            this.HotRadioButton.AutoSize = true;
            this.HotRadioButton.Checked = true;
            this.HotRadioButton.Location = new System.Drawing.Point(6, 20);
            this.HotRadioButton.Name = "HotRadioButton";
            this.HotRadioButton.Size = new System.Drawing.Size(136, 21);
            this.HotRadioButton.TabIndex = 2;
            this.HotRadioButton.TabStop = true;
            this.HotRadioButton.Text = "Горячекатанная";
            this.HotRadioButton.UseVisualStyleBackColor = true;
            this.HotRadioButton.CheckedChanged += new System.EventHandler(this.HotRadioButton_CheckedChanged);
            // 
            // ColdRadioButton
            // 
            this.ColdRadioButton.AutoSize = true;
            this.ColdRadioButton.Location = new System.Drawing.Point(6, 43);
            this.ColdRadioButton.Name = "ColdRadioButton";
            this.ColdRadioButton.Size = new System.Drawing.Size(145, 21);
            this.ColdRadioButton.TabIndex = 3;
            this.ColdRadioButton.Text = "Холоднокатанная";
            this.ColdRadioButton.UseVisualStyleBackColor = true;
            this.ColdRadioButton.CheckedChanged += new System.EventHandler(this.ColdRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HotRadioButton);
            this.groupBox1.Controls.Add(this.ColdRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип трубы";
            // 
            // DuComboBox
            // 
            this.DuComboBox.DataSource = this.gOST873278BindingSource;
            this.DuComboBox.DisplayMember = "DN";
            this.DuComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DuComboBox.FormattingEnabled = true;
            this.DuComboBox.Location = new System.Drawing.Point(224, 117);
            this.DuComboBox.Name = "DuComboBox";
            this.DuComboBox.Size = new System.Drawing.Size(103, 25);
            this.DuComboBox.TabIndex = 0;
            this.DuComboBox.SelectedIndexChanged += new System.EventHandler(this.DuComboBox_SelectedIndexChanged);
            // 
            // gOST873278BindingSource
            // 
            this.gOST873278BindingSource.DataMember = "GOST_8732-78";
            this.gOST873278BindingSource.DataSource = this.mainENGDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(43, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Диаметр наружный (мм):";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // DocComboBox
            // 
            this.DocComboBox.DisplayMember = "S";
            this.DocComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DocComboBox.FormattingEnabled = true;
            this.DocComboBox.Items.AddRange(new object[] {
            "ГОСТ 8732-78",
            "ГОСТ 8734-75",
            "ТУ 14-3Р-1128-2007"});
            this.DocComboBox.Location = new System.Drawing.Point(225, 298);
            this.DocComboBox.Name = "DocComboBox";
            this.DocComboBox.Size = new System.Drawing.Size(103, 21);
            this.DocComboBox.TabIndex = 0;
            this.DocComboBox.SelectedIndexChanged += new System.EventHandler(this.DocComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(48, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Нормативный документ:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrimechanieTextBox
            // 
            this.PrimechanieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PrimechanieTextBox.Location = new System.Drawing.Point(12, 355);
            this.PrimechanieTextBox.Multiline = true;
            this.PrimechanieTextBox.Name = "PrimechanieTextBox";
            this.PrimechanieTextBox.Size = new System.Drawing.Size(316, 62);
            this.PrimechanieTextBox.TabIndex = 5;
            // 
            // s_gdTableAdapter
            // 
            this.s_gdTableAdapter.ClearBeforeFill = true;
            // 
            // shdBindingSource
            // 
            this.shdBindingSource.DataMember = "S_hd";
            this.shdBindingSource.DataSource = this.mainENGDataSet;
            // 
            // s_hdTableAdapter
            // 
            this.s_hdTableAdapter.ClearBeforeFill = true;
            // 
            // gOST873475BindingSource
            // 
            this.gOST873475BindingSource.DataMember = "GOST_8734-75";
            this.gOST873475BindingSource.DataSource = this.mainENGDataSet;
            // 
            // gOST_8734_75TableAdapter
            // 
            this.gOST_8734_75TableAdapter.ClearBeforeFill = true;
            // 
            // gOST_8732_78TableAdapter
            // 
            this.gOST_8732_78TableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(9, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Отбраковочная толщина (мм):";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(138, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Длина (м):";
            this.label5.Click += new System.EventHandler(this.label1_Click);
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
            this.MaterialComboBox.Location = new System.Drawing.Point(224, 210);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(103, 25);
            this.MaterialComboBox.TabIndex = 0;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(140, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Материал:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // DlinaNumericUpDown
            // 
            this.DlinaNumericUpDown.DecimalPlaces = 1;
            this.DlinaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DlinaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DlinaNumericUpDown.Location = new System.Drawing.Point(225, 182);
            this.DlinaNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DlinaNumericUpDown.Name = "DlinaNumericUpDown";
            this.DlinaNumericUpDown.Size = new System.Drawing.Size(102, 23);
            this.DlinaNumericUpDown.TabIndex = 6;
            this.DlinaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DlinaNumericUpDown.ValueChanged += new System.EventHandler(this.DlinaNumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(104, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Масса п. м. (кг):";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // MassaNumericUpDown
            // 
            this.MassaNumericUpDown.DecimalPlaces = 3;
            this.MassaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MassaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MassaNumericUpDown.Location = new System.Drawing.Point(225, 241);
            this.MassaNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MassaNumericUpDown.Name = "MassaNumericUpDown";
            this.MassaNumericUpDown.Size = new System.Drawing.Size(102, 23);
            this.MassaNumericUpDown.TabIndex = 6;
            this.MassaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MassaNumericUpDown.ValueChanged += new System.EventHandler(this.MassaNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(12, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Примечание:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResultatTextBox
            // 
            this.ResultatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ResultatTextBox.Location = new System.Drawing.Point(11, 442);
            this.ResultatTextBox.Name = "ResultatTextBox";
            this.ResultatTextBox.Size = new System.Drawing.Size(317, 23);
            this.ResultatTextBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(12, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Реультат:";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(224, 468);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 40);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.Location = new System.Drawing.Point(11, 473);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 40);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OtbrakTolshNumericUpDown
            // 
            this.OtbrakTolshNumericUpDown.DecimalPlaces = 1;
            this.OtbrakTolshNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OtbrakTolshNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.OtbrakTolshNumericUpDown.Location = new System.Drawing.Point(225, 269);
            this.OtbrakTolshNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OtbrakTolshNumericUpDown.Name = "OtbrakTolshNumericUpDown";
            this.OtbrakTolshNumericUpDown.Size = new System.Drawing.Size(102, 23);
            this.OtbrakTolshNumericUpDown.TabIndex = 6;
            this.OtbrakTolshNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OtbrakTolshNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Truba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 520);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OtbrakTolshNumericUpDown);
            this.Controls.Add(this.MassaNumericUpDown);
            this.Controls.Add(this.DlinaNumericUpDown);
            this.Controls.Add(this.ResultatTextBox);
            this.Controls.Add(this.PrimechanieTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DuComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.DocComboBox);
            this.Controls.Add(this.TolshComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Truba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Трубы";
            this.Load += new System.EventHandler(this.Truba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sgdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainENGDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gOST873278BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOST873475BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlinaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtbrakTolshNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TolshComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton HotRadioButton;
        private System.Windows.Forms.RadioButton ColdRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DuComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DocComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrimechanieTextBox;
        private MainENGDataSet mainENGDataSet;
        private System.Windows.Forms.BindingSource sgdBindingSource;
        private MainENGDataSetTableAdapters.S_gdTableAdapter s_gdTableAdapter;
        private System.Windows.Forms.BindingSource shdBindingSource;
        private MainENGDataSetTableAdapters.S_hdTableAdapter s_hdTableAdapter;
        private System.Windows.Forms.BindingSource gOST873475BindingSource;
        private MainENGDataSetTableAdapters.GOST_8734_75TableAdapter gOST_8734_75TableAdapter;
        private System.Windows.Forms.BindingSource gOST873278BindingSource;
        private MainENGDataSetTableAdapters.GOST_8732_78TableAdapter gOST_8732_78TableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown DlinaNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MassaNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ResultatTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown OtbrakTolshNumericUpDown;
    }
}