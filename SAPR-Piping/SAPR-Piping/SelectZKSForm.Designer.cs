namespace SAPR_Piping
{
    partial class SelectZKSForm
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
            this.pNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоОборотовНаВтулкеШтокаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоОборотовМаховикаРедуктораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадкиISO5210ДляПриводнойАрматурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trxHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.массаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.массаИзделияСКОФDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.крутящийМоментНDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зКСBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new SAPR_Piping.MainDataSet();
            this.mainDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зКСTableAdapter = new SAPR_Piping.MainDataSetTableAdapters.ЗКСTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зКСBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNDataGridViewTextBoxColumn,
            this.dNDataGridViewTextBoxColumn,
            this.lDataGridViewTextBoxColumn,
            this.l1DataGridViewTextBoxColumn,
            this.l2DataGridViewTextBoxColumn,
            this.l3DataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.h1DataGridViewTextBoxColumn,
            this.h2DataGridViewTextBoxColumn,
            this.h3DataGridViewTextBoxColumn,
            this.wDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.количествоОборотовНаВтулкеШтокаDataGridViewTextBoxColumn,
            this.количествоОборотовМаховикаРедуктораDataGridViewTextBoxColumn,
            this.площадкиISO5210ДляПриводнойАрматурыDataGridViewTextBoxColumn,
            this.trxHDataGridViewTextBoxColumn,
            this.массаDataGridViewTextBoxColumn,
            this.массаИзделияСКОФDataGridViewTextBoxColumn,
            this.крутящийМоментНDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.зКСBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 675);
            this.dataGridView1.TabIndex = 0;
            // 
            // pNDataGridViewTextBoxColumn
            // 
            this.pNDataGridViewTextBoxColumn.DataPropertyName = "PN";
            this.pNDataGridViewTextBoxColumn.HeaderText = "PN";
            this.pNDataGridViewTextBoxColumn.Name = "pNDataGridViewTextBoxColumn";
            // 
            // dNDataGridViewTextBoxColumn
            // 
            this.dNDataGridViewTextBoxColumn.DataPropertyName = "DN";
            this.dNDataGridViewTextBoxColumn.HeaderText = "DN";
            this.dNDataGridViewTextBoxColumn.Name = "dNDataGridViewTextBoxColumn";
            // 
            // lDataGridViewTextBoxColumn
            // 
            this.lDataGridViewTextBoxColumn.DataPropertyName = "L";
            this.lDataGridViewTextBoxColumn.HeaderText = "L";
            this.lDataGridViewTextBoxColumn.Name = "lDataGridViewTextBoxColumn";
            // 
            // l1DataGridViewTextBoxColumn
            // 
            this.l1DataGridViewTextBoxColumn.DataPropertyName = "L1";
            this.l1DataGridViewTextBoxColumn.HeaderText = "L1";
            this.l1DataGridViewTextBoxColumn.Name = "l1DataGridViewTextBoxColumn";
            // 
            // l2DataGridViewTextBoxColumn
            // 
            this.l2DataGridViewTextBoxColumn.DataPropertyName = "L2";
            this.l2DataGridViewTextBoxColumn.HeaderText = "L2";
            this.l2DataGridViewTextBoxColumn.Name = "l2DataGridViewTextBoxColumn";
            // 
            // l3DataGridViewTextBoxColumn
            // 
            this.l3DataGridViewTextBoxColumn.DataPropertyName = "L3";
            this.l3DataGridViewTextBoxColumn.HeaderText = "L3";
            this.l3DataGridViewTextBoxColumn.Name = "l3DataGridViewTextBoxColumn";
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            // 
            // h1DataGridViewTextBoxColumn
            // 
            this.h1DataGridViewTextBoxColumn.DataPropertyName = "H1";
            this.h1DataGridViewTextBoxColumn.HeaderText = "H1";
            this.h1DataGridViewTextBoxColumn.Name = "h1DataGridViewTextBoxColumn";
            // 
            // h2DataGridViewTextBoxColumn
            // 
            this.h2DataGridViewTextBoxColumn.DataPropertyName = "H2";
            this.h2DataGridViewTextBoxColumn.HeaderText = "H2";
            this.h2DataGridViewTextBoxColumn.Name = "h2DataGridViewTextBoxColumn";
            // 
            // h3DataGridViewTextBoxColumn
            // 
            this.h3DataGridViewTextBoxColumn.DataPropertyName = "H3";
            this.h3DataGridViewTextBoxColumn.HeaderText = "H3";
            this.h3DataGridViewTextBoxColumn.Name = "h3DataGridViewTextBoxColumn";
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn.HeaderText = "W";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "D";
            this.dDataGridViewTextBoxColumn.HeaderText = "D";
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            // 
            // количествоОборотовНаВтулкеШтокаDataGridViewTextBoxColumn
            // 
            this.количествоОборотовНаВтулкеШтокаDataGridViewTextBoxColumn.DataPropertyName = "Количество оборотов на втулке штока";
            this.количествоОборотовНаВтулкеШтокаDataGridViewTextBoxColumn.HeaderText = "Количество оборотов на втулке штока";
            this.количествоОборотовНаВтулкеШтокаDataGridViewTextBoxColumn.Name = "количествоОборотовНаВтулкеШтокаDataGridViewTextBoxColumn";
            // 
            // количествоОборотовМаховикаРедуктораDataGridViewTextBoxColumn
            // 
            this.количествоОборотовМаховикаРедуктораDataGridViewTextBoxColumn.DataPropertyName = "Количество оборотов маховика редуктора";
            this.количествоОборотовМаховикаРедуктораDataGridViewTextBoxColumn.HeaderText = "Количество оборотов маховика редуктора";
            this.количествоОборотовМаховикаРедуктораDataGridViewTextBoxColumn.Name = "количествоОборотовМаховикаРедуктораDataGridViewTextBoxColumn";
            // 
            // площадкиISO5210ДляПриводнойАрматурыDataGridViewTextBoxColumn
            // 
            this.площадкиISO5210ДляПриводнойАрматурыDataGridViewTextBoxColumn.DataPropertyName = "Площадки ISO 5210 для приводной арматуры";
            this.площадкиISO5210ДляПриводнойАрматурыDataGridViewTextBoxColumn.HeaderText = "Площадки ISO 5210 для приводной арматуры";
            this.площадкиISO5210ДляПриводнойАрматурыDataGridViewTextBoxColumn.Name = "площадкиISO5210ДляПриводнойАрматурыDataGridViewTextBoxColumn";
            // 
            // trxHDataGridViewTextBoxColumn
            // 
            this.trxHDataGridViewTextBoxColumn.DataPropertyName = "TrxH";
            this.trxHDataGridViewTextBoxColumn.HeaderText = "TrxH";
            this.trxHDataGridViewTextBoxColumn.Name = "trxHDataGridViewTextBoxColumn";
            // 
            // массаDataGridViewTextBoxColumn
            // 
            this.массаDataGridViewTextBoxColumn.DataPropertyName = "Масса";
            this.массаDataGridViewTextBoxColumn.HeaderText = "Масса";
            this.массаDataGridViewTextBoxColumn.Name = "массаDataGridViewTextBoxColumn";
            // 
            // массаИзделияСКОФDataGridViewTextBoxColumn
            // 
            this.массаИзделияСКОФDataGridViewTextBoxColumn.DataPropertyName = "Масса изделия с КОФ";
            this.массаИзделияСКОФDataGridViewTextBoxColumn.HeaderText = "Масса изделия с КОФ";
            this.массаИзделияСКОФDataGridViewTextBoxColumn.Name = "массаИзделияСКОФDataGridViewTextBoxColumn";
            // 
            // крутящийМоментНDataGridViewTextBoxColumn
            // 
            this.крутящийМоментНDataGridViewTextBoxColumn.DataPropertyName = "Крутящий момент Н";
            this.крутящийМоментНDataGridViewTextBoxColumn.HeaderText = "Крутящий момент Н";
            this.крутящийМоментНDataGridViewTextBoxColumn.Name = "крутящийМоментНDataGridViewTextBoxColumn";
            // 
            // зКСBindingSource
            // 
            this.зКСBindingSource.DataMember = "ЗКС";
            this.зКСBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainDataSetBindingSource
            // 
            this.mainDataSetBindingSource.DataSource = this.mainDataSet;
            this.mainDataSetBindingSource.Position = 0;
            // 
            // зКСTableAdapter
            // 
            this.зКСTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::SAPR_Piping.Properties.Resources.ЗКСч;
            this.pictureBox1.Location = new System.Drawing.Point(1009, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 675);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SelectZKSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelectZKSForm";
            this.Text = "Задвижки клиновые стальные DN от 15 до 1200 PN от 16 до 250 кгс/см2 \"ВАРК\"";
            this.Load += new System.EventHandler(this.SelectZKSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зКСBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mainDataSetBindingSource;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource зКСBindingSource;
        private MainDataSetTableAdapters.ЗКСTableAdapter зКСTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn h1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn h2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn h3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоОборотовНаВтулкеШтокаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоОборотовМаховикаРедуктораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадкиISO5210ДляПриводнойАрматурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trxHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn массаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn массаИзделияСКОФDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn крутящийМоментНDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}