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
            this.button1 = new System.Windows.Forms.Button();
            this.cbFilterMonthYear = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myCarDataSet = new MyCar.MyCarDataSet();
            this.fuelTableAdapter = new MyCar.MyCarDataSetTableAdapters.FuelTableAdapter();
            this.tableAdapterManager = new MyCar.MyCarDataSetTableAdapters.TableAdapterManager();
            this.monthYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthYearTableAdapter = new MyCar.MyCarDataSetTableAdapters.MonthYearTableAdapter();
            this.myCarDataSet1 = new MyCar.MyCarDataSet();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fuelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fuelDataGridView
            // 
            this.fuelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fuelDataGridView.AutoGenerateColumns = false;
            this.fuelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fuelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.fuelDataGridView.DataSource = this.fuelBindingSource;
            this.fuelDataGridView.Location = new System.Drawing.Point(12, 12);
            this.fuelDataGridView.Name = "fuelDataGridView";
            this.fuelDataGridView.Size = new System.Drawing.Size(597, 338);
            this.fuelDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFilterMonthYear
            // 
            this.cbFilterMonthYear.DataSource = this.monthYearBindingSource;
            this.cbFilterMonthYear.DisplayMember = "MonthYear";
            this.cbFilterMonthYear.FormattingEnabled = true;
            this.cbFilterMonthYear.Location = new System.Drawing.Point(24, 365);
            this.cbFilterMonthYear.Name = "cbFilterMonthYear";
            this.cbFilterMonthYear.Size = new System.Drawing.Size(132, 21);
            this.cbFilterMonthYear.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "Фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // monthYearBindingSource
            // 
            this.monthYearBindingSource.DataMember = "MonthYear";
            this.monthYearBindingSource.DataSource = this.myCarDataSet;
            // 
            // monthYearTableAdapter
            // 
            this.monthYearTableAdapter.ClearBeforeFill = true;
            // 
            // myCarDataSet1
            // 
            this.myCarDataSet1.DataSetName = "MyCarDataSet";
            this.myCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateFilling";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Litres";
            this.dataGridViewTextBoxColumn3.HeaderText = "Литры";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PricePerLitre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена за литр";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SumFilling";
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма заправки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Distance";
            this.dataGridViewTextBoxColumn6.HeaderText = "Расстояние";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Odometr";
            this.dataGridViewTextBoxColumn7.HeaderText = "Одометер";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 397);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbFilterMonthYear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fuelDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fuelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCarDataSet myCarDataSet;
        private System.Windows.Forms.BindingSource fuelBindingSource;
        private MyCarDataSetTableAdapters.FuelTableAdapter fuelTableAdapter;
        private MyCarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fuelDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbFilterMonthYear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource monthYearBindingSource;
        private MyCarDataSetTableAdapters.MonthYearTableAdapter monthYearTableAdapter;
        private MyCarDataSet myCarDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

