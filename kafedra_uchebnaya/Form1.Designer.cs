namespace kafedra_uchebnaya
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.koddisciplinuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodkafedruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raschasovkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontrolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplinuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._21_101_05__Ucheba_studentov_DataSet = new kafedra_uchebnaya._21_101_05__Ucheba_studentov_DataSet();
            this.disciplinuTableAdapter = new kafedra_uchebnaya._21_101_05__Ucheba_studentov_DataSetTableAdapters.DisciplinuTableAdapter();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.kod_disciplinu = new System.Windows.Forms.TextBox();
            this.kod_kafedru = new System.Windows.Forms.TextBox();
            this.name_dis = new System.Windows.Forms.TextBox();
            this.raschasovka = new System.Windows.Forms.TextBox();
            this.Kontrol = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._21_101_05__Ucheba_studentov_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.koddisciplinuDataGridViewTextBoxColumn,
            this.kodkafedruDataGridViewTextBoxColumn,
            this.namedisDataGridViewTextBoxColumn,
            this.raschasovkaDataGridViewTextBoxColumn,
            this.kontrolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.disciplinuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // koddisciplinuDataGridViewTextBoxColumn
            // 
            this.koddisciplinuDataGridViewTextBoxColumn.DataPropertyName = "Kod_disciplinu";
            this.koddisciplinuDataGridViewTextBoxColumn.HeaderText = "Kod_disciplinu";
            this.koddisciplinuDataGridViewTextBoxColumn.Name = "koddisciplinuDataGridViewTextBoxColumn";
            // 
            // kodkafedruDataGridViewTextBoxColumn
            // 
            this.kodkafedruDataGridViewTextBoxColumn.DataPropertyName = "Kod_kafedru";
            this.kodkafedruDataGridViewTextBoxColumn.HeaderText = "Kod_kafedru";
            this.kodkafedruDataGridViewTextBoxColumn.Name = "kodkafedruDataGridViewTextBoxColumn";
            // 
            // namedisDataGridViewTextBoxColumn
            // 
            this.namedisDataGridViewTextBoxColumn.DataPropertyName = "Name_dis";
            this.namedisDataGridViewTextBoxColumn.HeaderText = "Name_dis";
            this.namedisDataGridViewTextBoxColumn.Name = "namedisDataGridViewTextBoxColumn";
            // 
            // raschasovkaDataGridViewTextBoxColumn
            // 
            this.raschasovkaDataGridViewTextBoxColumn.DataPropertyName = "Raschasovka";
            this.raschasovkaDataGridViewTextBoxColumn.HeaderText = "Raschasovka";
            this.raschasovkaDataGridViewTextBoxColumn.Name = "raschasovkaDataGridViewTextBoxColumn";
            // 
            // kontrolDataGridViewTextBoxColumn
            // 
            this.kontrolDataGridViewTextBoxColumn.DataPropertyName = "Kontrol";
            this.kontrolDataGridViewTextBoxColumn.HeaderText = "Kontrol";
            this.kontrolDataGridViewTextBoxColumn.Name = "kontrolDataGridViewTextBoxColumn";
            // 
            // disciplinuBindingSource
            // 
            this.disciplinuBindingSource.DataMember = "Disciplinu";
            this.disciplinuBindingSource.DataSource = this._21_101_05__Ucheba_studentov_DataSet;
            // 
            // _21_101_05__Ucheba_studentov_DataSet
            // 
            this._21_101_05__Ucheba_studentov_DataSet.DataSetName = "_21_101_05__Ucheba_studentov_DataSet";
            this._21_101_05__Ucheba_studentov_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplinuTableAdapter
            // 
            this.disciplinuTableAdapter.ClearBeforeFill = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(29, 240);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(116, 49);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(151, 240);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 49);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(565, 38);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 30);
            this.Search.TabIndex = 3;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // kod_disciplinu
            // 
            this.kod_disciplinu.Location = new System.Drawing.Point(29, 182);
            this.kod_disciplinu.Name = "kod_disciplinu";
            this.kod_disciplinu.Size = new System.Drawing.Size(100, 20);
            this.kod_disciplinu.TabIndex = 5;
            // 
            // kod_kafedru
            // 
            this.kod_kafedru.Location = new System.Drawing.Point(135, 182);
            this.kod_kafedru.Name = "kod_kafedru";
            this.kod_kafedru.Size = new System.Drawing.Size(100, 20);
            this.kod_kafedru.TabIndex = 6;
            // 
            // name_dis
            // 
            this.name_dis.Location = new System.Drawing.Point(241, 182);
            this.name_dis.Name = "name_dis";
            this.name_dis.Size = new System.Drawing.Size(100, 20);
            this.name_dis.TabIndex = 7;
            // 
            // raschasovka
            // 
            this.raschasovka.Location = new System.Drawing.Point(347, 182);
            this.raschasovka.Name = "raschasovka";
            this.raschasovka.Size = new System.Drawing.Size(100, 20);
            this.raschasovka.TabIndex = 8;
            // 
            // Kontrol
            // 
            this.Kontrol.Location = new System.Drawing.Point(453, 182);
            this.Kontrol.Name = "Kontrol";
            this.Kontrol.Size = new System.Drawing.Size(100, 20);
            this.Kontrol.TabIndex = 9;
            this.Kontrol.TextChanged += new System.EventHandler(this.kontrol_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(565, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 310);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Kontrol);
            this.Controls.Add(this.raschasovka);
            this.Controls.Add(this.name_dis);
            this.Controls.Add(this.kod_kafedru);
            this.Controls.Add(this.kod_disciplinu);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._21_101_05__Ucheba_studentov_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _21_101_05__Ucheba_studentov_DataSet _21_101_05__Ucheba_studentov_DataSet;
        private System.Windows.Forms.BindingSource disciplinuBindingSource;
        private _21_101_05__Ucheba_studentov_DataSetTableAdapters.DisciplinuTableAdapter disciplinuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn koddisciplinuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodkafedruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raschasovkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox kod_disciplinu;
        private System.Windows.Forms.TextBox kod_kafedru;
        private System.Windows.Forms.TextBox name_dis;
        private System.Windows.Forms.TextBox raschasovka;
        private System.Windows.Forms.TextBox Kontrol;
        private System.Windows.Forms.TextBox textBox1;
    }
}

