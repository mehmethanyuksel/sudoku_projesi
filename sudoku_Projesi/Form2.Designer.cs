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
            this.kistatistikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kistatistikTableAdapter = new sudoku_Projesi.db_sudokuDataSetTableAdapters.kistatistikTableAdapter();
            this.kadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kistatistikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kadiDataGridViewTextBoxColumn,
            this.skorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kistatistikBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(290, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_sudokuDataSet
            // 
            this.db_sudokuDataSet.DataSetName = "db_sudokuDataSet";
            this.db_sudokuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kistatistikBindingSource
            // 
            this.kistatistikBindingSource.DataMember = "kistatistik";
            this.kistatistikBindingSource.DataSource = this.db_sudokuDataSet;
            // 
            // kistatistikTableAdapter
            // 
            this.kistatistikTableAdapter.ClearBeforeFill = true;
            // 
            // kadiDataGridViewTextBoxColumn
            // 
            this.kadiDataGridViewTextBoxColumn.DataPropertyName = "k_adi";
            this.kadiDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.kadiDataGridViewTextBoxColumn.Name = "kadiDataGridViewTextBoxColumn";
            this.kadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // skorDataGridViewTextBoxColumn
            // 
            this.skorDataGridViewTextBoxColumn.DataPropertyName = "skor";
            this.skorDataGridViewTextBoxColumn.HeaderText = "Skor";
            this.skorDataGridViewTextBoxColumn.Name = "skorDataGridViewTextBoxColumn";
            this.skorDataGridViewTextBoxColumn.Width = 120;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kistatistikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_sudokuDataSet db_sudokuDataSet;
        private System.Windows.Forms.BindingSource kistatistikBindingSource;
        private db_sudokuDataSetTableAdapters.kistatistikTableAdapter kistatistikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skorDataGridViewTextBoxColumn;
    }
}