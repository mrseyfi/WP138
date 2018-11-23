namespace Prj138
{
    partial class frmTest3
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
            this.dB138DataSet = new Prj138.DB138DataSet();
            this.tblCityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CityTableAdapter = new Prj138.DB138DataSetTableAdapters.tbl_CityTableAdapter();
            this.iDciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleCiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB138DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDciDataGridViewTextBoxColumn,
            this.titleCiDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // dB138DataSet
            // 
            this.dB138DataSet.DataSetName = "DB138DataSet";
            this.dB138DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCityBindingSource
            // 
            this.tblCityBindingSource.DataMember = "tbl_City";
            this.tblCityBindingSource.DataSource = this.dB138DataSet;
            // 
            // tbl_CityTableAdapter
            // 
            this.tbl_CityTableAdapter.ClearBeforeFill = true;
            // 
            // iDciDataGridViewTextBoxColumn
            // 
            this.iDciDataGridViewTextBoxColumn.DataPropertyName = "IDci";
            this.iDciDataGridViewTextBoxColumn.HeaderText = "IDci";
            this.iDciDataGridViewTextBoxColumn.Name = "iDciDataGridViewTextBoxColumn";
            this.iDciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleCiDataGridViewTextBoxColumn
            // 
            this.titleCiDataGridViewTextBoxColumn.DataPropertyName = "titleCi";
            this.titleCiDataGridViewTextBoxColumn.HeaderText = "titleCi";
            this.titleCiDataGridViewTextBoxColumn.Name = "titleCiDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 203);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(492, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // frmTest3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 377);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTest3";
            this.Text = "frmTest3";
            this.Load += new System.EventHandler(this.frmTest3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB138DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB138DataSet dB138DataSet;
        private System.Windows.Forms.BindingSource tblCityBindingSource;
        private DB138DataSetTableAdapters.tbl_CityTableAdapter tbl_CityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleCiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}