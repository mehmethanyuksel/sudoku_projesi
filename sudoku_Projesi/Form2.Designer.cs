namespace sudoku_Projesi
{
    partial class Form2
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
            this.db_sudokuDataSet = new sudoku_Projesi.db_sudokuDataSet();
            this.istatistiklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istatistiklerTableAdapter = new sudoku_Projesi.db_sudokuDataSetTableAdapters.istatistiklerTableAdapter();
            this.db_sudokuDataSet1 = new sudoku_Projesi.db_sudokuDataSet1();
            this.istatistikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istatistikTableAdapter = new sudoku_Projesi.db_sudokuDataSet1TableAdapters.istatistikTableAdapter();
            this.db_sudokuDataSet2 = new sudoku_Projesi.db_sudokuDataSet2();
            this.kistatistikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kistatistikTableAdapter = new sudoku_Projesi.db_sudokuDataSet2TableAdapters.kistatistikTableAdapter();
            this.k_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istatistiklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istatistikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kistatistikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.k_adi,
            this.skorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kistatistikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_sudokuDataSet
            // 
            this.db_sudokuDataSet.DataSetName = "db_sudokuDataSet";
            this.db_sudokuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // istatistiklerBindingSource
            // 
            this.istatistiklerBindingSource.DataMember = "istatistikler";
            this.istatistiklerBindingSource.DataSource = this.db_sudokuDataSet;
            // 
            // istatistiklerTableAdapter
            // 
            this.istatistiklerTableAdapter.ClearBeforeFill = true;
            // 
            // db_sudokuDataSet1
            // 
            this.db_sudokuDataSet1.DataSetName = "db_sudokuDataSet1";
            this.db_sudokuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // istatistikBindingSource
            // 
            this.istatistikBindingSource.DataMember = "istatistik";
            this.istatistikBindingSource.DataSource = this.db_sudokuDataSet1;
            // 
            // istatistikTableAdapter
            // 
            this.istatistikTableAdapter.ClearBeforeFill = true;
            // 
            // db_sudokuDataSet2
            // 
            this.db_sudokuDataSet2.DataSetName = "db_sudokuDataSet2";
            this.db_sudokuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kistatistikBindingSource
            // 
            this.kistatistikBindingSource.DataMember = "kistatistik";
            this.kistatistikBindingSource.DataSource = this.db_sudokuDataSet2;
            // 
            // kistatistikTableAdapter
            // 
            this.kistatistikTableAdapter.ClearBeforeFill = true;
            // 
            // k_adi
            // 
            this.k_adi.DataPropertyName = "k_adi";
            this.k_adi.HeaderText = "k_adi";
            this.k_adi.Name = "k_adi";
            this.k_adi.Width = 120;
            // 
            // skorDataGridViewTextBoxColumn
            // 
            this.skorDataGridViewTextBoxColumn.DataPropertyName = "skor";
            this.skorDataGridViewTextBoxColumn.HeaderText = "skor";
            this.skorDataGridViewTextBoxColumn.Name = "skorDataGridViewTextBoxColumn";
            this.skorDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 342);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istatistiklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istatistikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kistatistikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_sudokuDataSet db_sudokuDataSet;
        private System.Windows.Forms.BindingSource istatistiklerBindingSource;
        private db_sudokuDataSetTableAdapters.istatistiklerTableAdapter istatistiklerTableAdapter;
        private db_sudokuDataSet1 db_sudokuDataSet1;
        private System.Windows.Forms.BindingSource istatistikBindingSource;
        private db_sudokuDataSet1TableAdapters.istatistikTableAdapter istatistikTableAdapter;
        private db_sudokuDataSet2 db_sudokuDataSet2;
        private System.Windows.Forms.BindingSource kistatistikBindingSource;
        private db_sudokuDataSet2TableAdapters.kistatistikTableAdapter kistatistikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn k_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn skorDataGridViewTextBoxColumn;
    }
}