namespace sudoku_Projesi
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kistatistikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sudokuDataSet = new sudoku_Projesi.db_sudokuDataSet();
            this.kistatistikTableAdapter = new sudoku_Projesi.db_sudokuDataSetTableAdapters.kistatistikTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kistatistikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_3);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(36, 28);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(49, 13);
            this.linkLabel4.TabIndex = 8;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Giriş Yap";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "SÜRE: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lütfen giriş yapınız";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kadiDataGridViewTextBoxColumn,
            this.skorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kistatistikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(205, 113);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // kadiDataGridViewTextBoxColumn
            // 
            this.kadiDataGridViewTextBoxColumn.DataPropertyName = "k_adi";
            this.kadiDataGridViewTextBoxColumn.HeaderText = "k_adi";
            this.kadiDataGridViewTextBoxColumn.Name = "kadiDataGridViewTextBoxColumn";
            this.kadiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.kadiDataGridViewTextBoxColumn.Width = 70;
            // 
            // skorDataGridViewTextBoxColumn
            // 
            this.skorDataGridViewTextBoxColumn.DataPropertyName = "skor";
            this.skorDataGridViewTextBoxColumn.HeaderText = "skor";
            this.skorDataGridViewTextBoxColumn.Name = "skorDataGridViewTextBoxColumn";
            this.skorDataGridViewTextBoxColumn.Width = 70;
            // 
            // kistatistikBindingSource
            // 
            this.kistatistikBindingSource.DataMember = "kistatistik";
            this.kistatistikBindingSource.DataSource = this.db_sudokuDataSet;
            // 
            // db_sudokuDataSet
            // 
            this.db_sudokuDataSet.DataSetName = "db_sudokuDataSet";
            this.db_sudokuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kistatistikTableAdapter
            // 
            this.kistatistikTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::sudoku_Projesi.Properties.Resources.dark_blue_home_icon_500x500;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(930, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 65);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::sudoku_Projesi.Properties.Resources.karistir_butonu;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(12, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 67);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::sudoku_Projesi.Properties.Resources.en_iyiler;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(12, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 65);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::sudoku_Projesi.Properties.Resources.turn_off_on_power_512;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(930, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 67);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::sudoku_Projesi.Properties.Resources.kontrolEttt;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(818, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 251);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1030, 531);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kistatistikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sudokuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_sudokuDataSet db_sudokuDataSet;
        private System.Windows.Forms.BindingSource kistatistikBindingSource;
        private db_sudokuDataSetTableAdapters.kistatistikTableAdapter kistatistikTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;





    }
}

