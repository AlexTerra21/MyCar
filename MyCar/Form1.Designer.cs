namespace MyCar
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
            this.fuelDataGridView = new System.Windows.Forms.DataGridView();
            this.fuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myCarDataSet = new MyCar.MyCarDataSet();
            this.btExit = new System.Windows.Forms.Button();
            this.cbFilterMonthYear = new System.Windows.Forms.ComboBox();
            this.monthYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelTableAdapter = new MyCar.MyCarDataSetTableAdapters.FuelTableAdapter();
            this.tableAdapterManager = new MyCar.MyCarDataSetTableAdapters.TableAdapterManager();
            this.monthYearTableAdapter = new MyCar.MyCarDataSetTableAdapters.MonthYearTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddRow = new System.Windows.Forms.Button();
            this.btEditRow = new System.Windows.Forms.Button();
            this.btDeleteRow = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fuelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthYearBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fuelDataGridView
            // 
            this.fuelDataGridView.AllowUserToAddRows = false;
            this.fuelDataGridView.AllowUserToDeleteRows = false;
            this.fuelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fuelDataGridView.AutoGenerateColumns = false;
            this.fuelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fuelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.fuelDataGridView.DataSource = this.fuelBindingSource;
            this.fuelDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.fuelDataGridView.Location = new System.Drawing.Point(12, 12);
            this.fuelDataGridView.MultiSelect = false;
            this.fuelDataGridView.Name = "fuelDataGridView";
            this.fuelDataGridView.ReadOnly = true;
            this.fuelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fuelDataGridView.Size = new System.Drawing.Size(540, 290);
            this.fuelDataGridView.TabIndex = 1;
            this.fuelDataGridView.SelectionChanged += new System.EventHandler(this.fuelDataGridView_SelectionChanged);
            // 
            // fuelBindingSource
            // 
            this.fuelBindingSource.DataMember = "Fuel";
            this.fuelBindingSource.DataSource = this.myCarDataSet;
            // 
            // myCarDataSet
            // 
            this.myCarDataSet.DataSetName = "MyCarDataSet";
            this.myCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Location = new System.Drawing.Point(465, 418);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cbFilterMonthYear
            // 
            this.cbFilterMonthYear.DataSource = this.monthYearBindingSource;
            this.cbFilterMonthYear.DisplayMember = "MonthYear";
            this.cbFilterMonthYear.FormattingEnabled = true;
            this.cbFilterMonthYear.Location = new System.Drawing.Point(6, 19);
            this.cbFilterMonthYear.Name = "cbFilterMonthYear";
            this.cbFilterMonthYear.Size = new System.Drawing.Size(183, 21);
            this.cbFilterMonthYear.TabIndex = 3;
            this.cbFilterMonthYear.SelectionChangeCommitted += new System.EventHandler(this.cbFilterMonthYear_SelectionChangeCommitted);
            // 
            // monthYearBindingSource
            // 
            this.monthYearBindingSource.DataMember = "MonthYear";
            this.monthYearBindingSource.DataSource = this.myCarDataSet;
            // 
            // fuelTableAdapter
            // 
            this.fuelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuelTableAdapter = this.fuelTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyCar.MyCarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // monthYearTableAdapter
            // 
            this.monthYearTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbFilterMonthYear);
            this.groupBox1.Location = new System.Drawing.Point(12, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // btAddRow
            // 
            this.btAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddRow.Location = new System.Drawing.Point(12, 308);
            this.btAddRow.Name = "btAddRow";
            this.btAddRow.Size = new System.Drawing.Size(108, 23);
            this.btAddRow.TabIndex = 6;
            this.btAddRow.Text = "Добавить";
            this.btAddRow.UseVisualStyleBackColor = true;
            this.btAddRow.Click += new System.EventHandler(this.btAddRow_Click);
            // 
            // btEditRow
            // 
            this.btEditRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditRow.Location = new System.Drawing.Point(126, 308);
            this.btEditRow.Name = "btEditRow";
            this.btEditRow.Size = new System.Drawing.Size(108, 23);
            this.btEditRow.TabIndex = 7;
            this.btEditRow.Text = "Редактировать";
            this.btEditRow.UseVisualStyleBackColor = true;
            this.btEditRow.Click += new System.EventHandler(this.btEditRow_Click);
            // 
            // btDeleteRow
            // 
            this.btDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeleteRow.Location = new System.Drawing.Point(240, 308);
            this.btDeleteRow.Name = "btDeleteRow";
            this.btDeleteRow.Size = new System.Drawing.Size(108, 23);
            this.btDeleteRow.TabIndex = 8;
            this.btDeleteRow.Text = "Удалить";
            this.btDeleteRow.UseVisualStyleBackColor = true;
            this.btDeleteRow.Click += new System.EventHandler(this.btDeleteRow_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateFilling";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 58;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SumFilling";
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма заправки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 107;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Litres";
            this.dataGridViewTextBoxColumn3.HeaderText = "Литры";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PricePerLitre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена за литр";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Distance";
            this.dataGridViewTextBoxColumn6.HeaderText = "Расстояние";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 92;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Odometr";
            this.dataGridViewTextBoxColumn7.HeaderText = "Одометер";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 83;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 452);
            this.Controls.Add(this.btDeleteRow);
            this.Controls.Add(this.btEditRow);
            this.Controls.Add(this.btAddRow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.fuelDataGridView);
            this.MinimumSize = new System.Drawing.Size(580, 436);
            this.Name = "Form1";
            this.Text = "Учет топлива";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fuelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthYearBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyCarDataSet myCarDataSet;
        private System.Windows.Forms.BindingSource fuelBindingSource;
        private MyCarDataSetTableAdapters.FuelTableAdapter fuelTableAdapter;
        private MyCarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fuelDataGridView;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox cbFilterMonthYear;
        private System.Windows.Forms.BindingSource monthYearBindingSource;
        private MyCarDataSetTableAdapters.MonthYearTableAdapter monthYearTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddRow;
        private System.Windows.Forms.Button btEditRow;
        private System.Windows.Forms.Button btDeleteRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

